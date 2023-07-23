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
using ThucAnNhanh.message_alert;
using ThucAnNhanh.Reports;

namespace ThucAnNhanh.Order
{
    public partial class FrmOrderNow : Form
    {
        public FrmOrderNow()
        {
            InitializeComponent();
            list = new List<DonOrder>();
        }

        MonAnBLL ma = new MonAnBLL();
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        HoaDonBLL hd = new HoaDonBLL();
        ChiTietHoaDonBLL cthd = new ChiTietHoaDonBLL();
        KhachHangBLL kh = new KhachHangBLL();
        BangGiaBLL bg = new BangGiaBLL();
        NhanVienBLL nv = new NhanVienBLL();
        BannerBLL bn = new BannerBLL();
        ThanhPhanMonAnBLL tpma = new ThanhPhanMonAnBLL();
        NguyenLieuBLL nl = new NguyenLieuBLL();

        /// <summary>
        /// Khai báo biến
        /// </summary>
        /// 
        List<DonOrder> list; //list tạm để order
        int slfirst = 1; //số lượng đầu tiên khi chọn 1 món ăn
        int index = -1;
        int slm = 0; //số lượng mới
        long ttm = 0; //thành tiền mới
        private int imageNumber = 1; // slider
        int IDKH = 0;

        //Load catagory món
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            flowListMonAn.Controls.Clear();
            try
            {
                CauHinh.moKetNoi();
                string doc = "SELECT ID, TenMA, Anh, MoTa, TinhTrang, ID_LoaiMA, GiaBan, GiaKhuyenMai FROM dbo.MonAn";
                SqlCommand cmd1 = new SqlCommand(doc, CauHinh.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    string hinh = rd["Anh"].ToString();
                    UC_ItemMenu uc = new UC_ItemMenu
                    {
                        ten = rd["TenMA"].ToString(),
                        giaban = long.Parse(rd["GiaBan"].ToString()),
                        giakm = long.Parse(rd["GiaKhuyenMai"].ToString()),
                        img = rd["Anh"].ToString(),
                        id = int.Parse(rd["ID"].ToString())
                    };

                    int w = (flowListMonAn.Size.Width - 40) / 3;
                    uc.Size = new Size(w, 125);
                    uc.Click += Uc_Click;
                    this.flowListMonAn.Controls.Add(uc);
                }
                CauHinh.dongKetNoi();
            }
            catch
            { }
        }

        private void btnCataGa_Click(object sender, EventArgs e)
        {
            flowListMonAn.Controls.Clear();
            try
            {
                CauHinh.moKetNoi();
                string doc = "select * from MonAn where ID_LoaiMA = 1";
                SqlCommand cmd1 = new SqlCommand(doc, CauHinh.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    string hinh = rd["Anh"].ToString();
                    UC_ItemMenu uc = new UC_ItemMenu
                    {
                        ten = rd["TenMA"].ToString(),
                        giaban = long.Parse(rd["GiaBan"].ToString()),
                        giakm = long.Parse(rd["GiaKhuyenMai"].ToString()),
                        img = rd["Anh"].ToString(),
                        id = int.Parse(rd["ID"].ToString())
                    };

                    int w = (flowListMonAn.Size.Width - 40) / 3;
                    uc.Size = new Size(w, 125);
                    uc.Click += Uc_Click;
                    this.flowListMonAn.Controls.Add(uc);
                }
                CauHinh.dongKetNoi();
            }
            catch
            { }
        }

        private void btnCataBurger_Click(object sender, EventArgs e)
        {
            flowListMonAn.Controls.Clear();
            try
            {
                CauHinh.moKetNoi();
                string doc = "select * from MonAn where ID_LoaiMA = 2";
                SqlCommand cmd1 = new SqlCommand(doc, CauHinh.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    string hinh = rd["Anh"].ToString();
                    UC_ItemMenu uc = new UC_ItemMenu
                    {
                        ten = rd["TenMA"].ToString(),
                        giaban = long.Parse(rd["GiaBan"].ToString()),
                        giakm = long.Parse(rd["GiaKhuyenMai"].ToString()),
                        img = rd["Anh"].ToString(),
                        id = int.Parse(rd["ID"].ToString())
                    };

                    int w = (flowListMonAn.Size.Width - 40) / 3;
                    uc.Size = new Size(w, 125);
                    uc.Click += Uc_Click;
                    this.flowListMonAn.Controls.Add(uc);
                }
                CauHinh.dongKetNoi();
            }
            catch
            { }
        }

