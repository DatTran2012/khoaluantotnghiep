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
    public partial class UC_DSNhanVien : UserControl
    {
        private string ChuoiKetNoi = Properties.Settings.Default.ChuoiKetNoi;
        SqlConnection con = null;
        public delegate void NewHome();
        public event NewHome OnNewHome;

        public UC_DSNhanVien()
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
       


        NhanVienBLL nv = new NhanVienBLL();
        LoaiNhanVienBLL lnv = new LoaiNhanVienBLL();
        NhomNhanVienBLL nnv = new NhomNhanVienBLL();
        QL_NguoiDung CauHinh = new QL_NguoiDung();

     

       
       

        string idnew = string.Empty;
        private void UC_DSNhanVien_Load(object sender, EventArgs e)
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
            //dgvDSNhanVien.DataSource = nv.GetData();
            int record = int.Parse(dgvDSNhanVien.RowCount.ToString()) - 1;
            lblRecord.Text = "Record: " + record;
            DataTable dt = new DataTable();
            dt = lnv.GetData();
            dt.Rows.Add(0, "Tất cả");
            cboLoaiNhanVien.DataSource = dt;
            cboLoaiNhanVien.DisplayMember = "TenLoaiNV";
            cboLoaiNhanVien.ValueMember = "ID";
            cboLoaiNhanVien.SelectedIndex = cboLoaiNhanVien.Items.Count - 1;

            if (nv.LayMaNVMax() == string.Empty)
            {
                idnew = "NV001";
            }
            else
            {
                int nvmax = int.Parse(nv.LayMaNVMax().Trim());
                idnew = "NV00" + (nvmax + 1).ToString();
            }
            DataTable dt2 = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT ID, TenNV, NgaySinh, GioiTinh, DiaChi, SDT, CMT, Anh, NgayVL, MatKhau from dbo.NhanVien", con);
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
        private void cboLoaiNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboLoaiNhanVien.SelectedIndex == cboLoaiNhanVien.Items.Count - 1)
            {
                dgvDSNhanVien.DataSource = nv.GetData();
                int filter = dgvDSNhanVien.Rows.Count - 1;
                lblFilter.Text = "Filter: "+filter;
                cboLoaiNhanVien.SelectedIndex = cboLoaiNhanVien.Items.Count - 1;
            }
            else
            {
                dgvDSNhanVien.DataSource = nv.GetNhanVienTheoMaLoai(cboLoaiNhanVien.SelectedIndex + 1);
                int filter = nv.GetNhanVienTheoMaLoai(cboLoaiNhanVien.SelectedIndex + 1).Rows.Count;
                lblFilter.Text = "Filter: " + filter;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtTimKiem.Text.Trim().Length > 0)
                {
                    dgvDSNhanVien.DataSource = CauHinh.Search3(txtTimKiem.Text, "NhanVien", "TenNV", "SDT");
                    int filter = dgvDSNhanVien.Rows.Count - 1;
                    lblFilter.Text = "Filter: " + filter;
                }
                else
                {
                    dgvDSNhanVien.DataSource = CauHinh.Search3(txtTimKiem.Text, "NhanVien", "TenNV", "SDT");
                    lblFilter.Text = "Filter: 0";
                }
            }
            catch

            {
                MessageBox.Show("...");
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (nv.InsertNV(idnew, dgvDSNhanVien.CurrentRow.Cells[1].Value.ToString(), DateTime.Parse(dgvDSNhanVien.CurrentRow.Cells[2].Value.ToString()),
                dgvDSNhanVien.CurrentRow.Cells[3].Value.ToString(), dgvDSNhanVien.CurrentRow.Cells[4].Value.ToString(), dgvDSNhanVien.CurrentRow.Cells[5].Value.ToString(),
                dgvDSNhanVien.CurrentRow.Cells[6].Value.ToString(), dgvDSNhanVien.CurrentRow.Cells[7].Value.ToString(),
                DateTime.Parse(dgvDSNhanVien.CurrentRow.Cells[8].Value.ToString()), idnew + "@123", 1))
            {
                alert_success frm = new alert_success();
                frm.showAlert("Thông báo", "Thêm nhân viên thành công!", Color.FromArgb(24, 24, 24), Color.Lime, "checkWhite2x.png", "closeWhite1x.png");
                frm.BringToFront();
                dgvDSNhanVien.DataSource = nv.GetData();
                if (nnv.InsertNhomNhanVien(idnew, int.Parse(cboLoaiNhanVien.SelectedValue.ToString())))
                    {
                    MessageBox.Show("Phân loại nhân viên thành công");
                    UC_DSNhanVien_Load(sender, e);
                }
            }
            else
                MessageBox.Show("Sai");
        }

      

        private void dgvDSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
