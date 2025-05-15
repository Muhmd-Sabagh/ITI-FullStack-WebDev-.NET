namespace EF_CodeFirstModel
{
    partial class FormRegister
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            BtnRegister = new Button();
            BtnLogin = new Button();
            ChkShowPass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(84, 23);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 0;
            label1.Text = "Register Your Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 79);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 120);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 160);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(160, 23);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(160, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 152);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(160, 23);
            txtPassword.TabIndex = 6;
            // 
            // BtnRegister
            // 
            BtnRegister.Location = new Point(55, 211);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(80, 40);
            BtnRegister.TabIndex = 7;
            BtnRegister.Text = "Register";
            BtnRegister.UseVisualStyleBackColor = true;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(200, 211);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(80, 40);
            BtnLogin.TabIndex = 8;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // ChkShowPass
            // 
            ChkShowPass.AutoSize = true;
            ChkShowPass.Location = new Point(286, 152);
            ChkShowPass.Name = "ChkShowPass";
            ChkShowPass.Size = new Size(55, 19);
            ChkShowPass.TabIndex = 9;
            ChkShowPass.Text = "Show";
            ChkShowPass.UseVisualStyleBackColor = true;
            ChkShowPass.CheckedChanged += ChkShowPass_CheckedChanged;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 283);
            Controls.Add(ChkShowPass);
            Controls.Add(BtnLogin);
            Controls.Add(BtnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegister";
            Text = "FormRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button BtnRegister;
        private Button BtnLogin;
        private CheckBox ChkShowPass;
    }
}