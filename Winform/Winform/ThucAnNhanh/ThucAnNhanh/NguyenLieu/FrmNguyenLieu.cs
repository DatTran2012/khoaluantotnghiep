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

namespace ThucAnNhanh.NguyenLieu
{
    public partial class FrmNguyenLieu : Form
    {
        public FrmNguyenLieu()
        {
            InitializeComponent();
        }
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        NguyenLieuBLL nl = new NguyenLieuBLL();
        private void FrmNguyenLieu_Load(object sender, EventArgs e)
        {
            dgvDSNguyenLieu.DataSource = nl.GetData();
            int record = int.Parse(dgvDSNguyenLieu.RowCount.ToString()) - 1;
            lblRecord.Text = "Số lượng: " + record;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtTimKiem.Text.Trim().Length > 0)
                {
                    dgvDSNguyenLieu.DataSource = CauHinh.Search2(txtTimKiem.Text, "NguyenLieu", "TenNguyenLieu");
                    int filter = int.Parse(CauHinh.Search2(txtTimKiem.Text, "NguyenLieu", "TenNguyenLieu").Rows.Count.ToString());
                    lblFilter.Text = "Lọc: " + filter;
                    //cboLoaiMonAn.SelectedValue = int.Parse(dgvDSMonAn.CurrentRow.Cells[5].Value.ToString());

                }
                else
                {
                    dgvDSNguyenLieu.DataSource = CauHinh.Search2(txtTimKiem.Text, "NguyenLieu", "TenNguyenLieu");
                    int filter = int.Parse(CauHinh.Search2(txtTimKiem.Text, "NguyenLieu", "TenNguyenLieu").Rows.Count.ToString());
                    lblFilter.Text = "Loc: 0";
                }
            }
            catch

            {
                MessageBox.Show("...");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            label1.Visible = txtID.Visible = false;
            label3.Visible = txtSLTon.Visible = false;
           txtID.Text = txtTenNL.Text = txtDVT.Text = txtSLTon.Text = string.Empty;
            txtTenNL.ReadOnly = txtDVT.ReadOnly = txtSLTon.ReadOnly = false;
        }

        private void dgvDSNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label1.Visible = txtID.Visible = true;
                label3.Visible = txtSLTon.Visible = true;
                txtTenNL.ReadOnly = txtDVT.ReadOnly = txtSLTon.ReadOnly = true;
                txtID.Text = dgvDSNguyenLieu.CurrentRow.Cells[0].Value.ToString();
                txtTenNL.Text = dgvDSNguyenLieu.CurrentRow.Cells[1].Value.ToString();
                txtDVT.Text = dgvDSNguyenLieu.CurrentRow.Cells[2].Value.ToString();
                txtSLTon.Text = dgvDSNguyenLieu.CurrentRow.Cells[3].Value.ToString();
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenNL.ReadOnly = txtDVT.ReadOnly = txtSLTon.ReadOnly = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                if (ktNhap())

                {
                    if (nl.InsertNL(txtTenNL.Text, txtDVT.Text))
                    {
                        FrmNguyenLieu_Load(sender, e);
                        alert_success frm = new alert_success();
                        frm.showAlert("Thông báo", "Thêm nguyên liệu thành công!", Color.FromArgb(24, 24, 24), Color.Lime, "checkBlack2x.png", "closeWhite1x.png");
                        frm.BringToFront();
                    }
                    else
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Cảnh báo", "Thêm nguyên liệu không thành công", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                        frm.BringToFront();
                    }
                }

                else
                {
                    alert_success frm = new alert_success();
                    frm.showAlert("Cảnh báo", "Vui lòng nhập đầy đủ các trường!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                    frm.BringToFront();
                }
            }
            else
            {
                if (ktNhap())
                {
                    if (nl.UpdateNL(txtTenNL.Text, txtDVT.Text, int.Parse(txtID.Text)))
                    {
                        FrmNguyenLieu_Load(sender, e);
                        alert_success frm = new alert_success();
                        frm.showAlert("Thông báo", "Cập nhật khách hàng thành công!", Color.FromArgb(24, 24, 24), Color.Lime, "checkBlack2x.png", "closeWhite1x.png");
                        frm.BringToFront();
                    }
                    else
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Cảnh báo", "Cập nhật khách hàng không thành công", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                        frm.BringToFront();
                    }
                }
                else
                {
                    alert_success frm = new alert_success();
                    frm.showAlert("Cảnh báo", "Vui lòng nhập đầy đủ các trường!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                    frm.BringToFront();
                }

            }
        }
        //Kiểm tra nhập đầy đủ
        public bool ktNhap()
        {
            if (
               string.IsNullOrWhiteSpace(txtTenNL.Text) ||
               string.IsNullOrWhiteSpace(txtDVT.Text)
                )
                return false;
            return true;
        }
    }
}
