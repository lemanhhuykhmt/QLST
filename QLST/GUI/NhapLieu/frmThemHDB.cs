using QLST.Controls;
using QLST.GUI.Chon;
using QLST.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLST.GUI.NhapLieu 
{
    public partial class frmThemHDB : Form
    {
        private HoaDonBan HDB;
        public frmThemHDB()
        {
            InitializeComponent();
            HDB = new HoaDonBan();
            loadDSKhuyenMai();
            loadDSNhanVien();
            loadDanhSachSP();
            loadTongTien();
            loadThanhToan();
            loadKhachHang();
            loadNgayLap();
        }
        public frmThemHDB(int id)
        {
            InitializeComponent();

            HDB = new HoaDonBan(id);
            loadDSKhuyenMai();
            loadChiTietHDB();
            loadTrangThai();
            loadKhuyenMai();
            loadDSNhanVien();
            loadNhanVien();
            loadDanhSachSP();
            loadTongTien();
            loadThanhToan();
            loadKhachHang();
            loadNgayLap();
        }
        
        private void loadDanhSachSP()
        {
            dgvDanhSachSP.Rows.Clear();
            DataTable dt = SanPhamControl.layDanhSach();
            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                int soluong;
                int vitri = HDB.ChiTiet.isContain(Convert.ToInt32(dt.Rows[i][0].ToString()));
                if (vitri != -1) // nếu sản phẩm có trong HDB
                {
                    soluong = Convert.ToInt32(dt.Rows[i]["SoLuong"].ToString()) - HDB.ChiTiet.ListSanPham[vitri].SoLuong;
                }
                else
                {
                    soluong = Convert.ToInt32(dt.Rows[i]["SoLuong"].ToString());
                }
                dgvDanhSachSP.Rows.Add(new object[] { dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][3], dt.Rows[i][4], soluong });
            }
           
        }

        private void loadChiTietHDB()
        {
            dgvChiTiet.Rows.Clear();
            for(int i = 0; i < HDB.ChiTiet.ListSanPham.Count; ++i)
            {
                dgvChiTiet.Rows.Add(new object[] {
                    HDB.ChiTiet.ListSanPham[i].TenSP,
                    HDB.ChiTiet.ListSanPham[i].SoLuong,
                    HDB.ChiTiet.ListSanPham[i].DonGia,
                    HDB.ChiTiet.ListSanPham[i].DonGia * HDB.ChiTiet.ListSanPham[i].SoLuong });
                dgvChiTiet.Rows[dgvChiTiet.Rows.Count - 2].Tag = HDB.ChiTiet.ListSanPham[i].IdSP;
            }

        }
        private void loadKhachHang()
        {
            if (HDB.layTenKH().Length == 0)
            {
                lbTenKH.Text = "Khách vãng lai";
            }
            else
            {
                lbTenKH.Text = HDB.layTenKH();
            }
        }
        private void loadTrangThai()
        {
            cbTrangThai.SelectedIndex = HDB.TrangThai - 1;
        }
        private void loadTongTien()
        {
            float tongTien = HDB.ChiTiet.tinhTongTien();
            lbTongTien.Text = "" + tongTien;
        }
        private void loadDSKhuyenMai()
        {
            DataTable ds = KhuyenMaiControl.layDanhSach();
            List<KhuyenMai> listKM = new List<KhuyenMai>();
            listKM.Add(new KhuyenMai
            {
                MaKM = 0,
                TenKM = "-----none-----",
                GiaTri = 0,
                LoaiKM = 0
            });
            for(int i = 0; i < ds.Rows.Count; ++i)
            {
                listKM.Add(new KhuyenMai {
                    MaKM = Convert.ToInt32(ds.Rows[i]["MaKM"].ToString()),
                    TenKM = ds.Rows[i]["TenKM"].ToString(),
                    GiaTri = double.Parse(ds.Rows[i]["GiaTri"].ToString()),
                    LoaiKM = Convert.ToInt32(ds.Rows[i]["LoaiKM"].ToString())
                });
            }
            cbKhuyenMai.DataSource = listKM;
            cbKhuyenMai.DisplayMember = "TenKM";
        }
        private void loadDSNhanVien()
        {
            DataTable ds = NhanVienControl.layDanhSach();
            List<NhanVien> listKM = new List<NhanVien>();
            for (int i = 0; i < ds.Rows.Count; ++i)
            {
                listKM.Add(new NhanVien
                {
                    MaNV = Convert.ToInt32(ds.Rows[i]["MaNV"].ToString()),
                    TenNV = ds.Rows[i]["TenNV"].ToString(),                  
                });
            }
            cbNhanVien.DataSource = listKM;
            cbNhanVien.DisplayMember = "TenNV";
        }
        private void loadKhuyenMai()
        {
            DataTable dt = HoaDonBanControl.layThongTinHDB(HDB.Id);
            HDB.KhuyenMai = new KhuyenMai(dt.Rows[0]["MaKM"].ToString().Length == 0 ? 0 : Convert.ToInt32(dt.Rows[0]["MaKM"].ToString()));
            if (HDB.KhuyenMai.TenKM.Length > 0)
            {
                cbKhuyenMai.Text = HDB.KhuyenMai.TenKM;
                return;
            }
            cbKhuyenMai.SelectedItem = "-----none-----";
        }
        private void loadNhanVien()
        {
            DataTable dt = HoaDonBanControl.layThongTinHDB(HDB.Id);
            HDB.IdNV = dt.Rows[0]["MaNV"].ToString().Length == 0 ? 0 : Convert.ToInt32(dt.Rows[0]["MaNV"].ToString());
            NhanVien nv = new NhanVien(HDB.IdNV);
            if (nv.TenNV.Length > 0)
            {
                cbNhanVien.Text = nv.TenNV;
                return;
            }
        }
        private void loadThanhToan() 
        {
            HDB.tinhThanhToan();
            lbThanhToan.Text = HDB.ThanhToan.ToString();
        }
        private void loadNgayLap()
        {
            lbNgayLap.Text = HDB.NgayLap.ToString();
        }


        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvChiTiet.Columns["colXoa"].Index)
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                HDB.ChiTiet.xoaSP(Convert.ToInt32(dgvChiTiet.Rows[e.RowIndex].Tag));
                loadDanhSachSP();
                loadChiTietHDB();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        { // còn thiếu lưu các thông tin khác
            if(HDB.Id == 0) // neu la hd moi
            {
                int ketqua = HoaDonBanControl.themDuLieu(HDB.IdKH, HDB.IdNV, HDB.NgayLap, HDB.KhuyenMai.MaKM, HDB.TrangThai, HDB.ThanhToan);
                if(ketqua <= 0)
                {
                    return;
                } //
                ketqua = 0;
                // lay ma hoa don vua nhap
                HDB.Id = HoaDonBanControl.layMaHDBMoi();
                if (HDB.Id == 0) return;
                for(int i = 0; i < HDB.ChiTiet.ListSanPham.Count; ++i)
                {
                    ketqua += HoaDonBanControl.themChiTietHDB(HDB.Id, HDB.ChiTiet.ListSanPham[i].IdSP, HDB.ChiTiet.ListSanPham[i].SoLuong, HDB.ChiTiet.ListSanPham[i].DonGia);
                }
                if(ketqua > 0)
                {
                    MessageBox.Show("them thanh cong");
                    this.Close();
                }
            }
            else // neu hd cu
            {
                //sua
                HoaDonBanControl.suaThongTin(HDB.Id, HDB.IdKH, HDB.IdNV, HDB.KhuyenMai.MaKM, HDB.TrangThai, HDB.ThanhToan);

                // xoa het chitiet cu
                HoaDonBanControl.xoaChiTietHDB(HDB.Id);
                //
                int ketqua = 0;
                for(int i = 0; i < HDB.ChiTiet.ListSanPham.Count; ++i)
                {
                    ketqua += HoaDonBanControl.themChiTietHDB(HDB.Id, HDB.ChiTiet.ListSanPham[i].IdSP, HDB.ChiTiet.ListSanPham[i].SoLuong, HDB.ChiTiet.ListSanPham[i].DonGia);

                }
                if(ketqua > 0)
                {
                    MessageBox.Show("sua thanh cong");
                    this.Close();
                }
            }
        }

        private void cbKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            HDB.KhuyenMai = cbKhuyenMai.SelectedValue as KhuyenMai;
            loadThanhToan();
        }

        private void dgvChiTiet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvChiTiet.Columns["colSoLuong"].Index) // cột số lượng
            {
                HDB.ChiTiet.ListSanPham[e.RowIndex].SoLuong = Convert.ToInt32(dgvChiTiet.CurrentCell.Value.ToString());
                loadDanhSachSP();

            }
            else if(e.ColumnIndex == dgvChiTiet.Columns["colDonGia"].Index) // cột đơn giá
            {
                HDB.ChiTiet.ListSanPham[e.RowIndex].DonGia = float.Parse(dgvChiTiet.CurrentCell.Value.ToString());
            }
            loadChiTietHDB();
            loadTongTien();
            loadThanhToan();
        }

        private void dgvDanhSachSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDanhSachSP.Columns["colThem"].Index)
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                int row = e.RowIndex;
                int soluong = (int)dgvDanhSachSP.Rows[row].Cells["colCon"].Value;
                if (soluong == 0) return;
                int id = Convert.ToInt32(dgvDanhSachSP.Rows[row].Cells[0].Value);
                HDB.ChiTiet.ThemSP(id);// thêm sp vào chi tiết sp
                //giảm số lượng
                dgvDanhSachSP.Rows[row].Cells["colCon"].Value = soluong - 1;
                loadChiTietHDB();
                loadTongTien();
                loadThanhToan();
            }
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            timKiem();
        }
        private void timKiem()
        {
            foreach (DataGridViewCell item in dgvDanhSachSP.SelectedCells)
            {
                item.Selected = false;
            }
            string stringTimKiem = txtTimKiemSP.Text;

            DataTable dt = SanPhamControl.timKiem(stringTimKiem);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                for (int j = 0; j < dgvDanhSachSP.Rows.Count - 1; ++j)
                {
                    if (dgvDanhSachSP.Rows[j].Cells[0].Value.ToString().Equals(dt.Rows[i][0].ToString()))
                    {
                        dgvDanhSachSP.Rows[j].Selected = true;
                        break;
                    }
                }
            }
        }
        private void txtTimKiemSP_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                timKiem();
            }
            else if(e.KeyValue == 27)
            {
                txtTimKiemSP.Text = "";
            }
        }

        private void nhanIDKH(int idkh)
        {
            
            HDB.IdKH = idkh;
            loadKhachHang();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmChonKH f = new frmChonKH();
            f.guiIDKH = nhanIDKH;
            f.ShowDialog();
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            HDB.TrangThai = cbTrangThai.SelectedIndex + 1;
        }

        private void dgvChiTiet_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(e.ColumnIndex != dgvChiTiet.Columns["colSoLuong"].Index && e.ColumnIndex != dgvChiTiet.Columns["colDonGia"].Index)
            {
                e.Cancel = true;
            }
        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            HDB.IdNV = (cbNhanVien.SelectedValue as NhanVien).MaNV;
        }
    }
}
