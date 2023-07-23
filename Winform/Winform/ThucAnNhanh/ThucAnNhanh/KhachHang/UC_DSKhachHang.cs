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
    public partial class UC_DSKhachHang : UserControl
    {
        public UC_DSKhachHang()
        {
            InitializeComponent();
        }
        KhachHangBLL kh = new KhachHangBLL();
        QL_NguoiDung CauHinh = new QL_NguoiDung();

        private void UC_DSKhachHang_Load(object sender, EventArgs e)
        {
           dgvDSKhachHang.DataSource =  kh.GetData();
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtTimKiem.Text.Trim().Length > 0)
                {
                    dgvDSKhachHang.DataSource = CauHinh.Search3(txtTimKiem.Text, "KhachHang", "TenKH", "SDT");
                    int filter = dgvDSKhachHang.Rows.Count - 1;
                    lblFilter.Text = "Filter: " + filter;
                }
                else
                {
                    dgvDSKhachHang.DataSource = CauHinh.Search3(txtTimKiem.Text, "KhachHang", "TenKH", "SDT");
                    lblFilter.Text = "Filter: 0";
                }
            }
            catch

            {
                MessageBox.Show("...");
            }
        }
    }
}
