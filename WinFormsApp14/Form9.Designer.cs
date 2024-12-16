namespace WinFormsApp14
{
    partial class QuanLySanPham
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
            dataGridView1 = new DataGridView();
            masp = new DataGridViewTextBoxColumn();
            mancc = new DataGridViewTextBoxColumn();
            malsp = new DataGridViewTextBoxColumn();
            tensp = new DataGridViewTextBoxColumn();
            gianhap = new DataGridViewTextBoxColumn();
            dongia = new DataGridViewTextBoxColumn();
            xuatxu = new DataGridViewTextBoxColumn();
            soluongton = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label1 = new Label();
            btnSua = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            Load = new Button();
            label4 = new Label();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            txtGiaNhap = new TextBox();
            txtDonGia = new TextBox();
            txtXuatXu = new TextBox();
            txtTenSP = new TextBox();
            txtMaLSP = new TextBox();
            txtMaNCC = new TextBox();
            txtMaSP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { masp, mancc, malsp, tensp, gianhap, dongia, xuatxu, soluongton });
            dataGridView1.Location = new Point(2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1700, 430);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // masp
            // 
            masp.HeaderText = "Mã SP";
            masp.MinimumWidth = 10;
            masp.Name = "masp";
            masp.Width = 200;
            // 
            // mancc
            // 
            mancc.HeaderText = "Mã NCC";
            mancc.MinimumWidth = 10;
            mancc.Name = "mancc";
            mancc.Width = 200;
            // 
            // malsp
            // 
            malsp.HeaderText = "Mã Loại SP";
            malsp.MinimumWidth = 10;
            malsp.Name = "malsp";
            malsp.Width = 200;
            // 
            // tensp
            // 
            tensp.HeaderText = "Tên SP";
            tensp.MinimumWidth = 10;
            tensp.Name = "tensp";
            tensp.Width = 200;
            // 
            // gianhap
            // 
            gianhap.HeaderText = "Giá Nhập";
            gianhap.MinimumWidth = 10;
            gianhap.Name = "gianhap";
            gianhap.Width = 200;
            // 
            // dongia
            // 
            dongia.HeaderText = "Đơn Giá";
            dongia.MinimumWidth = 10;
            dongia.Name = "dongia";
            dongia.Width = 200;
            // 
            // xuatxu
            // 
            xuatxu.HeaderText = "Xuất Xứ";
            xuatxu.MinimumWidth = 10;
            xuatxu.Name = "xuatxu";
            xuatxu.Width = 200;
            // 
            // soluongton
            // 
            soluongton.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            soluongton.HeaderText = "Số Lượng Tồn";
            soluongton.MinimumWidth = 10;
            soluongton.Name = "soluongton";
            soluongton.Width = 208;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(1106, 428);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 231);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(160, 40);
            label1.Name = "label1";
            label1.Size = new Size(278, 31);
            label1.TabIndex = 11;
            label1.Text = "Nhập mã/tên sản phẩm";
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.Info;
            btnSua.Location = new Point(331, 166);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(173, 42);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Info;
            btnSearch.Location = new Point(114, 166);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(173, 42);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(188, 100);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 35);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveBorder;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Load);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtGiaNhap);
            panel1.Controls.Add(txtDonGia);
            panel1.Controls.Add(txtXuatXu);
            panel1.Controls.Add(txtTenSP);
            panel1.Controls.Add(txtMaLSP);
            panel1.Controls.Add(txtMaNCC);
            panel1.Controls.Add(txtMaSP);
            panel1.Location = new Point(2, 428);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 231);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.HighlightText;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(445, 169);
            label8.Name = "label8";
            label8.Size = new Size(110, 31);
            label8.TabIndex = 15;
            label8.Text = "Đơn Giá";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.HighlightText;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(445, 125);
            label7.Name = "label7";
            label7.Size = new Size(119, 31);
            label7.TabIndex = 14;
            label7.Text = "Giá nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.HighlightText;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(445, 84);
            label6.Name = "label6";
            label6.Size = new Size(104, 31);
            label6.TabIndex = 13;
            label6.Text = "Xuất xứ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.HighlightText;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(445, 43);
            label5.Name = "label5";
            label5.Size = new Size(97, 31);
            label5.TabIndex = 12;
            label5.Text = "Tên SP";
            // 
            // Load
            // 
            Load.BackColor = SystemColors.Info;
            Load.Location = new Point(904, 121);
            Load.Name = "Load";
            Load.Size = new Size(173, 42);
            Load.TabIndex = 8;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = false;
            Load.Click += Load_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HighlightText;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(14, 128);
            label4.Name = "label4";
            label4.Size = new Size(145, 31);
            label4.TabIndex = 11;
            label4.Text = "Mã Loại SP";
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Info;
            btnThem.Location = new Point(904, 46);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(173, 42);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HighlightText;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(14, 85);
            label3.Name = "label3";
            label3.Size = new Size(107, 31);
            label3.TabIndex = 10;
            label3.Text = "Mã NCC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(14, 43);
            label2.Name = "label2";
            label2.Size = new Size(88, 31);
            label2.TabIndex = 9;
            label2.Text = "Mã SP";
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(601, 125);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(230, 35);
            txtGiaNhap.TabIndex = 6;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(601, 166);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(230, 35);
            txtDonGia.TabIndex = 5;
            // 
            // txtXuatXu
            // 
            txtXuatXu.Location = new Point(601, 82);
            txtXuatXu.Name = "txtXuatXu";
            txtXuatXu.Size = new Size(230, 35);
            txtXuatXu.TabIndex = 4;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(601, 40);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(230, 35);
            txtTenSP.TabIndex = 3;
            // 
            // txtMaLSP
            // 
            txtMaLSP.Location = new Point(163, 125);
            txtMaLSP.Name = "txtMaLSP";
            txtMaLSP.Size = new Size(230, 35);
            txtMaLSP.TabIndex = 2;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(163, 81);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(230, 35);
            txtMaNCC.TabIndex = 1;
            txtMaNCC.TextChanged += textBox2_TextChanged;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(163, 40);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(230, 35);
            txtMaSP.TabIndex = 0;
            // 
            // QuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1701, 659);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Name = "QuanLySanPham";
            Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtMaLSP;
        private TextBox txtMaNCC;
        private TextBox txtMaSP;
        private TextBox txtSearch;
        private TextBox txtGiaNhap;
        private TextBox txtDonGia;
        private TextBox txtXuatXu;
        private TextBox txtTenSP;
        private Button btnThem;
        private Button btnSearch;
        private Button btnSua;
        private DataGridViewTextBoxColumn masp;
        private DataGridViewTextBoxColumn mancc;
        private DataGridViewTextBoxColumn malsp;
        private DataGridViewTextBoxColumn tensp;
        private DataGridViewTextBoxColumn gianhap;
        private DataGridViewTextBoxColumn dongia;
        private DataGridViewTextBoxColumn xuatxu;
        private DataGridViewTextBoxColumn soluongton;
        private Button Load;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}