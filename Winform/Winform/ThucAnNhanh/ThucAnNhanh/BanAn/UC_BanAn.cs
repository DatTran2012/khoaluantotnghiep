using Guna.UI2.WinForms;
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

namespace ThucAnNhanh.BanAn
{
    public partial class UC_BanAn : UserControl
    {
        public UC_BanAn()
        {
            InitializeComponent();
        }
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        private void UC_BanAn_Load(object sender, EventArgs e)
        {
            rdbTatCa_Check();
        }
        private void rdbTatCa_Check()
        {
            this.flowLayoutPanel1.Controls.Clear();
            CauHinh.moKetNoi();
            string doc = "select ID, ViTri, TinhTrang from BanAn where TinhTrang = 1";
            SqlCommand cmd = new SqlCommand(doc, CauHinh.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Guna2GradientTileButton btn = new Guna2GradientTileButton
                {
                    Text = rd["ID"].ToString() + "-" + rd["ViTri"].ToString(),
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                    BackColor = Color.Transparent,
                    FillColor = Color.White,
                    FillColor2 = Color.White,
                    BorderRadius = 30,
                    Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\table.png"),
                    ImageOffset = new Point(0, 15),
                    ImageSize = new Size(80, 80),
                };
                int w = (flowLayoutPanel1.Size.Width - 60) / 6;
                btn.Size = new Size(w, w);
                this.flowLayoutPanel1.Controls.Add(btn);
            }
            lblFilter.Text = "Số bàn có khách: " + flowLayoutPanel1.Controls.Count + "";
            CauHinh.dongKetNoi();
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbTatCa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbTangTret_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbTatCa_CheckedChanged_1(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            Guna2RadioButton radio = sender as Guna2RadioButton;
            if (radio.Checked)
            {
                if (rdbTatCa.Checked)
                {
                    rdbTatCa_Check();
                }
                else
                {
                    CauHinh.moKetNoi();
                    string doc = "select ID, ViTri, TinhTrang from BanAn where TinhTrang = 1 and ViTri = N'" + radio.Text + "'";
                    SqlCommand cmd = new SqlCommand(doc, CauHinh.conn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        Guna2GradientTileButton btn = new Guna2GradientTileButton
                        {
                            Text = rd["ID"].ToString() + "-" + rd["ViTri"].ToString(),
                            ForeColor = Color.Black,
                            Font = new Font("Segoe UI", 12, FontStyle.Regular),
                            BackColor = Color.Transparent,
                            FillColor = Color.White,
                            FillColor2 = Color.White,
                            BorderRadius = 30,
                            Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\table.png"),
                            ImageOffset = new Point(0, 15),
                            ImageSize = new Size(80, 80),
                        };

                        int w = (flowLayoutPanel1.Size.Width - 60) / 6;
                        btn.Size = new Size(w, w);
                        this.flowLayoutPanel1.Controls.Add(btn);
                    }
                    lblFilter.Text = "Số bàn có khách: " + flowLayoutPanel1.Controls.Count + "";
                    CauHinh.dongKetNoi();
                }
            }
        }


    }
}
