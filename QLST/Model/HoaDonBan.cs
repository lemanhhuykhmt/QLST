
using QLST.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Model
{
    class HoaDonBan
    {
        private ChiTietHDB chiTiet;
        private int id;
        private DateTime ngayLap;
        private int idNV;
        private int idKH;
        private int trangThai;
        private KhuyenMai khuyenMai;
        private double thanhToan;

        public ChiTietHDB ChiTiet
        {
            set { }
            get { if (chiTiet == null) chiTiet = new ChiTietHDB(); return chiTiet; }
        }
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public DateTime NgayLap
        {
            set { ngayLap = value; }
            get { return ngayLap; }
        }
        public int IdNV
        {
            set { idNV = value; }
            get { return idNV; }
        }
        public int IdKH
        {
            set { idKH = value; }
            get { return idKH; }
        }
        public KhuyenMai KhuyenMai
        {
            set { khuyenMai = value; }
            get { return khuyenMai; }
        }
        public double ThanhToan
        {
            set { }
            get { return thanhToan; }
        }
        public int TrangThai
        {
            set { trangThai = value; }
            get { return trangThai; }
        }


        public HoaDonBan()
        {
            chiTiet = new ChiTietHDB();
            id = 0;
            ngayLap = DateTime.Now;
            idNV = 0;
            idKH = 0;
            khuyenMai = new KhuyenMai(0);
            thanhToan = 0;
            trangThai = 0;
        }
        public HoaDonBan(int id)
        {
            chiTiet = new ChiTietHDB(id);
            this.id = id;
            DataTable dt = HoaDonBanControl.layThongTinHDB(id);
            idKH = dt.Rows[0]["MaKH"].ToString().Length == 0 ? 0 : Convert.ToInt32(dt.Rows[0]["MaKH"].ToString());
            idNV = dt.Rows[0]["MaNV"].ToString().Length == 0 ? 0 : Convert.ToInt32(dt.Rows[0]["MaNV"].ToString());
            trangThai = Convert.ToInt32(dt.Rows[0]["TrangThai"].ToString());
            khuyenMai = new KhuyenMai(dt.Rows[0]["MaKM"].ToString().Length == 0 ? 0 : Convert.ToInt32(dt.Rows[0]["MaKM"].ToString()));
            thanhToan = double.Parse(dt.Rows[0]["ThanhToan"].ToString());
            ngayLap = DateTime.Parse(dt.Rows[0]["NgayLap"].ToString());
        }

        public void Luu()
        {

        }

        public void tinhThanhToan()
        {
            int loaiKM = khuyenMai.LoaiKM;
            double giaTri = khuyenMai.GiaTri;

            if(loaiKM == 0) // mã = 0
            {
                thanhToan = chiTiet.tinhTongTien();
            }
            else if(loaiKM == 1) // %
            {
                thanhToan = chiTiet.tinhTongTien() - chiTiet.tinhTongTien() * giaTri / 100;
            }
            else if(loaiKM == 2) // trừ thẳng
            {
                thanhToan = chiTiet.tinhTongTien() - giaTri;
                if (thanhToan < 0) thanhToan = 0;
            }
        }
        public string layTenNV()
        {
            return NhanVienControl.layTenNV(idNV);
        }
        public string layTenKH()
        {
            return KhachHangControl.layTenKH(idKH);
        }
    }
}
