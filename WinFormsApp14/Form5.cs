using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace WinFormsApp14
{
    public partial class FormThongKe : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=banhang;User ID=sa;Password=12345678;TrustServerCertificate=True";

        public FormThongKe()
        {
            InitializeComponent();
            LoadProductData();
        }
        private void LoadProductData()
        {
            string query = "SELECT * FROM ViewThongKe";  // Truy vấn trực tiếp từ View

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Tắt AutoGenerateColumns để không tự động tạo cột
                dataGridView1.AutoGenerateColumns = false;

                // Gán dữ liệu cho các cột thủ công
                dataGridView1.DataSource = dt;

                // Gán dữ liệu vào các cột cụ thể
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col.Name == "MaSP") col.DataPropertyName = "MaSP";
                    if (col.Name == "TenSP") col.DataPropertyName = "TenSP";
                    if (col.Name == "DonGia") col.DataPropertyName = "DonGia";
                    if (col.Name == "SoLuongBan") col.DataPropertyName = "SoLuongBan";
                    if (col.Name == "SoLuongTon") col.DataPropertyName = "SoLuongTon";
                }
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim(); // Lấy thông tin từ TextBox

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm hoặc tên sản phẩm.");
                return;
            }

            // Truy vấn từ ViewThongKe, sử dụng điều kiện tìm kiếm
            string query = @"
                SELECT * 
                FROM ViewThongKe
                WHERE MaSP = @searchText OR TenSP LIKE '%' + @searchText + '%'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchText", searchText);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.AutoGenerateColumns = false;

                // Gán dữ liệu vào các cột thủ công
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    // Nếu tìm thấy sản phẩm, mở Form6 và truyền dữ liệu
                    Form6 form6 = new Form6(dt);
                    form6.Show();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm.");
                }
            }

        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            LoadProductData();
        }
    }
}
