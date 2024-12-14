namespace WinFormsApp14
{
    partial class Form6
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
            chitietSP = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            SoLuongHong = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)chitietSP).BeginInit();
            SuspendLayout();
            // 
            // chitietSP
            // 
            chitietSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chitietSP.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, DonGia, SoLuongBan, SoLuongHong, SoLuongTon });
            chitietSP.Location = new Point(12, 12);
            chitietSP.Name = "chitietSP";
            chitietSP.RowHeadersWidth = 82;
            chitietSP.Size = new Size(1254, 538);
            chitietSP.TabIndex = 0;
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
            // DonGia
            // 
            DonGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 10;
            DonGia.Name = "DonGia";
            DonGia.Width = 143;
            // 
            // SoLuongBan
            // 
            SoLuongBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 10;
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.Width = 202;
            // 
            // SoLuongHong
            // 
            SoLuongHong.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SoLuongHong.HeaderText = "Số lượng hỏng";
            SoLuongHong.MinimumWidth = 10;
            SoLuongHong.Name = "SoLuongHong";
            SoLuongHong.Width = 218;
            // 
            // SoLuongTon
            // 
            SoLuongTon.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 10;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.Width = 198;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 562);
            Controls.Add(chitietSP);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)chitietSP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView chitietSP;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn SoLuongHong;
        private DataGridViewTextBoxColumn SoLuongTon;
    }
}