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
using ThucAnNhanh.KhachHang;
using ThucAnNhanh.MonAn;
using ThucAnNhanh.NguyenLieu;
using ThucAnNhanh.NhanVien;
using ThucAnNhanh.NhapHang;
using ThucAnNhanh.NhapXuat;
using ThucAnNhanh.ThongKe;
using ThucAnNhanh.XepLich;

namespace ThucAnNhanh
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }
        public static string TenDN = string.Empty;
        PhanQuyenBLL pqnv = new PhanQuyenBLL();
        NhanVienBLL nv = new NhanVienBLL();
        NhomNhanVienBLL nnv = new NhomNhanVienBLL();
        LoaiNhanVienBLL lnv = new LoaiNhanVienBLL();
        List<Guna2Button> list = new List<Guna2Button>();


        //public void customizeDesign()
        //{
        //    panelSubThucDon.Visible = false;
        //    panelSubNguyenLieu.Visible = false;

        //}
        private void hideSubMenu()
        {
            if (panelSubNguyenLieu.Visible == true)
            {
                panelSubNguyenLieu.Visible = false;             
            }
            if (panelSubNhanSu.Visible == true)
            {
                panelSubNhanSu.Visible = false;
            }
            if (panelSubThucDon.Visible == true)
            {
                panelSubThucDon.Visible = false;
            }    
           
            if (panelSubVoucher.Visible == true)
            {
                panelSubVoucher.Visible = false;
            }    
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }


      

       

        private void picUser_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_User uc = new UC_User();
            panel2.Controls.Add(uc);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            int nhomNV = nnv.timLoaiNV(TenDN);
            list.Add(btnMHChinh);
            list.Add(btnNhanVien);
            list.Add(btnDSNhanVien);
            list.Add(btnXepLich);
            list.Add(btnKhachHang);
            list.Add(btnNhapXuat);
            list.Add(btnNhapHang);
            list.Add(btnThucDon);
            list.Add(btnDSMonAn);
            list.Add(btnBangGia);
            list.Add(btnDSNguyenLieu);
            list.Add(btnDinhLuong);           
            list.Add(btnThongKe);
            list.Add(btnDangXuat);
            foreach (Guna2Button item in list)
            {
                if (item.Tag != null)
                {
                    int mh = int.Parse(item.Tag.ToString());
                    if (pqnv.kiemTraQuyen(nhomNV, mh) == 1)
                    {
                        item.Visible = true;
                    }
                    else
                    {
                        item.Visible = false;
                    }
                }
            }
            foreach (DataRow dr in nv.GetNhanVienTheoMaNV(TenDN).Rows)
            {
                string tenLoai = lnv.layTenLoaiNV(nhomNV);

                picUser.ImageLocation = dr["Anh"].ToString();
                lblTenNV.Text = dr["TenNV"].ToString();
                lblChucVu.Text = tenLoai;
            }               

         }

        private void btnMHChinh_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            panel2.Controls.Clear();
            UC_Home uc = new UC_Home();
            panel2.Controls.Add(uc);
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubThucDon);
        }

        private void btnDSMonAn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            FrmMonAn frm = new FrmMonAn();
            frm.Show();
            //panel2.Controls.Clear();
            //UC_DSMonAn uc = new UC_DSMonAn();
            //panel2.Controls.Add(uc);
        }

        private void btnBangGia_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            panel2.Controls.Clear();
            UC_GiaMonAn uc = new UC_GiaMonAn();
            panel2.Controls.Add(uc);
        }

       

        private void btnDSNguyenLieu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            FrmNguyenLieu frm = new FrmNguyenLieu();
            frm.Show();
        }
        

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubNhanSu);
        }


        private void btnDSNhanVien_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //panel2.Controls.Clear();
            //UC_DSNhanVien uc = new UC_DSNhanVien();
            //panel2.Controls.Add(uc);
            FrmNhanVien frm = new FrmNhanVien();
            frm.Show();
        }

        private void btnXepLich_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            panel2.Controls.Clear();
            //UC_XepLichLamViec uc = new UC_XepLichLamViec();
            UC_XepLich uc = new UC_XepLich();
            panel2.Controls.Add(uc);
        }

      

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //UC_DSKhachHang uc = new UC_DSKhachHang();
            //panel2.Controls.Add(uc);
            FrmKhachHang frm = new FrmKhachHang();
            frm.Show();
        }

        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            FrmNhapXuat frm = new FrmNhapXuat();
            frm.Show();
        }      

        
        private void btnDinhLuong_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubVoucher);
        }

        private void btnDSVoucher_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnLichSuDoi_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

       
       

        
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDangNhap frm2 = new FrmDangNhap();
            frm2.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            FrmNhapHang frm = new FrmNhapHang();
            frm.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_ThongKe uc = new UC_ThongKe();
            panel2.Controls.Add(uc);
        }
    }
}
