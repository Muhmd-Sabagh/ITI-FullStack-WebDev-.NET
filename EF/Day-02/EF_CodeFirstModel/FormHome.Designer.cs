namespace EF_CodeFirstModel
{
    partial class FormHome
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
            lblWelcome = new Label();
            label2 = new Label();
            DgvNews = new DataGridView();
            lblCategories = new Label();
            lblAuthors = new Label();
            txtCatName = new TextBox();
            lblCatName = new Label();
            lblCatDesc = new Label();
            rtbCatDesc = new RichTextBox();
            BtnCatAdd = new Button();
            cbCategory = new ComboBox();
            BtnCatDel = new Button();
            cbAuthor = new ComboBox();
            lblAuthName = new Label();
            BtnAuthDel = new Button();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            lblAuthor = new Label();
            txtTitle = new TextBox();
            txtBrief = new TextBox();
            rtbDesc = new RichTextBox();
            dtpPublishDate = new DateTimePicker();
            cbNewsCategory = new ComboBox();
            cbNewsAuthor = new ComboBox();
            BtnAdd = new Button();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            BtnCancel = new Button();
            lblCatName1 = new Label();
            BtnAccDel = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvNews).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F);
            lblWelcome.Location = new Point(200, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(204, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome <username>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(16, 54);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 1;
            label2.Text = "News";
            // 
            // DgvNews
            // 
            DgvNews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvNews.Location = new Point(12, 347);
            DgvNews.Name = "DgvNews";
            DgvNews.Size = new Size(592, 150);
            DgvNews.TabIndex = 2;
            DgvNews.RowHeaderMouseDoubleClick += DgvNews_RowHeaderMouseDoubleClick;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Font = new Font("Segoe UI", 12F);
            lblCategories.Location = new Point(233, 54);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(84, 21);
            lblCategories.TabIndex = 3;
            lblCategories.Text = "Categories";
            // 
            // lblAuthors
            // 
            lblAuthors.AutoSize = true;
            lblAuthors.Font = new Font("Segoe UI", 12F);
            lblAuthors.Location = new Point(471, 54);
            lblAuthors.Name = "lblAuthors";
            lblAuthors.Size = new Size(65, 21);
            lblAuthors.TabIndex = 4;
            lblAuthors.Text = "Authors";
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(319, 86);
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(125, 23);
            txtCatName.TabIndex = 5;
            // 
            // lblCatName
            // 
            lblCatName.AutoSize = true;
            lblCatName.Location = new Point(261, 94);
            lblCatName.Name = "lblCatName";
            lblCatName.Size = new Size(39, 15);
            lblCatName.TabIndex = 7;
            lblCatName.Text = "Name";
            // 
            // lblCatDesc
            // 
            lblCatDesc.AutoSize = true;
            lblCatDesc.Location = new Point(233, 128);
            lblCatDesc.Name = "lblCatDesc";
            lblCatDesc.Size = new Size(67, 15);
            lblCatDesc.TabIndex = 8;
            lblCatDesc.Text = "Description";
            // 
            // rtbCatDesc
            // 
            rtbCatDesc.Location = new Point(319, 125);
            rtbCatDesc.Name = "rtbCatDesc";
            rtbCatDesc.Size = new Size(125, 46);
            rtbCatDesc.TabIndex = 9;
            rtbCatDesc.Text = "";
            // 
            // BtnCatAdd
            // 
            BtnCatAdd.Location = new Point(319, 183);
            BtnCatAdd.Name = "BtnCatAdd";
            BtnCatAdd.Size = new Size(75, 37);
            BtnCatAdd.TabIndex = 10;
            BtnCatAdd.Text = "Add";
            BtnCatAdd.UseVisualStyleBackColor = true;
            BtnCatAdd.Click += BtnCatAdd_Click;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(289, 263);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(125, 23);
            cbCategory.TabIndex = 11;
            // 
            // BtnCatDel
            // 
            BtnCatDel.Location = new Point(319, 297);
            BtnCatDel.Name = "BtnCatDel";
            BtnCatDel.Size = new Size(75, 35);
            BtnCatDel.TabIndex = 12;
            BtnCatDel.Text = "Delete";
            BtnCatDel.UseVisualStyleBackColor = true;
            BtnCatDel.Click += BtnCatDel_Click;
            // 
            // cbAuthor
            // 
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(471, 108);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(121, 23);
            cbAuthor.TabIndex = 13;
            // 
            // lblAuthName
            // 
            lblAuthName.AutoSize = true;
            lblAuthName.Location = new Point(471, 90);
            lblAuthName.Name = "lblAuthName";
            lblAuthName.Size = new Size(79, 15);
            lblAuthName.TabIndex = 14;
            lblAuthName.Text = "Author Name";
            // 
            // BtnAuthDel
            // 
            BtnAuthDel.Location = new Point(498, 146);
            BtnAuthDel.Name = "BtnAuthDel";
            BtnAuthDel.Size = new Size(64, 35);
            BtnAuthDel.TabIndex = 15;
            BtnAuthDel.Text = "Delete";
            BtnAuthDel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 94);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 16;
            label1.Text = "Title";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 125);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 17;
            label8.Text = "Brief";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 156);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 18;
            label9.Text = "Description";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 203);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 19;
            label10.Text = "PublishDate";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 236);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 20;
            label11.Text = "Category";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(39, 270);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(44, 15);
            lblAuthor.TabIndex = 21;
            lblAuthor.Text = "Author";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(89, 84);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(119, 23);
            txtTitle.TabIndex = 22;
            // 
            // txtBrief
            // 
            txtBrief.Location = new Point(89, 117);
            txtBrief.Name = "txtBrief";
            txtBrief.Size = new Size(119, 23);
            txtBrief.TabIndex = 23;
            // 
            // rtbDesc
            // 
            rtbDesc.Location = new Point(89, 146);
            rtbDesc.Name = "rtbDesc";
            rtbDesc.Size = new Size(119, 39);
            rtbDesc.TabIndex = 24;
            rtbDesc.Text = "";
            // 
            // dtpPublishDate
            // 
            dtpPublishDate.Format = DateTimePickerFormat.Short;
            dtpPublishDate.Location = new Point(89, 197);
            dtpPublishDate.MaxDate = new DateTime(2025, 5, 15, 0, 0, 0, 0);
            dtpPublishDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpPublishDate.Name = "dtpPublishDate";
            dtpPublishDate.Size = new Size(119, 23);
            dtpPublishDate.TabIndex = 25;
            dtpPublishDate.Value = new DateTime(2025, 5, 15, 0, 0, 0, 0);
            // 
            // cbNewsCategory
            // 
            cbNewsCategory.FormattingEnabled = true;
            cbNewsCategory.Location = new Point(89, 228);
            cbNewsCategory.Name = "cbNewsCategory";
            cbNewsCategory.Size = new Size(119, 23);
            cbNewsCategory.TabIndex = 26;
            // 
            // cbNewsAuthor
            // 
            cbNewsAuthor.FormattingEnabled = true;
            cbNewsAuthor.Location = new Point(89, 262);
            cbNewsAuthor.Name = "cbNewsAuthor";
            cbNewsAuthor.Size = new Size(119, 23);
            cbNewsAuthor.TabIndex = 27;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(89, 297);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(56, 35);
            BtnAdd.TabIndex = 28;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(24, 297);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(59, 35);
            BtnUpdate.TabIndex = 29;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(151, 297);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(57, 35);
            BtnDelete.TabIndex = 30;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(214, 297);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(56, 35);
            BtnCancel.TabIndex = 31;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // lblCatName1
            // 
            lblCatName1.AutoSize = true;
            lblCatName1.Location = new Point(289, 245);
            lblCatName1.Name = "lblCatName1";
            lblCatName1.Size = new Size(90, 15);
            lblCatName1.TabIndex = 32;
            lblCatName1.Text = "Category Name";
            // 
            // BtnAccDel
            // 
            BtnAccDel.Location = new Point(498, 13);
            BtnAccDel.Name = "BtnAccDel";
            BtnAccDel.Size = new Size(106, 23);
            BtnAccDel.TabIndex = 33;
            BtnAccDel.Text = "Delete Account";
            BtnAccDel.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 511);
            Controls.Add(BtnAccDel);
            Controls.Add(lblCatName1);
            Controls.Add(BtnCancel);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnAdd);
            Controls.Add(cbNewsAuthor);
            Controls.Add(cbNewsCategory);
            Controls.Add(dtpPublishDate);
            Controls.Add(rtbDesc);
            Controls.Add(txtBrief);
            Controls.Add(txtTitle);
            Controls.Add(lblAuthor);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(BtnAuthDel);
            Controls.Add(lblAuthName);
            Controls.Add(cbAuthor);
            Controls.Add(BtnCatDel);
            Controls.Add(cbCategory);
            Controls.Add(BtnCatAdd);
            Controls.Add(rtbCatDesc);
            Controls.Add(lblCatDesc);
            Controls.Add(lblCatName);
            Controls.Add(txtCatName);
            Controls.Add(lblAuthors);
            Controls.Add(lblCategories);
            Controls.Add(DgvNews);
            Controls.Add(label2);
            Controls.Add(lblWelcome);
            Name = "FormHome";
            Text = "FormHome";
            Load += FormHome_Load;
            ((System.ComponentModel.ISupportInitialize)DgvNews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label label2;
        private DataGridView DgvNews;
        private Label lblCategories;
        private Label lblAuthors;
        private TextBox txtCatName;
        private Label lblCatName;
        private Label lblCatDesc;
        private RichTextBox rtbCatDesc;
        private Button BtnCatAdd;
        private ComboBox cbCategory;
        private Button BtnCatDel;
        private ComboBox cbAuthor;
        private Label lblAuthName;
        private Button BtnAuthDel;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label lblAuthor;
        private TextBox txtTitle;
        private TextBox txtBrief;
        private RichTextBox rtbDesc;
        private DateTimePicker dtpPublishDate;
        private ComboBox cbNewsCategory;
        private ComboBox cbNewsAuthor;
        private Button BtnAdd;
        private Button BtnUpdate;
        private Button BtnDelete;
        private Button BtnCancel;
        private Label lblCatName1;
        private Button BtnAccDel;
    }
}