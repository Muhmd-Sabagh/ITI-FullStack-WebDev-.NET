using Microsoft.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace CRUD_With_Dapper
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        public Form2()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateDgv();

            CbTopic.DataSource = conn.Query<Topic>("SELECT * FROM Topic").ToList();
            CbTopic.ValueMember = "Top_Id";
            CbTopic.DisplayMember = "Top_Name";

            ResetFields();
            ResetBtns();
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() != "")
                MessageBox.Show(ValidateInputs());
            else
            {
                int affectedRows = conn.Execute("INSERT INTO Course VALUES(@name, @duration, @topId)", new
                {
                    name = txtName.Text,
                    duration = int.Parse(txtDuration.Text),
                    topId = (int)CbTopic.SelectedValue
                });

                if (affectedRows > 0)
                {
                    MessageBox.Show("Course Added Successfully");

                    UpdateDgv();
                    ResetFields();
                }
            }
        }
        int crsId;
        private void dgvCourses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dgvCourses.SelectedRows[0];
            crsId = (int)row.Cells[0].Value;
            txtName.Text = row.Cells[1].Value?.ToString();
            txtDuration.Text = row.Cells[2].Value?.ToString();
            CbTopic.SelectedValue = (int)row.Cells[3].Value;

            BtnAdd.Enabled = false;
            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
            BtnCancel.Enabled = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() != "")
                MessageBox.Show(ValidateInputs());
            else
            {
                int affectedRows = conn.Execute(
                    "UPDATE Course SET Crs_Name = @name, Crs_Duration = @duration, Top_Id = @topId WHERE Crs_Id = @id",
                    new
                    {
                        name = txtName.Text,
                        duration = txtDuration.Text,
                        topId = (int)CbTopic.SelectedValue,
                        id = crsId,
                    });

                if (affectedRows > 0)
                {
                    MessageBox.Show("Course Updated Successfully");

                    UpdateDgv();
                    ResetFields();
                    ResetBtns();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete the Course?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int affectedRows = conn.Execute(
                        "DELETE FROM Course WHERE Crs_Id = @id",
                        new { id = crsId, });

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Course Deleted Successfully");

                        UpdateDgv();
                        ResetFields();
                        ResetBtns();
                    }
                }
                catch (SqlException ex) when (ex.Number == 547) // 547 = foreign key violation
                {
                    MessageBox.Show("Cannot delete this course because it is referenced by other data.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetBtns();
            ResetFields();
        }

        private void UpdateDgv()
        {
            dgvCourses.DataSource = conn
                .Query<Course, Topic, object>
                (
                    "SELECT C.Crs_Id, C.Crs_Name, C.Crs_Duration, C.Top_Id, T.Top_Name FROM Course C JOIN Topic T ON C.Top_Id = T.Top_Id",
                    (crs, t) => new
                    {
                        Crs_Id = crs.Crs_Id,
                        Crs_Name = crs.Crs_Name,
                        Crs_Duration = crs.Crs_Duration,
                        Top_Id = crs.Top_Id,
                        Top_Name = t.Top_Name
                    },
                    splitOn: "Top_Name"
                ).ToList();
            dgvCourses.Columns["Top_Id"].Visible = false;
        }

        private void ResetFields()
        {
            txtName.Text = txtDuration.Text = "";
            CbTopic.SelectedIndex = -1;
        }

        private void ResetBtns()
        {
            BtnAdd.Enabled = true;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            BtnCancel.Enabled = false;
        }

        private string ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length < 3)
                return "Course Name must be at least 3 letters";
            else if (string.IsNullOrWhiteSpace(txtDuration.Text) || !int.TryParse(txtDuration.Text, out int duration) || duration < 0)
                return "Course Duration must be positive integer";
            else if (CbTopic.SelectedIndex == -1)
                return "Course Topic must be specified";
            else return "";
        }
    }
}
