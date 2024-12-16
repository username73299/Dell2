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
    public partial class ThongKeDoanhThu : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=banhang;User ID=sa;Password=12345678;TrustServerCertificate=True";

        public ThongKeDoanhThu()
        {
            InitializeComponent();
            LoadProductData();
        }

        private void LoadProductData()
        {
            string query = "SELECT * FROM ViewThongKeDoanhThu";  // Truy vấn trực tiếp từ View

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dtt = new DataTable();
                adapter.Fill(dtt);

                // Tắt AutoGenerateColumns để không tự động tạo cột
                dataGridView1.AutoGenerateColumns = false;

                // Gán dữ liệu cho các cột thủ công
                dataGridView1.DataSource = dtt;

                // Gán dữ liệu vào các cột cụ thể
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col.Name == "MaSP") col.DataPropertyName = "maSanPham";
                    if (col.Name == "TenSP") col.DataPropertyName = "tenSanPham";
                    if (col.Name == "GiaNhap") col.DataPropertyName = "giaNhap";
                    if (col.Name == "DonGia") col.DataPropertyName = "donGia";
                    if (col.Name == "LoiNhuan") col.DataPropertyName = "LoiNhuan";
                    if (col.Name == "TongSoLuongBan") col.DataPropertyName = "TongSoLuongBan";
                    if (col.Name == "TongLoiNhuan") col.DataPropertyName = "TongLoiNhuan";
                }
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

            string query = "SELECT * FROM ViewThongKeDoanhThu WHERE maSanPham LIKE @searchText OR tenSanPham LIKE @searchText";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                adapter.Fill(dtt);
                dataGridView1.AutoGenerateColumns = false;

                // Gán dữ liệu vào các cột thủ công
                dataGridView1.DataSource = dtt;
                if (dtt.Rows.Count > 0)
                {
                    Form8 form8 = new Form8(dtt);
                    form8.Show();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm.");
                }
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
