
namespace ThucAnNhanh.KhachHang
{
    partial class UC_DSKhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DSKhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDSKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.guna2GradientPanel1.Controls.Add(this.txtTimKiem);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(906, 100);
            this.guna2GradientPanel1.TabIndex = 21;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiem.BorderColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderRadius = 15;
            this.txtTimKiem.BorderThickness = 3;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.IconLeft")));
            this.txtTimKiem.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtTimKiem.Location = new System.Drawing.Point(20, 36);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(294, 36);
            this.txtTimKiem.TabIndex = 13;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvDSKhachHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKhachHang.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDSKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSKhachHang.ColumnHeadersHeight = 44;
            this.dgvDSKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column10});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSKhachHang.EnableHeadersVisualStyles = false;
            this.dgvDSKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSKhachHang.Location = new System.Drawing.Point(20, 138);
            this.dgvDSKhachHang.Name = "dgvDSKhachHang";
            this.dgvDSKhachHang.RowHeadersVisible = false;
            this.dgvDSKhachHang.RowHeadersWidth = 51;
            this.dgvDSKhachHang.RowTemplate.Height = 24;
            this.dgvDSKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKhachHang.Size = new System.Drawing.Size(867, 374);
            this.dgvDSKhachHang.TabIndex = 22;
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
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GioiTinh";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiaChi";
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            this.Column6.HeaderText = "Số điện thoại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "DiemTichLuy";
            this.Column10.HeaderText = "Điểm tích lũy";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFilter.Location = new System.Drawing.Point(172, 551);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(66, 21);
            this.lblFilter.TabIndex = 25;
            this.lblFilter.Text = "Filter: 0";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRecord.Location = new System.Drawing.Point(39, 551);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(89, 21);
            this.lblRecord.TabIndex = 24;
            this.lblRecord.Text = "Record: 0";
            // 
            // UC_DSKhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.dgvDSKhachHang);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UC_DSKhachHang";
            this.Size = new System.Drawing.Size(906, 607);
            this.Load += new System.EventHandler(this.UC_DSKhachHang_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblRecord;
    }
}