        private void btnCataCombo_Click(object sender, EventArgs e)
        {
            flowListMonAn.Controls.Clear();
            try
            {
                CauHinh.moKetNoi();
                string doc = "select * from MonAn where ID_LoaiMA = 3";
                SqlCommand cmd1 = new SqlCommand(doc, CauHinh.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    string hinh = rd["Anh"].ToString();
                    UC_ItemMenu uc = new UC_ItemMenu
                    {
                        ten = rd["TenMA"].ToString(),
                        giaban = long.Parse(rd["GiaBan"].ToString()),
                        giakm = long.Parse(rd["GiaKhuyenMai"].ToString()),
                        img = rd["Anh"].ToString(),
                        id = int.Parse(rd["ID"].ToString())
                    };

                    int w = (flowListMonAn.Size.Width - 40) / 3;
                    uc.Size = new Size(w, 125);
                    uc.Click += Uc_Click;
                    this.flowListMonAn.Controls.Add(uc);
                }
                CauHinh.dongKetNoi();
            }
            catch
            { }
        }

        private void btnCataAnKem_Click(object sender, EventArgs e)
        {
            flowListMonAn.Controls.Clear();
            try
            {
                CauHinh.moKetNoi();
                string doc = "select * from MonAn where ID_LoaiMA = 4";
                SqlCommand cmd1 = new SqlCommand(doc, CauHinh.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    string hinh = rd["Anh"].ToString();
                    UC_ItemMenu uc = new UC_ItemMenu
                    {
                        ten = rd["TenMA"].ToString(),
                        giaban = long.Parse(rd["GiaBan"].ToString()),
                        giakm = long.Parse(rd["GiaKhuyenMai"].ToString()),
                        img = rd["Anh"].ToString(),
                        id = int.Parse(rd["ID"].ToString())
                    };

                    int w = (flowListMonAn.Size.Width - 40) / 3;
                    uc.Size = new Size(w, 125);
                    uc.Click += Uc_Click;
                    this.flowListMonAn.Controls.Add(uc);
                }
                CauHinh.dongKetNoi();
            }
            catch
            { }
        }


        //Frm Load
        private void FrmOrderNow_Load(object sender, EventArgs e)
        {
            sinhMaHD();
            btnTatCa.PerformClick();
            timer1.Enabled = true;
            timer1.Start();
            lblNgayLap.Text = DateTime.Now.ToString();
            lblNhanVien.Text = nv.layTenNV(FrmMain.TenDN);
            lblTongTien.Text = lblGiamGia.Text = lblThanhToan.Text = txtTienNhan.Text = lblConLai.Text = txtSDT.Text = lblTenKH.Text = lblDiemTichLuy.Text = lblADKhuyenMai.Text = string.Empty;

        }


        /// Click vào 1 món ăn
        private void Uc_Click(object sender, EventArgs e)
        {
            UC_ItemMenu uc = sender as UC_ItemMenu;
            uc.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\checked1.png");
            uc.BorderStyle = BorderStyle.Fixed3D;
            uc.BackgroundImageLayout = ImageLayout.Stretch;

            DonOrder dbh = new DonOrder();
            if (kttrungdgv(uc.id) == 1)
            {
                list.RemoveAt(index);
                dbh.idmon = uc.id;
                dbh.tenmon = uc.ten;
                dbh.sl = slm + 1;
                dbh.giaban = uc.giaban;
                dbh.giakm = uc.giakm;
                dbh.thanhtien = uc.giakm + ttm;
                list.Add(dbh);
                dgvOrder.DataSource = null;
                setupColumDGV();
                dgvOrder.DataSource = list;
                tinhToan();
            }
            else
            {
                dbh.idmon = uc.id;
                dbh.tenmon = uc.ten;
                dbh.sl = slfirst;
                dbh.giaban = uc.giaban;
                dbh.giakm = uc.giakm;
                dbh.thanhtien = uc.giakm * dbh.sl;
                list.Add(dbh);
                dgvOrder.DataSource = null;
                setupColumDGV();
                dgvOrder.DataSource = list;
                tinhToan();
            }
        }



