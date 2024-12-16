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

    public partial class QuanLySanPham : Form
    {
        private SqlConnection connection;

        public QuanLySanPham()
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
        }
        private void DisconnectFromDatabase()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void LoadProductData()
        {
            string query = "SELECT * FROM ViewSanPhamW"; // Truy vấn từ view

            try
            {
                ConnectToDatabase(); // Mở kết nối
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                // Xóa các dòng cũ trong DataGridView
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    // Thêm các dòng dữ liệu vào DataGridView
                    dataGridView1.Rows.Add(
                        reader["maSanPham"].ToString(),
                        reader["maNhaCungCap"].ToString(),
                        reader["maLoaiSanPham"].ToString(),
                        reader["tenSanPham"].ToString(),
                        reader["giaNhap"].ToString(),
                        reader["donGia"].ToString(),
                        reader["xuatXu"].ToString(),
                        reader["SoLuongTon"].ToString() // Số lượng tồn tính từ View
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sản phẩm: " + ex.Message);
            }
            finally
            {
                DisconnectFromDatabase(); // Đảm bảo đóng kết nối
            }
        }








        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            string mancc = txtMaNCC.Text;
            string malsp = txtMaLSP.Text;
            string tensp = txtTenSP.Text;
            string xuatxu = txtXuatXu.Text;
            string gianhap = txtGiaNhap.Text;
            string dongia = txtDonGia.Text;

            string query = "INSERT INTO SanPham (maSanPham, maNhaCungCap, maLoaiSanPham, tenSanPham, giaNhap, donGia, xuatXu) VALUES (@maSanPham, @maNhaCungCap, @maLoaiSanPham ,@tenSanPham ,@giaNhap ,@donGia, @xuatXu)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@maSanPham", masp);
            cmd.Parameters.AddWithValue("@maNhaCungCap", mancc);
            cmd.Parameters.AddWithValue("@maLoaiSanPham", malsp);
            cmd.Parameters.AddWithValue("@tenSanPham", tensp);
            cmd.Parameters.AddWithValue("@giaNhap", gianhap);
            cmd.Parameters.AddWithValue("@donGia", dongia);
            cmd.Parameters.AddWithValue("@xuatXu", xuatxu);

            try
            {
                ConnectToDatabase();
                cmd.ExecuteNonQuery();
                DisconnectFromDatabase();
                LoadProductData();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim(); // Lấy từ ô tìm kiếm

            if (string.IsNullOrEmpty(searchKeyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            string query = "SELECT * FROM ViewSanPhamW WHERE maSanPham LIKE @searchKeyword OR tenSanPham LIKE @searchKeyword";

            try
            {
                ConnectToDatabase();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchKeyword", "%" + searchKeyword + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.Rows.Clear(); // Xóa dữ liệu cũ

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["maSanPham"].ToString(),
                        reader["maNhaCungCap"].ToString(),
                        reader["maLoaiSanPham"].ToString(),
                        reader["tenSanPham"].ToString(),
                        reader["giaNhap"].ToString(),
                        reader["donGia"].ToString(),
                        reader["xuatXu"].ToString(),
                        reader["SoLuongTon"].ToString()
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm sản phẩm: " + ex.Message);
            }
            finally
            {
                DisconnectFromDatabase(); // Đảm bảo đóng kết nối
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim(); // Lấy từ ô tìm kiếm

            if (string.IsNullOrEmpty(searchKeyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm để sửa.");
                return;
            }

            string masp = txtMaSP.Text;
            string mancc = txtMaNCC.Text;
            string malsp = txtMaLSP.Text;
            string tensp = txtTenSP.Text;
            string xuatxu = txtXuatXu.Text;
            string gianhap = txtGiaNhap.Text;
            string dongia = txtDonGia.Text;

            string query = "UPDATE SanPham SET maNhaCungCap = @maNhaCungCap, maLoaiSanPham = @maLoaiSanPham, " +
                           "tenSanPham = @tenSanPham, giaNhap = @giaNhap, donGia = @donGia, xuatXu = @xuatXu " +
                           "WHERE maSanPham LIKE @searchKeyword";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@searchKeyword", "%" + searchKeyword + "%");
            cmd.Parameters.AddWithValue("@maSanPham", masp);
            cmd.Parameters.AddWithValue("@maNhaCungCap", mancc);
            cmd.Parameters.AddWithValue("@maLoaiSanPham", malsp);
            cmd.Parameters.AddWithValue("@tenSanPham", tensp);
            cmd.Parameters.AddWithValue("@giaNhap", gianhap);
            cmd.Parameters.AddWithValue("@donGia", dongia);
            cmd.Parameters.AddWithValue("@xuatXu", xuatxu);

            try
            {
                ConnectToDatabase();
                cmd.ExecuteNonQuery(); // Thực thi câu lệnh UPDATE
                MessageBox.Show("Cập nhật sản phẩm thành công.");
                DisconnectFromDatabase();
                LoadProductData(); // Tải lại dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa sản phẩm: " + ex.Message);
            }
            finally
            {
                DisconnectFromDatabase(); // Đảm bảo đóng kết nối
            }

        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
