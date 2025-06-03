namespace API_To_Form
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
            DgvCourses = new DataGridView();
            BtnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtDesc = new TextBox();
            txtDuration = new TextBox();
            CbDepts = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DgvCourses).BeginInit();
            SuspendLayout();
            // 
            // DgvCourses
            // 
            DgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCourses.Location = new Point(12, 257);
            DgvCourses.Name = "DgvCourses";
            DgvCourses.Size = new Size(385, 181);
            DgvCourses.TabIndex = 0;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(322, 203);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 39);
            BtnAdd.TabIndex = 1;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 59);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 104);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 3;
            label2.Text = "Course Desc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 144);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 4;
            label3.Text = "Course Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 179);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 5;
            label4.Text = "Department";
            // 
            // txtName
            // 
            txtName.Location = new Point(141, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 6;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(141, 101);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(121, 23);
            txtDesc.TabIndex = 7;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(141, 141);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(121, 23);
            txtDuration.TabIndex = 8;
            // 
            // CbDepts
            // 
            CbDepts.FormattingEnabled = true;
            CbDepts.Location = new Point(141, 176);
            CbDepts.Name = "CbDepts";
            CbDepts.Size = new Size(121, 23);
            CbDepts.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 450);
            Controls.Add(CbDepts);
            Controls.Add(txtDuration);
            Controls.Add(txtDesc);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnAdd);
            Controls.Add(DgvCourses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvCourses;
        private Button BtnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtDesc;
        private TextBox txtDuration;
        private ComboBox CbDepts;
    }
}
