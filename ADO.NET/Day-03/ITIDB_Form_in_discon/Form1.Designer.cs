namespace ITIDB_Form_in_discon
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
            btn_add = new Button();
            label1 = new Label();
            label2 = new Label();
            dgv_courses = new DataGridView();
            txt_name = new TextBox();
            cb_topics = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_duration = new TextBox();
            cb_courses = new ComboBox();
            btn_update = new Button();
            btn_del = new Button();
            label7 = new Label();
            btn_cancel = new Button();
            btn_save = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Location = new Point(85, 171);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 36);
            btn_add.TabIndex = 0;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 1;
            label1.Text = "Add\\Update Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 67);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // dgv_courses
            // 
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Location = new Point(29, 248);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.Size = new Size(466, 163);
            dgv_courses.TabIndex = 3;
            dgv_courses.RowHeaderMouseDoubleClick += dgv_courses_RowHeaderMouseDoubleClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(97, 64);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(121, 23);
            txt_name.TabIndex = 4;
            // 
            // cb_topics
            // 
            cb_topics.FormattingEnabled = true;
            cb_topics.Location = new Point(97, 133);
            cb_topics.Name = "cb_topics";
            cb_topics.Size = new Size(121, 23);
            cb_topics.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(360, 24);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 6;
            label3.Text = "Delete Course";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 101);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Duration";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 136);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Topic";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(321, 67);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 9;
            label6.Text = "Name";
            // 
            // txt_duration
            // 
            txt_duration.Location = new Point(97, 98);
            txt_duration.Name = "txt_duration";
            txt_duration.Size = new Size(121, 23);
            txt_duration.TabIndex = 10;
            // 
            // cb_courses
            // 
            cb_courses.FormattingEnabled = true;
            cb_courses.Location = new Point(369, 64);
            cb_courses.Name = "cb_courses";
            cb_courses.Size = new Size(121, 23);
            cb_courses.TabIndex = 11;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(29, 171);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 36);
            btn_update.TabIndex = 12;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(380, 101);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(75, 36);
            btn_del.TabIndex = 13;
            btn_del.Text = "Delete";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(201, 213);
            label7.Name = "label7";
            label7.Size = new Size(141, 25);
            label7.TabIndex = 14;
            label7.Text = "Courses Details";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(143, 171);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 36);
            btn_cancel.TabIndex = 15;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(321, 171);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(169, 36);
            btn_save.TabIndex = 16;
            btn_save.Text = "Save Changes";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 423);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Controls.Add(label7);
            Controls.Add(btn_del);
            Controls.Add(btn_update);
            Controls.Add(cb_courses);
            Controls.Add(txt_duration);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cb_topics);
            Controls.Add(txt_name);
            Controls.Add(dgv_courses);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_add);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add;
        private Label label1;
        private Label label2;
        private DataGridView dgv_courses;
        private TextBox txt_name;
        private ComboBox cb_topics;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_duration;
        private ComboBox cb_courses;
        private Button btn_update;
        private Button btn_del;
        private Label label7;
        private Button btn_cancel;
        private Button btn_save;
    }
}
