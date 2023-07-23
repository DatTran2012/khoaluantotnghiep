using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucAnNhanh.KhachHang
{
    public partial class FrmTimKH : Form
    {
        public FrmTimKH()
        {
            InitializeComponent();
        }
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        KhachHangBLL kh = new KhachHangBLL();

        public static int IDKH = 0;
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text != string.Empty)
            {
               dgvDSKhachHang.DataSource = CauHinh.Search(txtTimKiem.Text, "KhachHang", "TenKH", "SDT");
                int filter = int.Parse(CauHinh.Search(txtTimKiem.Text, "KhachHang", "TenKH", "SDT").Rows.Count.ToString());
                lblFilter.Text = "Filter: " + filter;
            }    
        }

        private void dgvDSKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDKH = int.Parse(dgvDSKhachHang.CurrentRow.Cells[0].Value.ToString());
        }

        private void FrmTimKH_Load(object sender, EventArgs e)
        {
            dgvDSKhachHang.DataSource = kh.GetData();
        }
    }
}
