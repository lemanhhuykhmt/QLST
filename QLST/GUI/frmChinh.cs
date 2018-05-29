using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLST.ExtendModel;
using QLST.GUI.UC;

namespace QLST.GUI
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc1.SelectedTab == tpBanHang)
            {
                ucHoaDonBan frm = new ucHoaDonBan();
                frm.Size = new Size(tc1.Controls[tc1.SelectedIndex].Width, tc1.Controls[tc1.SelectedIndex].Height);
                frm.Visible = true;
                tpBanHang.Controls.Add(frm);
            }
            if (tc1.SelectedTab == tpHangHoa)
            {
                ucSanPham frm = new ucSanPham();
                frm.Size = new Size(tc1.Controls[tc1.SelectedIndex].Width, tc1.Controls[tc1.SelectedIndex].Height);
                frm.Visible = true;
                tpHangHoa.Controls.Add(frm);
            }
            else if (tc1.SelectedTab == tpKhachHang)
            {
                ucKhachHang frm = new ucKhachHang();
                frm.Size = new Size(tc1.Controls[tc1.SelectedIndex].Width, tc1.Controls[tc1.SelectedIndex].Height);
                frm.Visible = true;
                tpKhachHang.Controls.Add(frm);
            }
            else if (tc1.SelectedTab == tpNhanVien)
            {
                ucNhanVien frm = new ucNhanVien();
                frm.Size = new Size(tc1.Controls[tc1.SelectedIndex].Width, tc1.Controls[tc1.SelectedIndex].Height);
                frm.Visible = true;
                tpNhanVien.Controls.Add(frm);
            }

        }
    }
}
