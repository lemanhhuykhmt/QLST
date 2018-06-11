using QLST.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Controls
{
    class LoaiSPControl
    {

       
        public static int themDuLieu(string ten, int mamh)//
        {//
            string query = "exec themlsp @ten , @mamh";//
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten , mamh});//
        }
        public static int xoaDuLieu(int maloai)//
        {
            string query = "exec xoalsp @ma";//
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maloai});//
        }
        public static DataTable layDSLoai(int idmh)//
        {
            string query = "select MaLoaiSP, TenLoaiSP from LoaiSP where MaMH = @mamh";//
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idmh});//
        }//
        public static DataTable layDSLoai()//
        {
            string query = "select MaLoaiSP, TenLoaiSP from LoaiSP";//
            return DataProvider.Instance.ExecuteQuery(query);//

        }//
         /*
  * 
  * using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLST.Controls;
using QLST.GUI.NhapLieu;

namespace QLST.GUI.UC
{
public partial class ucHoaDonBan : UserControl
{
 public ucHoaDonBan()
 {
     InitializeComponent();
     loadDuLieu();

 }
 private void loadDuLieu()
 {
     dgvDanhSach.Rows.Clear();
     DataTable dt = HoaDonBanControl.layDanhSach();
     for(int i = 0; i < dt.Rows.Count; ++i)
     {
         int idTrangThai = Convert.ToInt32(dt.Rows[i]["TrangThai"].ToString());
         string tenTrangThai = "";
         if(idTrangThai == 1)
         {
             tenTrangThai = "Đã thanh toán";
         }
         else if(idTrangThai == 2)
         {
             tenTrangThai = "Đang giao";
         }
         else if (idTrangThai == 3)
         {
             tenTrangThai = "Chưa thanh toán";
         }
         else if (idTrangThai == 4)
         {
             tenTrangThai = "Hoàn trả";
         }
         dgvDanhSach.Rows.Add(new object[] {false, dt.Rows[i][0], dt.Rows[i]["TenKH"], dt.Rows[i]["TenNV"], dt.Rows[i]["NgayLap"], tenTrangThai});
     }
 }

 private void btnNhap_Click(object sender, EventArgs e)
 {
     frmThemHDB f = new frmThemHDB();
     f.ShowDialog();
     loadDuLieu();
 }

 private void btnTimKiem_Click(object sender, EventArgs e)
 {
     // get text
     string value = txtTimKiem.Text;
     if (value.Length == 0)
     {
         loadDuLieu();
         return;
     }
     timKiem(value);
 }
 private void timKiem(string value)
 {
     dgvDanhSach.Rows.Clear();
     DataTable dt = HoaDonBanControl.timKiem(value);// tìm kiếm
     for (int i = 0; i < dt.Rows.Count; ++i)
     {
         int idTrangThai = Convert.ToInt32(dt.Rows[i][4].ToString());
         string tenTrangThai = "";
         if (idTrangThai == 1)
         {
             tenTrangThai = "Đã thanh toán";
         }
         else if (idTrangThai == 2)
         {
             tenTrangThai = "Đang giao";
         }
         else if (idTrangThai == 3)
         {
             tenTrangThai = "Chưa thanh toán";
         }
         else if (idTrangThai == 4)
         {
             tenTrangThai = "Hoàn trả";
         }
         dgvDanhSach.Rows.Add(new object[] { false, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], tenTrangThai });
     }
 }
 private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
 {
     if (dgvDanhSach.Rows.Count == e.RowIndex + 1) return;

     int id = Convert.ToInt32(dgvDanhSach.Rows[e.RowIndex].Cells[1].Value.ToString());
     if (e.ColumnIndex == dgvDanhSach.Columns["colSua"].Index)
     {
         frmThemHDB f = new frmThemHDB(id);
         f.ShowDialog();
         loadDuLieu();
     }
     else if(e.ColumnIndex == dgvDanhSach.Columns["colXoa"].Index)
     {
         HoaDonBanControl.xoaThongTin(id);
         loadDuLieu();
     }

 }

 private void btnXoa_Click(object sender, EventArgs e)
 {
     int ketQua = 0;
     for (int i = 0; i < dgvDanhSach.Rows.Count - 1; ++i)
     {
         if (Convert.ToBoolean(dgvDanhSach.Rows[i].Cells["colCheck"].Value.ToString()))
         {
             ketQua += HoaDonBanControl.xoaThongTin(Convert.ToInt32(dgvDanhSach.Rows[i].Cells["colMa"].Value.ToString()));
         }
     }
     if (ketQua > 0)
     {
         MessageBox.Show("xóa thành công " + ketQua);
         loadDuLieu();
     }
     else
     {
         MessageBox.Show("xóa thất bại");
     }
 }

 private void txtTimKiem_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
 {
     if (e.KeyValue == 13)
     {
         // get text
         string value = txtTimKiem.Text;
         if (value.Length == 0)
         {
             loadDuLieu();
             return;
         }
         timKiem(value);
     }
     else if (e.KeyValue == 27)
     {
         txtTimKiem.Text = "";
         loadDuLieu();
     }
 }
}
}

  */
    }
}
