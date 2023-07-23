using BLL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucAnNhanh.XepLich;

namespace ThucAnNhanh.NhanVien
{
    public partial class UC_LichLamViec : UserControl
    {
        public UC_LichLamViec()
        {
            InitializeComponent();
        }
        PhanCongBLL pc = new PhanCongBLL();
        NhanVienBLL nv = new NhanVienBLL();
        int month, year;
        public static string kk = string.Empty;

        private void UC_LichLamViec_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            lblToday.Text = "Today: " + DateTime.Today.ToShortDateString();
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthName + " " + year;
            //ngày đầu tiên của tháng
            DateTime startoftheMonth = new DateTime(year, month, 1);
            //đếm ngày của tháng
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(startoftheMonth.DayOfWeek.ToString("d")) + 1;
            //cục tàng hình
            for(int i = 1; i < dayofweek; i++)
            {
                Guna2Button uc = new Guna2Button();
                uc.BorderRadius = 20;
                uc.Size = new Size(60, 60);
                uc.BackColor = Color.Transparent;
                uc.FillColor = Color.Transparent;

                dayContainer.Controls.Add(uc);
            }    
            //cục ngày trong tháng
            for(int i = 1; i<= days; i++)
            {
                Guna2Button uc = new Guna2Button();
                uc.BorderRadius = 20;
                uc.Size = new Size(60, 60);
                uc.BackColor = Color.Transparent;
                //uc.FillColor = Color.FromArgb(64, 186, 210);
                uc.FillColor = Color.White;
                uc.ForeColor = Color.Black;

                uc.Text = i.ToString();
                dayContainer.Controls.Add(uc);
                string kk =month + "/" + i + "/" + year;
                if (pc.GetDataTheoNgay(DateTime.Parse(kk)).Rows.Count > 0)
                     uc.FillColor = Color.FromArgb(250,173,23);
               
                //if (kk == DateTime.Parse(DateTime.Today.ToShortDateString()).ToString("MM/dd/yyyy"))
                //{
                //    //uc.BackColor = Color.FromArgb(13, 71, 161);
                //    uc.FillColor = Color.Black;
                //    uc.ForeColor = Color.Black;
                //}
                uc.Click += Uc_Click;
                dayContainer.Controls.Add(uc);
            }    
        }

