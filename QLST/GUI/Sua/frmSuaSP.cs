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
    public partial class frmSuaSP : Form
    {
        private int idSP;
        public frmSuaSP()
        {
            InitializeComponent();
        }
        public frmSuaSP(int id)
        {// MaSP, TenSP, TenLoaiSP, DonGia, DonViDo, HSD, NSX, SoLuong
            InitializeComponent();
            idSP = id;
            DataTable dt = SanPhamControl.layThongTin(id);
            txtTenCu.Text = dt.Rows[0][1].ToString();
            txtLoaiCu.Text = dt.Rows[0][2].ToString();
            txtDonGiaCu.Text = dt.Rows[0][3].ToString();
            txtDonViCu.Text = dt.Rows[0][4].ToString();
            txtHSDCu.Text = String.Format("{0:dd/MM/yyyy}", dt.Rows[0][5]); //dt.Rows[0][5].ToString();
            txtNSXCu.Text = String.Format("{0:dd/MM/yyyy}", dt.Rows[0][6]);
            txtSoLuongCu.Text = dt.Rows[0][7].ToString();
            loadLoaiSP();
        }

        private void loadLoaiSP()
        {
            DataTable dt = SanPhamControl.layDanhSachLoaiSP();
            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                cbLoai.Items.Add(dt.Rows[i][1]);
            }

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtTenMoi.Text;
            int loai = SanPhamControl.layIDLoaiSP(cbLoai.Text);
            float dongia = float.Parse(txtDonGiaMoi.Text);
            string donvi = txtDonViMoi.Text;
            DateTime hsd = Convert.ToDateTime(dtpHSDMoi.Text);
            DateTime nsx = Convert.ToDateTime(dtpNSXMoi.Text);
            int soluong = Convert.ToInt32(txtSoLuongMoi.Text);
            if (kiemTra(ten, loai, dongia, donvi, hsd, nsx, soluong))
            {
                int ketQua = 0;//int id, string ten, int loai, float dongia, string donvido, DateTime hsd, DateTime nsx, int soluong
                ketQua = SanPhamControl.suaThongTin(idSP, ten, loai, dongia, donvi, hsd, nsx, soluong);
                if (ketQua > 0)
                {
                    MessageBox.Show("thay đổi thành công");
                    this.Close();
                }
            }
        }
        private bool kiemTra(string ten, int loai, float dongia, string donvi, DateTime hsd, DateTime nsx, int soluong)
        {
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
