using API_To_Form.DisplayModels;

namespace API_To_Form
{
    public partial class Form1 : Form
    {
        HttpClient client;
        List<CourseData> coursesData;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7212/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpResponseMessage coursesResponse = client.GetAsync("api/course").Result;
            if (coursesResponse.IsSuccessStatusCode)
            {
                coursesData = coursesResponse.Content.ReadAsAsync<List<CourseData>>().Result;
                DgvCourses.DataSource = coursesData;
            }

            HttpResponseMessage deptResponse = client.GetAsync("api/department").Result;
            if (deptResponse.IsSuccessStatusCode)
            {
                List<DepartmentData> departmentData = deptResponse.Content.ReadAsAsync<List<DepartmentData>>().Result;
                CbDepts.DataSource = departmentData;
                CbDepts.ValueMember = "id";
                CbDepts.DisplayMember = "name";
            }
        }

        private void ResetFields()
        {
            txtName.Text = txtDesc.Text = txtDuration.Text = "";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("api/course", new CourseData
            {
                crs_Name = txtName.Text,
                crs_Desc = txtDesc.Text,
                duration = int.Parse(txtDuration.Text),
                dept_Id = (int)CbDepts.SelectedValue
            }).Result;
            if (response.IsSuccessStatusCode)
            {
                ResetFields();
                Form1_Load(null, null);
                MessageBox.Show("Course Added Successfully");
            }
        }
    }
}
