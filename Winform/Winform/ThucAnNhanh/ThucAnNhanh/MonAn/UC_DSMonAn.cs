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

namespace ThucAnNhanh
{
    public partial class UC_DSMonAn : UserControl
    {
        public UC_DSMonAn()
        {
            InitializeComponent();
        }
        MonAnBLL ma = new MonAnBLL();
        LoaiMonAnBLL lma = new LoaiMonAnBLL();
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        
        public int slFilter = 0;
        private void UC_DSMonAn_Load(object sender, EventArgs e)
        {
            dgvDSMonAn.DataSource = ma.GetData();
            int record = int.Parse(dgvDSMonAn.RowCount.ToString()) - 1;
            lblRecord.Text = "Record: " + record;
            DataTable dt = new DataTable();
            dt = lma.GetData();
            dt.Rows.Add(0, "TẤT CẢ");
            cboLoaiMonAn.DataSource = dt;           
            cboLoaiMonAn.DisplayMember = "TenLoaiMA";
            cboLoaiMonAn.ValueMember = "ID";
            cboLoaiMonAn.SelectedIndex = cboLoaiMonAn.Items.Count-1;
        }

        private void thêMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ma.InsertMonAn(int.Parse(dgvDSMonAn.CurrentRow.Cells[0].Value.ToString()), dgvDSMonAn.CurrentRow.Cells[1].Value.ToString(), dgvDSMonAn.CurrentRow.Cells[2].Value.ToString(),
                dgvDSMonAn.CurrentRow.Cells[3].Value.ToString(), int.Parse(dgvDSMonAn.CurrentRow.Cells[4].Value.ToString()), int.Parse(cboLoaiMonAn.SelectedValue.ToString()), 
                int.Parse(dgvDSMonAn.CurrentRow.Cells[6].Value.ToString()), int.Parse(dgvDSMonAn.CurrentRow.Cells[7].Value.ToString())))
            { 
                dgvDSMonAn.DataSource = ma.GetData();
            }
            else
                MessageBox.Show("Sai");
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtTimKiem.Text.Trim().Length > 0)
                {
                    dgvDSMonAn.DataSource = CauHinh.Search2(txtTimKiem.Text, "MonAn", "TenMA");
                    int filter = int.Parse(CauHinh.Search2(txtTimKiem.Text, "MonAn", "TenMA").Rows.Count.ToString());
                    lblFilter.Text = "Filter: " + filter;
                    //cboLoaiMonAn.SelectedValue = int.Parse(dgvDSMonAn.CurrentRow.Cells[5].Value.ToString());

                }
                else
                {
                    dgvDSMonAn.DataSource = CauHinh.Search2(txtTimKiem.Text, "MonAn", "TenMA");
                    int filter = int.Parse(CauHinh.Search2(txtTimKiem.Text, "MonAn", "TenMA").Rows.Count.ToString());
                    lblFilter.Text = "Filter: 0";
                }
            }catch

            {
                MessageBox.Show("...");
            }

        }

        private void cboLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboLoaiMonAn.SelectedIndex == cboLoaiMonAn.Items.Count-1)
            {
                dgvDSMonAn.DataSource = ma.GetData();
                int filter = dgvDSMonAn.Rows.Count - 1;
                lblFilter.Text = "Filter: " + filter;
                cboLoaiMonAn.SelectedIndex = cboLoaiMonAn.Items.Count - 1;

            }
            else
            {
                dgvDSMonAn.DataSource = ma.GetMonAnTheoLoai(cboLoaiMonAn.SelectedIndex + 1);
                int filter = ma.GetMonAnTheoLoai(cboLoaiMonAn.SelectedIndex + 1).Rows.Count;
                lblFilter.Text = "Filter: " + filter;

            }
        }

        private void dgvDSMonAn_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
