using QLST.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLST.GUI.Chon
{
    public partial class frmChonKH : Form
    {
        public delegate void delGuiIDKH(int id);
        public delGuiIDKH guiIDKH;
        public frmChonKH()
        {
            InitializeComponent();
            loadDanhSach();
        }
        private void loadDanhSach()
        {
            dgvDanhSach.Rows.Clear();
            DataTable dt = KhachHangControl.layDanhSach();
            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                dgvDanhSach.Rows.Add(new object[] { dt.Rows[i][1], dt.Rows[i][3], dt.Rows[i][2] });
                dgvDanhSach.Rows[i].Tag = dt.Rows[i][0];
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                guiIDKH.Invoke(Convert.ToInt32(dgvDanhSach.Rows[e.RowIndex].Tag));
                this.Close();
            }
        }
    }
}
