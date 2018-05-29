using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Model
{
    class LoaiSP
    {
        private int idLoai;
        private string tenLoai;
        
        public int IdLoai
        {
            set { idLoai = value; }
            get { return idLoai; }
        }
        public string TenLoai
        {
            set { tenLoai = value; }
            get { return tenLoai; }
        }
        public LoaiSP()
        {

        }
        public LoaiSP(int id, string ten)
        {
            idLoai = id;
            tenLoai = ten;
        }
    }
}
