using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucAnNhanh.message_alert
{
    public partial class alert_success : Form
    {
        public alert_success()
        {
            InitializeComponent();
        }
        public enum enmAction
        {
            wait, start, close
        }

        private alert_success.enmAction action;
        private int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 2000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }

                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0)
                    {
                        base.Close();
                    }
                    break;
            }

        }

        private void btncClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showAlert(string msg, string content, Color foreColor, Color backColor, string icon, string iconclose)
        {
            this.Opacity = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            string fname;
            for (int i = 0; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                alert_success frm = (alert_success)Application.OpenForms[fname];
                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            this.label1.Text = msg;
            this.label2.Text = content;
            this.label1.ForeColor = foreColor;
            this.label2.ForeColor = foreColor;
            this.BackColor = backColor;
            this.btnClose.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\alert\\2x\\" + iconclose);
            this.picIcon.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\alert\\2x\\" + icon);
            this.Show();

            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
