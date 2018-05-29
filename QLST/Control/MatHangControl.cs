using QLST.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Controls
{
    class MatHangControl
    {
        public static DataTable layDSMH()
        {
            string query = "select MaMH, TenMH from MatHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public static int themDuLieu(string ten)
        {
            string query = "exec themmh @ten";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten});
        }
        public static int xoaDuLieu(int mamh)
        {
            string query = "exec xoamh @ma";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mamh});
        }
    }
}
