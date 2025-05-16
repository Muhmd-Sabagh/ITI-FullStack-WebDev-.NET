namespace CRUD_With_Dapper
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CbTopic = new ComboBox();
            txtName = new TextBox();
            txtDuration = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvCourses = new DataGridView();
            BtnAdd = new Button();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            BtnCancel = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // CbTopic
            // 
            CbTopic.FormattingEnabled = true;
            CbTopic.Location = new Point(410, 100);
            CbTopic.Name = "CbTopic";
            CbTopic.Size = new Size(113, 23);
            CbTopic.TabIndex = 23;
            // 
            // txtName
            // 
            txtName.Location = new Point(68, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 22;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(244, 95);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(100, 23);
            txtDuration.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(185, 219);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 20;
            label5.Text = "Courses Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 103);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 19;
            label4.Text = "Topic";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 103);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 18;
            label3.Text = "Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 103);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 17;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(161, 30);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 16;
            label1.Text = "Operations on Courses";
            // 
            // dgvCourses
            // 
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(16, 252);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.Size = new Size(507, 150);
            dgvCourses.TabIndex = 15;
            dgvCourses.RowHeaderMouseDoubleClick += dgvCourses_RowHeaderMouseDoubleClick;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(111, 154);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(57, 38);
            BtnAdd.TabIndex = 24;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(195, 154);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(57, 38);
            BtnUpdate.TabIndex = 25;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(287, 154);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(57, 38);
            BtnDelete.TabIndex = 26;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(368, 154);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(57, 38);
            BtnCancel.TabIndex = 27;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.InactiveCaption;
            label6.Location = new Point(390, 9);
            label6.Name = "label6";
            label6.Padding = new Padding(4);
            label6.Size = new Size(133, 23);
            label6.TabIndex = 28;
            label6.Text = "You Can Try Validation";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(535, 415);
            Controls.Add(label6);
            Controls.Add(BtnCancel);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnAdd);
            Controls.Add(CbTopic);
            Controls.Add(txtName);
            Controls.Add(txtDuration);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCourses);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CbTopic;
        private TextBox txtName;
        private TextBox txtDuration;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvCourses;
        private Button BtnAdd;
        private Button BtnUpdate;
        private Button BtnDelete;
        private Button BtnCancel;
        private Label label6;
    }
}