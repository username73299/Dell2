namespace WinFormsApp14
{
    partial class NhaCungCapForm
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
            txtTenNCC = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnThemNCC = new Button();
            btnXoaNCC = new Button();
            btnTimKiem = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            Load = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMaNCC = new TextBox();
            label1 = new Label();
            btnSua = new Button();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(192, 40);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(230, 35);
            txtTenNCC.TabIndex = 1;
            txtTenNCC.TextChanged += txtTenNCC_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(192, 110);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(230, 35);
            txtDiaChi.TabIndex = 2;
            txtDiaChi.TextChanged += textBox3_TextChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(609, 40);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(230, 35);
            txtSDT.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(609, 107);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 35);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.GridColor = SystemColors.Desktop;
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1700, 416);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã NCC ";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên NCC";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 343;
            // 
            // Column3
            // 
            Column3.HeaderText = "Địa Chỉ";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 450;
            // 
            // Column4
            // 
            Column4.HeaderText = "SĐT";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column5.HeaderText = "Email";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 450;
            // 
            // btnThemNCC
            // 
            btnThemNCC.BackColor = SystemColors.Info;
            btnThemNCC.Location = new Point(518, 179);
            btnThemNCC.Name = "btnThemNCC";
            btnThemNCC.Size = new Size(173, 42);
            btnThemNCC.TabIndex = 7;
            btnThemNCC.Text = "ThêmNCC";
            btnThemNCC.UseVisualStyleBackColor = false;
            btnThemNCC.Click += btnThemNCC_Click;
            // 
            // btnXoaNCC
            // 
            btnXoaNCC.BackColor = SystemColors.Info;
            btnXoaNCC.Location = new Point(512, 164);
            btnXoaNCC.Name = "btnXoaNCC";
            btnXoaNCC.Size = new Size(173, 42);
            btnXoaNCC.TabIndex = 10;
            btnXoaNCC.Text = "XoáNCC";
            btnXoaNCC.UseVisualStyleBackColor = false;
            btnXoaNCC.Click += btnXoaNCC_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.Info;
            btnTimKiem.Location = new Point(55, 164);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(173, 42);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1700, 412);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(Load);
            panel2.Controls.Add(btnThemNCC);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTenNCC);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(txtEmail);
            panel2.Location = new Point(0, 416);
            panel2.Name = "panel2";
            panel2.Size = new Size(951, 244);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // Load
            // 
            Load.BackColor = SystemColors.Info;
            Load.Location = new Point(272, 179);
            Load.Name = "Load";
            Load.Size = new Size(173, 42);
            Load.TabIndex = 16;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = false;
            Load.Click += Load_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(518, 110);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(518, 40);
            label4.Name = "label4";
            label4.Size = new Size(63, 31);
            label4.TabIndex = 8;
            label4.Text = "SDT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(51, 114);
            label3.Name = "label3";
            label3.Size = new Size(94, 31);
            label3.TabIndex = 7;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(51, 40);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 6;
            label2.Text = "Tên NCC";
            label2.Click += label2_Click;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(322, 76);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(230, 35);
            txtMaNCC.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(145, 76);
            label1.Name = "label1";
            label1.Size = new Size(107, 31);
            label1.TabIndex = 15;
            label1.Text = "Mã NCC";
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.Info;
            btnSua.Location = new Point(284, 164);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(173, 42);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(btnTimKiem);
            panel4.Controls.Add(btnSua);
            panel4.Controls.Add(txtMaNCC);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(btnXoaNCC);
            panel4.Location = new Point(948, 416);
            panel4.Name = "panel4";
            panel4.Size = new Size(752, 244);
            panel4.TabIndex = 17;
            // 
            // NhaCungCapForm
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1701, 659);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Name = "NhaCungCapForm";
            Text = "NCC";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTenNCC;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private DataGridView dataGridView1;
        private Button btnThemNCC;
        private Button btnLuu;
        private Button btnXoaNCC;
        private Button btnTimKiem;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtMaNCC;
        private Button Load;
        private Button btnSua;
        private Panel panel4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}