        /// Kiểm tra trùng dgv

        public int kttrungdgv(int masp)
        {
            for (int i = 0; i < dgvOrder.Rows.Count; i++)
            {
                if (masp == int.Parse(dgvOrder.Rows[i].Cells[2].Value.ToString()))
                {
                    index = i;
                    slm = int.Parse(dgvOrder.Rows[i].Cells[6].Value.ToString());
                    ttm = long.Parse(dgvOrder.Rows[i].Cells[7].Value.ToString());
                    return 1;
                }
            }
            return 0;
        }



        /// <summary>
        /// Tạo bảng tạm để order
        /// </summary>
        DataGridViewTextBoxColumn hd1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd3 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd4 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd5 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd6 = new DataGridViewTextBoxColumn();
        DataGridViewButtonColumn hd7 = new DataGridViewButtonColumn();
        DataGridViewButtonColumn hd8 = new DataGridViewButtonColumn();

        private void setupColumDGV()
        {
            dgvOrder.Columns.Clear();
            // Column1
            // 
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hd1.DataPropertyName = "idmon";
            hd1.HeaderText = "Mã món";
            hd1.Name = "Column1";
            hd1.DisplayIndex = 1;
            hd1.Width = 100;
            hd1.ReadOnly = true;
            // 
            // Column2
            // 
            hd2.DataPropertyName = "tenmon";
            hd2.HeaderText = "Tên món";
            hd2.Name = "Column2";
            hd2.DisplayIndex = 2;
            hd2.Width = 250;
            hd2.ReadOnly = true;
            // 
            // Column3
            // 
            hd3.DataPropertyName = "giaban";
            hd3.HeaderText = "Giá gốc";
            hd3.Name = "Column3";
            hd3.DisplayIndex = 3;
            hd3.Width = 200;
            hd3.ReadOnly = true;
            // 
            // Column4
            // 

            hd4.DataPropertyName = "giakm";
            hd4.HeaderText = "Giá bán";
            hd4.Name = "Column4";
            hd4.DisplayIndex = 4;
            hd4.Width = 200;
            hd4.ReadOnly = true;


            // 
            // Column5
            // 
            hd5.DataPropertyName = "sl";
            hd5.HeaderText = "Số Lượng";
            hd5.Name = "Column5";

            hd5.DisplayIndex = 5;
            //hd4.ReadOnly = true;
            hd5.Width = 100;
            // 
            // Column6
            // 
            hd6.DataPropertyName = "thanhtien";
            hd6.HeaderText = "Thành Tiền";
            hd6.Name = "Column6";
            hd6.DisplayIndex = 6;
            //hd6.ReadOnly = true;
            hd6.Width = 200;
            //

            // 
            // Column7
            // 
            hd7.DataPropertyName = "btnTang";
            hd7.HeaderText = "Tăng";
            hd7.Name = "Column7";
            hd7.DisplayIndex = 7;
            hd7.ReadOnly = true;
            hd7.Width = 200;
            hd7.Text = "+";
            hd7.UseColumnTextForButtonValue = true;
            //


            // 
            // Column8
            // 
            hd8.DataPropertyName = "btnGiam";
            hd8.HeaderText = "Giảm";
            hd8.Name = "Column8";
            hd8.DisplayIndex = 8;
            hd8.ReadOnly = true;
            hd8.Width = 200;
            hd8.Text = "-";
            hd8.UseColumnTextForButtonValue = true;

            dgvOrder.Columns.Add(hd1);
            dgvOrder.Columns.Add(hd2);
            dgvOrder.Columns.Add(hd3);
            dgvOrder.Columns.Add(hd4);
            dgvOrder.Columns.Add(hd5);
            dgvOrder.Columns.Add(hd6);
            dgvOrder.Columns.Add(hd7);
            dgvOrder.Columns.Add(hd8);
        }





        /// Sinh mã hóa đơn     
        public void sinhMaHD()
        {
            int hdmax = hd.layMaHDMax();
            lblMaHD.Text = (hdmax + 1).ToString();
        }

