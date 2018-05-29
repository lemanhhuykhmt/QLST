using QLST.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Model
{
    class SanPham
    {
        private int idSP;
        private string tenSP;        
        private float donGia;
        private int soLuong;
        public int IdSP
        {
            set
            {
                idSP = value;
            }
            get
            {
                return idSP;
            }
        }
        public string TenSP
        {
            set
            {
                tenSP = value;
            }
            get
            {
                return tenSP;
            }
        }
        public float DonGia
        {
            set
            {
                donGia = value;
            }
            get
            {
                return donGia;
            }
        }
        public int SoLuong
        {
            set
            {
                soLuong = value;
            }
            get
            {
                return soLuong;
            }
        }
        public SanPham()
        {

        }
        public SanPham(DataRow row)
        {
            idSP = Convert.ToInt32(row[0].ToString());
            tenSP = row[1].ToString();
            donGia = float.Parse(row[2].ToString());
            soLuong = Convert.ToInt32(row[3].ToString());
        }
        public SanPham(int id)
        {
            DataTable dt = SanPhamControl.layThongTin(id);
            idSP = Convert.ToInt32(dt.Rows[0][0].ToString());
            tenSP = dt.Rows[0][1].ToString();
            donGia = float.Parse(dt.Rows[0][3].ToString());
            soLuong = 1;
        }
    }
}
