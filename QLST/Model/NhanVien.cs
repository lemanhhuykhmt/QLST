using System;
using System.Collections.Generic;
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
    }
}