        private void Uc_Click(object sender, EventArgs e)
        {
            pnEmployeeCa1.Controls.Clear();
            pnEmployeeCa2.Controls.Clear();
            pnEmployeeCa3.Controls.Clear();
            Guna2Button uc = sender as Guna2Button;
            kk = month + "/" + uc.Text + "/" + year;
            string hh =  uc.Text + "/" + month + "/" + year;
            lblLichNgayLam.Text = "Lịch làm ngày " +  hh;


            if (pc.GetDataTheoNgay(DateTime.Parse(kk)).Rows.Count > 0)
            {
                foreach (DataRow dr in pc.GetDataTheoCa(1, DateTime.Parse(kk)).Rows)
                {
                    string id = dr["IDNV"].ToString();
                    string img = string.Empty;
                    foreach (DataRow dr1 in nv.GetNhanVienTheoMaNV(id).Rows)
                    {
                        img = dr1["Anh"].ToString();
                    }
                    UC_UserItem btn = new UC_UserItem { name = nv.layTenNV(id), pic = img };
                    pnEmployeeCa1.Controls.Add(btn);
                }
                foreach (DataRow dr in pc.GetDataTheoCa(2, DateTime.Parse(kk)).Rows)
                {
                    string id = dr["IDNV"].ToString();
                    string img = string.Empty;
                    foreach (DataRow dr1 in nv.GetNhanVienTheoMaNV(id).Rows)
                    {
                        img = dr1["Anh"].ToString();
                    }
                    UC_UserItem btn = new UC_UserItem { name = nv.layTenNV(id), pic = img };
                    pnEmployeeCa2.Controls.Add(btn);
                }
                foreach (DataRow dr in pc.GetDataTheoCa(3, DateTime.Parse(kk)).Rows)
                {
                    string id = dr["IDNV"].ToString();
                    string img = string.Empty;
                    foreach (DataRow dr1 in nv.GetNhanVienTheoMaNV(id).Rows)
                    {
                        img = dr1["Anh"].ToString();
                    }
                    UC_UserItem btn = new UC_UserItem { name = nv.layTenNV(id), pic = img };
                    pnEmployeeCa3.Controls.Add(btn);
                }
            }
            else
            {
                FrmXepLich frm = new FrmXepLich();
                frm.Show();
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                dayContainer.Controls.Clear();
                if (month == 1)
                {
                    year = year - 1;
                    month = 13;
                }
                month--;


                string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lblDate.Text = monthName + " " + year;
                //ngày đầu tiên của tháng
                DateTime startoftheMonth = new DateTime(year, month, 1);
                //đếm ngày của tháng
                int days = DateTime.DaysInMonth(year, month);
                int dayofweek = Convert.ToInt32(startoftheMonth.DayOfWeek.ToString("d")) + 1;
                //cục tàng hình
                for (int i = 1; i < dayofweek; i++)
                {
                    Guna2Button uc = new Guna2Button();
                    uc.BorderRadius = 20;
                    uc.Size = new Size(60, 60);
                    uc.BackColor = Color.Transparent;
                    uc.FillColor = Color.Transparent;

                    dayContainer.Controls.Add(uc);
                }
                //cục ngày trong tháng
                for (int i = 1; i <= days; i++)
                {
                    Guna2Button uc = new Guna2Button();
                    uc.BorderRadius = 20;
                    uc.Size = new Size(60, 60);
                    uc.BackColor = Color.Transparent;
                    //uc.FillColor = Color.FromArgb(64, 186, 210);
                    uc.FillColor = Color.White;
                    uc.ForeColor = Color.Black;

                    uc.Text = i.ToString();
                    dayContainer.Controls.Add(uc);
                    string kk = month + "/" + i + "/" + year;
                    if (pc.GetDataTheoNgay(DateTime.Parse(kk)).Rows.Count > 0)
                        uc.FillColor = Color.FromArgb(250, 173, 23);

                    //if (kk == DateTime.Parse(DateTime.Today.ToShortDateString()).ToString("MM/dd/yyyy"))
                    //{
                    //    uc.BackColor = Color.FromArgb(13, 71, 161);
                    //}
                    uc.Click += Uc_Click;
                    dayContainer.Controls.Add(uc);

                }
            }
            catch { }
        }

  
        private void btnXepLich_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(kk + DateTime.Parse(DateTime.Today.ToShortDateString()).ToString("MM/dd/yyyy"));

            FrmXepLich frm = new FrmXepLich();
            frm.Show();
            frm.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                dayContainer.Controls.Clear();               
                if (month == 12)
                {
                    year = year + 1;
                    month = 0;
                }

                month++;
                string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lblDate.Text = monthName + " " + year;
                //ngày đầu tiên của tháng
                DateTime startoftheMonth = new DateTime(year, month, 1);
                //đếm ngày của tháng
                int days = DateTime.DaysInMonth(year, month);
                int dayofweek = Convert.ToInt32(startoftheMonth.DayOfWeek.ToString("d")) + 1;
                //cục tàng hình
                for (int i = 1; i < dayofweek; i++)
                {
                    Guna2Button uc = new Guna2Button();
                    uc.BorderRadius = 20;
                    uc.Size = new Size(60, 60);
                    uc.BackColor = Color.Transparent;
                    uc.FillColor = Color.Transparent;

                    dayContainer.Controls.Add(uc);
                }
                //cục ngày trong tháng
                for (int i = 1; i <= days; i++)
                {
                    Guna2Button uc = new Guna2Button();
                    uc.BorderRadius = 20;
                    uc.Size = new Size(60, 60);
                    uc.BackColor = Color.Transparent;
                    //uc.FillColor = Color.FromArgb(64, 186, 210);
                    uc.FillColor = Color.White;
                    uc.ForeColor = Color.Black;

                    uc.Text = i.ToString();
                    dayContainer.Controls.Add(uc);
                    string kk = month + "/" + i + "/" + year;
                    if (pc.GetDataTheoNgay(DateTime.Parse(kk)).Rows.Count > 0)
                        uc.FillColor = Color.FromArgb(250, 173, 23);

                    //if (kk == DateTime.Parse(DateTime.Today.ToShortDateString()).ToString("MM/dd/yyyy"))
                    //{
                    //    uc.BackColor = Color.FromArgb(13, 71, 161);
                    //}
                    uc.Click += Uc_Click;
                    dayContainer.Controls.Add(uc);
                }
            }
            catch { }           
        }
    }
}
