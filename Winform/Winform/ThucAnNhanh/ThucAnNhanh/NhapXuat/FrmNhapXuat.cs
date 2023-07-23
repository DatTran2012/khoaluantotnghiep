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

namespace ThucAnNhanh.NhapXuat
{
    public partial class FrmNhapXuat : Form
    {
        public FrmNhapXuat()
        {
            InitializeComponent();
        }
        HoaDonBLL hd = new HoaDonBLL();
        PhieuNhapBLL pn = new PhieuNhapBLL();
        ChiTietHoaDonBLL cthd = new ChiTietHoaDonBLL();
        ChiTietPhieuNhapBLL ctpn = new ChiTietPhieuNhapBLL();

        private void FrmNhapXuat_Load(object sender, EventArgs e)
        {
            dgvHD.DataSource = hd.GetDataHD();
            dgvPN.DataSource = pn.GetDataPN();
            chartHD();
            chartPN();
        }



        public void chartHD()
        {

            setChart(pro1, hd.TinhTongThang(DateTime.Parse("01/01/2022")), lblpro1);
            setChart(pro2, hd.TinhTongThang(DateTime.Parse("02/02/2022")), lblpro2);
            setChart(pro3, hd.TinhTongThang(DateTime.Parse("04/02/2022")), lblpro3);
            setChart(pro4, hd.TinhTongThang(DateTime.Parse("04/02/2022")), lblpro4);
            setChart(pro5, hd.TinhTongThang(DateTime.Parse("05/02/2022")), lblpro5);
            setChart(pro6, hd.TinhTongThang(DateTime.Parse("06/02/2022")), lblpro6);
            setChart(pro7, hd.TinhTongThang(DateTime.Parse("07/02/2022")), lblpro7);
            setChart(pro8, hd.TinhTongThang(DateTime.Parse("08/02/2022")), lblpro8);
            setChart(pro9, hd.TinhTongThang(DateTime.Parse("09/02/2022")), lblpro9);
            setChart(pro10, hd.TinhTongThang(DateTime.Parse("10/02/2022")), lblpro10);
            setChart(pro11, hd.TinhTongThang(DateTime.Parse("11/02/2022")), lblpro11);
            setChart(pro12, hd.TinhTongThang(DateTime.Parse("12/02/2022")), lblpro12);
        }
        public void setChart(Guna2VProgressBar pro, int value, Label lbl)
        {
            pro.Value = value;
            lbl.Text = value.ToString();
        }

       
        

        public void chartPN()
        {

            setChart(probar1, pn.TinhTongThang(DateTime.Parse("01/01/2022")), lblprobar1);
            setChart(probar2, pn.TinhTongThang(DateTime.Parse("02/01/2022")), lblprobar2);
            setChart(probar3, pn.TinhTongThang(DateTime.Parse("03/01/2022")), lblprobar3);
            setChart(probar4, pn.TinhTongThang(DateTime.Parse("04/01/2022")), lblprobar4);
            setChart(probar5, pn.TinhTongThang(DateTime.Parse("05/01/2022")), lblprobar5);
            setChart(probar6, pn.TinhTongThang(DateTime.Parse("06/01/2022")), lblprobar6);
            setChart(probar7, pn.TinhTongThang(DateTime.Parse("07/01/2022")), lblprobar7);
            setChart(probar8, pn.TinhTongThang(DateTime.Parse("08/01/2022")), lblprobar8);
            setChart(probar9, pn.TinhTongThang(DateTime.Parse("09/01/2022")), lblprobar9);
            setChart(probar10, pn.TinhTongThang(DateTime.Parse("10/01/2022")), lblprobar10);
            setChart(probar11, pn.TinhTongThang(DateTime.Parse("11/01/2022")), lblprobar11);
            setChart(probar12, pn.TinhTongThang(DateTime.Parse("12/01/2022")), lblprobar12);
        }

        private void dgvPN_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvCTPN.DataSource = ctpn.GetDataTheoMaPN(int.Parse(dgvPN.CurrentRow.Cells[0].Value.ToString()));

            }
            catch
            {

            }
        }

        private void dgvHD_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvCTHD.DataSource = cthd.LoadTheoMaHD(int.Parse(dgvHD.CurrentRow.Cells[0].Value.ToString()));
            }
            catch
            {

            }
        }

       
    }
}