        //lblNgayLap hóa đơn
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNgayLap.Text = DateTime.Now.ToString();
        }

        //slider
        string img = string.Empty;
        private void LoadNextImage()
        {
            int imageNumber2 = bn.GetData().Rows.Count + 1;


            if (imageNumber == imageNumber2)
            {
                imageNumber = 1;
            }
            foreach (DataRow dr in bn.GetDataTheoID(imageNumber).Rows)
            {
                img = dr["Description"].ToString();
            }
            slider.ImageLocation = img;
            imageNumber++;
        }
        //    if(imageNumber == 3)
        //        {
        //            imageNumber  = 1;
        //        }
        //slider.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
        //imageNumber++;


        //thời gian slider
        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        // long thanhtoan = 0;
        //các tính toán thành tiền
        public void tinhToan()
        {
            long tongTienGoc = CauHinh.tinhTongTien1(dgvOrder, 4, 6);
            long giamGia = CauHinh.tinhTongTien(dgvOrder, 7);
          //  long xu = long.Parse(lblDiemTichLuy.Text);
            lblTongTien.Text = string.Format("{0:0,0}", decimal.Parse(tongTienGoc.ToString()));
            lblGiamGia.Text = string.Format("{0:0,0}", decimal.Parse((tongTienGoc - giamGia).ToString()));
            
            // thanhtoan = tongTienGoc - giamGia;
            //lblThanhToan.Text = string.Format("{0:0,0}", decimal.Parse(thanhtoan.ToString()));
            lblThanhToan.Text = giamGia.ToString();
        }

        //Tìm khách hàng qua số điện thoại
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text != string.Empty)
            {
                foreach (DataRow dr in kh.TimKHTheoSDT(txtSDT.Text.Trim()).Rows)
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
                        frm.BringToFront();
                        frm.showAlert("Cảnh báo", "Không tìm thấy SĐT của khách hàng này!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
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


        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTienNhan.Text != string.Empty)
                {
                    lblConLai.Text = string.Format("{0:0,0}", decimal.Parse((float.Parse(txtTienNhan.Text) - CauHinh.tinhTongTien(dgvOrder, 7) + float.Parse(lblADKhuyenMai.Text)).ToString()));
                }
                else
                {
                    lblConLai.Text = string.Empty;
                }
            }
            catch { }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // try
            {
                if (dgvOrder.Rows.Count > 0)
                {
                    if (txtSDT.Text.Trim().Length > 0)
                    {
                        if (txtTienNhan.Text.Trim().Length > 0)
                        {
                            if (txtSDT.Text.Length == 10)
                            {
                                if (float.Parse(txtTienNhan.Text) >= float.Parse(lblThanhToan.Text))
                                {
                                    if (hd.insertHD(int.Parse(lblMaHD.Text), DateTime.Now, long.Parse(lblThanhToan.Text), FrmMain.TenDN, 1, 0, "Đã thanh toán"))
                                    {

                                        int flag = 0;
                                        for (int i = 0; i < dgvOrder.RowCount; i++)
                                        {
                                            int idma = int.Parse(dgvOrder.Rows[i].Cells[2].Value.ToString());
                                            int sl = int.Parse(dgvOrder.Rows[i].Cells[6].Value.ToString());
                                            long gb = long.Parse(dgvOrder.Rows[i].Cells[5].Value.ToString());
                                            long tt = long.Parse(dgvOrder.Rows[i].Cells[7].Value.ToString());
                                            if (cthd.insertCTHD(int.Parse(lblMaHD.Text), idma, sl, gb, tt))
                                            {

                                                foreach (DataRow dr in tpma.GetDataByIDMonAn(idma).Rows)
                                                {
                                                    int idnl = int.Parse(dr["ID_NguyenLieu"].ToString());
                                                    int dl = int.Parse(dr["DinhLuong"].ToString());
                                                    if (nl.UpdateSLTon(sl * dl, idnl))
                                                    {
                                                        flag = 1;
                                                    }
                                                }
                                            }
                                        }
                                        if (flag == 1)
                                        {
                                            FrmRPHoaDon.MaHD = int.Parse(lblMaHD.Text);
                                            FrmRPHoaDon frm2 = new FrmRPHoaDon();
                                            frm2.Show();
                                            frm2.BringToFront();

                                            list.Clear();
                                            dgvOrder.DataSource = null;
                                            setupColumDGV();
                                            FrmOrderNow_Load(sender, e);
                                            alert_success frm = new alert_success();
                                            frm.showAlert("Thông báo", "Thanh toán thành công!", Color.FromArgb(24, 24, 24), Color.Lime, "checkBlack2x.png", "closeWhite1x.png");
                                            frm.BringToFront();
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
                                        alert_success frm = new alert_success();
                                        frm.showAlert("Cảnh báo", "Thanh toán thất bại!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                                        frm.BringToFront();
                                    }
                                }
                                else
                                {
                                    alert_success frm = new alert_success();
                                    frm.showAlert("Lưu ý", "Vui lòng nhập tiền lớn hơn tiền cần thanh toán!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                                    frm.BringToFront();
                                }

                            }

                            else
                            {
                                alert_success frm = new alert_success();
                                frm.showAlert("Lưu ý", "Vui lòng nhập SĐT gồm 10 ký số!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                                frm.BringToFront();
                            }
                        }
                        else
                        {
                            alert_success frm = new alert_success();
                            frm.showAlert("Lưu ý", "Vui lòng nhập tiền khách hàng đưa!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                            frm.BringToFront();
                        }
                    }
                    else
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Lưu ý", "Vui lòng nhập SĐT khách hàng!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                        frm.BringToFront();
                        txtSDT.Focus();
                    }
                }
                else
                {
                    alert_success frm = new alert_success();
                    frm.showAlert("Lưu ý", "Vui lòng chọn menu để thanh toán!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                    frm.BringToFront();
                }
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrder.Columns[e.ColumnIndex].Name == "Column7")
            {

                dgvOrder.Rows[e.RowIndex].Cells[6].Value = int.Parse(dgvOrder.Rows[e.RowIndex].Cells[6].Value.ToString()) + 1;
                dgvOrder.Rows[e.RowIndex].Cells[7].Value = long.Parse(dgvOrder.Rows[e.RowIndex].Cells[7].Value.ToString()) + long.Parse(dgvOrder.Rows[e.RowIndex].Cells[5].Value.ToString());
                tinhToan();

            }
            if (dgvOrder.Columns[e.ColumnIndex].Name == "Column8")
            {
                if (int.Parse(dgvOrder.Rows[e.RowIndex].Cells[6].Value.ToString()) > 1)
                {
                    dgvOrder.Rows[e.RowIndex].Cells[6].Value = int.Parse(dgvOrder.Rows[e.RowIndex].Cells[6].Value.ToString()) - 1;
                    dgvOrder.Rows[e.RowIndex].Cells[7].Value = float.Parse(dgvOrder.Rows[e.RowIndex].Cells[7].Value.ToString()) - float.Parse(dgvOrder.Rows[e.RowIndex].Cells[5].Value.ToString());
                    tinhToan();

                }
                else
                {
                    dgvOrder.Rows[e.RowIndex].Cells[6].Value = int.Parse(dgvOrder.Rows[e.RowIndex].Cells[6].Value.ToString());
                }
            }
        }
      public bool ktXu()
        {
            if (chkXu.Checked)
                return true;
            return false;
        }

        //btnIn
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            list.Clear();
            dgvOrder.DataSource = null;
            setupColumDGV();
            FrmOrderNow_Load(sender, e);
        }




        //Chỉ nhập số ở txtSDT, txtTienNhan
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //Kiểm tra nhập đầy đủ
        public bool ktNhap()
        {
            if (string.IsNullOrWhiteSpace(txtSDT.Text) ||
               string.IsNullOrWhiteSpace(txtTienNhan.Text))
                return false;
            return true;
        }

        private void chkXu_CheckedChanged(object sender, EventArgs e)
        {
            lblADKhuyenMai.Text = lblDiemTichLuy.Text;
           long tien = (CauHinh.tinhTongTien1(dgvOrder, 4, 6) - long.Parse(lblADKhuyenMai.Text));
            MessageBox.Show(tien.ToString());
            lblThanhToan.Text = tien.ToString();
        }
    }
}
