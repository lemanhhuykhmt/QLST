using QLST.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Model
{
    class ChiTietHDB
    {
        private List<SanPham> listSanPham;

        public List<SanPham> ListSanPham
        {
            get
            {
                return listSanPham;
            }
        }
        public ChiTietHDB()
        {
            listSanPham = new List<SanPham>();
        }
        public ChiTietHDB(int id)
        {
            loadChiTiet(id);
        }
        private void loadChiTiet(int id) // lấy danh sách hóa đơn có mã là id
        {
            DataTable data = HoaDonBanControl.layDanhSachSP(id);
            listSanPham = new List<SanPham>();
            for (int i = 0; i < data.Rows.Count; ++i)
            {
                SanPham sanPham = new SanPham(data.Rows[i]);
                listSanPham.Add(sanPham);
            }
        }
        public void ThemSP(int id)
        {
            int vitri = isContain(id);
            if (vitri != -1) // nếu đã có sản phẩm trong list
            {
                listSanPham[vitri].SoLuong++;
                return;
            }


            SanPham sp = new SanPham(id);
            listSanPham.Add(sp);
        }
        public void xoaSP(int id)
        {
            int vitri = isContain(id);
            if (vitri != -1)
            {
                listSanPham.RemoveAt(vitri);
            }
        }
        public int isContain(int id)// kiểm tra danh sách có mã id chưa, nếu đúng trả về vị trị của nó trong list
        {
            for (int i = 0; i < listSanPham.Count; ++i)
            {
                if (id == listSanPham[i].IdSP)
                {
                    return i;
                }
            }
            return -1;
        }
        public float tinhTongTien()
        {
            float tongTien = 0;
            for (int i = 0; i < listSanPham.Count; ++i)
            {
                tongTien += (listSanPham[i].SoLuong * listSanPham[i].DonGia);
            }
            return tongTien;
        }
    }
}
