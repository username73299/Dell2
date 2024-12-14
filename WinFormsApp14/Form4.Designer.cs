namespace WinFormsApp14
{
    partial class TransForm
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
            btnNhaCungCap = new Button();
            btnThongKeSanPham = new Button();
            btnThongKeDoanhThu = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.Location = new Point(676, 103);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Size = new Size(215, 56);
            btnNhaCungCap.TabIndex = 0;
            btnNhaCungCap.Text = "Nhà Cung Cấp";
            btnNhaCungCap.UseVisualStyleBackColor = true;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // btnThongKeSanPham
            // 
            btnThongKeSanPham.Location = new Point(630, 325);
            btnThongKeSanPham.Name = "btnThongKeSanPham";
            btnThongKeSanPham.Size = new Size(303, 46);
            btnThongKeSanPham.TabIndex = 1;
            btnThongKeSanPham.Text = "Thống Kê Sản Phẩm";
            btnThongKeSanPham.UseVisualStyleBackColor = true;
            btnThongKeSanPham.Click += btnThongKeSanPham_Click;
            // 
            // btnThongKeDoanhThu
            // 
            btnThongKeDoanhThu.Location = new Point(649, 230);
            btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            btnThongKeDoanhThu.Size = new Size(284, 46);
            btnThongKeDoanhThu.TabIndex = 2;
            btnThongKeDoanhThu.Text = "Thống Kê Doanh Thu";
            btnThongKeDoanhThu.UseVisualStyleBackColor = true;
            btnThongKeDoanhThu.Click += btnThongKeDoanhThu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(709, 434);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThongKeDoanhThu);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnNhaCungCap);
            panel1.Controls.Add(btnThongKeSanPham);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1677, 635);
            panel1.TabIndex = 4;
            // 
            // TransForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1701, 659);
            Controls.Add(panel1);
            Name = "TransForm";
            Text = "Form4";
            Load += TransForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnNhaCungCap;
        private Button btnThongKeSanPham;
        private Button btnThongKeDoanhThu;
        private Button btnThoat;
        private Panel panel1;
    }
}