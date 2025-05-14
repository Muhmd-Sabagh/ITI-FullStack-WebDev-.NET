namespace EF_With_ITIDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Btn_Add = new Button();
            label6 = new Label();
            label7 = new Label();
            Btn_Update = new Button();
            Btn_Cancel = new Button();
            Btn_Delete = new Button();
            DGV_Students = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            Txt_Fname = new TextBox();
            Txt_Lname = new TextBox();
            Txt_Address = new TextBox();
            Txt_Age = new TextBox();
            CB_Departments = new ComboBox();
            CB_Supervisors = new ComboBox();
            CB_Students = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Students).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 118);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 149);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "Age";
            // 
            // Btn_Add
            // 
            Btn_Add.Location = new Point(81, 237);
            Btn_Add.Name = "Btn_Add";
            Btn_Add.Size = new Size(61, 37);
            Btn_Add.TabIndex = 5;
            Btn_Add.Text = "Add";
            Btn_Add.UseVisualStyleBackColor = true;
            Btn_Add.Click += Btn_Add_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 179);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 9;
            label6.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 208);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 10;
            label7.Text = "Supervisor";
            // 
            // Btn_Update
            // 
            Btn_Update.Location = new Point(33, 237);
            Btn_Update.Name = "Btn_Update";
            Btn_Update.Size = new Size(61, 37);
            Btn_Update.TabIndex = 11;
            Btn_Update.Text = "Update";
            Btn_Update.UseVisualStyleBackColor = true;
            Btn_Update.Click += Btn_Update_Click;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new Point(125, 237);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(61, 37);
            Btn_Cancel.TabIndex = 12;
            Btn_Cancel.Text = "Cancel";
            Btn_Cancel.UseVisualStyleBackColor = true;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // Btn_Delete
            // 
            Btn_Delete.Location = new Point(428, 115);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Size = new Size(61, 37);
            Btn_Delete.TabIndex = 13;
            Btn_Delete.Text = "Delete";
            Btn_Delete.UseVisualStyleBackColor = true;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // DGV_Students
            // 
            DGV_Students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Students.Location = new Point(33, 314);
            DGV_Students.Name = "DGV_Students";
            DGV_Students.Size = new Size(509, 150);
            DGV_Students.TabIndex = 14;
            DGV_Students.RowHeaderMouseDoubleClick += DGV_Students_RowHeaderMouseDoubleClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(392, 9);
            label8.Name = "label8";
            label8.Size = new Size(135, 25);
            label8.TabIndex = 15;
            label8.Text = "Delete Student";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(200, 283);
            label9.Name = "label9";
            label9.Size = new Size(146, 25);
            label9.TabIndex = 16;
            label9.Text = "Students Details";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(417, 53);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 17;
            label10.Text = "Student Name";
            // 
            // Txt_Fname
            // 
            Txt_Fname.Location = new Point(77, 53);
            Txt_Fname.Name = "Txt_Fname";
            Txt_Fname.Size = new Size(121, 23);
            Txt_Fname.TabIndex = 18;
            // 
            // Txt_Lname
            // 
            Txt_Lname.Location = new Point(77, 84);
            Txt_Lname.Name = "Txt_Lname";
            Txt_Lname.Size = new Size(121, 23);
            Txt_Lname.TabIndex = 19;
            // 
            // Txt_Address
            // 
            Txt_Address.Location = new Point(77, 115);
            Txt_Address.Name = "Txt_Address";
            Txt_Address.Size = new Size(121, 23);
            Txt_Address.TabIndex = 20;
            // 
            // Txt_Age
            // 
            Txt_Age.Location = new Point(77, 146);
            Txt_Age.Name = "Txt_Age";
            Txt_Age.Size = new Size(121, 23);
            Txt_Age.TabIndex = 21;
            // 
            // CB_Departments
            // 
            CB_Departments.FlatStyle = FlatStyle.Popup;
            CB_Departments.FormattingEnabled = true;
            CB_Departments.Location = new Point(77, 176);
            CB_Departments.Name = "CB_Departments";
            CB_Departments.Size = new Size(121, 23);
            CB_Departments.TabIndex = 22;
            // 
            // CB_Supervisors
            // 
            CB_Supervisors.FlatStyle = FlatStyle.Popup;
            CB_Supervisors.FormattingEnabled = true;
            CB_Supervisors.Location = new Point(77, 205);
            CB_Supervisors.Name = "CB_Supervisors";
            CB_Supervisors.Size = new Size(121, 23);
            CB_Supervisors.TabIndex = 23;
            // 
            // CB_Students
            // 
            CB_Students.FlatStyle = FlatStyle.Popup;
            CB_Students.FormattingEnabled = true;
            CB_Students.Location = new Point(392, 75);
            CB_Students.Name = "CB_Students";
            CB_Students.Size = new Size(135, 23);
            CB_Students.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 476);
            Controls.Add(CB_Students);
            Controls.Add(CB_Supervisors);
            Controls.Add(CB_Departments);
            Controls.Add(Txt_Age);
            Controls.Add(Txt_Address);
            Controls.Add(Txt_Lname);
            Controls.Add(Txt_Fname);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(DGV_Students);
            Controls.Add(Btn_Delete);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_Update);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Btn_Add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Btn_Add;
        private Label label6;
        private Label label7;
        private Button Btn_Update;
        private Button Btn_Cancel;
        private Button Btn_Delete;
        private DataGridView DGV_Students;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox Txt_Fname;
        private TextBox Txt_Lname;
        private TextBox Txt_Address;
        private TextBox Txt_Age;
        private ComboBox CB_Departments;
        private ComboBox CB_Supervisors;
        private ComboBox CB_Students;
    }
}
