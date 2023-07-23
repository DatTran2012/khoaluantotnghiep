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
using ThucAnNhanh.BanAn;
using ThucAnNhanh.Order;

namespace ThucAnNhanh
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();
            }
            catch(Exception)
            {
                throw;
            }
            SqlDependency.Stop(ChuoiKetNoi2);
            SqlDependency.Start(ChuoiKetNoi2);
            con = new SqlConnection(ChuoiKetNoi2);
            LoadBanTrong();
            LoadBanCoKhach();
        }
        BanAnBLL ba = new BanAnBLL();
        HoaDonBLL hd = new HoaDonBLL();
        BannerBLL bn = new BannerBLL();
        OrderBLL od = new OrderBLL();
        public void LoadBanTrong()
        {
            banTrong.Value = ba.demBanTrong();
            banTrong.Maximum = ba.GetData().Rows.Count -1;
            btnBanTrong.Text = ba.demBanTrong().ToString();
            if(banTrong.Value < 0)
            {
                banTrong.InnerColor = Color.White;
                banTrong.ProgressColor = Color.Red;
                banTrong.ProgressColor2 = Color.Red;
            }    
            else if (banTrong.Value < 5)
            {
                banTrong.InnerColor = Color.White;
                banTrong.ProgressColor = Color.Yellow;
                banTrong.ProgressColor2 = Color.Yellow;
            }
            else
            {
                banTrong.InnerColor = Color.White;
                banTrong.ProgressColor = Color.FromArgb(0, 192, 0);
                banTrong.ProgressColor2 = Color.FromArgb(0, 192, 0);
            }
        }
        public void LoadBanCoKhach()
        {
            banCoKhach.Value = ba.demBanCoKhach();
            banCoKhach.Maximum = ba.GetData().Rows.Count -1;
            btnBanCoKhach.Text = ba.demBanCoKhach().ToString();
            if (banCoKhach.Value < 0)
            {
                banCoKhach.InnerColor = Color.White;
                banCoKhach.ProgressColor = Color.Red;
                banCoKhach.ProgressColor2 = Color.Red;
            }
            else if (banCoKhach.Value < 5)
            {
                banCoKhach.InnerColor = Color.White;
                banCoKhach.ProgressColor = Color.Yellow;
                banCoKhach.ProgressColor2 = Color.Yellow;
            }          
            else
            {
                banCoKhach.InnerColor = Color.White;
                banCoKhach.ProgressColor = Color.FromArgb(0, 192, 0);
                banCoKhach.ProgressColor2 = Color.FromArgb(0, 192, 0);
            }

        }
        private void UC_Home_Load(object sender, EventArgs e)
        {
            OnNewHome += new NewHome(UC_Home_OnNewHome);
            LoadData();
            LoadDataWeb();
            timer1.Enabled = true;
            timer1.Start();
            lblYeuCauTT.Text = hd.GetDataYCThanhToan().Rows.Count + " bàn ăn đang chờ thanh toán!";
            btnYeuCauTT.Text = hd.GetDataYCThanhToan().Rows.Count.ToString();
            lblYeuCauXacNhan.Text = od.GetDataChoXacNhan().Rows.Count + " đơn đặt đang chờ xác nhận!";
            btnChoXacNhan.Text = od.GetDataChoXacNhan().Rows.Count.ToString();
        }

        private void UC_Home_OnNewHome()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if(i.InvokeRequired)
            {
                NewHome dd = new NewHome(UC_Home_OnNewHome);
                i.BeginInvoke(dd, null);
                return;
            }
            LoadData();
            LoadDataWeb();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // lblGio.Text = DateTime.Now.ToShortTimeString();

        }

       

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();            
            UC_ThanhToan uc = new UC_ThanhToan();            
            this.Controls.Add(uc);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FrmOrderNow frm = new FrmOrderNow();
            frm.Show();
        }
        string img = string.Empty;
        private int imageNumber = 1;
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
        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void btnBanTrong_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UC_BanTrong uc = new UC_BanTrong();
            this.Controls.Add(uc);
        }

        private void btnBanCoKhach_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UC_BanAn uc = new UC_BanAn();
            this.Controls.Add(uc);
        }


        private string ChuoiKetNoi2 = Properties.Settings.Default.ChuoiKetNoi2;
        public delegate void NewHome();
        public event NewHome OnNewHome;
        SqlConnection con = null;

        //Load yêu cầu thanh toán từ mobile

        public void LoadData()
        {
            DataTable dt = new DataTable();
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT ID, NgayLap, TongTien, ID_NhanVien, ID_KhachHang, ID_BanAn, TinhTrang FROM dbo.HoaDon where TinhTrang = N'Yêu cầu thanh toán'", con);
            cmd.Notification = null;
            SqlDependency de = new SqlDependency(cmd);
            de.OnChange += new OnChangeEventHandler(de_OnChange);
     

            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            btnYeuCauTT.Text = dt.Rows.Count.ToString();
            lblYeuCauTT.Text = dt.Rows.Count.ToString() + " bàn ăn đang chờ thanh toán";


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
        //Load xác nhận order từ web
        public void LoadDataWeb()
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT ID, ID_KhachHang, TongTien, DiaChi, SDT, TinhTrang, GhiChu, Email, TenKH FROM dbo.[Order] where TinhTrang = N'Chờ xác nhận'", con);
            cmd.Notification = null;
            SqlDependency de = new SqlDependency(cmd);
            de.OnChange += new OnChangeEventHandler(de_OnChange);


            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            btnChoXacNhan.Text = dt.Rows.Count.ToString();
            lblYeuCauXacNhan.Text = dt.Rows.Count.ToString() + " đơn đặt đang chờ xác nhận!";

        }
        private void btnChoXacNhan_Click(object sender, EventArgs e)
        {
            FrmXacNhanOrder frm = new FrmXacNhanOrder();
            frm.Show();
        }
    }
}