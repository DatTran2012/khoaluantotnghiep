
namespace ThucAnNhanh.NhanVien
{
    partial class UC_DSNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DSNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.cboLoaiNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDSNhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemNV = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.guna2GradientPanel1.Controls.Add(this.cboLoaiNhanVien);
            this.guna2GradientPanel1.Controls.Add(this.txtTimKiem);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(800, 100);
            this.guna2GradientPanel1.TabIndex = 20;
            // 
            // cboLoaiNhanVien
            // 
            this.cboLoaiNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiNhanVien.BorderColor = System.Drawing.Color.White;
            this.cboLoaiNhanVien.BorderRadius = 15;
            this.cboLoaiNhanVien.BorderThickness = 3;
            this.cboLoaiNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiNhanVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiNhanVien.FocusedState.Parent = this.cboLoaiNhanVien;
            this.cboLoaiNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoaiNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiNhanVien.HoverState.Parent = this.cboLoaiNhanVien;
            this.cboLoaiNhanVien.ItemHeight = 30;
            this.cboLoaiNhanVien.ItemsAppearance.Parent = this.cboLoaiNhanVien;
            this.cboLoaiNhanVien.Location = new System.Drawing.Point(484, 36);
            this.cboLoaiNhanVien.Name = "cboLoaiNhanVien";
            this.cboLoaiNhanVien.ShadowDecoration.Parent = this.cboLoaiNhanVien;
            this.cboLoaiNhanVien.Size = new System.Drawing.Size(294, 36);
            this.cboLoaiNhanVien.TabIndex = 0;
            this.cboLoaiNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboLoaiNhanVien_SelectedIndexChanged);
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
            // dgvDSNhanVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNhanVien.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDSNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSNhanVien.ColumnHeadersHeight = 44;
            this.dgvDSNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvDSNhanVien.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSNhanVien.EnableHeadersVisualStyles = false;
            this.dgvDSNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSNhanVien.Location = new System.Drawing.Point(20, 138);
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.RowHeadersVisible = false;
            this.dgvDSNhanVien.RowHeadersWidth = 51;
            this.dgvDSNhanVien.RowTemplate.Height = 24;
            this.dgvDSNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNhanVien.Size = new System.Drawing.Size(758, 524);
            this.dgvDSNhanVien.TabIndex = 21;
            this.dgvDSNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSNhanVien.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvDSNhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSNhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDSNhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSNhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDSNhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSNhanVien.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvDSNhanVien.ThemeStyle.ReadOnly = false;
            this.dgvDSNhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSNhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSNhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDSNhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSNhanVien.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDSNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNhanVien_CellContentClick);
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
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GioiTinh";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
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
            // Column7
            // 
            this.Column7.DataPropertyName = "CMT";
            this.Column7.HeaderText = "Chứng minh thư";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Anh";
            this.Column8.HeaderText = "Ảnh";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "NgayVL";
            this.Column9.HeaderText = "Ngày vào làm";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "MatKhau";
            this.Column10.HeaderText = "Mật khẩu";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemNV});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 28);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(182, 24);
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // timer1
            // 
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFilter.Location = new System.Drawing.Point(149, 696);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(66, 21);
            this.lblFilter.TabIndex = 27;
            this.lblFilter.Text = "Filter: 0";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRecord.Location = new System.Drawing.Point(16, 696);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(89, 21);
            this.lblRecord.TabIndex = 26;
            this.lblRecord.Text = "Record: 0";
            // 
            // UC_DSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.dgvDSNhanVien);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UC_DSNhanVien";
            this.Size = new System.Drawing.Size(800, 752);
            this.Load += new System.EventHandler(this.UC_DSNhanVien_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSNhanVien;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiNhanVien;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblRecord;
    }
}
