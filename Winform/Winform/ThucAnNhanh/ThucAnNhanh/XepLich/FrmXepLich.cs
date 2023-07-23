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
using ThucAnNhanh.message_alert;
using ThucAnNhanh.NhanVien;

namespace ThucAnNhanh.XepLich
{
    public partial class FrmXepLich : Form
    {
        PhanCongBLL pc = new PhanCongBLL();
        NhanVienBLL nv = new NhanVienBLL();
        List<ListNhanVien> list;
        public FrmXepLich()
        {
            InitializeComponent();
            list = new List<ListNhanVien>();

        }

        private void FrmXepLich_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in nv.GetNhanVienTheoMaLoai(1).Rows)
            {
                string id = dr["ID"].ToString();
                string img = dr["Anh"].ToString();
                string name = dr["TenNV"].ToString();
                UC_UserItem uc = new UC_UserItem { id = id, name = name, pic = img };
                uc.Click += Uc_Click;
                pnQuanLy.Controls.Add(uc);
            }
            foreach (DataRow dr in nv.GetNhanVienTheoMaLoai(2).Rows)
            {
                string id = dr["ID"].ToString();
                string img = dr["Anh"].ToString();
                string name = dr["TenNV"].ToString();
                UC_UserItem uc = new UC_UserItem { id = id, name = name, pic = img }; 
                uc.Click += Uc_Click;
                pnThuNgan.Controls.Add(uc);
            }
            foreach (DataRow dr in nv.GetNhanVienTheoMaLoai(3).Rows)
            {
                string id = dr["ID"].ToString();
                string img = dr["Anh"].ToString();
                string name = dr["TenNV"].ToString();
                UC_UserItem uc = new UC_UserItem { id = id, name = name, pic = img };
                uc.Click += Uc_Click;
                pnOrder.Controls.Add(uc);

            }
            foreach (DataRow dr in nv.GetNhanVienTheoMaLoai(4).Rows)
            {
                string id = dr["ID"].ToString();
                string img = dr["Anh"].ToString();
                string name = dr["TenNV"].ToString();
                UC_UserItem uc = new UC_UserItem { id = id, name = name, pic = img };
                uc.Click += Uc_Click;
                pnCheBien.Controls.Add(uc);
            }

        }

        private void Uc_Click(object sender, EventArgs e)
        {
            UC_UserItem uc = sender as UC_UserItem;
            //MessageBox.Show(uc.id);
            if (kttrungdgv(uc.id) == 0)
            {

                //list.RemoveAt(index);
                Label lbl = new Label();
                lbl.Size = new Size(295, 45);
                //lbl.Text = uc.name;
                ListNhanVien lnv = new ListNhanVien();
                lnv.id = uc.id;
                lnv.name = uc.name;
                lnv.loainv = tabNV.SelectedTab.Text;
                //MessageBox.Show(tabNV.SelectedTab.Text);
                list.Add(lnv);

                dataGridView1.DataSource = null;
                setupColumDGV();
                dataGridView1.DataSource = list;

            }
            else
            {

            }

        }

       
        DataGridViewTextBoxColumn hd1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd3 = new DataGridViewTextBoxColumn();
        DataGridViewButtonColumn hd4 = new DataGridViewButtonColumn();

        private void setupColumDGV()
        {
            dataGridView1.Columns.Clear();
            // Column1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hd1.DataPropertyName = "id";
            hd1.HeaderText = "ID";
            hd1.Name = "Column1";
            hd1.DisplayIndex = 1;
            //hd1.Width = 100;
            hd1.ReadOnly = true;

            hd2.DataPropertyName = "name";
            hd2.HeaderText = "Tên";
            hd2.Name = "Column2";
            hd2.DisplayIndex = 2;
           // hd2.Width = 100;
            hd2.ReadOnly = true;

            hd3.DataPropertyName = "loainv";
            hd3.HeaderText = "Loại nhân viên";
            hd3.Name = "Column3";
            hd3.DisplayIndex = 3;
           // hd3.Width = 100;
            hd3.ReadOnly = true;
            ////
            ///
            hd4.DataPropertyName = "btnXoa";
            hd4.HeaderText = "Xóa";
            hd4.Name = "Column4";
            hd4.DisplayIndex = 4;
            hd4.ReadOnly = true;
          //  hd4.Width = 200;
            hd4.Text = "Xóa";
            hd4.UseColumnTextForButtonValue = true;

            // 
            dataGridView1.Columns.Add(hd1);
            dataGridView1.Columns.Add(hd2);
            dataGridView1.Columns.Add(hd3);
            dataGridView1.Columns.Add(hd4);
        }

        private void btnLapLich_Click(object sender, EventArgs e)
        {
            if (cboCaLam.SelectedIndex != -1)
            {
                int flag = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    string idnv = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    if (pc.insertPhanCong(idnv, cboCaLam.SelectedIndex + 1, ngay, null))
                    {
                        flag = 1;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
                if (flag == 1)
                {
                    alert_success frm = new alert_success();
                    frm.showAlert("Thông báo", "Xếp lịch thành công!", Color.White, Color.FromArgb(51, 105, 30), "checkWhite2x.png", "closeWhite1x.png");
                    frm.BringToFront();
                }
                else
                {
                    alert_success frm = new alert_success();
                    frm.showAlert("Cảnh báo", "Xếp lịch thất bại!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                    frm.BringToFront();
                }
            }
            else
            {
                alert_success frm = new alert_success();
                frm.showAlert("Cảnh báo", "Vui lòng chọn ca làm!", Color.FromArgb(24, 24, 24), Color.FromArgb(255, 214, 0), "warningBlack2x.png", "closeBlack1x.png");
                frm.BringToFront();
            }    
        }
        public DateTime ngay;

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ngay = DateTime.Parse(e.Start.ToShortDateString());
        }

        int index = -1;
        public int kttrungdgv(string idnv)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (idnv == dataGridView1.Rows[i].Cells[1].Value.ToString())
                {
                    index = i;
                    return 1;
                }
            }
            return 0;
        }
        SqlConnection con = null;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                string id = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
               
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }
    }

}
