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

namespace ThucAnNhanh
{
    public partial class UC_User : UserControl
    {
        public UC_User()
        {
            InitializeComponent();
        }
        NhanVienBLL nv = new NhanVienBLL();
        PhanCongBLL pc = new PhanCongBLL();
        private void UC_User_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in nv.GetNhanVienTheoMaNV(FrmMain.TenDN).Rows)
            {
                txtID.Text = dr["ID"].ToString();
                txtHoTen.Text = dr["TenNV"].ToString();
                dateNgaySinh.Text = dr["NgaySinh"].ToString();
                cboGioiTinh.SelectedItem = dr["GioiTinh"].ToString();
                txtDiaChi.Text = dr["DiaChi"].ToString();
                txtSDT.Text = dr["SDT"].ToString();
                txtCMT.Text = dr["CMT"].ToString();
                ptAnh.ImageLocation = (dr["Anh"].ToString());
                dateNgayVL.Text = dr["NgayVL"].ToString();

            }
            if(pc.kiemTraDiemDanh(FrmMain.TenDN, timCaLam(), DateTime.Today.ToShortDateString()) > 0)
            {
                btnDiemDanh.FillColor = Color.LightCyan;
                btnDiemDanh.FillColor2 = Color.LightCyan;
                btnDiemDanh.Text = "Đã điểm danh";
            }    
        }

        private void btnSuaMatKhau_Click(object sender, EventArgs e)
        {
            pnEdit.Visible = true;
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (txtConfirm.Text == string.Empty)
            {
                lblError.Text = "Vui lòng nhập mật khẩu mới!";
                txtConfirm.Focus();
                return;
            }
            if ((txtConfirm.Text) != (txtNew.Text))
            {
                lblErrorConfirm.Text = "Vui lòng nhập lại mật khẩu khớp với mật khẩu mới!";
                // MessageBox.Show("Confirm password not matching with new passsword");
                txtConfirm.Focus();
                return;

            }
            else
            {
                txtConfirm.Text = string.Empty;
            }
        }



        //Tìm ca làm hiện tại
        public int timCaLam()
        {
            if (DateTime.Now.Hour > 6 && DateTime.Now.Hour < 13)
            {
                return 1;
            }
            else if (DateTime.Now.Hour < 18)
            {
                return 2;
            }
            else if (DateTime.Now.Hour < 22)
            {
                return 3;
            }
            return 0;
        }
        /// Tính giờ làm
        /// 
        public string tinhGioLam()
        {
            if (timCaLam() == 1)
            {
                if (DateTime.Now.Hour < 8 || (DateTime.Now.Hour == 8 && DateTime.Now.Minute == 0))
                {

                    return "Đi làm đúng giờ";
                }
                else if (DateTime.Now.Hour >= 8 && DateTime.Now.Minute > 0)
                {
                    return "Đi làm trễ " + (DateTime.Now.Hour - 8) + ":" + DateTime.Now.Minute + "'";
                }
            }
            if (timCaLam() == 2)
            {
                if (DateTime.Now.Hour < 13 || (DateTime.Now.Hour == 3 && DateTime.Now.Minute == 0))
                {

                    return "Đi làm đúng giờ";
                }
                else if (DateTime.Now.Hour >= 13 && DateTime.Now.Minute > 0)
                {
                    return "Đi làm trễ " + (DateTime.Now.Hour - 13) + ":" + DateTime.Now.Minute + "'";
                }
            }
            if (timCaLam() == 3)
            {
                if (DateTime.Now.Hour < 18 || (DateTime.Now.Hour == 18 && DateTime.Now.Minute == 0))
                {

                    return "Đi làm đúng giờ";
                }
                else if (DateTime.Now.Hour >= 18 && DateTime.Now.Minute > 0)
                {
                    return "Đi làm trễ " + (DateTime.Now.Hour - 18) + ":" + DateTime.Now.Minute + "'";
                }
            }
            return string.Empty;
        }


        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            if (timCaLam() == 0)
            {
                alert_success frm = new alert_success();
                frm.showAlert("Cảnh báo", "Hiện tại đang ngoài giờ làm việc!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                frm.BringToFront();
            }
            else
            {


                if (pc.KTKC(FrmMain.TenDN, DateTime.Parse(DateTime.Today.ToShortDateString()), timCaLam()) > 0)
                {

                    if (pc.updateDiemDanh(tinhGioLam(), FrmMain.TenDN, 1, DateTime.Today.ToShortDateString()))
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Thông báo", "Điểm danh thành công!", Color.White, Color.FromArgb(51, 105, 30), "checkWhite2x.png", "closeWhite1x.png");
                        frm.BringToFront();



                    }
                    else
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Cảnh báo", "Điểm danh thất bại!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                        frm.BringToFront();
                    }

                }
                else
                {
                    alert_success frm = new alert_success();
                    frm.showAlert("Cảnh báo", "Bạn không có lịch cho ca làm này!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                    frm.BringToFront();
                }
            }
        }

      

       
        //Mật khẩu tối thiểu tám ký tự, ít nhất một chữ cái, một số và một ký tự đặc biệt

        private void txtNew_Leave(object sender, EventArgs e)
        {
            string strRegex = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(txtNew.Text))
            {
                txtNew.ForeColor = Color.Black;
                 lblError.Text = string.Empty;
            }
            else
            {              
                lblError.Text = "Mật khẩu tối thiểu tám ký tự, ít nhất một chữ cái, một số và một ký tự đặc biệt!";
                txtNew.ForeColor = Color.Red;
                txtNew.Focus();

            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if(nv.UpdateMK(txtNew.Text, FrmMain.TenDN))
            {
                alert_success frm = new alert_success();
                frm.showAlert("Thông báo", "Đổi mật khẩu thành công!", Color.White, Color.FromArgb(51, 105, 30), "checkWhite2x.png", "closeWhite1x.png");
                frm.BringToFront();
            }
            else
            {
                alert_success frm = new alert_success();
                frm.showAlert("Cảnh báo", "Đổi mật khẩu chưa thành công!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                frm.BringToFront();
            } 
                
        }

     
    }
}
