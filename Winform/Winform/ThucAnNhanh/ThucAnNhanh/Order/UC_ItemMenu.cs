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

namespace ThucAnNhanh.Order
{
    public partial class UC_ItemMenu : UserControl
    {
        public UC_ItemMenu()
        {
            InitializeComponent();
        }

        public string img { get; set; }
        public string ten { get; set; }
        public long giaban { get; set; }
        public long giakm { get; set; }
        public int id { get; set; }

        
        private void UC_ItemMenu_Load(object sender, EventArgs e)
        {
            pic.ImageLocation = img;
            lblTen.Text = ten;
            lblGiaBan.Text = giaban.ToString();
            lblGiaKM.Text = giakm.ToString();
            if(giaban == giakm)
            {
                lblGiaBan.Visible = false;
            }    
        }

      
      
    }
}
