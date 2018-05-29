namespace QLST.GUI.Sua
{
    partial class frmSuaNV
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbNgaySinh = new System.Windows.Forms.CheckBox();
            this.dtpNgaySinhMoi = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTinhMoi = new System.Windows.Forms.ComboBox();
            this.txtLuongMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDTMoi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenMoi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLuongCu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDTCu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNgaySinhCu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbNgaySinh);
            this.groupBox2.Controls.Add(this.dtpNgaySinhMoi);
            this.groupBox2.Controls.Add(this.cbGioiTinhMoi);
            this.groupBox2.Controls.Add(this.txtLuongMoi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSDTMoi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTenMoi);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(434, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 326);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mới";
            // 
            // ckbNgaySinh
            // 
            this.ckbNgaySinh.AutoSize = true;
            this.ckbNgaySinh.Location = new System.Drawing.Point(335, 163);
            this.ckbNgaySinh.Name = "ckbNgaySinh";
            this.ckbNgaySinh.Size = new System.Drawing.Size(18, 17);
            this.ckbNgaySinh.TabIndex = 16;
            this.ckbNgaySinh.UseVisualStyleBackColor = true;
            this.ckbNgaySinh.CheckedChanged += new System.EventHandler(this.ckbNgaySinh_CheckedChanged);
            // 
            // dtpNgaySinhMoi
            // 
            this.dtpNgaySinhMoi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinhMoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhMoi.Location = new System.Drawing.Point(101, 162);
            this.dtpNgaySinhMoi.Name = "dtpNgaySinhMoi";
            this.dtpNgaySinhMoi.Size = new System.Drawing.Size(227, 22);
            this.dtpNgaySinhMoi.TabIndex = 15;
            this.dtpNgaySinhMoi.Value = new System.DateTime(2018, 3, 30, 0, 0, 0, 0);
            // 
            // cbGioiTinhMoi
            // 
            this.cbGioiTinhMoi.FormattingEnabled = true;
            this.cbGioiTinhMoi.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinhMoi.Location = new System.Drawing.Point(101, 93);
            this.cbGioiTinhMoi.Name = "cbGioiTinhMoi";
            this.cbGioiTinhMoi.Size = new System.Drawing.Size(227, 24);
            this.cbGioiTinhMoi.TabIndex = 14;
            // 
            // txtLuongMoi
            // 
            this.txtLuongMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongMoi.Location = new System.Drawing.Point(101, 273);
            this.txtLuongMoi.Name = "txtLuongMoi";
            this.txtLuongMoi.Size = new System.Drawing.Size(227, 27);
            this.txtLuongMoi.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lương:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày Sinh:";
            // 
            // txtSDTMoi
            // 
            this.txtSDTMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTMoi.Location = new System.Drawing.Point(101, 216);
            this.txtSDTMoi.Name = "txtSDTMoi";
            this.txtSDTMoi.Size = new System.Drawing.Size(227, 27);
            this.txtSDTMoi.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(7, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Điện Thoại:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(7, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 23);
            this.label13.TabIndex = 2;
            this.label13.Text = "Giới Tính:";
            // 
            // txtTenMoi
            // 
            this.txtTenMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMoi.Location = new System.Drawing.Point(101, 33);
            this.txtTenMoi.Name = "txtTenMoi";
            this.txtTenMoi.Size = new System.Drawing.Size(227, 27);
            this.txtTenMoi.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(7, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên:";
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Location = new System.Drawing.Point(473, 405);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(111, 51);
            this.btnDong.TabIndex = 20;
            this.btnDong.Text = "Hủy";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(231, 405);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(111, 51);
            this.btnXacNhan.TabIndex = 21;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLuongCu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSDTCu);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNgaySinhCu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenCu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 326);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiện Tại";
            // 
            // txtLuongCu
            // 
            this.txtLuongCu.Enabled = false;
            this.txtLuongCu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongCu.Location = new System.Drawing.Point(107, 273);
            this.txtLuongCu.Name = "txtLuongCu";
            this.txtLuongCu.Size = new System.Drawing.Size(221, 27);
            this.txtLuongCu.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lương:";
            // 
            // txtSDTCu
            // 
            this.txtSDTCu.Enabled = false;
            this.txtSDTCu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTCu.Location = new System.Drawing.Point(107, 216);
            this.txtSDTCu.Name = "txtSDTCu";
            this.txtSDTCu.Size = new System.Drawing.Size(221, 27);
            this.txtSDTCu.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(7, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Điện Thoại";
            // 
            // txtNgaySinhCu
            // 
            this.txtNgaySinhCu.Enabled = false;
            this.txtNgaySinhCu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinhCu.Location = new System.Drawing.Point(107, 157);
            this.txtNgaySinhCu.Name = "txtNgaySinhCu";
            this.txtNgaySinhCu.Size = new System.Drawing.Size(221, 27);
            this.txtNgaySinhCu.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày Sinh:";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Enabled = false;
            this.txtGioiTinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(107, 94);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(221, 27);
            this.txtGioiTinh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giới Tính:";
            // 
            // txtTenCu
            // 
            this.txtTenCu.Enabled = false;
            this.txtTenCu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCu.Location = new System.Drawing.Point(107, 33);
            this.txtTenCu.Name = "txtTenCu";
            this.txtTenCu.Size = new System.Drawing.Size(221, 27);
            this.txtTenCu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // frmSuaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSuaNV";
            this.Text = "frmSuaNV";
            this.Load += new System.EventHandler(this.frmSuaNV_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhMoi;
        private System.Windows.Forms.ComboBox cbGioiTinhMoi;
        private System.Windows.Forms.TextBox txtLuongMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDTMoi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenMoi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLuongCu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDTCu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNgaySinhCu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenCu;
        private System.Windows.Forms.Label label1;
    }
}