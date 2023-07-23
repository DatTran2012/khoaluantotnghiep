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
using ThucAnNhanh.Reports;

namespace ThucAnNhanh.ThongKe
{
    public partial class UC_ThongKe : UserControl
    {
        HoaDonBLL hd = new HoaDonBLL();
        PhieuNhapBLL pn = new PhieuNhapBLL();
        ThongKeMonAnBLL tk = new ThongKeMonAnBLL();
        NhanVienBLL nv = new NhanVienBLL();
        public UC_ThongKe()
        {
            InitializeComponent();
            LoadLuongKhachTrongNgay();
            LoadDoanhThuThang();
            LoadDoanhThu2Ngay(proDoanhThu1, hd.TinhDoanhThuHomQua(), lblDoanhThu1);
            LoadDoanhThu2Ngay(proDoanhThu2, hd.TinhDoanhThuHomNay(), lblDoanhThu2);

        }
        public void LoadDoanhThuThang()
        {
            lblDoanhThuThang.Text = hd.TinhTongThang(DateTime.Parse(DateTime.Today.ToShortDateString())).ToString();
            lblTienNhapThang.Text = pn.TinhTongThang(DateTime.Parse(DateTime.Today.ToShortDateString())).ToString();

        }
        public void LoadLuongKhachTrongNgay()
        {
            //chart2.Visible = true;
            //chart2.DataSource = tk.GetData(1);
            //chart2.Series["Total"].XValueMember = "Column2";
            //chart2.Series["Total"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            //chart2.Series["Total"].YValueMembers = "Column3";
            //chart2.Series["Total"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

        }
        public void LoadLuongKhach(Guna2VProgressBar guna2VProgressBar, Guna2ProgressBar guna2ProgressBar, int valuePro, Label label)
        {
            if (guna2VProgressBar.Value > 0 && guna2VProgressBar.Value < 500)
                guna2VProgressBar.ProgressColor = guna2VProgressBar.ProgressColor2 = Color.Red;
            else if (guna2VProgressBar.Value  < 2000)
                guna2VProgressBar.ProgressColor = guna2VProgressBar.ProgressColor2 = Color.Yellow;
            else
                guna2VProgressBar.ProgressColor = guna2VProgressBar.ProgressColor2 = Color.Green;
           
        }
        public void LoadDoanhThu2Ngay(Guna2ProgressBar guna2ProgressBar, long valuePro, Label label)
        {
            label.Text = valuePro.ToString();
            guna2ProgressBar.Value = int.Parse(valuePro.ToString());
            if (guna2ProgressBar.Value > 0 && guna2ProgressBar.Value < 1000000)
                guna2ProgressBar.ProgressColor = guna2ProgressBar.ProgressColor2 = Color.Red;
            else if (guna2ProgressBar.Value < 3000000)
                guna2ProgressBar.ProgressColor = guna2ProgressBar.ProgressColor2 = Color.Yellow;
            else
                guna2ProgressBar.ProgressColor = guna2ProgressBar.ProgressColor2 = Color.Green;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WordExport word = new WordExport();
            string thangtk = DateTime.Now.Month.ToString();
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            //string sohd = hd.HDThang().Rows.Count.ToString();
            string sohd = "10";
            float tongtien = 100;
            //float tongtien = 0;
            //foreach (DataRow dr in hd.HDThang().Rows)
            //{
            //    tongtien += float.Parse(dr["TongTien"].ToString());
            //}
            word.ThongKeDoanhThu(thangtk, ngay, thang, nam, nv.layTenNV(FrmMain.TenDN), sohd, tongtien.ToString(), nv.layTenNV(FrmMain.TenDN));
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            WordExport word = new WordExport();
            string thangtk = DateTime.Now.Month.ToString();
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            //string sohd = hd.HDThang().Rows.Count.ToString();
            string sohd = "10";
            float tongtien = 100;
            //float tongtien = 0;
            //foreach (DataRow dr in hd.HDThang().Rows)
            //{
            //    tongtien += float.Parse(dr["TongTien"].ToString());
            //}
            word.ThongKeDoanhThu(thangtk, ngay, thang, nam, nv.layTenNV(FrmMain.TenDN), sohd, tongtien.ToString(), nv.layTenNV(FrmMain.TenDN));
        }
    }
}
