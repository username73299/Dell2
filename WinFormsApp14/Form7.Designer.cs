namespace WinFormsApp14
{
    partial class ThongKeDoanhThu
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
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            GiaNhap = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            LoiNhuan = new DataGridViewTextBoxColumn();
            TongSoLuongBan = new DataGridViewTextBoxColumn();
            TongLoiNhuan = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            LoadData = new Button();
            panel2 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, GiaNhap, DonGia, LoiNhuan, TongSoLuongBan, TongLoiNhuan });
            dataGridView1.Location = new Point(-1, -3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1362, 664);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MaSP
            // 
            MaSP.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MaSP.HeaderText = "Mã Sản Phẩm";
            MaSP.MinimumWidth = 10;
            MaSP.Name = "MaSP";
            MaSP.Width = 198;
            // 
            // TenSP
            // 
            TenSP.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TenSP.HeaderText = "Tên Sản Phẩm";
            TenSP.MinimumWidth = 10;
            TenSP.Name = "TenSP";
            TenSP.Width = 206;
            // 
            // GiaNhap
            // 
            GiaNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            GiaNhap.HeaderText = "Giá Nhập";
            GiaNhap.MinimumWidth = 10;
            GiaNhap.Name = "GiaNhap";
            GiaNhap.Width = 152;
            // 
            // DonGia
            // 
            DonGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DonGia.HeaderText = "Giá Bán";
            DonGia.MinimumWidth = 10;
            DonGia.Name = "DonGia";
            DonGia.Width = 138;
            // 
            // LoiNhuan
            // 
            LoiNhuan.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            LoiNhuan.HeaderText = "Lợi Nhuận";
            LoiNhuan.MinimumWidth = 10;
            LoiNhuan.Name = "LoiNhuan";
            LoiNhuan.Width = 165;
            // 
            // TongSoLuongBan
            // 
            TongSoLuongBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TongSoLuongBan.HeaderText = "Tổng Lượng Bán";
            TongSoLuongBan.MinimumWidth = 10;
            TongSoLuongBan.Name = "TongSoLuongBan";
            TongSoLuongBan.Width = 194;
            // 
            // TongLoiNhuan
            // 
            TongLoiNhuan.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TongLoiNhuan.HeaderText = "Tổng Lợi Nhuận";
            TongLoiNhuan.MinimumWidth = 10;
            TongLoiNhuan.Name = "TongLoiNhuan";
            TongLoiNhuan.Width = 225;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(LoadData);
            panel1.Location = new Point(1360, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 271);
            panel1.TabIndex = 1;
            // 
            // LoadData
            // 
            LoadData.BackColor = SystemColors.Info;
            LoadData.Location = new Point(73, 114);
            LoadData.Name = "LoadData";
            LoadData.Size = new Size(173, 42);
            LoadData.TabIndex = 0;
            LoadData.Text = "Load";
            LoadData.UseVisualStyleBackColor = false;
            LoadData.Click += LoadData_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(1360, 265);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 396);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(73, 91);
            label1.Name = "label1";
            label1.Size = new Size(172, 31);
            label1.TabIndex = 2;
            label1.Text = "Mã Sản Phẩm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 35);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(73, 251);
            button1.Name = "button1";
            button1.Size = new Size(173, 42);
            button1.TabIndex = 0;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1701, 659);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Name = "ThongKeDoanhThu";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn GiaNhap;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn LoiNhuan;
        private DataGridViewTextBoxColumn TongSoLuongBan;
        private DataGridViewTextBoxColumn TongLoiNhuan;
        private Panel panel1;
        private Panel panel2;
        private Button LoadData;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}