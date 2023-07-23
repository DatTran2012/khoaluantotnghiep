using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucAnNhanh.MonAn
{
    public partial class UC_GiaMonAn : UserControl
    {
        public UC_GiaMonAn()
        {
            InitializeComponent();
        }
        BangGiaBLL bg = new BangGiaBLL();
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        private void UC_GiaMonAn_Load(object sender, EventArgs e)
        {
            dgvDSBangGia.DataSource = bg.GetData();
            int record = int.Parse(dgvDSBangGia.RowCount.ToString()) - 1;
            lblRecord.Text = "Record: " + record;
        }

        private void dgvDSBangGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtTenMonAn.Text = dgvDSBangGia.CurrentRow.Cells[4].Value.ToString();
            txtGiaBan.Text = dgvDSBangGia.CurrentRow.Cells[2].Value.ToString();
            dateToday.Text = dgvDSBangGia.CurrentRow.Cells[1].Value.ToString();

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtTimKiem.Text.Trim().Length > 0)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ID_MonAn, TenMA, NgayAD, dbo.BangGia.GiaBan, dbo.BangGia.GiaKhuyenMai FROM dbo.BangGia, dbo.MonAn where dbo.BangGia.ID_MonAn = dbo.MonAn.ID and TenMA like N'%" + txtTimKiem.Text + "%'", Properties.Settings.Default.ChuoiKetNoi);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDSBangGia.DataSource = dt;
                    int filter = dgvDSBangGia.Rows.Count - 1;
                    lblFilter.Text = "Filter: " + filter;
                    //cboLoaiMonAn.SelectedValue = int.Parse(dgvDSMonAn.CurrentRow.Cells[5].Value.ToString());
                }
                else
                {
                    dgvDSBangGia.DataSource = bg.GetData();
                    lblFilter.Text = "Filter: 0";
                }
            }
            catch

            {
                MessageBox.Show("...");
            }
        }

        private void btnThemGia_Click(object sender, EventArgs e)
        {
            if (bg.KTKC(int.Parse(dgvDSBangGia.CurrentRow.Cells[0].Value.ToString()), dateToday.Text) == 0)
            {
                if (bg.InsertBG(int.Parse(dgvDSBangGia.CurrentRow.Cells[0].Value.ToString()), dateToday.Value, int.Parse(txtGiaBan.Text), int.Parse(txtGiaKM.Text)))
                {
                    MessageBox.Show("Thêm giá thành công");
                    UC_GiaMonAn_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm giá thất bại");
                }
            }
            else
            {
                if (bg.UpdateBangGia(int.Parse(txtGiaKM.Text), int.Parse(dgvDSBangGia.CurrentRow.Cells[0].Value.ToString()), dateToday.Value.ToShortDateString()))
                {
                    MessageBox.Show("Cập nhật giá thành công");
                    UC_GiaMonAn_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật giá thất bại");
                }
            }
        }

        private void cboTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cboTinhTrang.SelectedIndex == 0)
            //{
            //    //dgvDSBangGia.DataSource = dt;
            //    int filter = dgvDSBangGia.Rows.Count - 1;
            //    lblFilter.Text = "Filter: " + filter;
            //}    
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            //txtTenMonAn.Text = txtGiaBan.Text = txtGiaKM.Text = string.Empty;
            //dateToday.Value = DateTime.Today;
            //txtTenMonAn.ReadOnly = txtGiaBan.ReadOnly = txtGiaKM.ReadOnly = false;
           
        }
    }
}
