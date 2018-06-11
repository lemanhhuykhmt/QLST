using QLST.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Controls
{
    class KhachHangControl
    {
        private static KhachHangControl instance;
        public KhachHangControl Instance
        {
            private set { instance = value; }
            get { if (instance == null) instance = new KhachHangControl(); return instance; }
        }
        private KhachHangControl()
        {

        }
        public static int themDuLieu(string ten, string diachi, string sdt)
        {
            string query = "exec themkh @ten , @diachi , @sdt";
            return DataProvider.Instance.ExecuteNonQuery(query, new String[] { ten, diachi, sdt });
        }
        public static DataTable layDanhSach() // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from KhachHang";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTin(int id) // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from KhachHang where MaKH = @makh";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        public static string layTenKH(int id)
        {
            if (id == 0)
            {
                return "";
            }
            string query = "select TenKH from KhachHang where MaKH = @ma";
            return DataProvider.Instance.ExecuteScalar(query, new object[] { id }).ToString();
        }
        public static int suaThongTin(int id, string ten, string diachi, string sdt) // sửa thông tin của khách hàng
        {
            string query = "exec suakh @id , @ten , @diachi , @sdt";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, diachi, sdt });
        }
        public static int xoaThongTin(int id)
        {
            string query = "exec xoakh @makh";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public static DataTable timKiem(object obj)
        {
            string str = "%" + obj.ToString() + "%";
            string query = "select * from KhachHang where TenKH like @ten or DiaChi like @diachi or SDT like @sdt";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { str, str, str });
        }
    }
}
