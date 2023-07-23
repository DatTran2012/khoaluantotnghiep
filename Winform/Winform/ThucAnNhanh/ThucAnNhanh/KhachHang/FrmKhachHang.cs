using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucAnNhanh.message_alert;

namespace ThucAnNhanh.KhachHang
{
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        KhachHangBLL kh = new KhachHangBLL();
        QL_NguoiDung CauHinh = new QL_NguoiDung();

       
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

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            dgvDSKhachHang.DataSource = kh.GetData();
            int record = int.Parse(dgvDSKhachHang.RowCount.ToString()) - 1;
            lblRecord.Text = "Số lượng: " + record;

        }
        string gioitinh;
        private void dgvDSKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label1.Visible = label7.Visible = txtID.Visible = txtDiemTL.Visible = true;
                txtTenKH.ReadOnly = txtDiemTL.ReadOnly = txtDiaChi.ReadOnly = txtSDT.ReadOnly = txtEmail.ReadOnly = true;
                dateNgaySinh.Enabled = false;
                txtID.Text = dgvDSKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtTenKH.Text = dgvDSKhachHang.CurrentRow.Cells[1].Value.ToString();
                dateNgaySinh.Text = dgvDSKhachHang.CurrentRow.Cells[3].Value.ToString();
                if (dgvDSKhachHang.CurrentRow.Cells[2].Value.ToString() == "Nam")
                {
                    rdbNam.Checked = true;
                    gioitinh = rdbNam.Text;
                }
                else
                {
                    rdbNu.Checked = true;
                    gioitinh = rdbNu.Text;
                }
                txtDiaChi.Text = dgvDSKhachHang.CurrentRow.Cells[4].Value.ToString();
                txtSDT.Text = dgvDSKhachHang.CurrentRow.Cells[5].Value.ToString();
                txtDiemTL.Text = dgvDSKhachHang.CurrentRow.Cells[6].Value.ToString();
                txtEmail.Text = dgvDSKhachHang.CurrentRow.Cells[7].Value.ToString();



            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            label1.Visible = label7.Visible = txtID.Visible = txtDiemTL.Visible = false;
            txtID.Text = txtTenKH.Text = txtDiaChi.Text = txtSDT.Text = txtDiemTL.Text = txtEmail.Text = string.Empty;
            txtTenKH.ReadOnly = txtDiemTL.ReadOnly = txtDiaChi.ReadOnly = txtSDT.ReadOnly = txtEmail.ReadOnly = false;
            dateNgaySinh.Text = DateTime.Today.ToShortDateString();
            dateNgaySinh.Enabled = true;
            txtTenKH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                if (ktNhap())

                {
                    if (gioitinh != string.Empty)
                    {
                        if (txtSDT.Text.Length == 10)
                        {
                            if (kh.InsertKH(txtTenKH.Text, gioitinh, dateNgaySinh.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, txtSDT.Text))
                            {
                                FrmKhachHang_Load(sender, e);
                                alert_success frm = new alert_success();
                                frm.showAlert("Thông báo", "Thêm khách hàng thành công!", Color.FromArgb(24, 24, 24), Color.Lime, "checkBlack2x.png", "closeWhite1x.png");
                                frm.BringToFront();
                            }
                            else
                            {
                                alert_success frm = new alert_success();
                                frm.showAlert("Cảnh báo", "Thêm khách hàng không thành công", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                                frm.BringToFront();
                            }
                        }
                        else
                        {
                            alert_success frm = new alert_success();
                            frm.showAlert("Cảnh báo", "Vui lòng nhập số điện thoại gồm 10 ký số!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                            frm.BringToFront();
                        }
                    }
                    else
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Cảnh báo", "Vui lòng chọn giới tính!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
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
                    if (gioitinh != string.Empty)
                    {
                        if (txtSDT.Text.Length == 10)
                        {
                            if (kh.UpdateKH(txtTenKH.Text, gioitinh, dateNgaySinh.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, int.Parse(txtID.Text)))
                            {
                                FrmKhachHang_Load(sender, e);
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
                            frm.showAlert("Cảnh báo", "Vui lòng nhập số điện thoại gồm 10 ký số!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                            frm.BringToFront();
                        }
                    }
                    else
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Cảnh báo", "Vui lòng chọn giới tính!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
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

        //kiểm tra nhập
        public bool ktNhap()
        {
            if (
               string.IsNullOrWhiteSpace(txtTenKH.Text) ||
               string.IsNullOrWhiteSpace(dateNgaySinh.Text) ||
               string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
               string.IsNullOrWhiteSpace(txtSDT.Text)||
               string.IsNullOrWhiteSpace(gioitinh)
              )
                return false;
            return true;
        }

        //chỉ nhập số
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenKH.ReadOnly = txtDiaChi.ReadOnly = txtSDT.ReadOnly = txtEmail.ReadOnly = false;
            dateNgaySinh.Enabled = true;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
        @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
        @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(txtEmail.Text))
            {
                txtEmail.ForeColor = Color.Black;
              
            }
            else
            {
                txtEmail.PlaceholderText = "Vui lòng nhập đúng định dạng email. Ví dụ: photo@gmail.com";
              txtEmail.Focus();
            }
        }
        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                gioitinh = radio.Text;
            }
        }

     
    }
}