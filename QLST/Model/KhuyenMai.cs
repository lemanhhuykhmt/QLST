using QLST.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Model
{
    class KhuyenMai
    {
        public int MaKM { get; set; }
        public string TenKM { get; set; }
        public int LoaiKM { get; set; }
        public double GiaTri { get; set; }
        public KhuyenMai()
        {

        }
        public KhuyenMai(int id)
        {
            if(id == 0)
            {
                MaKM = 0;
                TenKM = "-----none-----";
                return;
            }
            DataTable dt = KhuyenMaiControl.layThongTin(id);
            MaKM = id;
            TenKM = dt.Rows[0]["TenKM"].ToString();
            LoaiKM = Convert.ToInt32(dt.Rows[0]["LoaiKM"].ToString());
            GiaTri = double.Parse(dt.Rows[0]["GiaTri"].ToString());
        }
    }
}
