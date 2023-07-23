using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucAnNhanh.NhanVien
{
    public partial class UC_UserItem : UserControl
    {
        public UC_UserItem()
        {
            InitializeComponent();
        }
        public string id { get; set; }
        public string pic { get; set; }
        public string name { get; set; }

        private void UC_UserItem_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            picAnh.ImageLocation = pic;
            this.Tag = id;
        }
    }
}
