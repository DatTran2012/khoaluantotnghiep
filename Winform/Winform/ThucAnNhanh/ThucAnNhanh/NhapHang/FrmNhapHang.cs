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
using ThucAnNhanh.List;
using ThucAnNhanh.message_alert;
using ThucAnNhanh.ReportExcel;

namespace ThucAnNhanh.NhapHang
{
    public partial class FrmNhapHang : Form
    {
        public FrmNhapHang()
        {
            InitializeComponent();
            list = new List<DonNhapHang>();
        }
        NguyenLieuBLL nl = new NguyenLieuBLL();
        PhieuNhapBLL pn = new PhieuNhapBLL();
        ChiTietPhieuNhapBLL ctpn = new ChiTietPhieuNhapBLL();
        NhanVienBLL nv = new NhanVienBLL();
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        List<DonNhapHang> list; //list tạm để nhập hàng

        DataGridViewTextBoxColumn nh1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn nh2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn nh3 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn nh4 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn nh5 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn nh6 = new DataGridViewTextBoxColumn();


        private void setupColumDGV()
        {
            dgvCTHD.Columns.Clear();
            // Column1
            // 
            dgvCTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            nh1.DataPropertyName = "idnl";
            nh1.HeaderText = "ID nguyên liệu";
            nh1.Name = "Column1";
            nh1.DisplayIndex = 1;
            nh1.Width = 100;
            nh1.ReadOnly = true;
            // 
            // Column2
            // 
            nh2.DataPropertyName = "tennl";
            nh2.HeaderText = "Tên nguyên liệu";
            nh2.Name = "Column2";
            nh2.DisplayIndex = 2;
            nh2.Width = 250;
            nh2.ReadOnly = true;
            // 
            // Column3
            // 
            nh3.DataPropertyName = "dvt";
            nh3.HeaderText = "Đơn vị tính";
            nh3.Name = "Column3";
            nh3.DisplayIndex = 3;
            nh3.Width = 200;
            nh3.ReadOnly = true;
            // 
            // Column4
            // 

            nh4.DataPropertyName = "slnhap";
            nh4.HeaderText = "Số lượng nhập";
            nh4.Name = "Column4";
            nh4.DisplayIndex = 4;
            nh4.Width = 200;
            nh4.ReadOnly = true;


            // 
            // Column5
            // 
            nh5.DataPropertyName = "gianhap";
            nh5.HeaderText = "Giá nhập";
            nh5.Name = "Column5";
            nh5.DisplayIndex = 5;
            nh5.ReadOnly = true;
            nh5.Width = 100;
            // 
            // Column6
            // 
            nh6.DataPropertyName = "thanhtien";
            nh6.HeaderText = "Thành Tiền";
            nh6.Name = "Column6";
            nh6.DisplayIndex = 6;
            //hd6.ReadOnly = true;
            nh6.Width = 200;
            //


            dgvCTHD.Columns.Add(nh1);
            dgvCTHD.Columns.Add(nh2);
            dgvCTHD.Columns.Add(nh3);
            dgvCTHD.Columns.Add(nh4);
            dgvCTHD.Columns.Add(nh5);
            dgvCTHD.Columns.Add(nh6);

        }

        private void FrmNhapHang_Load(object sender, EventArgs e)
        {

            FillComboBox(cboNguyenLieu);
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            GetComboBoxData(combData);
            cboNguyenLieu.AutoCompleteCustomSource = combData;

            sinhMaPN();
            dgvCTHD.DataSource = null;
            list.Clear();
            lblNgayNhap.Text = DateTime.Today.ToShortDateString();
            lblNhanVien.Text = nv.layTenNV(FrmMain.TenDN);
            lblTongTienNhap.Text = CauHinh.tinhTongTien(dgvCTHD, 5).ToString();
        }

        //tìm mã phiếu nhập
        public void sinhMaPN()
        {
            if (pn.timPNMax() == 0)
            {
                lblMaPhieuNhap.Text = "1";
            }
            else
            {
                int? hdmax = pn.timPNMax();
                lblMaPhieuNhap.Text = (hdmax + 1).ToString();
            }
        }
        private void GetComboBoxData(AutoCompleteStringCollection dataCollection)
        {
            DataTable dtData = nl.GetData();
            foreach (DataRow row in dtData.Rows)
            {
                dataCollection.Add(row[0].ToString());
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

        private void cboNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow dr in nl.GetDataByIDNL(int.Parse(cboNguyenLieu.SelectedValue.ToString())).Rows)
                {
                    if (nl.GetDataByIDNL(int.Parse(cboNguyenLieu.SelectedValue.ToString())).Rows.Count == 1)
                        lblDVT.Text = dr["DVT"].ToString();
                }
            }
            catch
            {
            }
        }

