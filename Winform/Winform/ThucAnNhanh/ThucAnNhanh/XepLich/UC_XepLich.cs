using BLL;
using Guna.UI2.WinForms;
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

namespace ThucAnNhanh.XepLich
{
    public partial class UC_XepLich : UserControl
    {
        public UC_XepLich()
        {
            InitializeComponent();
        }
        PhanCongBLL pc = new PhanCongBLL();
        NhomNhanVienBLL nnv = new NhomNhanVienBLL();
        NhanVienBLL nv = new NhanVienBLL();
        private void dateNgayLam_ValueChanged(object sender, EventArgs e)
        {
            dgvPhanCong.DataSource = pc.GetDataTheoNgay(DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()));

        }

        private void cboCaLam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPhanCong.DataSource = pc.GetDataTheoCa(int.Parse(cboCaLam.SelectedItem.ToString().Substring(3)), DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()));
            lblQuanLy.Text = demSL(1).ToString();
            lblThuNgan.Text = demSL(2).ToString();
            lblOrder.Text = demSL(3).ToString();
            lblCheBien.Text = demSL(4).ToString();
            ktSL();

        }

        public int demSL(int loainv)
        {
            int dem = 0;
            for (int i = 0; i < dgvPhanCong.Rows.Count; i++)
            {
                int lnv = nnv.timLoaiNV(dgvPhanCong.Rows[i].Cells[0].Value.ToString());
                if (lnv == loainv)
                    dem++;
            }
            return dem;
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (sl(1,1))
            {
                if (pc.KTKC(cboQuanLy.SelectedValue.ToString(), DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()), cboCaLam.SelectedIndex + 1) == 0)
                {
                    if (pc.insertPhanCong(cboQuanLy.SelectedValue.ToString(), cboCaLam.SelectedIndex + 1, DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()), "Chưa điểm danh"))
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Thông báo", "Xếp lịch thành công!", Color.White, Color.FromArgb(51, 105, 30), "checkWhite2x.png", "closeWhite1x.png");
                        frm.BringToFront();
                        dgvPhanCong.DataSource = pc.GetDataTheoCa(int.Parse(cboCaLam.SelectedItem.ToString().Substring(3)), DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()));
                        ktSL();
                    }
                }
                else
                {
                    alert_success frm = new alert_success();
                    frm.showAlert("Cảnh báo", "Nhân viên này đã có lịch rồi!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                    frm.BringToFront();
                }
            }
            else
            {
                alert_success frm = new alert_success();
                frm.showAlert("Cảnh báo", "Nhân viên này đã đủ số lượng!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                frm.BringToFront();
            }
        }

        private void UC_XepLich_Load(object sender, EventArgs e)
        {
            loadCbo(cboQuanLy, 1);
            loadCbo(cboThuNgan, 2);
            loadCbo(cboOrder, 3);
            loadCbo(cboCheBien, 4);
            ktSL();

        }
        public void loadCbo(Guna2ComboBox cbo, int lnv)
        {
            cbo.DataSource = nv.GetNhanVienTheoMaLoai(lnv);
            cbo.ValueMember = "ID";
            cbo.DisplayMember = "TenNV";
        }

        private void btnPhanCongTN_Click(object sender, EventArgs e)
        {
            if (sl(2,1))
            {
                if (pc.KTKC(cboThuNgan.SelectedValue.ToString(), DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()), cboCaLam.SelectedIndex + 1) == 0)
                {
                    if (pc.insertPhanCong(cboThuNgan.SelectedValue.ToString(), cboCaLam.SelectedIndex + 1, DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()), "Chưa điểm danh"))
                    {

                        alert_success frm = new alert_success();
                        frm.showAlert("Thông báo", "Xếp lịch thành công!", Color.White, Color.FromArgb(51, 105, 30), "checkWhite2x.png", "closeWhite1x.png");
                        frm.BringToFront();
                        dgvPhanCong.DataSource = pc.GetDataTheoCa(int.Parse(cboCaLam.SelectedItem.ToString().Substring(3)), DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()));
                        ktSL();
                    }
                }
                else
                {
                    alert_success frm = new alert_success();
                    frm.showAlert("Cảnh báo", "Nhân viên này đã có lịch rồi!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                    frm.BringToFront();
                }
            }
            else
            {
                alert_success frm = new alert_success();
                frm.showAlert("Cảnh báo", "Nhân viên này đã đủ số lượng!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                frm.BringToFront();
            }
        }

        private void btnPhanCongCB_Click(object sender, EventArgs e)
        {
            if (sl(4,2) )
            {
                if (pc.KTKC(cboCheBien.SelectedValue.ToString(), DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()), cboCaLam.SelectedIndex + 1) == 0)
                {
                    if (pc.insertPhanCong(cboCheBien.SelectedValue.ToString(), cboCaLam.SelectedIndex + 1, DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()), "Chưa điểm danh"))
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Thông báo", "Xếp lịch thành công!", Color.White, Color.FromArgb(51, 105, 30), "checkWhite2x.png", "closeWhite1x.png");
                        frm.BringToFront();
                        dgvPhanCong.DataSource = pc.GetDataTheoCa(int.Parse(cboCaLam.SelectedItem.ToString().Substring(3)), DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()));
                        ktSL();
                    }
                }
                else
                {
                    alert_success frm = new alert_success();
                    frm.showAlert("Cảnh báo", "Nhân viên này đã có lịch rồi!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                    frm.BringToFront();
                }
            }
            else
            {
                alert_success frm = new alert_success();
                frm.showAlert("Cảnh báo", "Nhân viên này đã đủ số lượng!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                frm.BringToFront();
            }
        }

        private void btnPhanCongOrder_Click(object sender, EventArgs e)
        {
            if (sl(3, 2))
            {
                if (pc.KTKC(cboOrder.SelectedValue.ToString(), DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()), cboCaLam.SelectedIndex + 1) == 0)
                {
                    if (pc.insertPhanCong(cboOrder.SelectedValue.ToString(), cboCaLam.SelectedIndex + 1, DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()), "Chưa điểm danh"))
                    {
                        alert_success frm = new alert_success();
                        frm.BringToFront();
                        frm.showAlert("Thông báo", "Xếp lịch thành công!", Color.White, Color.FromArgb(51, 105, 30), "checkWhite2x.png", "closeWhite1x.png");
                        dgvPhanCong.DataSource = pc.GetDataTheoCa(int.Parse(cboCaLam.SelectedItem.ToString().Substring(3)), DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()));
                        ktSL();
                    }
                }
                else
                {
                    alert_success frm = new alert_success();
                    frm.showAlert("Cảnh báo", "Nhân viên này đã có lịch rồi!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                    frm.BringToFront();
                }
            }else
            {
                alert_success frm = new alert_success();
                frm.showAlert("Cảnh báo", "Nhân viên này đã đủ số lượng!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                frm.BringToFront();
            }    
        }
        public void ktSL()
        {           
                lblQuanLyThieu.Text = (1 - demSL(1)).ToString();     
                lblThuNganThieu.Text = (1 - demSL(2)).ToString();
                lblOrderThieu.Text = (2 - demSL(3)).ToString();
                lblCheBienThieu.Text = (2  - demSL(4)).ToString();
        }

        public bool sl(int idlnv, int sl)
        {
            if (demSL(idlnv) == sl)
                
                return false;
                
            
            return true;
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (pc.deletePhanCong(dgvPhanCong.CurrentRow.Cells[0].Value.ToString(), int.Parse(dgvPhanCong.CurrentRow.Cells[1].Value.ToString()), dgvPhanCong.CurrentRow.Cells[2].Value.ToString()))
            {
                alert_success frm = new alert_success();
                frm.BringToFront();
                frm.showAlert("Thông báo", "Xóa lịch thành công!", Color.White, Color.FromArgb(51, 105, 30), "checkWhite2x.png", "closeWhite1x.png");
                dgvPhanCong.DataSource = pc.GetDataTheoCa(int.Parse(cboCaLam.SelectedItem.ToString().Substring(3)), DateTime.Parse(DateTime.Parse(dateNgayLam.Text).ToShortDateString()));
                ktSL();
            }
            else
            {
                alert_success frm = new alert_success();
                frm.showAlert("Cảnh báo", "Xóa lịch thất bại!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                frm.BringToFront();
            }
        }
    }
}
