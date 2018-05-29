namespace QLST.GUI.UC
{
    partial class ucNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnNhap);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 58);
            this.panel1.TabIndex = 8;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(43, 23);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(198, 22);
            this.txtTimKiem.TabIndex = 5;
            this.txtTimKiem.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtTimKiem_PreviewKeyDown);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(813, 23);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(719, 22);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Thêm khách hàng";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(247, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 23);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 584);
            this.panel2.TabIndex = 11;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colMa,
            this.colTen,
            this.colNgaySinh,
            this.colSDT,
            this.colGioiTinh,
            this.colLuong,
            this.colSua,
            this.colXoa});
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(967, 584);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // colCheck
            // 
            this.colCheck.FillWeight = 20F;
            this.colCheck.HeaderText = "";
            this.colCheck.Name = "colCheck";
            // 
            // colMa
            // 
            this.colMa.DataPropertyName = "colMa";
            this.colMa.FillWeight = 30F;
            this.colMa.HeaderText = "Mã";
            this.colMa.Name = "colMa";
            // 
            // colTen
            // 
            this.colTen.FillWeight = 150F;
            this.colTen.HeaderText = "Tên Giáo Viên";
            this.colTen.Name = "colTen";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FillWeight = 70F;
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "SĐT";
            this.colSDT.Name = "colSDT";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.FillWeight = 70F;
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colLuong
            // 
            this.colLuong.FillWeight = 90F;
            this.colLuong.HeaderText = "Lương";
            this.colLuong.Name = "colLuong";
            // 
            // colSua
            // 
            this.colSua.FillWeight = 15F;
            this.colSua.HeaderText = "";
            this.colSua.Name = "colSua";
            this.colSua.Text = "i";
            this.colSua.UseColumnTextForButtonValue = true;
            // 
            // colXoa
            // 
            this.colXoa.FillWeight = 15F;
            this.colXoa.HeaderText = "";
            this.colXoa.Name = "colXoa";
            this.colXoa.Text = "x";
            this.colXoa.UseColumnTextForButtonValue = true;
            // 
            // ucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucNhanVien";
            this.Size = new System.Drawing.Size(967, 648);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuong;
        private System.Windows.Forms.DataGridViewButtonColumn colSua;
        private System.Windows.Forms.DataGridViewButtonColumn colXoa;
    }
}
