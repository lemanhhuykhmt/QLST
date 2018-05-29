using QLST.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLST.GUI.Sua
{
    public partial class frmSuaNV : Form
    {
        private int id;
        public frmSuaNV()
        {
            InitializeComponent();
        }
        public frmSuaNV(int id)
        {
            InitializeComponent();
            this.id = id;
            DataTable dt = NhanVienControl.layThongTin(id);
            txtTenCu.Text = dt.Rows[0][1].ToString();
            txtGioiTinh.Text = dt.Rows[0][3].ToString();
            txtNgaySinhCu.Text = String.Format("{0:dd/MM/yyyy}", dt.Rows[0][4]);
            txtSDTCu.Text = dt.Rows[0][2].ToString();
            txtLuongCu.Text = dt.Rows[0][5].ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtTenMoi.Text;
            string gioitinh = cbGioiTinhMoi.Text;
            string ngaysinh = dtpNgaySinhMoi.Text;
            string sdt = txtSDTMoi.Text;
            double luong = 0;
            if (txtLuongMoi.Text.Length != 0)
            {
                luong = double.Parse(txtLuongMoi.Text);
            }
            if (ckbNgaySinh.Checked == false)
            {
                ngaysinh = "";
            }
            else
            {
                ngaysinh = String.Format("{0:yyyy/MM/dd}", ngaysinh);
            }
            if (kiemTra(ten, gioitinh, ngaysinh, sdt, luong))
            {
                int ketQua = 0;
                ketQua = NhanVienControl.suaThongTin(id, ten, gioitinh, ngaysinh, sdt, luong);
                if (ketQua > 0)
                {
                    MessageBox.Show("thay đổi thành công");
                    this.Close();
                }
            }
        }
        private bool kiemTra(string ten, string gioitinh, string ngaysinh, string sdt, double luong)
        {
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ckbNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaySinhMoi.Enabled = ckbNgaySinh.Checked;
        }

        private void frmSuaNV_Load(object sender, EventArgs e)
        {
            ckbNgaySinh.Checked = false;
            dtpNgaySinhMoi.Enabled = false;
        }
    }
}
