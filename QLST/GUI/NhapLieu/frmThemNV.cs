using QLST.ExtendModel;
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
    public partial class frmThemNV : Form
    {
        public frmThemNV()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text;
            string gioiTinh = cbGioiTinh.SelectedItem.ToString();
            DateTime ngaySinh = DateTime.Parse(dtpNgaySinh.Text);
            string sdt = txtSDT.Text;
            float luong = float.Parse(txtLuong.Text);
            if(kiemTraDuLieu(ten, gioiTinh, ngaySinh, sdt, luong))
            {
                string query = "exec themnv @ten , @gioitinh , @ngaysinh , @luong , @sdt";
                int ketqua = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, gioiTinh, ngaySinh, luong, sdt});
                if (ketqua > 0)
                {
                    MessageBox.Show("thêm thành công");
                    txtHoTen.Text = "";
                    cbGioiTinh.Text = "Lựa chọn giới tính";
                    txtSDT.Text = "";
                    txtLuong.Text = "";
                }
                else
                {
                    MessageBox.Show("thêm thất bại");
                }
            }
        }

        private bool kiemTraDuLieu(string ten, string gioiTinh, DateTime ngaySinh, string sdt, float luong)
        {
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
