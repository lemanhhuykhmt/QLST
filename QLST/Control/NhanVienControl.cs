using QLST.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Controls
{
    public class NhanVienControl
    {
        public static string layTenNV(int id)
        {
            if (id == 0)///
            {
                return "";//
            }
            string query = "select TenNV from NhanVien where MaNV = @id";//
            return DataProvider.Instance.ExecuteScalar(query, new object[] { id }).ToString();//
        }
        public static int themDuLieu(string ten, DateTime ngaysinh, string sdt, string gioitinh, double luong)//
        {//
            string query = "exec themgv @ten , @ngaysinh , @sdt , @gioitinh , @luong";//
            if (luong == 0) return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, ngaysinh, sdt, gioitinh, null });
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, ngaysinh, sdt, gioitinh, luong });
        }
        public static DataTable layDanhSach() // lấy thông tin khách hàng có id là ..//
        {
            string query = "select * from NhanVien";//lấy ra thông tin khách hàng có mã//
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);//
            return dt;//
        }
        public static DataTable layThongTin(int id) // lấy thông tin khách hàng có id là ..//
        {
            string query = "select * from NhanVien where MaNV = @ma";//lấy ra thông tin khách hàng có mã//
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });//
            return dt;//
        }//
        public static int suaThongTin(int id, string ten, string gioitinh, string ngaysinh, string sdt, double luong) // sửa thông tin của khách hàng
        {
            string query = "exec suanv @id , @ten , @gioitinh , @ngaysinh , @sdt  , @luong";//
            if (luong == 0) return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, gioitinh, ngaysinh, sdt, "" });
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, gioitinh, ngaysinh, sdt, luong });//
        }
        public static int xoaThongTin(int id)//
        {
            string query = "exec xoanv @ma";//
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });//
        }
        public static DataTable timKiem(object obj)//
        {
            string str = "%" + obj.ToString() + "%";//
            string query = "select * from NhanVien where TenNV like @ten or SDT like @sdt";//
            return DataProvider.Instance.ExecuteQuery(query, new object[] { str, str });//
        }
    }
}
