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
    public partial class Form8 : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=banhang;User ID=sa;Password=12345678;TrustServerCertificate=True";

        public Form8(DataTable dtt)
        {
            InitializeComponent();
            chitietDT.DataSource = dtt;
            chitietDT.AutoGenerateColumns = false;
            foreach (DataGridViewColumn col in chitietDT.Columns)
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

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
