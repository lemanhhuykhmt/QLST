using QLST.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Controls
{
    class SanPhamControl
    {
        public static int themDuLieu(string ten, int loai, double dongia, string donvido, string hsd, string nsx, int soluong)
        {
            string query = "exec themsp @tensp , @loaisp , @dongia , @donvido , @hsd , @nsx , @soluong";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, loai, dongia, donvido, hsd, nsx, soluong });
        }
        public static DataTable layDanhSach() // lấy danh sách sản phẩm
        {
            string query = "select sp.MaSP, sp.TenSP, loai.TenLoaiSP, sp.DonGia, " 
                + "sp.DonViDo, sp.HSD, sp.NSX, sp.SoLuong from SanPham as sp left " 
                + "join LoaiSP as loai on sp.MaLoaiSP = loai.MaLoaiSP";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTin(int id) // lấy thông tin khách hàng có id là ..
        {
            string query = "select MaSP, TenSP, TenLoaiSP, DonGia, DonViDo, HSD, NSX, SoLuong from SanPham, LoaiSP where MaSP = @masp and SanPham.MaLoaiSP = LoaiSP.MaLoaiSP";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        public static int suaThongTin(int id, string ten, int loai, float dongia, string donvido, DateTime hsd, DateTime nsx, int soluong) // sửa thông tin của khách hàng
        {
            string query = "exec suakh @id , @ten , @loai , @dongia , @donvi , @hsd , @nsx , @soluong";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, loai, dongia, donvido, hsd, nsx, soluong });
        }
        public static int xoaThongTin(int id)
        {
            string query = "exec xoasp @ma";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public static DataTable timKiem(object obj)
        {
            string str = "%" + obj.ToString() + "%";
            string query = "select * from (select MaSP, TenSP, TenLoaiSP, DonGia, DonViDo, HSD, NSX, SoLuong from SanPham as sp, LoaiSP as loai where ConDung = 1 and sp.MaLoaiSP = loai.MaLoaiSP) as a" + 
                " where a.MaSP like @ma or a.TenSP like @ten or a.TenLoaiSP like @loai or a.DonViDo like @donvido";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { str, str, str, str });
        }
        public static DataTable layDanhSachLoaiSP()
        {
            string query = "select MaLoaiSP, TenLoaiSP from LoaiSP";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public static int layIDLoaiSP(string ten)
        {
            string query = "select MaLoaiSP from LoaiSP where TenLoaiSP like @ten";
            return (int) DataProvider.Instance.ExecuteScalar(query, new object[] { ten});
        }
        public static DataTable layDSSPTheoMH(int id)
        {
            string query = "select MaSP, TenSP, TenLoaiSP,DonGia, DonViDo, HSD, NSX, SoLuong from SanPham, LoaiSP, MatHang " +
                 "where ConDung = 1 and SanPham.MaLoaiSP = LoaiSP.MaLoaiSP and LoaiSP.MaMH = MatHang.MaMH and MatHang.MaMH = @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id});
        }
    }
}
