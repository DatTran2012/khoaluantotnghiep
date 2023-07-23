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
using ThucAnNhanh.message_alert;

namespace ThucAnNhanh.MonAn
{
    public partial class FrmMonAn : Form
    {
        public FrmMonAn()
        {
            InitializeComponent();
        }
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        MonAnBLL ma = new MonAnBLL();
        LoaiMonAnBLL lma = new LoaiMonAnBLL();
        NguyenLieuBLL nl = new NguyenLieuBLL();
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtTimKiem.Text.Trim().Length > 0)
                {
                    dgvDSMonAn.DataSource = CauHinh.Search2(txtTimKiem.Text, "MonAn", "TenMA");
                    int filter = int.Parse(CauHinh.Search2(txtTimKiem.Text, "MonAn", "TenMA").Rows.Count.ToString());
                    lblFilter.Text = "Lọc: " + filter;
                    //cboLoaiMonAn.SelectedValue = int.Parse(dgvDSMonAn.CurrentRow.Cells[5].Value.ToString());

                }
                else
                {
                    dgvDSMonAn.DataSource = CauHinh.Search2(txtTimKiem.Text, "MonAn", "TenMA");
                    int filter = int.Parse(CauHinh.Search2(txtTimKiem.Text, "MonAn", "TenMA").Rows.Count.ToString());
                    lblFilter.Text = "Loc: 0";
                }
            }
            catch

            {
                MessageBox.Show("...");
            }

        }

        private void cboLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Text = string.Empty;
            if (cboLoaiMonAn.SelectedIndex == cboLoaiMonAn.Items.Count - 1)
            {
                dgvDSMonAn.DataSource = ma.GetData();
                int filter = dgvDSMonAn.Rows.Count - 1;
                lblFilter.Text = "Lọc: " + filter;
                cboLoaiMonAn.SelectedIndex = cboLoaiMonAn.Items.Count - 1;

            }
            else
            {
                dgvDSMonAn.DataSource = ma.GetMonAnTheoLoai(cboLoaiMonAn.SelectedIndex + 1);
                int filter = ma.GetMonAnTheoLoai(cboLoaiMonAn.SelectedIndex + 1).Rows.Count;
                lblFilter.Text = "Lọc: " + filter;

            }
        }

        private void FrmMonAn_Load(object sender, EventArgs e)
        {
            dgvDSMonAn.DataSource = ma.GetData();
            int record = int.Parse(dgvDSMonAn.RowCount.ToString()) - 1;
            lblRecord.Text = "Số lượng: " + record;
            DataTable dt = new DataTable();
            dt = lma.GetData();
            dt.Rows.Add(0, "TẤT CẢ");
            cboLoaiMonAn.DataSource = dt;
            cboLoaiMonAn.DisplayMember = "TenLoaiMA";
            cboLoaiMonAn.ValueMember = "ID";
            cboLoaiMonAn.SelectedIndex = cboLoaiMonAn.Items.Count - 1;
            cboLoai.DataSource = lma.GetData();
            cboLoai.DisplayMember = "TenLoaiMA";
            cboLoai.ValueMember = "ID";
            ///
            FillComboBox(cboNguyenLieu1);          
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            GetComboBoxData(combData);
            cboNguyenLieu1.AutoCompleteCustomSource = combData;
        }
        //
        private void GetComboBoxData(AutoCompleteStringCollection dataCollection)
        {
            DataTable dtData = nl.GetData();
            foreach (DataRow row in dtData.Rows)
            {
                dataCollection.Add(row[1].ToString());
            }
        }

        //combobox Nguyên liệu
        private void FillComboBox(ComboBox cmbComboBox)
        {
            DataTable dtData = nl.GetData();
            cmbComboBox.DataSource = dtData;
            cmbComboBox.ValueMember = "ID";
            cmbComboBox.DisplayMember = "TenNguyenLieu";
        }




        private void btnThem_Click(object sender, EventArgs e)
        {
            label1.Visible = txtID.Visible = false;
            txtTenMA.Text = txtMoTa.Text = txtAnh.Text = string.Empty;
            txtTenMA.ReadOnly = txtMoTa.ReadOnly = txtAnh.ReadOnly = false;
            cboLoai.SelectedIndex = -1;
            pic.ImageLocation = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ktNhap())
            {
                if (txtID.Text.Length == 0)
                {
                    if (ma.InsertMA(txtTenMA.Text, txtAnh.Text, txtMoTa.Text, 0, int.Parse(cboLoai.SelectedValue.ToString()), 0, 0))
                    {
                        FrmMonAn_Load(sender, e);
                        alert_success frm = new alert_success();
                        frm.showAlert("Thông báo", "Thêm món ăn thành công!", Color.FromArgb(24, 24, 24), Color.Lime, "checkBlack2x.png", "closeWhite1x.png");
                        frm.BringToFront();
                    }
                    else
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Cảnh báo", "Thêm món ăn không thành công!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                        frm.BringToFront();
                    }
                }
                else
                {
                    if (ma.UpdateMA(txtTenMA.Text, txtAnh.Text, txtMoTa.Text, int.Parse(cboLoai.SelectedValue.ToString()), int.Parse(txtID.Text)))
                    {
                        FrmMonAn_Load(sender, e);
                        alert_success frm = new alert_success();
                        frm.showAlert("Thông báo", "Cập nhật món ăn thành công!", Color.FromArgb(24, 24, 24), Color.Lime, "checkBlack2x.png", "closeWhite1x.png");
                        frm.BringToFront();
                    }
                    else
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Cảnh báo", "Cập nhật món ăn không thành công!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                        frm.BringToFront();
                    }
                }
            }
            else
            {
                alert_success frm = new alert_success();
                frm.showAlert("Cảnh báo", "Vui lòng nhập đầy đủ các thông tin!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                frm.BringToFront();
            }

        }




        private void dgvDSMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label1.Visible = txtID.Visible = true;
                txtTenMA.ReadOnly = txtMoTa.ReadOnly = txtAnh.ReadOnly = true;
                txtID.Text = dgvDSMonAn.CurrentRow.Cells[0].Value.ToString();
                txtTenMA.Text = dgvDSMonAn.CurrentRow.Cells[1].Value.ToString();
                txtAnh.Text = dgvDSMonAn.CurrentRow.Cells[2].Value.ToString();
                txtMoTa.Text = dgvDSMonAn.CurrentRow.Cells[3].Value.ToString();
                pic.ImageLocation = dgvDSMonAn.CurrentRow.Cells[2].Value.ToString();
                cboLoai.SelectedValue = (dgvDSMonAn.CurrentRow.Cells[5].Value.ToString());
            }
            catch { }
        }

        //load ảnh
        private void txtAnh_Leave(object sender, EventArgs e)
        {
            pic.ImageLocation = txtAnh.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenMA.ReadOnly = txtMoTa.ReadOnly = txtAnh.ReadOnly = false;
        }


        //Kiểm tra nhập đầy đủ
        public bool ktNhap()
        {
            if (
               string.IsNullOrWhiteSpace(txtTenMA.Text) ||
               string.IsNullOrWhiteSpace(txtMoTa.Text) ||
                string.IsNullOrWhiteSpace(txtAnh.Text) || cboLoai.SelectedIndex < 0)
                return false;
            return true;
        }
    }
}
