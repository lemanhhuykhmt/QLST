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
    public partial class frmThemLoaiSP : Form
    {
        public frmThemLoaiSP()
        {
            InitializeComponent();
        }

        private void frmThemLoaiSP_Load(object sender, EventArgs e)
        {
            List<MatHang> list = new List<MatHang>();
            list.Add(new MatHang() { IdMH = 0, TenMH = "----None----"});
            DataTable dt = MatHangControl.layDSMH();
            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                list.Add(new MatHang (){ IdMH = Convert.ToInt32(dt.Rows[i]["MaMH"].ToString()), TenMH = dt.Rows[i]["TenMH"].ToString()});
            }
            cbMatHang.DataSource = list;
            cbMatHang.DisplayMember = "TenMH";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten = txtTenLoai.Text;
            MatHang mh = cbMatHang.SelectedValue as MatHang;
            if(mh.IdMH == 0) // thêm mặt hàng
            {
                int ketqua = MatHangControl.themDuLieu(ten);
                if(ketqua > 0)
                {
                    this.Close();
                }
            }
            else // thêm loại sản phẩm
            {
                int ketqua = LoaiSPControl.themDuLieu(ten, mh.IdMH);
                if (ketqua > 0)
                {
                    this.Close();
                }
            }
        }
    }
}
