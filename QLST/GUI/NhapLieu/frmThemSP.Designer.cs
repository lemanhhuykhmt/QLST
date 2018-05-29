namespace QLST.GUI.NhapLieu
{
    partial class frmThemSP
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dtpNSX = new System.Windows.Forms.DateTimePicker();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Location = new System.Drawing.Point(340, 520);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(144, 51);
            this.btnDong.TabIndex = 32;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(104, 520);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 51);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "OK";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dtpNSX
            // 
            this.dtpNSX.CustomFormat = "dd/MM/yyyy";
            this.dtpNSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNSX.Location = new System.Drawing.Point(276, 374);
            this.dtpNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNSX.Name = "dtpNSX";
            this.dtpNSX.Size = new System.Drawing.Size(277, 30);
            this.dtpNSX.TabIndex = 46;
            this.dtpNSX.Value = new System.DateTime(2018, 3, 30, 0, 0, 0, 0);
            // 
            // dtpHSD
            // 
            this.dtpHSD.CustomFormat = "dd/MM/yyyy";
            this.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHSD.Location = new System.Drawing.Point(276, 312);
            this.dtpHSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(277, 30);
            this.dtpHSD.TabIndex = 45;
            this.dtpHSD.Value = new System.DateTime(2018, 3, 30, 0, 0, 0, 0);
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(276, 104);
            this.cbLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(277, 30);
            this.cbLoai.TabIndex = 44;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(276, 448);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(277, 27);
            this.txtSoLuong.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(113, 446);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 42;
            this.label4.Text = "Số Lượng:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(113, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = "NSX:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(113, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 31);
            this.label6.TabIndex = 40;
            this.label6.Text = "HSD:";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(276, 245);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(277, 27);
            this.txtDonVi.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(113, 243);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 31);
            this.label11.TabIndex = 38;
            this.label11.Text = "Đơn Vị:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(276, 173);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(277, 27);
            this.txtDonGia.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(113, 172);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 31);
            this.label12.TabIndex = 36;
            this.label12.Text = "Đơn Giá:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(113, 104);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 31);
            this.label13.TabIndex = 35;
            this.label13.Text = "Loại :";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(276, 41);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(277, 27);
            this.txtTen.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(113, 40);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 31);
            this.label14.TabIndex = 33;
            this.label14.Text = "Tên:";
            // 
            // frmThemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 593);
            this.Controls.Add(this.dtpNSX);
            this.Controls.Add(this.dtpHSD);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThemSP";
            this.Text = "frmThemSP";
            this.Load += new System.EventHandler(this.frmThemSP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DateTimePicker dtpNSX;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label14;
    }
}