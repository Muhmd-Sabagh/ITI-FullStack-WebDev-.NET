using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ITIDB_Form_in_discon
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            // 1. Define Connection
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
        }

        DataTable coursesDT;
        int lastID;
        private void Form1_Load(object sender, EventArgs e)
        {
            // 2. Define Command
            SqlCommand cmd = new SqlCommand(@"
                SELECT 
                    C.*, 
                    CASE 
                        WHEN EXISTS (SELECT 1 FROM Ins_Course IC WHERE IC.Crs_Id = C.Crs_Id) THEN 1
                        WHEN EXISTS (SELECT 1 FROM Stud_Course SC WHERE SC.Crs_Id = C.Crs_Id) THEN 1
		                ELSE 0
                    END AS HasRefrence
                FROM Course C", conn);
            // SqlCommand cmd = new SqlCommand("SELECT * FROM Course", conn);
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Topic", conn);

            // 3. Define SQL Data Adapter
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);

            // 4. Define Datatable
            coursesDT = new DataTable();
            DataTable topicsDT = new DataTable();

            // 5. Fill The Datatable with The Adapter
            adapter.Fill(coursesDT);
            adapter2.Fill(topicsDT);

            // 6. Bind Data
            dgv_courses.DataSource = coursesDT;
            dgv_courses.Columns[dgv_courses.Columns.Count - 1].Visible = false;
            lastID = (int)coursesDT.Rows[coursesDT.Rows.Count - 1]["Crs_Id"];
            cb_topics.DataSource = topicsDT;
            cb_topics.ValueMember = "Top_Id";
            cb_topics.DisplayMember = "Top_Name";
            cb_courses.DataSource = coursesDT;
            cb_courses.ValueMember = "Crs_Id";
            cb_courses.DisplayMember = "Crs_Name";
            btn_add.Visible = true;
            btn_update.Visible = false;
            btn_cancel.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRow row = coursesDT.NewRow();

            lastID += 100;
            row["Crs_Id"] = lastID;
            row["Crs_Name"] = txt_name.Text;
            row["Crs_Duration"] = txt_duration.Text;
            row["Top_Id"] = cb_topics.SelectedValue;
            row["HasRefrence"] = 0;

            coursesDT.Rows.Add(row);

            // dgv_courses.DataSource = coursesDT;
            txt_name.Text = txt_duration.Text = "";
            cb_topics.SelectedValue = 1;
            MessageBox.Show("Course Added Successfully");
        }

        int crsID;
        private void dgv_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv_courses.SelectedRows[0];
            if (row.Cells[0].Value != DBNull.Value && row.Cells[0].Value != null)
            {

                crsID = (int)row.Cells[0].Value;
                txt_name.Text = row.Cells[1].Value.ToString();
                txt_duration.Text = row.Cells[2].Value.ToString();
                cb_topics.SelectedValue = row.Cells[3].Value;

                btn_update.Visible = true;
                btn_cancel.Visible = true;
                btn_add.Visible = false;
            }
            else
            {
                txt_name.Text = txt_duration.Text = "";
                cb_topics.SelectedValue = 1;

                btn_update.Visible = false;
                btn_cancel.Visible = false;
                btn_add.Visible = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in coursesDT.Rows)
            {
                if (row.RowState != DataRowState.Deleted && (int)row["Crs_Id"] == crsID)
                {
                    row["Crs_Name"] = txt_name.Text;
                    row["Crs_Duration"] = txt_duration.Text;
                    row["Top_Id"] = cb_topics.SelectedValue;
                    break;
                }
            }

            // dgv_courses.DataSource = coursesDT;
            txt_name.Text = txt_duration.Text = "";
            cb_topics.SelectedValue = 1;

            btn_update.Visible = false;
            btn_cancel.Visible = false;
            btn_add.Visible = true;

            MessageBox.Show("Course Updated Successfully");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_name.Text = txt_duration.Text = "";
            cb_topics.SelectedValue = 1;

            btn_update.Visible = false;
            btn_cancel.Visible = false;
            btn_add.Visible = true;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the Course?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataRow row in coursesDT.Rows)
                {
                    if (row.RowState != DataRowState.Deleted && (int)row["Crs_Id"] == (int)cb_courses.SelectedValue)
                    {
                        if ((int)row["HasRefrence"] == 1)
                        {
                            MessageBox.Show("This course is linked to another table and cannot be deleted.");
                            return;
                        }

                        row.Delete();
                        break;
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveChanges();
            MessageBox.Show("All Changes Saved To Your DB Successfully");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChanges();
            MessageBox.Show("All Changes Saved To Your DB Successfully");
        }

        private void SaveChanges()
        {
            SqlCommand insertCMD = new SqlCommand("INSERT INTO Course VALUES(@id, @name, @duration, @topId)", conn);
            insertCMD.Parameters.Add("@id", SqlDbType.Int, 4, "Crs_Id");
            insertCMD.Parameters.Add("@name", SqlDbType.NVarChar, 50, "Crs_Name");
            insertCMD.Parameters.Add("@duration", SqlDbType.Int, 4, "Crs_Duration");
            insertCMD.Parameters.Add("@topId", SqlDbType.Int, 4, "Top_Id");

            SqlCommand updateCMD = new SqlCommand("UPDATE Course SET Crs_Name=@name, Crs_Duration=@duration, Top_Id=@topId WHERE Crs_Id=@id", conn);
            updateCMD.Parameters.Add("@id", SqlDbType.Int, 4, "Crs_Id");
            updateCMD.Parameters.Add("@name", SqlDbType.NVarChar, 50, "Crs_Name");
            updateCMD.Parameters.Add("@duration", SqlDbType.Int, 4, "Crs_Duration");
            updateCMD.Parameters.Add("@topId", SqlDbType.Int, 4, "Top_Id");

            SqlCommand deleteCMD = new SqlCommand("DELETE FROM Course WHERE Crs_Id=@id", conn);
            deleteCMD.Parameters.Add("@id", SqlDbType.Int, 4, "Crs_Id");

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = insertCMD;
            adapter.UpdateCommand = updateCMD;
            adapter.DeleteCommand = deleteCMD;

            adapter.Update(coursesDT);
            coursesDT.AcceptChanges();
        }
    }
}
