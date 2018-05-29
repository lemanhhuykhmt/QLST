using QLST.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Model
{
    class NhanVien
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public double Luong { get; set; }
        public NhanVien()
        {
            MaNV = 0;
            TenNV = "";
        }
        public NhanVien(int ma)
        {
            if(ma == 0)
            {
                MaNV = 0;
                TenNV = "";
            }
            else
            {
                MaNV = ma;
                DataTable dt = NhanVienControl.layThongTin(ma);
                TenNV = dt.Rows[0]["TenNV"].ToString();
            }
        }
    }
}
