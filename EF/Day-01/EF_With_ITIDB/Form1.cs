using EF_With_ITIDB.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_With_ITIDB
{
    public partial class Form1 : Form
    {
        ITIContext DB;
        public Form1()
        {
            InitializeComponent();
            DB = new ITIContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var students = DB.Students
                .Select(s => new
                {
                    s.St_Id,
                    s.St_Fname,
                    s.St_Lname,
                    FullName = (s.St_Fname == null ? s.St_Fname : (s.St_Fname + " ")) + s.St_Lname,
                    s.St_Address,
                    s.St_Age,
                    DepartmentName = s.Dept.Dept_Name,
                    Supervisor = (s.St_superNavigation.St_Fname + s.St_superNavigation.St_Lname)
                }).ToList();

            DGV_Students.DataSource = students;
            CB_Students.DataSource = CB_Supervisors.DataSource = students;
            CB_Students.ValueMember = CB_Supervisors.ValueMember = "St_Id";
            CB_Students.DisplayMember = CB_Supervisors.DisplayMember = "FullName";

            CB_Departments.DataSource = DB.Departments
                .Select(d => new
                {
                    d.Dept_Id,
                    d.Dept_Name
                }).ToList();
            CB_Departments.ValueMember = "Dept_Id";
            CB_Departments.DisplayMember = "Dept_Name";

            ResetBtns();
        }


        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Student newSt = new Student
            {
                St_Fname = Txt_Fname.Text,
                St_Lname = Txt_Lname.Text,
                St_Address = Txt_Address.Text,
                St_Age = int.Parse(Txt_Age.Text),
                St_super = (int)CB_Supervisors.SelectedValue,
                Dept_Id = (int)CB_Departments.SelectedValue
            };

            DB.Students.Add(newSt);
            DB.SaveChanges();

            ResetFields();
            MessageBox.Show("Student Added Successfully");
        }

        int stID;
        Student st;
        private void DGV_Students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            stID = (int)DGV_Students.SelectedRows[0].Cells[0].Value;

            st = DB.Students.Where(s => s.St_Id == stID).First();

            Txt_Fname.Text = st.St_Fname;
            Txt_Lname.Text = st.St_Lname;
            Txt_Address.Text = st.St_Address;
            Txt_Age.Text = st.St_Age.ToString();
            CB_Departments.SelectedValue = st.Dept_Id ?? 0;
            CB_Supervisors.SelectedValue = st.St_super ?? 0;

            Btn_Add.Visible = false;
            Btn_Cancel.Visible = true;
            Btn_Update.Visible = true;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            ResetFields();
            ResetBtns();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            st.St_Fname = Txt_Fname.Text;
            st.St_Lname = Txt_Lname.Text;
            st.St_Address = Txt_Address.Text;
            st.St_Age = int.Parse(Txt_Age.Text);
            st.Dept_Id = (int)CB_Departments.SelectedValue;
            st.St_super = (int)CB_Supervisors.SelectedValue;

            DB.SaveChanges();

            ResetFields();
            ResetBtns();

            MessageBox.Show("Student Information Updated");
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Do Delete That Student?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Student delSt = DB.Students.Where(s => s.St_Id == (int)CB_Students.SelectedValue).First();

                    DB.Students.Remove(delSt);

                    DB.SaveChanges();
                    ResetFields();
                    ResetBtns();

                    MessageBox.Show("Student Has Been Deleted");
            }
                catch { MessageBox.Show("The Student Cannot Be Deleted Becuse It Is In A Relation With Another Table"); }
            }
        }

        private void ResetFields()
        {
            Txt_Fname.Text = Txt_Lname.Text = Txt_Address.Text = Txt_Age.Text = "";
            CB_Departments.SelectedIndex = CB_Students.SelectedIndex = CB_Supervisors.SelectedIndex = 0;
            
            var students = DB.Students
                .Select(s => new
                {
                    s.St_Id,
                    s.St_Fname,
                    s.St_Lname,
                    FullName = (s.St_Fname == null ? s.St_Fname : (s.St_Fname + " ")) + s.St_Lname,
                    s.St_Address,
                    s.St_Age,
                    DepartmentName = s.Dept.Dept_Name,
                    Supervisor = (s.St_superNavigation.St_Fname + s.St_superNavigation.St_Lname)
                }).ToList();
            
            CB_Students.DataSource = CB_Supervisors.DataSource = students;
            CB_Students.ValueMember = CB_Supervisors.ValueMember = "St_Id";
            CB_Students.DisplayMember = CB_Supervisors.DisplayMember = "FullName";
            DGV_Students.DataSource = students;
        }


        private void ResetBtns()
        {
            Btn_Add.Visible = true;
            Btn_Cancel.Visible = false;
            Btn_Update.Visible = false;
        }

    }
}
