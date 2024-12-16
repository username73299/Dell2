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
    public partial class NhaCungCapForm : Form
    {
        private SqlConnection connection;

        public NhaCungCapForm()
        {
            InitializeComponent();
            string connectionString = @"Data Source=localhost;Initial Catalog=banhang;User ID=sa;Password=12345678;TrustServerCertificate=True";
            connection = new SqlConnection(connectionString);
        }
        private void ConnectToDatabase()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                DisconnectFromDatabase(); // Đảm bảo đóng kết nối
            }

        }
        private void DisconnectFromDatabase()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        private void LoadDataGridView()
        {
            string query = "SELECT * FROM NhaCungCap";
            try
            {
                ConnectToDatabase(); // Mở kết nối
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.Rows.Clear(); // Xóa các dòng cũ

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["maNhaCungCap"].ToString(),
                        reader["tenNhaCungCap"].ToString(),
                        reader["diachi"].ToString(),
                        reader["sdt"].ToString(),
                        reader["email"].ToString()
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                DisconnectFromDatabase(); // Đảm bảo đóng kết nối
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            string tenncc = txtTenNCC.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;

            string query = "INSERT INTO NhaCungCap (tenNhaCungCap, diachi, sdt, email) VALUES (@tenNhaCungCap, @diachi, @sdt, @email)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@tenNhaCungCAp", tenncc);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@email", email);

            try
            {
                ConnectToDatabase();
                cmd.ExecuteNonQuery();
                DisconnectFromDatabase();
                LoadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp: " + ex.Message);
            }
            finally
            {
                DisconnectFromDatabase(); // Đảm bảo đóng kết nối
            }

        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã nhà cung cấp từ textbox
            int mancc;
            bool isValid = int.TryParse(txtMaNCC.Text, out mancc);
            if (!isValid)
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp hợp lệ.");
                return;
            }

            // Câu truy vấn SQL để xóa nhà cung cấp
            string query = "DELETE FROM NhaCungCap WHERE maNhaCungCap = @maNhaCungCap";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@maNhaCungCap", mancc);

            try
            {
                // Kết nối đến cơ sở dữ liệu và thực thi câu lệnh xóa
                ConnectToDatabase();
                int rowsAffected = cmd.ExecuteNonQuery();  // Lấy số lượng bản ghi bị ảnh hưởng

                // Kiểm tra nếu không có bản ghi nào bị xóa
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp với mã đã nhập.");
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công.");
                    LoadDataGridView();  // Tải lại DataGridView sau khi xóa
                }

                // Ngắt kết nối
                DisconnectFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhà cung cấp: " + ex.Message);
            }
            finally
            {
                DisconnectFromDatabase(); // Đảm bảo đóng kết nối
            }


        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int maNCC;
            // Kiểm tra giá trị mã nhà cung cấp có hợp lệ hay không
            bool isValidMaNCC = int.TryParse(txtMaNCC.Text, out maNCC);

            if (!isValidMaNCC)
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp hợp lệ.");
                return;
            }

            // Câu truy vấn SQL để tìm kiếm nhà cung cấp theo mã nhà cung cấp
            string query = "SELECT * FROM NhaCungCap WHERE maNhaCungCap = @maNhaCungCap";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@maNhaCungCap", maNCC);

            try
            {
                ConnectToDatabase();
                SqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();  // Xóa dữ liệu cũ trong DataGridView trước khi hiển thị kết quả mới

                // Nếu có kết quả tìm thấy
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Thêm dòng dữ liệu vào DataGridView
                        dataGridView1.Rows.Add(
                            reader["maNhaCungCap"].ToString(),
                            reader["tenNhaCungCap"].ToString(),
                            reader["diachi"].ToString(),
                            reader["sdt"].ToString(),
                            reader["email"].ToString()
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin nhà cung cấp.");
                }
                DisconnectFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
            finally
            {
                DisconnectFromDatabase(); // Đảm bảo đóng kết nối
            }

        }
        private void Load_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int mancc;
            bool isValid = int.TryParse(txtMaNCC.Text, out mancc);
            if (!isValid)
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp hợp lệ.");
                return;
            }

            string tenncc = txtTenNCC.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;

            string query = "UPDATE NhaCungCap SET tenNhaCungCap = @tenNhaCungCap, diachi = @diachi, sdt = @sdt, email = @email WHERE maNhaCungCap = @maNhaCungCap";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@tenNhaCungCap", tenncc);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@maNhaCungCap", mancc);

            try
            {
                ConnectToDatabase();
                int rowsAffected = cmd.ExecuteNonQuery();  // Kiểm tra số dòng bị ảnh hưởng

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp với mã đã nhập.");
                }
                else
                {
                    MessageBox.Show("Sửa thông tin nhà cung cấp thành công.");
                    LoadDataGridView();  // Tải lại DataGridView sau khi sửa
                }
                DisconnectFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa nhà cung cấp: " + ex.Message);
            }
            finally
            {
                DisconnectFromDatabase(); // Đảm bảo đóng kết nối
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
