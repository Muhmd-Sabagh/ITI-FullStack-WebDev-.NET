using Microsoft.Data.SqlClient;
using System.Data;
namespace ITIDB_Form_in_NTiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int lastID;
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable coursesDT = Course.GetAllCourses();
            DGV_Courses.DataSource = coursesDT;
            CB_Courses.DataSource = coursesDT;
            CB_Courses.ValueMember = "Crs_Id";
            CB_Courses.DisplayMember = "Crs_Name";
            CB_Topics.DataSource = Topic.GetAllTopics();
            CB_Topics.ValueMember = "Top_Id";
            CB_Topics.DisplayMember = "Top_Name";

            lastID = (int)coursesDT.Rows[coursesDT.Rows.Count - 1]["Crs_Id"];

            ResetBtns();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            int affectedRows = Course.AddCourse((lastID + 100), Text_Name.Text, int.Parse(Text_Duration.Text), (int)CB_Topics.SelectedValue);
            if (affectedRows > 0)
            {
                RefreshFields();
                MessageBox.Show("Course Added Successfully");
            }
            else
            {
                MessageBox.Show("Error While Adding The Course", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int crsID;
        private void DGV_Courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = DGV_Courses.SelectedRows[0];
            if (row.Cells[0].Value != DBNull.Value && row.Cells[0].Value != null)
            {

                crsID = (int)row.Cells[0].Value;
                Text_Name.Text = row.Cells[1].Value.ToString();
                Text_Duration.Text = row.Cells[2].Value.ToString();
                CB_Topics.SelectedValue = row.Cells[3].Value;

                Btn_Update.Visible = true;
                Btn_Cancel.Visible = true;
                Btn_Add.Visible = false;
            }
            else
            {
                ResetFields();
                ResetBtns();
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            int affectedRows = Course.UpdateCourse(crsID, Text_Name.Text, int.Parse(Text_Duration.Text), (int)CB_Topics.SelectedValue);
            if (affectedRows > 0)
            {
                RefreshFields();
                ResetBtns();

                MessageBox.Show("Course Updated Successfully");
            }
            else
            {
                MessageBox.Show("Error While Updating The Course Info", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            ResetFields();
            ResetBtns();
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                int affectedRows = Course.DeleteCourse((int)CB_Courses.SelectedValue);
                if (affectedRows > 0)
                {
                    RefreshFields();
                    ResetBtns();

                    MessageBox.Show("Course Deleted Successfully");
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

        // Helper Methods
        public void RefreshFields()
        {
            DataTable coursesDT = Course.GetAllCourses();
            DGV_Courses.DataSource = coursesDT;
            CB_Courses.DataSource = coursesDT;
            ResetFields();
        }

        public void ResetFields()
        {
            Text_Name.Text = Text_Duration.Text = "";
            CB_Topics.SelectedValue = 1;
        }

        public void ResetBtns()
        {
            Btn_Update.Visible = false;
            Btn_Cancel.Visible = false;
            Btn_Add.Visible = true;
        }
    }
}
