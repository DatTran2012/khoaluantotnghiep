using BLL;
using Guna.UI2.WinForms;
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
using ThucAnNhanh.KhachHang;
using ThucAnNhanh.message_alert;
using ThucAnNhanh.Reports;

namespace ThucAnNhanh
{
    public partial class UC_ThanhToan : UserControl
    {
        public UC_ThanhToan()
        {
            InitializeComponent();
        }
        MonAnBLL ma = new MonAnBLL();
        HoaDonBLL hd = new HoaDonBLL();
        ChiTietHoaDonBLL cthd = new ChiTietHoaDonBLL();
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        KhachHangBLL kh = new KhachHangBLL();
        BanAnBLL ba = new BanAnBLL();

        private void UC_ThanhToan_Load(object sender, EventArgs e)
        {
            try
            {
                CauHinh.moKetNoi();
                string doc = "select ID_BanAn, ID from HoaDon where TinhTrang = N'Yêu cầu thanh toán'";
                SqlCommand cmd1 = new SqlCommand(doc, CauHinh.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    Guna2GradientTileButton btn = new Guna2GradientTileButton
                    {
                        Text = rd["ID_BanAn"].ToString(),
                        Tag = rd["ID"].ToString(),
                        ForeColor = Color.Black,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        BackColor = Color.Transparent,
                        FillColor = Color.White,
                        FillColor2 = Color.White,
                        BorderRadius = 30,
                        Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\table.png"),
                        ImageOffset = new Point(0, 15),
                        ImageSize = new Size(40, 40),                        
                    };
                    string ten = btn.Text;
                    int w = (flowLayoutPanel1.Size.Width - 70) / 4;
                    btn.Size = new Size(w, w);
                    btn.Click += Btn_Click;
                    this.flowLayoutPanel1.Controls.Add(btn);
                }
                CauHinh.dongKetNoi();
            }
            catch
            { }

        }

        public void tinhTien()
        {
            long tongTienGoc = CauHinh.tinhTongTien(dgvCTHD,4);
            lblTongTien.Text = string.Format("{0:0,0}", decimal.Parse(tongTienGoc.ToString()));
            lblThanhToan.Text = tongTienGoc.ToString();

        }
        int idHD;
        int idBan;
        private void Btn_Click(object sender, EventArgs e)
        {
            Guna2GradientTileButton uc = sender as Guna2GradientTileButton;
            idHD = int.Parse((string)uc.Tag);
            //idHD = hd.TimMaHD(int.Parse(uc.Text));
            idBan = int.Parse(uc.Text);
            dgvCTHD.DataSource = cthd.LoadTheoMaHD(idHD);
            tinhTien();
        }

        public void Alert(string msg, string content, Color foreColor, Color backcolor, string icon, string iconImage)
        {
            alert_success frm = new alert_success();
            frm.showAlert(msg, content, foreColor, backcolor, icon, iconImage);
        }
     
        int IDKH = 0;
     

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int IDKH = FrmTimKH.IDKH;
            MessageBox.Show(IDKH.ToString());
        }

       

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text != string.Empty)
            {
                foreach (DataRow dr in kh.TimKHTheoSDT(txtSDT.Text).Rows)
                {
                    if (kh.TimKHTheoSDT(txtSDT.Text).Rows.Count == 1)
                    {
                        IDKH = int.Parse(dr["ID"].ToString());
                        lblTenKH.Text = dr["TenKH"].ToString();
                        lblDiemTichLuy.Text = dr["DiemTichLuy"].ToString();
                    }
                    else
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Cảnh báo", "Không tìm thấy SĐT của khách hàng này!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                        frm.BringToFront();
                        txtSDT.Focus();
                    }
                }
            }
            else
            {
                lblTenKH.Text = lblDiemTichLuy.Text = string.Empty;
                alert_success frm = new alert_success();
                frm.showAlert("Cảnh báo", "Không tìm thấy SĐT của khách hàng này!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                frm.BringToFront();
                txtSDT.Focus();
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            FrmTimKH frm = new FrmTimKH();
            frm.Show();
            IDKH = FrmTimKH.IDKH;
            MessageBox.Show(IDKH.ToString());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(idHD.ToString());
            if (lblTenKH.Text.Length > 0)
            {
                if (hd.UpdateTTTT(IDKH, "Đã thanh toán", idHD))
                {
                    if (ba.updateTTBan(idBan))
                    {
                        FrmRPHoaDon.MaHD = idHD;
                        FrmRPHoaDon frm2 = new FrmRPHoaDon();
                        frm2.Show();
                        frm2.BringToFront();
                        dgvCTHD.DataSource = null;
                        
                        UC_ThanhToan_Load(sender, e);
                        alert_success frm = new alert_success();
                        frm.showAlert("Thông báo", "Thanh toán thành công!", Color.FromArgb(24, 24, 24), Color.Lime, "checkBlack2x.png", "closeWhite1x.png");
                        frm.BringToFront();
                    }
                }
                else
                {

                    alert_success frm = new alert_success();
                    frm.showAlert("Cảnh báo", "Thanh toán thất bại!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                    frm.BringToFront();
                }
            }
            else
            {

                if (hd.UpdateTTTT(0, "Đã thanh toán", idHD))
                {
                    if (ba.updateTTBan(idBan))
                    {
                        FrmRPHoaDon.MaHD = idHD;
                        FrmRPHoaDon frm2 = new FrmRPHoaDon();
                        frm2.Show();
                        frm2.BringToFront();
                        dgvCTHD.DataSource = null;
                        UC_ThanhToan_Load(sender, e);
                        alert_success frm = new alert_success();
                        frm.showAlert("Thông báo", "Thanh toán thành công!", Color.FromArgb(24, 24, 24), Color.Lime, "checkBlack2x.png", "closeWhite1x.png");
                        frm.BringToFront();
                    }
                }
                else
                {

                    alert_success frm = new alert_success();
                    frm.showAlert("Cảnh báo", "Thanh toán thất bại!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                    frm.BringToFront();
                }
            }
        }

        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTienNhan.Text != string.Empty)
                {
                    lblConLai.Text = string.Format("{0:0,0}", decimal.Parse((float.Parse(txtTienNhan.Text) - CauHinh.tinhTongTien(dgvCTHD, 4)).ToString()));
                }
                else
                {
                    lblConLai.Text = string.Empty;
                }
            }
            catch { }
        }
    }
}
