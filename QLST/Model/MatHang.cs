using QLST.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Model
{
    class MatHang
    {
        private int idMH;
        private string tenMH;
        private List<LoaiSP> listLoai;
        public int IdMH
        {
            set { idMH = value; }
            get { return idMH; }
        }
        public string TenMH
        {
            set { tenMH = value; }
            get { return tenMH; }
        }
        public List<LoaiSP> ListLoai
        {
            get { return listLoai; }
        }

        public MatHang()
        {
            listLoai = new List<LoaiSP>();
        }
        public MatHang(int id, string ten)
        {
            idMH = id;
            tenMH = ten;
            listLoai = new List<LoaiSP>();
        }
        public void layDSLoai()
        {
            DataTable dtLoai = LoaiSPControl.layDSLoai(idMH);
            for(int i = 0; i < dtLoai.Rows.Count; ++i)
            {
                listLoai.Add(new LoaiSP(Convert.ToInt32(dtLoai.Rows[i][0].ToString()), dtLoai.Rows[i][1].ToString()));
            }
        }
    }
}
