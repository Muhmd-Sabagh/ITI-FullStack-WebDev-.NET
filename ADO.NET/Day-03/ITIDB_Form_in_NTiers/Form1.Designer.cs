namespace ITIDB_Form_in_NTiers
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
            Btn_Cancel = new Button();
            label7 = new Label();
            Btn_Del = new Button();
            Btn_Update = new Button();
            CB_Courses = new ComboBox();
            Text_Duration = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            CB_Topics = new ComboBox();
            Text_Name = new TextBox();
            DGV_Courses = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            Btn_Add = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Courses).BeginInit();
            SuspendLayout();
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new Point(136, 161);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(75, 36);
            Btn_Cancel.TabIndex = 32;
            Btn_Cancel.Text = "Cancel";
            Btn_Cancel.UseVisualStyleBackColor = true;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(194, 203);
            label7.Name = "label7";
            label7.Size = new Size(141, 25);
            label7.TabIndex = 31;
            label7.Text = "Courses Details";
            // 
            // Btn_Del
            // 
            Btn_Del.Location = new Point(373, 91);
            Btn_Del.Name = "Btn_Del";
            Btn_Del.Size = new Size(75, 36);
            Btn_Del.TabIndex = 30;
            Btn_Del.Text = "Delete";
            Btn_Del.UseVisualStyleBackColor = true;
            Btn_Del.Click += Btn_Del_Click;
            // 
            // Btn_Update
            // 
            Btn_Update.Location = new Point(22, 161);
            Btn_Update.Name = "Btn_Update";
            Btn_Update.Size = new Size(75, 36);
            Btn_Update.TabIndex = 29;
            Btn_Update.Text = "Update";
            Btn_Update.UseVisualStyleBackColor = true;
            Btn_Update.Click += Btn_Update_Click;
            // 
            // CB_Courses
            // 
            CB_Courses.FormattingEnabled = true;
            CB_Courses.Location = new Point(362, 54);
            CB_Courses.Name = "CB_Courses";
            CB_Courses.Size = new Size(121, 23);
            CB_Courses.TabIndex = 28;
            // 
            // Text_Duration
            // 
            Text_Duration.Location = new Point(90, 88);
            Text_Duration.Name = "Text_Duration";
            Text_Duration.Size = new Size(121, 23);
            Text_Duration.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(314, 57);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 26;
            label6.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 126);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 25;
            label5.Text = "Topic";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 91);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 24;
            label4.Text = "Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(353, 14);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 23;
            label3.Text = "Delete Course";
            // 
            // CB_Topics
            // 
            CB_Topics.FormattingEnabled = true;
            CB_Topics.Location = new Point(90, 123);
            CB_Topics.Name = "CB_Topics";
            CB_Topics.Size = new Size(121, 23);
            CB_Topics.TabIndex = 22;
            // 
            // Text_Name
            // 
            Text_Name.Location = new Point(90, 54);
            Text_Name.Name = "Text_Name";
            Text_Name.Size = new Size(121, 23);
            Text_Name.TabIndex = 21;
            // 
            // DGV_Courses
            // 
            DGV_Courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Courses.Location = new Point(22, 238);
            DGV_Courses.Name = "DGV_Courses";
            DGV_Courses.Size = new Size(466, 163);
            DGV_Courses.TabIndex = 20;
            DGV_Courses.RowHeaderMouseDoubleClick += DGV_Courses_RowHeaderMouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 57);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 19;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(22, 14);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 18;
            label1.Text = "Add\\Update Course";
            // 
            // Btn_Add
            // 
            Btn_Add.Location = new Point(78, 161);
            Btn_Add.Name = "Btn_Add";
            Btn_Add.Size = new Size(75, 36);
            Btn_Add.TabIndex = 17;
            Btn_Add.Text = "Add";
            Btn_Add.UseVisualStyleBackColor = true;
            Btn_Add.Click += Btn_Add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 421);
            Controls.Add(Btn_Cancel);
            Controls.Add(label7);
            Controls.Add(Btn_Del);
            Controls.Add(Btn_Update);
            Controls.Add(CB_Courses);
            Controls.Add(Text_Duration);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CB_Topics);
            Controls.Add(Text_Name);
            Controls.Add(DGV_Courses);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_Add);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Btn_Cancel;
        private Label label7;
        private Button Btn_Del;
        private Button Btn_Update;
        private ComboBox CB_Courses;
        private TextBox Text_Duration;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox CB_Topics;
        private TextBox Text_Name;
        private DataGridView DGV_Courses;
        private Label label2;
        private Label label1;
        private Button Btn_Add;
    }
}
