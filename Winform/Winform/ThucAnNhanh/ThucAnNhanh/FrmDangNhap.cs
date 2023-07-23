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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        NhanVienBLL nv = new NhanVienBLL();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                MessageBox.Show("không được bỏ trống mã nhân viên");
                txtID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtMatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống mật khẩu");
                this.txtMatKhau.Focus();
                return;
            }
            int kq = CauHinh.Check_Config(); //hàm Check_Config() thuộc Class QL_NguoiDung
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }

            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }
        public void ProcessLogin()
        {
            int result;
            result = CauHinh.Check_User(txtID.Text, txtMatKhau.Text);
            //Check_User viết trong Class QL_NguoiDung
            // Wrong username or pass
            if (result == 10)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                txtID.ResetText();
                txtMatKhau.ResetText();
                txtMatKhau.Select();
                return;
            }
            // Account had been disabled
            else if (result == 20)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            FrmMain frm = new FrmMain();
            FrmMain.TenDN = txtID.Text;
            //frmNhanVien.MK = txtMK.Text;
            frm.Show();
            this.Hide();

        }
        public void ProcessConfig()
        {
            //frmConfig frm = new frmConfig();
            //frm.Show();
        }

        private void txtMatKhau_IconRightClick(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
