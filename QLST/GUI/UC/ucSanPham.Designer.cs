namespace QLST.GUI.UC
{
    partial class ucSanPham
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
            this.tvLoaiSP = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemLoai = new System.Windows.Forms.Button();
            this.btnXoaLoai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnXoaLoai);
            this.panel1.Controls.Add(this.btnThemLoai);
            this.panel1.Controls.Add(this.tvLoaiSP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 677);
            this.panel1.TabIndex = 0;
            // 
            // tvLoaiSP
            // 
            this.tvLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvLoaiSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tvLoaiSP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvLoaiSP.Location = new System.Drawing.Point(0, 78);
            this.tvLoaiSP.Name = "tvLoaiSP";
            this.tvLoaiSP.Size = new System.Drawing.Size(313, 599);
            this.tvLoaiSP.TabIndex = 0;
            this.tvLoaiSP.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvLoaiSP_NodeMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(219, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 677);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDanhSach);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(902, 568);
            this.panel4.TabIndex = 13;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colMa,
            this.colTen,
            this.colLoai,
            this.colDonGia,
            this.colDVD,
            this.colHSD,
            this.colNSX,
            this.colSoLuong,
            this.colSua,
            this.colXoa});
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(902, 568);
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
            this.colMa.FillWeight = 25F;
            this.colMa.HeaderText = "Mã";
            this.colMa.Name = "colMa";
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tên  Sản Phẩm";
            this.colTen.Name = "colTen";
            // 
            // colLoai
            // 
            this.colLoai.FillWeight = 60F;
            this.colLoai.HeaderText = "Loại";
            this.colLoai.Name = "colLoai";
            // 
            // colDonGia
            // 
            this.colDonGia.FillWeight = 50F;
            this.colDonGia.HeaderText = "Giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // colDVD
            // 
            this.colDVD.FillWeight = 50F;
            this.colDVD.HeaderText = "Đơn Vị";
            this.colDVD.Name = "colDVD";
            // 
            // colHSD
            // 
            this.colHSD.FillWeight = 60F;
            this.colHSD.HeaderText = "HSD";
            this.colHSD.Name = "colHSD";
            // 
            // colNSX
            // 
            this.colNSX.FillWeight = 60F;
            this.colNSX.HeaderText = "NSX";
            this.colNSX.Name = "colNSX";
            // 
            // colSoLuong
            // 
            this.colSoLuong.FillWeight = 35F;
            this.colSoLuong.HeaderText = "Còn";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colSua
            // 
            this.colSua.FillWeight = 20F;
            this.colSua.HeaderText = "";
            this.colSua.Name = "colSua";
            this.colSua.Text = "i";
            this.colSua.UseColumnTextForButtonValue = true;
            // 
            // colXoa
            // 
            this.colXoa.FillWeight = 20F;
            this.colXoa.HeaderText = "";
            this.colXoa.Name = "colXoa";
            this.colXoa.Text = "x";
            this.colXoa.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTimKiem);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnNhap);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(902, 72);
            this.panel3.TabIndex = 12;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(16, 28);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(198, 22);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtTimKiem_PreviewKeyDown);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(719, 27);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(625, 26);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 8;
            this.btnNhap.Text = "Thêm khách hàng";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(220, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 23);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Location = new System.Drawing.Point(61, 3);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(30, 32);
            this.btnThemLoai.TabIndex = 1;
            this.btnThemLoai.Text = "+";
            this.btnThemLoai.UseVisualStyleBackColor = true;
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // btnXoaLoai
            // 
            this.btnXoaLoai.Location = new System.Drawing.Point(124, 3);
            this.btnXoaLoai.Name = "btnXoaLoai";
            this.btnXoaLoai.Size = new System.Drawing.Size(30, 32);
            this.btnXoaLoai.TabIndex = 2;
            this.btnXoaLoai.Text = "-";
            this.btnXoaLoai.UseVisualStyleBackColor = true;
            this.btnXoaLoai.Click += new System.EventHandler(this.btnXoaLoai_Click);
            // 
            // ucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucSanPham";
            this.Size = new System.Drawing.Size(1121, 677);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvLoaiSP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewButtonColumn colSua;
        private System.Windows.Forms.DataGridViewButtonColumn colXoa;
        private System.Windows.Forms.Button btnThemLoai;
        private System.Windows.Forms.Button btnXoaLoai;
    }
}
