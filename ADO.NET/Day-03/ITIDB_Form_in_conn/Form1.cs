using Microsoft.Data.SqlClient;
using System.Configuration;

namespace ITIDB_Form
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // 2. Define Command
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course", conn);
            SqlCommand cmd2 = new SqlCommand("SELECT Top_Id, Top_Name FROM Topic", conn);

            // 3. Open The Connection
            conn.Open();

            // 4. Execute The command
            SqlDataReader reader = cmd.ExecuteReader();
            List<Course> courses = new List<Course>();

            while (reader.Read())
            {
                courses.Add(new Course
                {
                    ID = (int)reader["Crs_Id"],
                    Name = reader["Crs_Name"].ToString(),
                    Duration = (int)reader["Crs_Duration"],
                    TopicId = (int)reader["Top_Id"]
                });
            }

            reader.Close();

            SqlDataReader reader2 = cmd2.ExecuteReader();
            List<Topic> topics = new List<Topic>();

            while (reader2.Read())
            {
                topics.Add(new Topic
                {
                    ID = (int)reader2["Top_Id"],
                    Name = reader2["Top_Name"].ToString()
                });
            }
            reader2.Close();

            // 5- Data Bind
            dgv_courses.DataSource = courses;

            cb_cname.DataSource = courses;
            cb_cname.ValueMember = "ID";
            cb_cname.DisplayMember = "Name";

            cb_topic.DataSource = topics;
            cb_topic.ValueMember = "ID";
            cb_topic.DisplayMember = "Name";

            // 6. Close The Connection
            conn.Close();

            ResetFields();
            ResetBtns();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Fixing the incomplete line causing CS1001 and CS1002 errors  
            int newID = dgv_courses.Rows.Count > 0 ? ((int)dgv_courses.Rows[dgv_courses.Rows.Count - 1].Cells[0].Value) + 100 : 100;

            SqlCommand cmd = new SqlCommand($"INSERT INTO Course VALUES(@id, @name, @duration, @topId)", conn);
            cmd.Parameters.AddWithValue("id", newID);
            cmd.Parameters.AddWithValue("name", text_name.Text);
            cmd.Parameters.AddWithValue("duration", text_duration.Text);
            cmd.Parameters.AddWithValue("topId", cb_topic.SelectedValue);

            conn.Open();
            int affectedRows = cmd.ExecuteNonQuery();
            conn.Close();

            if (affectedRows > 0)
            {
                Form1_Load(null, null);
                MessageBox.Show("Course Added Successfully");
            }
            else
            {
                MessageBox.Show("Error While Adding The Course", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete the Course?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Course WHERE Crs_Id=@id", conn);
                cmd.Parameters.AddWithValue("id", cb_cname.SelectedValue);
                try
                {
                    conn.Open();
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        Form1_Load(null, null);
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
                finally
                {
                    conn.Close();
                }
            }
        }

        int crsID;
        private void dgv_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv_courses.SelectedRows[0];
            if (row.Cells[0].Value != DBNull.Value && row.Cells[0].Value != null)
            {
                crsID = (int)row.Cells[0].Value;
                text_name.Text = row.Cells[1].Value.ToString();
                text_duration.Text = row.Cells[2].Value.ToString();
                cb_topic.SelectedValue = (int)row.Cells[3].Value;

                btn_add.Visible = false;
                btn_update.Visible = true;
                btn_cancel.Visible = true;
            }
            else
            {
                ResetFields();
                ResetBtns();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Course SET Crs_Name=@name, Crs_Duration=@duration, Top_Id=@topId WHERE Crs_Id=@id", conn);
            cmd.Parameters.AddWithValue("id", crsID);
            cmd.Parameters.AddWithValue("name", text_name.Text);
            cmd.Parameters.AddWithValue("duration", text_duration.Text);
            cmd.Parameters.AddWithValue("topId", cb_topic.SelectedValue);

            conn.Open();
            int affectedRows = cmd.ExecuteNonQuery();
            conn.Close();

            if (affectedRows > 0)
            {
                Form1_Load(null, null);
                MessageBox.Show("Couse info Updated Successfully");
            }
            else
            {
                MessageBox.Show("Error While Updating The Course Info", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ResetFields();
            ResetBtns();
        }

        // Helper Functions
        public void ResetFields()
        {
            text_name.Text = text_duration.Text = "";
            cb_topic.SelectedValue = 1;
        }

        public void ResetBtns()
        {
            btn_add.Visible = true;
            btn_update.Visible = false;
            btn_cancel.Visible = false;
        }
    }
}
