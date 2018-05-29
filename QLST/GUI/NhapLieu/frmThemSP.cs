using QLST.Controls;
using QLST.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLST.GUI.NhapLieu
{
    public partial class frmThemSP : Form
    {
        public frmThemSP()
        {
            InitializeComponent();
        }

        private void frmThemSP_Load(object sender, EventArgs e)
        {
            List<LoaiSP> list = new List<LoaiSP>();
            DataTable dt = LoaiSPControl.layDSLoai();
            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                list.Add(new LoaiSP(Convert.ToInt32(dt.Rows[i]["MaLoaiSP"].ToString()), dt.Rows[i]["TenLoaiSP"].ToString()));
            }
            cbLoai.DataSource = list;
            cbLoai.DisplayMember = "TenLoai";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tensp = txtTen.Text;
            LoaiSP loai = cbLoai.SelectedValue as LoaiSP;
            double dongia = double.Parse(txtDonGia.Text);
            string donvi = txtDonVi.Text;
            string hsd = dtpHSD.Text;
            string nsx = dtpNSX.Text;
            int soluong = Convert.ToInt32(txtSoLuong.Text);

            if(true)
            {
                int ketqua = SanPhamControl.themDuLieu(tensp, loai.IdLoai, dongia, donvi, hsd, nsx, soluong);
                if(ketqua > 0)
                {
                    MessageBox.Show("them thanh cong");
                    this.Close();
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
