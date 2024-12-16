using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp14
{
    public partial class TransForm : Form
    {
        public TransForm()
        {
            InitializeComponent();
        }

        private void TransForm_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu tkdt = new ThongKeDoanhThu();
            tkdt.Show();
        }

        private void btnThongKeSanPham_Click(object sender, EventArgs e)
        {
            FormThongKe formThongKe = new FormThongKe();
            formThongKe.Show();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCapForm nccForm = new NhaCungCapForm();
            nccForm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuanLySP_Click(object sender, EventArgs e)
        {
            QuanLySanPham  qlsp = new QuanLySanPham();
            qlsp.Show();
        }
    }
}
