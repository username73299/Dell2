namespace WinFormsApp14
{
    partial class Form3
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
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMaNCC = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(289, 44);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(200, 39);
            txtTenNCC.TabIndex = 1;
            txtTenNCC.TextChanged += txtTenNCC_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(289, 126);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(200, 39);
            txtDiaChi.TabIndex = 2;
            txtDiaChi.TextChanged += textBox3_TextChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(738, 48);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(200, 39);
            txtSDT.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(738, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 39);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.GridColor = SystemColors.ButtonShadow;
            dataGridView1.Location = new Point(12, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1677, 375);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã NCC ";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên NCC";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 343;
            // 
            // Column3
            // 
            Column3.HeaderText = "Địa Chỉ";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 450;
            // 
            // Column4
            // 
            Column4.HeaderText = "SĐT";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 450;
            // 
            // btnThemNCC
            // 
            btnThemNCC.Location = new Point(464, 197);
            btnThemNCC.Name = "btnThemNCC";
            btnThemNCC.Size = new Size(150, 46);
            btnThemNCC.TabIndex = 7;
            btnThemNCC.Text = "ThêmNCC";
            btnThemNCC.UseVisualStyleBackColor = true;
            btnThemNCC.Click += btnThemNCC_Click;
            // 
            // btnXoaNCC
            // 
            btnXoaNCC.Location = new Point(1480, 537);
            btnXoaNCC.Name = "btnXoaNCC";
            btnXoaNCC.Size = new Size(150, 46);
            btnXoaNCC.TabIndex = 10;
            btnXoaNCC.Text = "XoáNCC";
            btnXoaNCC.UseVisualStyleBackColor = true;
            btnXoaNCC.Click += btnXoaNCC_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1480, 448);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 46);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1698, 389);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnThemNCC);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTenNCC);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(txtEmail);
            panel2.Location = new Point(0, 386);
            panel2.Name = "panel2";
            panel2.Size = new Size(1047, 272);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Location = new Point(1044, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(654, 272);
            panel3.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(603, 129);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(603, 51);
            label4.Name = "label4";
            label4.Size = new Size(56, 32);
            label4.TabIndex = 8;
            label4.Text = "SDT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 126);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 7;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 47);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 6;
            label2.Text = "Tên NCC";
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(1232, 484);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(200, 39);
            txtMaNCC.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1106, 487);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 15;
            label1.Text = "Mã NCC";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1701, 659);
            Controls.Add(label1);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoaNCC);
            Controls.Add(txtMaNCC);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form3";
            Text = "NCC";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Panel panel3;
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtMaNCC;
    }
}