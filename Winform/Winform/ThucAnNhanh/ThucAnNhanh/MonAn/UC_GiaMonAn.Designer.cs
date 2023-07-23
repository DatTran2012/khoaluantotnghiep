
namespace ThucAnNhanh.MonAn
{
    partial class UC_GiaMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GiaMonAn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtGiaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemGia = new Guna.UI2.WinForms.Guna2TileButton();
            this.txtGiaKM = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenMonAn = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateToday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.dgvDSBangGia = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBangGia)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
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
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.guna2Panel1.Controls.Add(this.txtGiaBan);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.btnThemGia);
            this.guna2Panel1.Controls.Add(this.txtGiaKM);
            this.guna2Panel1.Controls.Add(this.txtTenMonAn);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.dateToday);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(593, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(313, 607);
            this.guna2Panel1.TabIndex = 23;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.txtGiaBan.BorderRadius = 10;
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.DefaultText = "";
            this.txtGiaBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.DisabledState.Parent = this.txtGiaBan;
            this.txtGiaBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.FocusedState.Parent = this.txtGiaBan;
            this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiaBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.HoverState.Parent = this.txtGiaBan;
            this.txtGiaBan.Location = new System.Drawing.Point(36, 302);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.PlaceholderText = "";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.ShadowDecoration.Parent = this.txtGiaBan;
            this.txtGiaBan.Size = new System.Drawing.Size(244, 36);
            this.txtGiaBan.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giá bán";
            // 
            // btnThemGia
            // 
            this.btnThemGia.CheckedState.Parent = this.btnThemGia;
            this.btnThemGia.CustomImages.Parent = this.btnThemGia;
            this.btnThemGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemGia.DisabledState.Parent = this.btnThemGia;
            this.btnThemGia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemGia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGia.ForeColor = System.Drawing.Color.White;
            this.btnThemGia.HoverState.Parent = this.btnThemGia;
            this.btnThemGia.Image = ((System.Drawing.Image)(resources.GetObject("btnThemGia.Image")));
            this.btnThemGia.ImageSize = new System.Drawing.Size(40, 40);
            this.btnThemGia.Location = new System.Drawing.Point(147, 484);
            this.btnThemGia.Name = "btnThemGia";
            this.btnThemGia.ShadowDecoration.Parent = this.btnThemGia;
            this.btnThemGia.Size = new System.Drawing.Size(133, 88);
            this.btnThemGia.TabIndex = 11;
            this.btnThemGia.Text = "LƯU";
            this.btnThemGia.Click += new System.EventHandler(this.btnThemGia_Click);
            // 
            // txtGiaKM
            // 
            this.txtGiaKM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.txtGiaKM.BorderRadius = 10;
            this.txtGiaKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaKM.DefaultText = "";
            this.txtGiaKM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaKM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaKM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaKM.DisabledState.Parent = this.txtGiaKM;
            this.txtGiaKM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaKM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaKM.FocusedState.Parent = this.txtGiaKM;
            this.txtGiaKM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiaKM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaKM.HoverState.Parent = this.txtGiaKM;
            this.txtGiaKM.Location = new System.Drawing.Point(36, 391);
            this.txtGiaKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGiaKM.Name = "txtGiaKM";
            this.txtGiaKM.PasswordChar = '\0';
            this.txtGiaKM.PlaceholderText = "";
            this.txtGiaKM.SelectedText = "";
            this.txtGiaKM.ShadowDecoration.Parent = this.txtGiaKM;
            this.txtGiaKM.Size = new System.Drawing.Size(244, 36);
            this.txtGiaKM.TabIndex = 10;
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.txtTenMonAn.BorderRadius = 10;
            this.txtTenMonAn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMonAn.DefaultText = "";
            this.txtTenMonAn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMonAn.DisabledState.Parent = this.txtTenMonAn;
            this.txtTenMonAn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMonAn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMonAn.FocusedState.Parent = this.txtTenMonAn;
            this.txtTenMonAn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenMonAn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMonAn.HoverState.Parent = this.txtTenMonAn;
            this.txtTenMonAn.Location = new System.Drawing.Point(35, 124);
            this.txtTenMonAn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.PasswordChar = '\0';
            this.txtTenMonAn.PlaceholderText = "";
            this.txtTenMonAn.ReadOnly = true;
            this.txtTenMonAn.SelectedText = "";
            this.txtTenMonAn.ShadowDecoration.Parent = this.txtTenMonAn;
            this.txtTenMonAn.Size = new System.Drawing.Size(244, 36);
            this.txtTenMonAn.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá khuyến mãi";
            // 
            // dateToday
            // 
            this.dateToday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.dateToday.BorderRadius = 10;
            this.dateToday.BorderThickness = 1;
            this.dateToday.CheckedState.Parent = this.dateToday;
            this.dateToday.FillColor = System.Drawing.Color.White;
            this.dateToday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateToday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateToday.HoverState.Parent = this.dateToday;
            this.dateToday.Location = new System.Drawing.Point(36, 213);
            this.dateToday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateToday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateToday.Name = "dateToday";
            this.dateToday.ShadowDecoration.Parent = this.dateToday;
            this.dateToday.Size = new System.Drawing.Size(244, 36);
            this.dateToday.TabIndex = 5;
            this.dateToday.Value = new System.DateTime(2021, 10, 11, 19, 6, 15, 102);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày áp dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên món ăn";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(593, 607);
            this.guna2Panel2.TabIndex = 25;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.lblFilter);
            this.guna2Panel4.Controls.Add(this.lblRecord);
            this.guna2Panel4.Controls.Add(this.dgvDSBangGia);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(593, 507);
            this.guna2Panel4.TabIndex = 27;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFilter.Location = new System.Drawing.Point(172, 451);
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
            this.lblRecord.Location = new System.Drawing.Point(39, 451);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(89, 21);
            this.lblRecord.TabIndex = 24;
            this.lblRecord.Text = "Record: 0";
            // 
            // dgvDSBangGia
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSBangGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSBangGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSBangGia.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDSBangGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSBangGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSBangGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSBangGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSBangGia.ColumnHeadersHeight = 44;
            this.dgvDSBangGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSBangGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSBangGia.EnableHeadersVisualStyles = false;
            this.dgvDSBangGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSBangGia.Location = new System.Drawing.Point(20, 38);
            this.dgvDSBangGia.Name = "dgvDSBangGia";
            this.dgvDSBangGia.RowHeadersVisible = false;
            this.dgvDSBangGia.RowHeadersWidth = 51;
            this.dgvDSBangGia.RowTemplate.Height = 24;
            this.dgvDSBangGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSBangGia.Size = new System.Drawing.Size(555, 374);
            this.dgvDSBangGia.TabIndex = 23;
            this.dgvDSBangGia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSBangGia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSBangGia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSBangGia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSBangGia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSBangGia.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvDSBangGia.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSBangGia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDSBangGia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSBangGia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDSBangGia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSBangGia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSBangGia.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvDSBangGia.ThemeStyle.ReadOnly = false;
            this.dgvDSBangGia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSBangGia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSBangGia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDSBangGia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSBangGia.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDSBangGia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSBangGia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSBangGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBangGia_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_MonAn";
            this.Column1.HeaderText = "ID món ăn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMA";
            this.Column2.HeaderText = "Tên món ăn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayAD";
            this.Column3.HeaderText = "Ngày áp dụng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GiaBan";
            this.Column4.HeaderText = "Giá bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GiaKhuyenMai";
            this.Column5.HeaderText = "Giá khuyến mãi";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.guna2Panel3.Controls.Add(this.txtTimKiem);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(593, 100);
            this.guna2Panel3.TabIndex = 26;
            // 
            // UC_GiaMonAn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_GiaMonAn";
            this.Size = new System.Drawing.Size(906, 607);
            this.Load += new System.EventHandler(this.UC_GiaMonAn_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBangGia)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaKM;
        private Guna.UI2.WinForms.Guna2TextBox txtTenMonAn;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateToday;
        private Guna.UI2.WinForms.Guna2TileButton btnThemGia;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSBangGia;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBan;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
    }
}
