namespace QLST.GUI
{
    partial class frmChinh
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
            this.tpNhanVien = new System.Windows.Forms.TabPage();
            this.tpKhachHang = new System.Windows.Forms.TabPage();
            this.tpHangHoa = new System.Windows.Forms.TabPage();
            this.tpBanHang = new System.Windows.Forms.TabPage();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tc1 = new System.Windows.Forms.TabControl();
            this.tpHome.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tc1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpNhanVien
            // 
            this.tpNhanVien.Location = new System.Drawing.Point(4, 25);
            this.tpNhanVien.Name = "tpNhanVien";
            this.tpNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhanVien.Size = new System.Drawing.Size(1215, 650);
            this.tpNhanVien.TabIndex = 5;
            this.tpNhanVien.Text = "Nhân Viên";
            this.tpNhanVien.UseVisualStyleBackColor = true;
            // 
            // tpKhachHang
            // 
            this.tpKhachHang.Location = new System.Drawing.Point(4, 25);
            this.tpKhachHang.Name = "tpKhachHang";
            this.tpKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tpKhachHang.Size = new System.Drawing.Size(1215, 650);
            this.tpKhachHang.TabIndex = 4;
            this.tpKhachHang.Text = "Khách Hàng";
            this.tpKhachHang.UseVisualStyleBackColor = true;
            // 
            // tpHangHoa
            // 
            this.tpHangHoa.Location = new System.Drawing.Point(4, 25);
            this.tpHangHoa.Name = "tpHangHoa";
            this.tpHangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.tpHangHoa.Size = new System.Drawing.Size(1215, 650);
            this.tpHangHoa.TabIndex = 2;
            this.tpHangHoa.Text = "Hàng Hóa";
            this.tpHangHoa.UseVisualStyleBackColor = true;
            // 
            // tpBanHang
            // 
            this.tpBanHang.Location = new System.Drawing.Point(4, 25);
            this.tpBanHang.Name = "tpBanHang";
            this.tpBanHang.Padding = new System.Windows.Forms.Padding(3);
            this.tpBanHang.Size = new System.Drawing.Size(1215, 650);
            this.tpBanHang.TabIndex = 1;
            this.tpBanHang.Text = "Bán Hàng";
            this.tpBanHang.UseVisualStyleBackColor = true;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.panel2);
            this.tpHome.Controls.Add(this.panel1);
            this.tpHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tpHome.Location = new System.Drawing.Point(4, 25);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(1215, 650);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 120);
            this.panel1.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(0, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(1209, 120);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Chào Mừng Đến Với Ứng Dụng Quản Lý Cửa Hàng Bán Bánh";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 503);
            this.panel2.TabIndex = 1;
            // 
            // tc1
            // 
            this.tc1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tc1.Controls.Add(this.tpHome);
            this.tc1.Controls.Add(this.tpBanHang);
            this.tc1.Controls.Add(this.tpHangHoa);
            this.tc1.Controls.Add(this.tpKhachHang);
            this.tc1.Controls.Add(this.tpNhanVien);
            this.tc1.Location = new System.Drawing.Point(0, 65);
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            this.tc1.Size = new System.Drawing.Size(1223, 679);
            this.tc1.TabIndex = 1;
            this.tc1.SelectedIndexChanged += new System.EventHandler(this.tc1_SelectedIndexChanged);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 739);
            this.Controls.Add(this.tc1);
            this.Name = "frmChinh";
            this.Text = "frmChinh";
            this.tpHome.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tc1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpNhanVien;
        private System.Windows.Forms.TabPage tpKhachHang;
        private System.Windows.Forms.TabPage tpHangHoa;
        private System.Windows.Forms.TabPage tpBanHang;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TabControl tc1;
    }
}