        private void txtSLNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {

                txtThanhTien.Text = (int.Parse(txtSLNhap.Text) * int.Parse(txtGiaNhap.Text)).ToString();
            }
            catch { }
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            //txtGiaNhap.Text = string.Format("{0:0,0}", decimal.Parse(txtGiaNhap.Text));
            //txtGiaNhap.SelectionStart = txtGiaNhap.Text.Length;
        }

        //Kiểm tra nhâp
        public bool ktNhap()
        {
            if (string.IsNullOrWhiteSpace(txtGiaNhap.Text) ||
               string.IsNullOrWhiteSpace(txtSLNhap.Text)
               )
                return false;
            return true;
        }
        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cboNguyenLieu.Text);

            if (ktNhap())
            {

                DonNhapHang dnh = new DonNhapHang();
                if (kttrungdgv(int.Parse(cboNguyenLieu.SelectedValue.ToString())) == 1)
                {
                    list.RemoveAt(index);
                    dnh.idnl = int.Parse(cboNguyenLieu.SelectedValue.ToString());
                    dnh.tennl = cboNguyenLieu.Text;
                    dnh.dvt = lblDVT.Text;
                    dnh.slnhap = slc + int.Parse(txtSLNhap.Text);
                    dnh.gianhap = int.Parse(txtGiaNhap.Text);
                    dnh.thanhtien = ttm + int.Parse(txtThanhTien.Text);
                    list.Add(dnh);
                    dgvCTHD.DataSource = null;
                    setupColumDGV();
                    dgvCTHD.DataSource = list;
                    lblTongTienNhap.Text = CauHinh.tinhTongTien(dgvCTHD, 5).ToString();
                }
                else
                {
                    dnh.idnl = int.Parse(cboNguyenLieu.SelectedValue.ToString());
                    dnh.tennl = cboNguyenLieu.Text;
                    dnh.dvt = lblDVT.Text;
                    dnh.slnhap = int.Parse(txtSLNhap.Text);
                    dnh.gianhap = int.Parse(txtGiaNhap.Text);
                    dnh.thanhtien = int.Parse(txtThanhTien.Text);
                    list.Add(dnh);
                    dgvCTHD.DataSource = null;
                    setupColumDGV();
                    dgvCTHD.DataSource = list;
                    lblTongTienNhap.Text = CauHinh.tinhTongTien(dgvCTHD, 5).ToString();
                }

                lblDVT.Text = txtGiaNhap.Text = txtSLNhap.Text = txtThanhTien.Text = string.Empty;

            }
            else
            {
                alert_success frm = new alert_success();
                frm.showAlert("Cảnh báo", "Vui lòng nhập đầy đủ các thông tin!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                frm.BringToFront();
            }
        }


        int slc = 0; //số lượng cũ
        long ttm = 0; //thành tiền mới
        int index = -1;

        //kt trùng khóa chính dgv
        public int kttrungdgv(int idnl)
        {
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                if (idnl == int.Parse(dgvCTHD.Rows[i].Cells[0].Value.ToString()))
                {
                    index = i;
                    slc = int.Parse(dgvCTHD.Rows[i].Cells[3].Value.ToString());
                    ttm = long.Parse(dgvCTHD.Rows[i].Cells[5].Value.ToString());
                    return 1;
                }
            }
            return 0;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.DataSource != null)
            {

                if (pn.InsertPN(int.Parse(lblMaPhieuNhap.Text), DateTime.Now, long.Parse(lblTongTienNhap.Text), FrmMain.TenDN))
                {
                    int flag = 0;
                    for (int i = 0; i < dgvCTHD.RowCount; i++)
                    {

                        int idnl = int.Parse(dgvCTHD.Rows[i].Cells[0].Value.ToString());
                        int sl = int.Parse(dgvCTHD.Rows[i].Cells[3].Value.ToString());
                        long gianhap = long.Parse(dgvCTHD.Rows[i].Cells[4].Value.ToString());
                        long thanhtien = long.Parse(dgvCTHD.Rows[i].Cells[5].Value.ToString());
                        if (ctpn.InsertCTPN(int.Parse(lblMaPhieuNhap.Text), idnl, sl, gianhap, thanhtien))
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 1)
                    {
                        FrmNhapHang_Load(sender, e);
                        alert_success frm = new alert_success();
                        frm.showAlert("Thông báo", "Nhập nguyên liệu thành công!", Color.FromArgb(24, 24, 24), Color.Lime, "checkBlack2x.png", "closeWhite1x.png");
                        frm.BringToFront();
                    }
                    else
                    {
                        list.Clear();
                        dgvCTHD.DataSource = null;
                        setupColumDGV();
                        FrmNhapHang_Load(sender, e);
                        alert_success frm = new alert_success();
                        frm.showAlert("Cảnh báo", "Nhập nguyên liệu thất bại!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                        frm.BringToFront();

                    }
                }
                else
                    MessageBox.Show("TB");
            }
            else
            {
                alert_success frm = new alert_success();
                frm.showAlert("Cảnh báo", "Vui lòng nhập đầy đủ các thông tin!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                frm.BringToFront();
            }
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();
            SaveFileDialog saveFile = new SaveFileDialog();
            if (dgvCTHD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất");
                return;
            }
            List<ChiTietPhieuNhap> pListCTPN = new List<ChiTietPhieuNhap>();
            // Đổ dữ liệu vào danh sách
            ExcelExport.tongtienNhap = lblTongTienNhap.Text;
            for (int i = 0; i < dgvCTHD.RowCount; i++)
            {
                ChiTietPhieuNhap ii = new ChiTietPhieuNhap();
                ii.IDPN = lblMaPhieuNhap.Text;
                ii.IDNL = dgvCTHD.Rows[i].Cells[0].Value.ToString();
                ii.TenNL = dgvCTHD.Rows[i].Cells[1].Value.ToString();
                ii.DVT = dgvCTHD.Rows[i].Cells[2].Value.ToString();
                ii.SoLuongNhap = int.Parse(dgvCTHD.Rows[i].Cells[3].Value.ToString());
                ii.GiaNhap = long.Parse(dgvCTHD.Rows[i].Cells[4].Value.ToString());
                ii.ThanhTien = long.Parse(dgvCTHD.Rows[i].Cells[5].Value.ToString());
                pListCTPN.Add(ii);
            }

            string path = string.Empty;
            excel.ExportKhoa(pListCTPN, ref path, false);
            // Confirm for open file was exported
            if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thôngtin",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                MessageBox.Show("Không tồn tại");
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            FrmNhapHang_Load(sender, e);
            list.Clear();
            dgvCTHD.DataSource = null;
            setupColumDGV();
            lblTongTienNhap.Text = string.Empty;


        }
    }
}
