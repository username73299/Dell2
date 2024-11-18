namespace WinFormsApp14
{
    partial class RegisterForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            btnGoToLogin = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(295, 109);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 39);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(295, 183);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 39);
            txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(295, 256);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(200, 39);
            txtConfirmPassword.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(103, 332);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 46);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "button1";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnGoToLogin
            // 
            btnGoToLogin.Location = new Point(485, 337);
            btnGoToLogin.Name = "btnGoToLogin";
            btnGoToLogin.Size = new Size(150, 46);
            btnGoToLogin.TabIndex = 4;
            btnGoToLogin.Text = "button2";
            btnGoToLogin.UseVisualStyleBackColor = true;
            btnGoToLogin.Click += btnGoToLogin_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoToLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "RegisterForm";
            Text = "Form2";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private Button btnGoToLogin;
    }
}