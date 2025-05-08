using Microsoft.Data.SqlClient;
namespace ITIDB_Form
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            // 1. Define Connection
            conn = new SqlConnection("Data Source=MUHMD-SABAGH-PC\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
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
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"INSERT INTO Course VALUES(@name, @duration, @topId)", conn);
            cmd.Parameters.AddWithValue("name", text_name.Text);
            cmd.Parameters.AddWithValue("duration", text_duration.Text);
            cmd.Parameters.AddWithValue("topId", cb_topic.SelectedValue);

            conn.Open();
            int affectedRows = cmd.ExecuteNonQuery();
            conn.Close();

            if (affectedRows > 0)
            {
                text_name.Text = text_duration.Text = "";

                Form1_Load(null, null);

                MessageBox.Show("Course Added Successfully");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Course WHERE Crs_Id=@id", conn);
            cmd.Parameters.AddWithValue("id", cb_cname.SelectedValue);

            conn.Open();
            int affectedRows = cmd.ExecuteNonQuery();
            conn.Close();

            if (affectedRows > 0)
            {
                Form1_Load(null, null);

                MessageBox.Show("Course Deleted Successfully");
            }
        }
    }
}
