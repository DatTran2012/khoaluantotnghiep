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

namespace ThucAnNhanh.NhanVien
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();
            }
            catch (Exception)
            {

                throw;
            }
            SqlDependency.Stop(ChuoiKetNoi);
            SqlDependency.Start(ChuoiKetNoi);
            con = new SqlConnection(ChuoiKetNoi);

        }
        private string ChuoiKetNoi = Properties.Settings.Default.ChuoiKetNoi2;
        SqlConnection con = null;
        public delegate void NewHome();
        public event NewHome OnNewHome;


        NhanVienBLL nv = new NhanVienBLL();
        LoaiNhanVienBLL lnv = new LoaiNhanVienBLL();
        NhomNhanVienBLL nnv = new NhomNhanVienBLL();
        QL_NguoiDung CauHinh = new QL_NguoiDung();






        string idnew = string.Empty;

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtTimKiem.Text.Trim().Length > 0)
                {
                    dgvDSNhanVien.DataSource = CauHinh.Search3(txtTimKiem.Text, "NhanVien", "TenNV", "SDT");
                    int filter = dgvDSNhanVien.Rows.Count;
                    lblFilter.Text = "Lọc: " + filter;
                }
                else
                {
                    dgvDSNhanVien.DataSource = CauHinh.Search3(txtTimKiem.Text, "NhanVien", "TenNV", "SDT");
                    lblFilter.Text = "Lọc: 0";
                }
            }
            catch

            {
                MessageBox.Show("...");
            }
        }

        private void cboLoaiNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiNhanVien.SelectedIndex == cboLoaiNhanVien.Items.Count - 1)
            {
                dgvDSNhanVien.DataSource = nv.GetData();
                int filter = dgvDSNhanVien.Rows.Count;
                lblFilter.Text = "Lọc: " + filter;
                cboLoaiNhanVien.SelectedIndex = cboLoaiNhanVien.Items.Count - 1;
            }
            else
            {
                dgvDSNhanVien.DataSource = nv.GetNhanVienTheoMaLoai(cboLoaiNhanVien.SelectedIndex + 1);
                int filter = nv.GetNhanVienTheoMaLoai(cboLoaiNhanVien.SelectedIndex + 1).Rows.Count;
                lblFilter.Text = "Lọc: " + filter;
            }
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            OnNewHome += new NewHome(Form1_OnNewHome);//tab
            //load data vao datagrid
            LoadData();

        }
        public void Form1_OnNewHome()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)//tab
            {
                NewHome dd = new NewHome(Form1_OnNewHome);
                i.BeginInvoke(dd, null);
                return;
            }
            LoadData();

        }

        public void LoadData()
        {
            dgvDSNhanVien.DataSource = nv.GetData();
            int record = int.Parse(dgvDSNhanVien.RowCount.ToString()) ;
            lblRecord.Text = "Tất cả: " + record;
            DataTable dt = new DataTable();
            dt = lnv.GetData();
            dt.Rows.Add(0, "Tất cả");
            cboLoaiNhanVien.DataSource = dt;
            cboLoaiNhanVien.DisplayMember = "TenLoaiNV";
            cboLoaiNhanVien.ValueMember = "ID";
            cboLoaiNhanVien.SelectedIndex = cboLoaiNhanVien.Items.Count - 1;
            cboLoai.DataSource = lnv.GetData();
            cboLoai.DisplayMember = "TenLoaiNV";
            cboLoai.ValueMember = "ID";

            //if (nv.LayMaNVMax() == string.Empty)
            //{
            //    idnew = "NV001";

            //}
            //else
            //{
            //    int nvmax = int.Parse(nv.LayMaNVMax().Trim());
            //    if (nvmax >= 9)
            //    {
            //        idnew = "NV0" + (nvmax + 1).ToString();
            //    }

            //    else
            //    {
            //        idnew = "NV00" + (nvmax + 1).ToString();
            //    }
            //}


            DataTable dt2 = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT ID, TenNV, NgaySinh, GioiTinh, DiaChi, SDT, CMT, Anh, NgayVL, MatKhau, TrangThai from dbo.NhanVien", con);
            cmd.Notification = null;

            SqlDependency de = new SqlDependency(cmd);
            de.OnChange += new OnChangeEventHandler(de_OnChange);

            dt2.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            dgvDSNhanVien.DataSource = dt2;

        }
        public void de_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency de = sender as SqlDependency;
            de.OnChange -= de_OnChange;
            if (OnNewHome != null)
            {
                OnNewHome();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtTrangThai.Visible = label11.Visible = false;
            txtTenNV.Text = txtDiaChi.Text = txtSDT.Text = txtCMT.Text = txtAnh.Text = txtTrangThai.Text = string.Empty;
            txtTenNV.ReadOnly = txtCMT.ReadOnly = txtDiaChi.ReadOnly = txtSDT.ReadOnly = txtTrangThai.ReadOnly = txtAnh.ReadOnly = false;
            dateNgaySinh.Text = dateNgayVL.Text = DateTime.Today.ToShortDateString();
        }

        string anh = string.Empty;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nv.ktkc(txtID.Text) == 0)
            {
                if (ktNhap())
                {
                    if (ktDu18Tuoi())
                    {
                        if (txtSDT.Text.Length == 10)
                        {
                            if (txtCMT.Text.Length == 9)
                            {
                                if (DateTime.Parse(dateNgayVL.Text) >= DateTime.Parse(DateTime.Today.ToShortDateString()))
                                {

                                    if (nv.InsertNV(layChuoi()+txtCMT.Text, txtTenNV.Text, DateTime.Parse(dateNgaySinh.Text), gioitinh, txtDiaChi.Text, txtSDT.Text, txtCMT.Text, txtAnh.Text, DateTime.Parse(dateNgayVL.Text), layChuoi() + txtCMT.Text, 1))
                                    {

                                        if (nnv.InsertNhomNhanVien(layChuoi()+txtCMT.Text, int.Parse(cboLoai.SelectedValue.ToString())))
                                        {
                                            FrmNhanVien_Load(sender, e);
                                            alert_success frm = new alert_success();
                                            frm.showAlert("Thông báo", "Thêm nhân viên thành công!", Color.FromArgb(24, 24, 24), Color.Lime, "checkBlack2x.png", "closeWhite1x.png");
                                            frm.BringToFront();
                                            txtTenNV.ReadOnly = txtCMT.ReadOnly = txtDiaChi.ReadOnly = txtSDT.ReadOnly = txtTrangThai.ReadOnly = txtAnh.ReadOnly = true;

                                        }
                                        else
                                        {
                                            alert_success frm = new alert_success();
                                            frm.showAlert("Cảnh báo", "Thêm nhân viên thất bại!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                                            frm.BringToFront();
                                        }
                                    }
                                    else
                                    {
                                        alert_success frm = new alert_success();
                                        frm.showAlert("Cảnh báo", "Thêm nhân viên thất bại!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                                        frm.BringToFront();
                                    }

                                }
                                else
                                {
                                    alert_success frm = new alert_success();
                                    frm.showAlert("Cảnh báo", "Vui lòng nhập số CMT gồm 9 ký số!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
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
                            frm.showAlert("Cảnh báo", "Vui lòng nhập ngày vào làm lớn hơn hoặc bằng ngày hiện tại!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                            frm.BringToFront();
                        }
                    }
                    else
                    {
                        alert_success frm = new alert_success();
                        frm.showAlert("Cảnh báo", "Vui lòng nhập tuổi trên 18!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                        frm.BringToFront();
                    }
                }
                else
                {
                    alert_success frm = new alert_success();
                    frm.showAlert("Cảnh báo", "Vui lòng nhập đầy đủ các thông tin!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                    frm.BringToFront();
                }

            }
            else
            {
                if (ktNhap())
                {
                    if (ktDu18Tuoi())
                    {
                        if (txtSDT.Text.Length == 10)
                        {
                           
                                    if (nv.UpdateNV(txtTenNV.Text, dateNgaySinh.Text, gioitinh, txtDiaChi.Text, txtSDT.Text, txtCMT.Text, txtAnh.Text, dateNgayVL.Text, int.Parse(txtTrangThai.Text), txtID.Text))
                                    {
                                        FrmNhanVien_Load(sender, e);
                                        alert_success frm = new alert_success();
                                        frm.showAlert("Thông báo", "Cập nhật nhân viên thành công!", Color.FromArgb(24, 24, 24), Color.Lime, "checkBlack2x.png", "closeWhite1x.png");
                                        frm.BringToFront();
                                    }
                                    else
                                    {
                                        alert_success frm = new alert_success();
                                        frm.showAlert("Cảnh báo", "Cập nhật nhân viên không thành công!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
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
                        frm.showAlert("Cảnh báo", "Vui lòng nhập tuổi trên 18!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                        frm.BringToFront();
                    }
                }

                else
                {
                    alert_success frm = new alert_success();
                    frm.showAlert("Cảnh báo", "Vui lòng nhập đầy đủ các thông tin!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                    frm.BringToFront();
                }
            }
        }

        public string layChuoi()
        {
            string chuoi = string.Empty;
            if (cboLoai.SelectedIndex == 1)
            {
                chuoi =  "QL";
            }
            else if (cboLoai.SelectedIndex == 2)
            {
                chuoi = "TN";
            }
            else if (cboLoai.SelectedIndex == 3)
            {
                chuoi = "OD";
            }
            return chuoi;
        }

        //lấy tình trạng nhân viên
        //public string layTinhTrang(int tt)
        //{
        //    string tinhtrang = string.Empty;
        //    if (tt == 1)
        //        tinhtrang = "Đang làm";
        //    else if (tt == 0)
        //        tinhtrang = "Đã nghỉ làm";
        //    return tinhtrang;
        //}

        string gioitinh = string.Empty;
        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                gioitinh = radio.Text;
            }
        }

        //Kiểm tra nhập đầy đủ
        public bool ktNhap()
        {
            if (
               string.IsNullOrWhiteSpace(txtTenNV.Text) ||
               string.IsNullOrWhiteSpace(dateNgaySinh.Text) ||
               string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
               string.IsNullOrWhiteSpace(txtSDT.Text) ||
               string.IsNullOrWhiteSpace(txtCMT.Text) ||
               string.IsNullOrWhiteSpace(dateNgayVL.Text) ||
                string.IsNullOrWhiteSpace(txtAnh.Text) || cboLoai.SelectedIndex < 0)


                return false;
            return true;
        }

        //load ảnh
        private void txtAnh_Leave(object sender, EventArgs e)
        {
            picNV.ImageLocation = txtAnh.Text;
        }

        //18 tuổi
        public bool ktDu18Tuoi()
        {
            DateTime birth = DateTime.Parse(dateNgaySinh.Text);
            DateTime today = DateTime.Today;     //we usually don't care about birth time
            TimeSpan age = today - birth;        //.NET FCL should guarantee this as precise
            double ageInDays = age.TotalDays;    //total number of days ... also precise
            double daysInYear = 365.2425;        //statistical value for 400 years
            double ageInYears = ageInDays / daysInYear;  //can be shifted ... not so precise
            if (ageInYears < 18)
                return false;
            return true;

        }


        //Chỉ nhập số
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

 

        private void dgvDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTenNV.ReadOnly = txtCMT.ReadOnly = txtDiaChi.ReadOnly = txtSDT.ReadOnly = txtTrangThai.ReadOnly = txtAnh.ReadOnly = true;

                txtID.Text = dgvDSNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dgvDSNhanVien.CurrentRow.Cells[1].Value.ToString();
                dateNgaySinh.Text = dgvDSNhanVien.CurrentRow.Cells[2].Value.ToString();
                if (dgvDSNhanVien.CurrentRow.Cells[3].Value.ToString() == "Nam")
                {
                    rdbNam.Checked = true;
                    gioitinh = rdbNam.Text;
                }
                else
                {
                    rdbNu.Checked = true;
                    gioitinh = rdbNu.Text;
                }
                txtDiaChi.Text = dgvDSNhanVien.CurrentRow.Cells[4].Value.ToString();
                txtSDT.Text = dgvDSNhanVien.CurrentRow.Cells[5].Value.ToString();
                txtCMT.Text = dgvDSNhanVien.CurrentRow.Cells[6].Value.ToString();
                txtAnh.Text = dgvDSNhanVien.CurrentRow.Cells[7].Value.ToString();
                dateNgayVL.Text = dgvDSNhanVien.CurrentRow.Cells[8].Value.ToString();
                //int trangthai = int.Parse(dgvDSNhanVien.CurrentRow.Cells[10].Value.ToString());
                txtTrangThai.Text = dgvDSNhanVien.CurrentRow.Cells[10].Value.ToString();
                cboLoai.SelectedValue = nnv.timLoaiNV(dgvDSNhanVien.CurrentRow.Cells[0].Value.ToString());
                picNV.ImageLocation = dgvDSNhanVien.CurrentRow.Cells[7].Value.ToString();

            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTrangThai.Visible = label11.Visible = true;

            txtTenNV.ReadOnly = txtCMT.ReadOnly = txtDiaChi.ReadOnly = txtSDT.ReadOnly = txtTrangThai.ReadOnly = txtAnh.ReadOnly = false;
         //   picNV.ImageLocation = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(layChuoi() + txtCMT.Text);
            
        }

       
    }
}
