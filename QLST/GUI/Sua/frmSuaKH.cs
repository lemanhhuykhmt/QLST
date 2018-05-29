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
    public partial class frmSuaKH : Form
    {
        private int idKH;
        public frmSuaKH()
        {
            InitializeComponent();
        }
        public frmSuaKH(int id)
        {
            InitializeComponent();
            idKH = id;
            DataTable dt = KhachHangControl.layThongTin(id);
            txtTenCu.Text = dt.Rows[0][1].ToString();
            txtDiaChiCu.Text = dt.Rows[0][2].ToString();
            txtSDTCu.Text = dt.Rows[0][3].ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtTenMoi.Text;
            string diachi = txtDiaChiMoi.Text;
            string sdt = txtSDTMoi.Text;
            if(kiemTra(ten, diachi, sdt))
            {
                int ketQua = 0;
                ketQua = KhachHangControl.suaThongTin(idKH , ten, diachi, sdt);
                if (ketQua > 0)
                {
                    MessageBox.Show("thay đổi thành công");
                    this.Close();
                }
            }
        }
        private bool kiemTra(string ten, string diachi, string sdt)
        {
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
