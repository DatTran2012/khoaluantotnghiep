
namespace ThucAnNhanh.KhachHang
{
    partial class FrmTimKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKH));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dgvDSKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiem.BorderColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderRadius = 15;
            this.txtTimKiem.BorderThickness = 0;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.IconLeft")));
            this.txtTimKiem.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtTimKiem.Location = new System.Drawing.Point(320, 40);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(318, 36);
            this.txtTimKiem.TabIndex = 14;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFilter.Location = new System.Drawing.Point(37, 390);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(66, 21);
            this.lblFilter.TabIndex = 26;
            this.lblFilter.Text = "Filter: 0";
            // 
            // dgvDSKhachHang
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDSKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKhachHang.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDSKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDSKhachHang.ColumnHeadersHeight = 44;
            this.dgvDSKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column10,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSKhachHang.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDSKhachHang.EnableHeadersVisualStyles = false;
            this.dgvDSKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSKhachHang.Location = new System.Drawing.Point(12, 93);
            this.dgvDSKhachHang.Name = "dgvDSKhachHang";
            this.dgvDSKhachHang.RowHeadersVisible = false;
            this.dgvDSKhachHang.RowHeadersWidth = 51;
            this.dgvDSKhachHang.RowTemplate.Height = 24;
            this.dgvDSKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKhachHang.Size = new System.Drawing.Size(930, 320);
            this.dgvDSKhachHang.TabIndex = 27;
            this.dgvDSKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSKhachHang.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvDSKhachHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSKhachHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDSKhachHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSKhachHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDSKhachHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSKhachHang.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvDSKhachHang.ThemeStyle.ReadOnly = false;
            this.dgvDSKhachHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSKhachHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSKhachHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDSKhachHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSKhachHang.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDSKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKhachHang_CellClick);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(846, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 29;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(897, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.FillWeight = 350F;
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GioiTinh";
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Giới tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.FillWeight = 150F;
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiaChi";
            this.Column5.FillWeight = 320F;
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            this.Column6.FillWeight = 200F;
            this.Column6.HeaderText = "Số điện thoại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "DiemTichLuy";
            this.Column10.FillWeight = 80F;
            this.Column10.HeaderText = "Điểm tích lũy";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Email";
            this.Column7.HeaderText = "Email";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MatKhau";
            this.Column8.HeaderText = "Mật khẩu";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // FrmTimKH
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(954, 425);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.dgvDSKhachHang);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.txtTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTimKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTimKH";
            this.Load += new System.EventHandler(this.FrmTimKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label lblFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSKhachHang;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}