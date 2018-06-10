using QLST.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Controls
{
    class NhaCungCapControl
    {
        public static int themDuLieu(string ten, string diachi, string sdt)
        {
            string query = "exec themnpp @ten , @diachi , @sdt";
            return DataProvider.Instance.ExecuteNonQuery(query, new String[] { ten, diachi, sdt });
        }
        public static DataTable layDanhSach() // lấy thông tin ncc
        {
            string query = "select * from NhaPhanPhoi";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTin(int id) // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from NhaPhanPhoi where MaNPP = @manpp";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
       
    }
}
