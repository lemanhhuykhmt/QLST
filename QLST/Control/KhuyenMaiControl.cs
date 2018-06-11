using QLST.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Controls
{
    class KhuyenMaiControl
    {

        public static DataTable layDanhSach()//
        {
            string query = "select MaKM, TenKM, GiaTri, LoaiKM from KhuyenMai ";//
            return DataProvider.Instance.ExecuteQuery(query);//
        }
        public static DataTable layThongTin(int id)//
        {
            string query = "select MaKM, TenKM, GiaTri, LoaiKM from KhuyenMai where MaKM = @ma";//
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id});//
        }
        public static double layGiaTri(string ten)//
        {//
            if(ten.Equals("-----none-----"))//
            {
                return 0;//
            }
            string query = "select GiaTri from KhuyenMai where TenKM = @makm";//
            return (double)DataProvider.Instance.ExecuteScalar(query,new object[]{ ten});//
        }//
        public static int layLoaiKhuyenMai(string ten)//
        {
            if(ten.Equals("-----none-----"))
            {
                return 0;
            }
            string query = "select LoaiKM from KhuyenMai where TenKM = @makm";
            return (int) DataProvider.Instance.ExecuteScalar(query, new object[] { ten });
        }
    }
}
