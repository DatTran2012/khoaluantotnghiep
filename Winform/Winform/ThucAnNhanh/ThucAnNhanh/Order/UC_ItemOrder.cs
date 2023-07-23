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
    public partial class UC_ItemOrder : UserControl
    {
        public UC_ItemOrder()
        {
            InitializeComponent();
        }

        
        public string ten { get; set; }
        public string diachi { get; set; }
        public int idorder { get; set; }

        private void UC_ItemOrder_Load(object sender, EventArgs e)
        {
            lblTenKH.Text = ten;
            lblDiaChi.Text = diachi;
            guna2CircleButton1.Text = idorder.ToString();
            
        }
    }
}
