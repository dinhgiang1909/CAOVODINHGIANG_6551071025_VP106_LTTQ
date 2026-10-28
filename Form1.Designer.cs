namespace QuanLySanPham
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtGiaBan = new TextBox();
            txtTenSanPham = new TextBox();
            txtMaSanPham = new TextBox();
            lblGiaBan = new Label();
            lblTenSanPham = new Label();
            lblMaSanPham = new Label();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            dgvSanPham = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGiaBan);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(txtMaSanPham);
            groupBox1.Controls.Add(lblGiaBan);
            groupBox1.Controls.Add(lblTenSanPham);
            groupBox1.Controls.Add(lblMaSanPham);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 178);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(161, 128);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(125, 27);
            txtGiaBan.TabIndex = 5;
            txtGiaBan.KeyPress += txtGiaBan_KeyPress;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(161, 80);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(125, 27);
            txtTenSanPham.TabIndex = 4;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(161, 36);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(125, 27);
            txtMaSanPham.TabIndex = 3;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Location = new Point(30, 135);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(104, 20);
            lblGiaBan.TabIndex = 2;
            lblGiaBan.Text = "Giá Bán(VND):";
            // 
            // lblTenSanPham
            // 
            lblTenSanPham.AutoSize = true;
            lblTenSanPham.Location = new Point(30, 87);
            lblTenSanPham.Name = "lblTenSanPham";
            lblTenSanPham.Size = new Size(104, 20);
            lblTenSanPham.TabIndex = 1;
            lblTenSanPham.Text = "Tên Sản Phẩm:";
            // 
            // lblMaSanPham
            // 
            lblMaSanPham.AutoSize = true;
            lblMaSanPham.Location = new Point(30, 39);
            lblMaSanPham.Name = "lblMaSanPham";
            lblMaSanPham.Size = new Size(102, 20);
            lblMaSanPham.TabIndex = 0;
            lblMaSanPham.Text = "Mã Sản Phẩm:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(445, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao Tác";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(169, 51);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(57, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(249, 51);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(68, 29);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(89, 51);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(55, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 51);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(60, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvSanPham);
            groupBox3.Location = new Point(12, 206);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 242);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Sản Phẩm";
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(6, 26);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(764, 210);
            dgvSanPham.TabIndex = 0;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblGiaBan;
        private Label lblTenSanPham;
        private Label lblMaSanPham;
        private GroupBox groupBox2;
        private TextBox txtGiaBan;
        private TextBox txtTenSanPham;
        private TextBox txtMaSanPham;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox3;
        private DataGridView dgvSanPham;
    }
}
