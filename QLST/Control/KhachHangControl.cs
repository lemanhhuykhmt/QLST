﻿using QLST.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Controls
{
    /*
     using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLST.Controls;
using QLST.Model;
using QLST.GUI.Sua;
using QLST.GUI.NhapLieu;

namespace QLST.GUI.UC
{
    public partial class ucSanPham : UserControl
    {
        public ucSanPham()
        {
            InitializeComponent();
            loadDuLieu();
            loadLoaiSP();
        }
        private void loadLoaiSP()
        {
            tvLoaiSP.Nodes.Clear();
            // lấy thống tin tất cả loại sp và mặt hàng
            tvLoaiSP.Nodes.Add("TatCa", "Tất cả");
            DataTable dtMatHang = MatHangControl.layDSMH();
            List<MatHang> listMH = new List<MatHang>();
            for (int i = 0; i < dtMatHang.Rows.Count; ++i)
            {
                MatHang mh = new MatHang(Convert.ToInt32(dtMatHang.Rows[i][0].ToString()), dtMatHang.Rows[i][1].ToString());
                mh.layDSLoai();
                listMH.Add(mh);
            }
            // đưa vào treeview
            for(int i = 0; i < listMH.Count; ++i)
            {
                tvLoaiSP.Nodes["TatCa"].Nodes.Add(listMH[i].IdMH.ToString(), listMH[i].TenMH);
                for(int j = 0; j < listMH[i].ListLoai.Count; ++j)
                {
                    tvLoaiSP.Nodes["TatCa"].Nodes[listMH[i].IdMH.ToString()].Nodes.Add(listMH[i].ListLoai[j].IdLoai.ToString(), listMH[i].ListLoai[j].TenLoai);
                }
            }

        }
        private void loadDuLieu()
        {
            dgvDanhSach.Rows.Clear();

            DataTable dt = SanPhamControl.layDanhSach();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvDanhSach.Rows.Add(new object[] { false, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], String.Format("{0:dd/MM/yyyy}", dt.Rows[i][5]),
                                     String.Format("{0:dd/MM/yyyy}", dt.Rows[i][6]), dt.Rows[i][7] });
            }
        }


        private void btnNhap_Click(object sender, EventArgs e)
        {
            frmThemSP f = new frmThemSP();
            f.ShowDialog();
            loadDuLieu();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ketQua = 0;
            for (int i = 0; i < dgvDanhSach.Rows.Count - 1; ++i)
            {
                if (Convert.ToBoolean(dgvDanhSach.Rows[i].Cells["colCheck"].Value.ToString()))
                {
                    ketQua += SanPhamControl.xoaThongTin(Convert.ToInt32(dgvDanhSach.Rows[i].Cells["colMa"].Value.ToString()));
                }
            }
            if (ketQua > 0)
            {
                MessageBox.Show("xóa thành công " + ketQua);
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("xóa thất bại");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // get text
            string value = txtTimKiem.Text;
            if (value.Length == 0)
            {
                loadDuLieu();
                return;
            }
            timKiem(value);
        }
        private void timKiem(string value)
        {
            
            dgvDanhSach.Rows.Clear();
            DataTable dt = SanPhamControl.timKiem(value);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvDanhSach.Rows.Add(false, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], String.Format("{0:dd/MM/yyyy}", dt.Rows[0][5]),
                                     String.Format("{0:dd/MM/yyyy}", dt.Rows[0][6]), dt.Rows[i][7]);
            }
        }
        private void txtTimKiem_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                // get text
                string value = txtTimKiem.Text;
                if (value.Length == 0)
                {
                    loadDuLieu();
                    return;
                }
                timKiem(value);
            }
            else if (e.KeyValue == 27)
            {
                txtTimKiem.Text = "";
                loadDuLieu();
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvDanhSach.Rows[e.RowIndex].Cells["colMa"].Value.ToString());
            if (e.ColumnIndex == dgvDanhSach.Columns["colSua"].Index)
            {
                frmSuaSP f = new frmSuaSP(id);
                f.ShowDialog();
                loadDuLieu();
            }
            else if (e.ColumnIndex == dgvDanhSach.Columns["colXoa"].Index)
            {
                int ketQua = SanPhamControl.xoaThongTin(id);
                if (ketQua <= 0)
                {
                    MessageBox.Show("Thực hiện thất bại");
                }
                else
                {
                    loadDuLieu();
                }
            }
        }

        private void tvLoaiSP_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Name.Equals("TatCa"))
            {
                loadDuLieu();
            }
            else if(e.Node.Parent.Equals(tvLoaiSP.Nodes["TatCa"]))
            {
                timTheoMatHang(Convert.ToInt32(e.Node.Name));    
            }
            else
            {
                timKiem(e.Node.Text);
            }
        }
        private void timTheoMatHang(int id)
        {
            dgvDanhSach.Rows.Clear();
            DataTable dt = SanPhamControl.layDSSPTheoMH(id);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvDanhSach.Rows.Add(false, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], String.Format("{0:dd/MM/yyyy}", dt.Rows[0][5]),
                                     String.Format("{0:dd/MM/yyyy}", dt.Rows[0][6]), dt.Rows[i][7]);
            }
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            frmThemLoaiSP f = new frmThemLoaiSP();
            f.ShowDialog();
            loadLoaiSP();
        }using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLST.Controls;
using QLST.Model;
using QLST.GUI.Sua;
using QLST.GUI.NhapLieu;

namespace QLST.GUI.UC
{
    public partial class ucSanPham : UserControl
    {
        public ucSanPham()
        {
            InitializeComponent();
            loadDuLieu();
            loadLoaiSP();
        }
        private void loadLoaiSP()
        {
            tvLoaiSP.Nodes.Clear();
            // lấy thống tin tất cả loại sp và mặt hàng
            tvLoaiSP.Nodes.Add("TatCa", "Tất cả");
            DataTable dtMatHang = MatHangControl.layDSMH();
            List<MatHang> listMH = new List<MatHang>();
            for (int i = 0; i < dtMatHang.Rows.Count; ++i)
            {
                MatHang mh = new MatHang(Convert.ToInt32(dtMatHang.Rows[i][0].ToString()), dtMatHang.Rows[i][1].ToString());
                mh.layDSLoai();
                listMH.Add(mh);
            }
            // đưa vào treeview
            for(int i = 0; i < listMH.Count; ++i)
            {
                tvLoaiSP.Nodes["TatCa"].Nodes.Add(listMH[i].IdMH.ToString(), listMH[i].TenMH);
                for(int j = 0; j < listMH[i].ListLoai.Count; ++j)
                {
                    tvLoaiSP.Nodes["TatCa"].Nodes[listMH[i].IdMH.ToString()].Nodes.Add(listMH[i].ListLoai[j].IdLoai.ToString(), listMH[i].ListLoai[j].TenLoai);
                }
            }

        }
        private void loadDuLieu()
        {
            dgvDanhSach.Rows.Clear();

            DataTable dt = SanPhamControl.layDanhSach();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvDanhSach.Rows.Add(new object[] { false, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], String.Format("{0:dd/MM/yyyy}", dt.Rows[i][5]),
                                     String.Format("{0:dd/MM/yyyy}", dt.Rows[i][6]), dt.Rows[i][7] });
            }
        }


        private void btnNhap_Click(object sender, EventArgs e)
        {
            frmThemSP f = new frmThemSP();
            f.ShowDialog();
            loadDuLieu();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ketQua = 0;
            for (int i = 0; i < dgvDanhSach.Rows.Count - 1; ++i)
            {
                if (Convert.ToBoolean(dgvDanhSach.Rows[i].Cells["colCheck"].Value.ToString()))
                {
                    ketQua += SanPhamControl.xoaThongTin(Convert.ToInt32(dgvDanhSach.Rows[i].Cells["colMa"].Value.ToString()));
                }
            }
            if (ketQua > 0)
            {
                MessageBox.Show("xóa thành công " + ketQua);
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("xóa thất bại");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // get text
            string value = txtTimKiem.Text;
            if (value.Length == 0)
            {
                loadDuLieu();
                return;
            }
            timKiem(value);
        }
        private void timKiem(string value)
        {
            
            dgvDanhSach.Rows.Clear();
            DataTable dt = SanPhamControl.timKiem(value);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvDanhSach.Rows.Add(false, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], String.Format("{0:dd/MM/yyyy}", dt.Rows[0][5]),
                                     String.Format("{0:dd/MM/yyyy}", dt.Rows[0][6]), dt.Rows[i][7]);
            }
        }
        private void txtTimKiem_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                // get text
                string value = txtTimKiem.Text;
                if (value.Length == 0)
                {
                    loadDuLieu();
                    return;
                }
                timKiem(value);
            }
            else if (e.KeyValue == 27)
            {
                txtTimKiem.Text = "";
                loadDuLieu();
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvDanhSach.Rows[e.RowIndex].Cells["colMa"].Value.ToString());
            if (e.ColumnIndex == dgvDanhSach.Columns["colSua"].Index)
            {
                frmSuaSP f = new frmSuaSP(id);
                f.ShowDialog();
                loadDuLieu();
            }
            else if (e.ColumnIndex == dgvDanhSach.Columns["colXoa"].Index)
            {
                int ketQua = SanPhamControl.xoaThongTin(id);
                if (ketQua <= 0)
                {
                    MessageBox.Show("Thực hiện thất bại");
                }
                else
                {
                    loadDuLieu();
                }
            }
        }

        private void tvLoaiSP_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Name.Equals("TatCa"))
            {
                loadDuLieu();
            }
            else if(e.Node.Parent.Equals(tvLoaiSP.Nodes["TatCa"]))
            {
                timTheoMatHang(Convert.ToInt32(e.Node.Name));    
            }
            else
            {
                timKiem(e.Node.Text);
            }
        }
        private void timTheoMatHang(int id)
        {
            dgvDanhSach.Rows.Clear();
            DataTable dt = SanPhamControl.layDSSPTheoMH(id);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvDanhSach.Rows.Add(false, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], String.Format("{0:dd/MM/yyyy}", dt.Rows[0][5]),
                                     String.Format("{0:dd/MM/yyyy}", dt.Rows[0][6]), dt.Rows[i][7]);
            }
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            frmThemLoaiSP f = new frmThemLoaiSP();
            f.ShowDialog();
            loadLoaiSP();
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            if(tvLoaiSP.SelectedNode.Name.Equals("TatCa"))
            {
                return;
            }
            else if(tvLoaiSP.SelectedNode.Parent.Name.Equals("TatCa")) // mặt hàng
            {
                MatHangControl.xoaDuLieu(Convert.ToInt32(tvLoaiSP.SelectedNode.Name));
                loadLoaiSP();
            }
            else
            {
                LoaiSPControl.xoaDuLieu(Convert.ToInt32(tvLoaiSP.SelectedNode.Name));
                loadLoaiSP();
            }
        }
    }
}


        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            if(tvLoaiSP.SelectedNode.Name.Equals("TatCa"))
            {
                return;
            }
            else if(tvLoaiSP.SelectedNode.Parent.Name.Equals("TatCa")) // mặt hàng
            {
                MatHangControl.xoaDuLieu(Convert.ToInt32(tvLoaiSP.SelectedNode.Name));
                loadLoaiSP();
            }
            else
            {
                LoaiSPControl.xoaDuLieu(Convert.ToInt32(tvLoaiSP.SelectedNode.Name));
                loadLoaiSP();
            }
        }
    }
}
*/
    class KhachHangControl
    {
        private static KhachHangControl instance;
        public KhachHangControl Instance
        {
            private set { instance = value; }
            get { if (instance == null) instance = new KhachHangControl(); return instance; }
        }
        private KhachHangControl()
        {

        }
        public static int themDuLieu(string ten, string diachi, string sdt)
        {
            string query = "exec themkh @ten , @diachi , @sdt";
            return DataProvider.Instance.ExecuteNonQuery(query, new String[] { ten, diachi, sdt });
        }
        public static DataTable layDanhSach() // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from KhachHang";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTin(int id) // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from KhachHang where MaKH = @makh";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        public static string layTenKH(int id)
        {
            if (id == 0)
            {
                return "";
            }
            string query = "select TenKH from KhachHang where MaKH = @ma";
            return DataProvider.Instance.ExecuteScalar(query, new object[] { id }).ToString();
        }
        public static int suaThongTin(int id, string ten, string diachi, string sdt) // sửa thông tin của khách hàng
        {
            string query = "exec suakh @id , @ten , @diachi , @sdt";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, diachi, sdt });
        }
        public static int xoaThongTin(int id)
        {
            string query = "exec xoakh @makh";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public static DataTable timKiem(object obj)
        {
            string str = "%" + obj.ToString() + "%";
            string query = "select * from KhachHang where TenKH like @ten or DiaChi like @diachi or SDT like @sdt";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { str, str, str });
        }
    }
}
