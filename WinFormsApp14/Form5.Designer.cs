namespace WinFormsApp14
{
    partial class FormThongKe
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
            DonGia = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            SoLuongHong = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            LoadData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, DonGia, SoLuongBan, SoLuongHong, SoLuongTon });
            dataGridView1.Location = new Point(12, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1357, 635);
            dataGridView1.TabIndex = 0;
            // 
            // MaSP
            // 
            MaSP.HeaderText = "Mã sản phẩm";
            MaSP.MinimumWidth = 10;
            MaSP.Name = "MaSP";
            MaSP.Width = 220;
            // 
            // TenSP
            // 
            TenSP.HeaderText = "Tên sản phẩm";
            TenSP.MinimumWidth = 10;
            TenSP.Name = "TenSP";
            TenSP.Width = 220;
            // 
            // DonGia
            // 
            DonGia.HeaderText = "Đơn Giá";
            DonGia.MinimumWidth = 10;
            DonGia.Name = "DonGia";
            DonGia.Width = 200;
            // 
            // SoLuongBan
            // 
            SoLuongBan.HeaderText = "Số Lượng Bán";
            SoLuongBan.MinimumWidth = 10;
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.Width = 220;
            // 
            // SoLuongHong
            // 
            SoLuongHong.HeaderText = "Số lượng hỏng";
            SoLuongHong.MinimumWidth = 10;
            SoLuongHong.Name = "SoLuongHong";
            SoLuongHong.Width = 220;
            // 
            // SoLuongTon
            // 
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 10;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.Width = 200;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(73, 210);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1375, 286);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 361);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 87);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 3;
            label1.Text = "Điền mã/ tên sp để tìm";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(LoadData);
            panel2.Location = new Point(1375, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 268);
            panel2.TabIndex = 4;
            // 
            // LoadData
            // 
            LoadData.Location = new Point(73, 114);
            LoadData.Name = "LoadData";
            LoadData.Size = new Size(150, 46);
            LoadData.TabIndex = 0;
            LoadData.Text = "Load";
            LoadData.UseVisualStyleBackColor = true;
            LoadData.Click += LoadData_Click;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1701, 659);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "FormThongKe";
            Text = "Form5";
            Load += FormThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn SoLuongHong;
        private DataGridViewTextBoxColumn SoLuongTon;
        private Label label1;
        private Panel panel2;
        private Button LoadData;
    }
}