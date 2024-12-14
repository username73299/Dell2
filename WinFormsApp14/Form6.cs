using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp14
{
    public partial class Form6 : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=banhang;User ID=sa;Password=12345678;TrustServerCertificate=True";

        public Form6(DataTable dt)
        {
            InitializeComponent();
            chitietSP.DataSource = dt;
            chitietSP.AutoGenerateColumns = false;

            foreach (DataGridViewColumn col in chitietSP.Columns)
            {
                if (col.Name == "MaSP") col.DataPropertyName = "MaSP";
                if (col.Name == "TenSP") col.DataPropertyName = "TenSP";
                if (col.Name == "DonGia") col.DataPropertyName = "DonGia";
                if (col.Name == "SoLuongBan") col.DataPropertyName = "SoLuongBan";
                if (col.Name == "SoLuongHong") col.DataPropertyName = "SoLuongHong";
                if (col.Name == "SoLuongTon") col.DataPropertyName = "SoLuongTon";
            }
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
