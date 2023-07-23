using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucAnNhanh.Reports
{
    public partial class FrmRPHoaDonGH : Form
    {
        public FrmRPHoaDonGH()
        {
            InitializeComponent();
        }
        public static int MaHD;
        private void FrmRPHoaDonGH_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            RPHoaDonGH rpt = new RPHoaDonGH();
            rpt.SetDatabaseLogon("khd", "!15102000Duong", "45.119.82.72", "ThucAnNhanh");
            rpt.SetParameterValue("HD", MaHD);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Height = 700;
            crystalReportViewer1.Width = 1200;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.Refresh();
        }
    }
}
