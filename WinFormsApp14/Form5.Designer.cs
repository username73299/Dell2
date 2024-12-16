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
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, DonGia, SoLuongBan, SoLuongTon });
            dataGridView1.Location = new Point(1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1276, 661);
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
            TenSP.Width = 350;
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
            // SoLuongTon
            // 
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 10;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.Width = 200;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 35);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(123, 210);
            button1.Name = "button1";
            button1.Size = new Size(173, 42);
            button1.TabIndex = 2;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveBorder;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1276, 272);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 389);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(79, 78);
            label1.Name = "label1";
            label1.Size = new Size(271, 31);
            label1.TabIndex = 3;
            label1.Text = "Điền mã/ tên sp để tìm";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(LoadData);
            panel2.Location = new Point(1276, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 275);
            panel2.TabIndex = 4;
            // 
            // LoadData
            // 
            LoadData.BackColor = SystemColors.Info;
            LoadData.Location = new Point(123, 102);
            LoadData.Name = "LoadData";
            LoadData.Size = new Size(173, 56);
            LoadData.TabIndex = 0;
            LoadData.Text = "Load";
            LoadData.UseVisualStyleBackColor = false;
            LoadData.Click += LoadData_Click;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1701, 659);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
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
        private Label label1;
        private Panel panel2;
        private Button LoadData;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn SoLuongTon;
    }
}