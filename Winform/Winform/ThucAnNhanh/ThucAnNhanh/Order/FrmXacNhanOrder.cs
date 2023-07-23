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
    public partial class FrmXacNhanOrder : Form
    {
        public FrmXacNhanOrder()
        {
            InitializeComponent();
        }
        QL_NguoiDung CauHinh = new QL_NguoiDung();

        KhachHangBLL kh = new KhachHangBLL();
        ChiTietOrderBLL cto = new ChiTietOrderBLL();
        OrderBLL od = new OrderBLL();
        HoaDonBLL hd = new HoaDonBLL();
        ChiTietHoaDonBLL cthd = new ChiTietHoaDonBLL();
        ThanhPhanMonAnBLL tpma = new ThanhPhanMonAnBLL();
        NguyenLieuBLL nl = new NguyenLieuBLL();


        int idHD = 0;
        private void FrmXacNhanOrder_Load(object sender, EventArgs e)
        {
            lblIDKhachHang.Text = lblTenKH.Text = lblDiaChi.Text = lblSDT.Text = lblTongTien.Text = string.Empty;
            LoadDonChoXacNhan();
            idHD = sinhMaHD();
            
        }
        public void LoadChiTietOrder(int id)
        {
            dgvCTOrder.DataSource = cto.GetDataByIDOrder(id);
        }
        public void LoadDonChoXacNhan()
        {
            fl.Controls.Clear();
            try
            {
                CauHinh.moKetNoi();
                string doc = "SELECT * FROM dbo.[Order] where TinhTrang = N'Chờ xác nhận'";
                SqlCommand cmd1 = new SqlCommand(doc, CauHinh.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    int dem = 0;
                    int idKH = int.Parse(rd["ID_KhachHang"].ToString());
                    if (idKH > 0)
                    {
                        foreach (DataRow dr2 in kh.GetDataTheoIDKH(idKH).Rows)
                        {
                            if (kh.GetDataTheoIDKH(idKH).Rows.Count == 1)
                            {
                                UC_ItemOrder uc1 = new UC_ItemOrder
                                {
                                    ten = dr2["TenKH"].ToString(),
                                    diachi = dr2["DiaChi"].ToString(),
                                    idorder = int.Parse(rd["ID"].ToString())
                                };
                                int w = (fl.Size.Width - 5);
                                uc1.Size = new Size(w, 80);
                                uc1.Click += Uc_Click;
                                this.fl.Controls.Add(uc1);
                                dem++;
                                
                            }

                        }
                    }
                    if (idKH == 0)
                    {
                        //int idOrder = int.Parse(rd["ID"].ToString());
                        //foreach (DataRow dr3 in od.GetDataTheoIDOrder(idOrder).Rows)
                        //{
                        //    if (od.GetDataTheoIDOrder(idOrder).Rows.Count == 1)
                        //    {
                                UC_ItemOrder uc = new UC_ItemOrder
                                {
                                    ten = rd["TenKH"].ToString(),
                                    diachi = rd["DiaChi"].ToString(),
                                    idorder = int.Parse(rd["ID"].ToString()),
                                };
                                int w = (fl.Size.Width - 5);
                                uc.Size = new Size(w, 70);
                                uc.Click += Uc_Click;
                                this.fl.Controls.Add(uc);
                               
                        //    }

                        //}
                    }
                }
                CauHinh.dongKetNoi();
            }

            catch
            { }
        }
        private void Uc_Click(object sender, EventArgs e)
        {
            UC_ItemOrder uc = sender as UC_ItemOrder;
            LoadChiTietOrder(uc.idorder);
            foreach (DataRow dr in od.GetDataTheoIDOrder(uc.idorder).Rows)
            {
                if (od.GetDataTheoIDOrder(uc.idorder).Rows.Count == 1)
                {

                    lblTongTien.Text = dr["TongTien"].ToString();
                    //int idOrder = int.Parse(dr["ID"].ToString());
                    int idKH = int.Parse(dr["ID_KhachHang"].ToString());
                    lblIDKhachHang.Text = dr["ID_KhachHang"].ToString();
                    if (idKH > 0)
                    {
                        foreach (DataRow dr2 in kh.GetDataTheoIDKH(idKH).Rows)
                        {
                            if (kh.GetDataTheoIDKH(idKH).Rows.Count == 1)
                            {
                                lblTenKH.Text = dr2["TenKH"].ToString();
                                lblDiaChi.Text = dr2["DiaChi"].ToString();
                                lblSDT.Text = dr2["SDT"].ToString();
                            }
                        }
                    }
                    else
                    {
                        foreach (DataRow dr3 in od.GetDataTheoIDOrder(uc.idorder).Rows)
                        {
                            if (od.GetDataTheoIDOrder(uc.idorder).Rows.Count == 1)
                            {
                                lblTenKH.Text = dr3["TenKH"].ToString();
                                lblDiaChi.Text = dr3["DiaChi"].ToString();
                                lblSDT.Text = dr3["SDT"].ToString();
                            }
                        }
                    }
                }
            }
           
        }
        public int sinhMaHD()
        {

            if (hd.layMaHDMax() == null)
            {
                return 1;
            }
            else
            {
                int? hdmax = hd.layMaHDMax();
                return (int)(hdmax + 1);
            }

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (hd.insertHD(idHD, DateTime.Now, long.Parse(lblTongTien.Text), FrmMain.TenDN, int.Parse(lblIDKhachHang.Text), 0, "Đã thanh toán"))
            {
                if (od.UpdateTT("Đã nhận đơn", int.Parse(dgvCTOrder.Rows[0].Cells[0].Value.ToString())))
                {
                    int flag = 0;
                    for (int i = 0; i < dgvCTOrder.RowCount; i++)
                    {
                        int idma = int.Parse(dgvCTOrder.Rows[i].Cells[1].Value.ToString());
                        int sl = int.Parse(dgvCTOrder.Rows[i].Cells[2].Value.ToString());
                        long gb = long.Parse(dgvCTOrder.Rows[i].Cells[3].Value.ToString());
                        long tt = long.Parse(dgvCTOrder.Rows[i].Cells[4].Value.ToString());

                        if (cthd.insertCTHD(idHD, idma, sl, gb, tt))
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
                        FrmRPHoaDonGH.MaHD = idHD;
                        FrmRPHoaDonGH frm2 = new FrmRPHoaDonGH();
                        frm2.Show();
                        frm2.BringToFront();
                        FrmXacNhanOrder_Load(sender, e);
                        alert_success frm = new alert_success();
                        frm.showAlert("Thông báo", "Xác nhận đơn hàng thành công!", Color.FromArgb(24, 24, 24), Color.Lime, "checkBlack2x.png", "closeWhite1x.png");
                        frm.BringToFront();
                        
                        lblDiaChi.Text = lblIDKhachHang.Text = lblSDT.Text = lblTongTien.Text = string.Empty;
                    }
                    else
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Cảnh báo", "Xác nhận đơn hàng thất bại!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                        frm.BringToFront();
                    }
                }
            }
        }
    }
}
