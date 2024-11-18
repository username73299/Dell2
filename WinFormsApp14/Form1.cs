using Microsoft.Data.SqlClient;

namespace WinFormsApp14
{
    public partial class LoginForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-4GP6MQB;Initial Catalog=banraucu;Integrated Security=True;TrustServerCertificate=True";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Dang nhap thanh cong!");
                    
                }
                else
                {
                    MessageBox.Show("Sai tai khoan hoac mat khau.");
                }
            }

        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();

        }
    }
}
