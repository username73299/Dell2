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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(295, 62);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 39);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(295, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 39);
            txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(295, 208);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(200, 39);
            txtConfirmPassword.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(307, 274);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 46);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Đăng ký ";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnGoToLogin
            // 
            btnGoToLogin.Location = new Point(307, 365);
            btnGoToLogin.Name = "btnGoToLogin";
            btnGoToLogin.Size = new Size(150, 46);
            btnGoToLogin.TabIndex = 4;
            btnGoToLogin.Text = "Đăng nhập";
            btnGoToLogin.UseVisualStyleBackColor = true;
            btnGoToLogin.Click += btnGoToLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 69);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 5;
            label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 142);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 6;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 215);
            label3.Name = "label3";
            label3.Size = new Size(210, 32);
            label3.TabIndex = 7;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 372);
            label4.Name = "label4";
            label4.Size = new Size(186, 32);
            label4.TabIndex = 8;
            label4.Text = "Đã có tài khoản:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGoToLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "RegisterForm";
            Text = "Tên tài khoản";
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}