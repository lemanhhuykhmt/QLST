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
        public static int themDuLieu(string ten, int mamh)
        {
            string query = "exec themlsp @ten , @mamh";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten , mamh});
        }
        public static int xoaDuLieu(int maloai)
        {
            string query = "exec xoalsp @ma";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maloai});
        }
        public static DataTable layDSLoai(int idmh)
        {
            string query = "select MaLoaiSP, TenLoaiSP from LoaiSP where MaMH = @mamh";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idmh});
        }
        public static DataTable layDSLoai()
        {
            string query = "select MaLoaiSP, TenLoaiSP from LoaiSP";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
