namespace WinFormsApp14
{
    partial class Form8
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
            chitietDT = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            GiaNhap = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            LoiNhuan = new DataGridViewTextBoxColumn();
            TongSoLuongBan = new DataGridViewTextBoxColumn();
            TongLoiNhuan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)chitietDT).BeginInit();
            SuspendLayout();
            // 
            // chitietDT
            // 
            chitietDT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chitietDT.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, GiaNhap, DonGia, LoiNhuan, TongSoLuongBan, TongLoiNhuan });
            chitietDT.Location = new Point(12, 12);
            chitietDT.Name = "chitietDT";
            chitietDT.RowHeadersWidth = 82;
            chitietDT.Size = new Size(1414, 426);
            chitietDT.TabIndex = 0;
            // 
            // MaSP
            // 
            MaSP.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MaSP.HeaderText = "Mã sản phẩm";
            MaSP.MinimumWidth = 10;
            MaSP.Name = "MaSP";
            MaSP.Width = 204;
            // 
            // TenSP
            // 
            TenSP.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TenSP.HeaderText = "Tên sản phẩm";
            TenSP.MinimumWidth = 10;
            TenSP.Name = "TenSP";
            TenSP.Width = 208;
            // 
            // GiaNhap
            // 
            GiaNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            GiaNhap.HeaderText = "Giá nhập";
            GiaNhap.MinimumWidth = 10;
            GiaNhap.Name = "GiaNhap";
            GiaNhap.Width = 154;
            // 
            // DonGia
            // 
            DonGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DonGia.HeaderText = "Giá bán";
            DonGia.MinimumWidth = 10;
            DonGia.Name = "DonGia";
            DonGia.Width = 140;
            // 
            // LoiNhuan
            // 
            LoiNhuan.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            LoiNhuan.HeaderText = "Lợi nhuận";
            LoiNhuan.MinimumWidth = 10;
            LoiNhuan.Name = "LoiNhuan";
            LoiNhuan.Width = 165;
            // 
            // TongSoLuongBan
            // 
            TongSoLuongBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TongSoLuongBan.HeaderText = "Tổng lượng bán";
            TongSoLuongBan.MinimumWidth = 10;
            TongSoLuongBan.Name = "TongSoLuongBan";
            TongSoLuongBan.Width = 230;
            // 
            // TongLoiNhuan
            // 
            TongLoiNhuan.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TongLoiNhuan.HeaderText = "Tổng Lợi Nhuận";
            TongLoiNhuan.MinimumWidth = 10;
            TongLoiNhuan.Name = "TongLoiNhuan";
            TongLoiNhuan.Width = 231;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 450);
            Controls.Add(chitietDT);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)chitietDT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView chitietDT;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn GiaNhap;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn LoiNhuan;
        private DataGridViewTextBoxColumn TongSoLuongBan;
        private DataGridViewTextBoxColumn TongLoiNhuan;
    }
}