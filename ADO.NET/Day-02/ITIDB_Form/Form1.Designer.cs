namespace ITIDB_Form
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
            dgv_courses = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            text_name = new TextBox();
            text_duration = new TextBox();
            cb_topic = new ComboBox();
            cb_cname = new ComboBox();
            label7 = new Label();
            btn_add = new Button();
            btn_del = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            SuspendLayout();
            // 
            // dgv_courses
            // 
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Location = new Point(12, 219);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.Size = new Size(461, 150);
            dgv_courses.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(51, 12);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 1;
            label1.Text = "Add Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 48);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 79);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 3;
            label3.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 111);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Topic";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(324, 12);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 5;
            label5.Text = "Delete Course";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 79);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Name";
            // 
            // text_name
            // 
            text_name.Location = new Point(89, 45);
            text_name.Name = "text_name";
            text_name.Size = new Size(121, 23);
            text_name.TabIndex = 7;
            // 
            // text_duration
            // 
            text_duration.Location = new Point(89, 76);
            text_duration.Name = "text_duration";
            text_duration.Size = new Size(121, 23);
            text_duration.TabIndex = 8;
            // 
            // cb_topic
            // 
            cb_topic.FormattingEnabled = true;
            cb_topic.Location = new Point(89, 108);
            cb_topic.Name = "cb_topic";
            cb_topic.Size = new Size(121, 23);
            cb_topic.TabIndex = 9;
            // 
            // cb_cname
            // 
            cb_cname.FormattingEnabled = true;
            cb_cname.Location = new Point(352, 76);
            cb_cname.Name = "cb_cname";
            cb_cname.Size = new Size(121, 23);
            cb_cname.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(178, 195);
            label7.Name = "label7";
            label7.Size = new Size(117, 21);
            label7.TabIndex = 11;
            label7.Text = "Courses Details";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(89, 141);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(53, 36);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(352, 111);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(51, 33);
            btn_del.TabIndex = 13;
            btn_del.Text = "Delete";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 381);
            Controls.Add(btn_del);
            Controls.Add(btn_add);
            Controls.Add(label7);
            Controls.Add(cb_cname);
            Controls.Add(cb_topic);
            Controls.Add(text_duration);
            Controls.Add(text_name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_courses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_courses;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox text_name;
        private TextBox text_duration;
        private ComboBox cb_topic;
        private ComboBox cb_cname;
        private Label label7;
        private Button btn_add;
        private Button btn_del;
    }
}
