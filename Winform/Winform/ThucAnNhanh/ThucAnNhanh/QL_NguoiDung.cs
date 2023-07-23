using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucAnNhanh.message_alert;

namespace ThucAnNhanh
{
    public class QL_NguoiDung
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.ChuoiKetNoi2 == string.Empty)
                return 1;
            SqlConnection _sqlCon = new SqlConnection(Properties.Settings.Default.ChuoiKetNoi2);
            try
            {
                if (_sqlCon.State == System.Data.ConnectionState.Closed)
                    _sqlCon.Open();
                return 0;
            }
            catch
            {
                return 2;
            }

        }
        public int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from NhanVien where ID='" + pUser + "' and MatKhau ='" + pPass + "'",
            Properties.Settings.Default.ChuoiKetNoi2);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 10;// User không tồn tại
            else if (dt.Rows[0][8] == null || dt.Rows[0][8].ToString() == "False")
            {
                return 20;// Không hoạt động
            }
            return 30;// Đăng nhập thành công
        }

        public DataTable Search(string tuKhoaTK, string table, string tenCot1, string tenCot2)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + table + " WHERE " + tenCot1 + " LIKE N'%" + tuKhoaTK + "%' or " +  tenCot2 + " LIKE '%" + tuKhoaTK + "%'", Properties.Settings.Default.ChuoiKetNoi2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Search2(string tuKhoaTK, string table, string tenCot1)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + table + " WHERE " + tenCot1 + " LIKE N'%" + tuKhoaTK + "%'", Properties.Settings.Default.ChuoiKetNoi2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Search3(string tuKhoaTK, string table1, string tenCot1, string tenCot2)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + table1 + " where " + tenCot1 + " LIKE N'%" + tuKhoaTK + "%' OR " + tenCot2 + " LIKE '%" + tuKhoaTK + "%'", Properties.Settings.Default.ChuoiKetNoi2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public SqlConnection conn;
        public QL_NguoiDung()
        {            
            conn = new SqlConnection(Properties.Settings.Default.ChuoiKetNoi2);
        }
        public int moKetNoi()
        {
            if (conn.State.ToString() == "Closed") ;
            {
                conn.Open();
                return 1;
            }
            return 0;
        }
        public void dongKetNoi()
        {
            if (conn.State.ToString() == "Open")
                conn.Close();
        }

        public long tinhTongTien1(DataGridView dgv, int cell, int cell2)
        {
            long tongtien = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                tongtien += ((long.Parse(dgv.Rows[i].Cells[cell].Value.ToString())) * long.Parse(dgv.Rows[i].Cells[cell2].Value.ToString()));
            }
            return tongtien;
        }
        public long tinhTongTien(DataGridView dgv, int cell)
        {
            long tongtien = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                tongtien += long.Parse(dgv.Rows[i].Cells[cell].Value.ToString());
            }
            return tongtien;
        }
        public void Alert(string msg, string content, Color foreColor, Color backcolor, string icon, string iconImage)
        {
            alert_success frm = new alert_success();
            frm.showAlert(msg, content, foreColor, backcolor, icon, iconImage);
        }
    }
}
