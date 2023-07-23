
namespace ThucAnNhanh.XepLich
{
    partial class UC_XepLich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateNgayLam = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboCaLam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboQuanLy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboThuNgan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboCheBien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboOrder = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnPhanCongQL = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.lblQuanLy = new System.Windows.Forms.Label();
            this.lblThuNgan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblCheBien = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPhanCongCB = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhanCongTN = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhanCongOrder = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCheBienThieu = new System.Windows.Forms.Label();
            this.lblOrderThieu = new System.Windows.Forms.Label();
            this.lblThuNganThieu = new System.Windows.Forms.Label();
            this.lblQuanLyThieu = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNgayLam
            // 
            this.dateNgayLam.BackColor = System.Drawing.SystemColors.Control;
            this.dateNgayLam.CheckedState.Parent = this.dateNgayLam;
            this.dateNgayLam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.dateNgayLam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayLam.ForeColor = System.Drawing.Color.White;
            this.dateNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateNgayLam.HoverState.Parent = this.dateNgayLam;
            this.dateNgayLam.Location = new System.Drawing.Point(137, 20);
            this.dateNgayLam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayLam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayLam.Name = "dateNgayLam";
            this.dateNgayLam.ShadowDecoration.Parent = this.dateNgayLam;
            this.dateNgayLam.Size = new System.Drawing.Size(287, 36);
            this.dateNgayLam.TabIndex = 21;
            this.dateNgayLam.Value = new System.DateTime(2021, 12, 26, 11, 25, 58, 949);
            this.dateNgayLam.ValueChanged += new System.EventHandler(this.dateNgayLam_ValueChanged);
            // 
            // cboCaLam
            // 
            this.cboCaLam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.cboCaLam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCaLam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaLam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCaLam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCaLam.FocusedState.Parent = this.cboCaLam;
            this.cboCaLam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCaLam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCaLam.HoverState.Parent = this.cboCaLam;
            this.cboCaLam.ItemHeight = 30;
            this.cboCaLam.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3"});
            this.cboCaLam.ItemsAppearance.Parent = this.cboCaLam;
            this.cboCaLam.Location = new System.Drawing.Point(570, 20);
            this.cboCaLam.Name = "cboCaLam";
            this.cboCaLam.ShadowDecoration.Parent = this.cboCaLam;
            this.cboCaLam.Size = new System.Drawing.Size(286, 36);
            this.cboCaLam.TabIndex = 20;
            this.cboCaLam.SelectedIndexChanged += new System.EventHandler(this.cboCaLam_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ca làm:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ngày:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboQuanLy
            // 
            this.cboQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.cboQuanLy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboQuanLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuanLy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboQuanLy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboQuanLy.FocusedState.Parent = this.cboQuanLy;
            this.cboQuanLy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboQuanLy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboQuanLy.HoverState.Parent = this.cboQuanLy;
            this.cboQuanLy.ItemHeight = 30;
            this.cboQuanLy.ItemsAppearance.Parent = this.cboQuanLy;
            this.cboQuanLy.Location = new System.Drawing.Point(137, 100);
            this.cboQuanLy.Name = "cboQuanLy";
            this.cboQuanLy.ShadowDecoration.Parent = this.cboQuanLy;
            this.cboQuanLy.Size = new System.Drawing.Size(214, 36);
            this.cboQuanLy.TabIndex = 24;
            // 
            // cboThuNgan
            // 
            this.cboThuNgan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.cboThuNgan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThuNgan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuNgan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboThuNgan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboThuNgan.FocusedState.Parent = this.cboThuNgan;
            this.cboThuNgan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboThuNgan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboThuNgan.HoverState.Parent = this.cboThuNgan;
            this.cboThuNgan.ItemHeight = 30;
            this.cboThuNgan.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3"});
            this.cboThuNgan.ItemsAppearance.Parent = this.cboThuNgan;
            this.cboThuNgan.Location = new System.Drawing.Point(570, 100);
            this.cboThuNgan.Name = "cboThuNgan";
            this.cboThuNgan.ShadowDecoration.Parent = this.cboThuNgan;
            this.cboThuNgan.Size = new System.Drawing.Size(213, 36);
            this.cboThuNgan.TabIndex = 25;
            // 
            // cboCheBien
            // 
            this.cboCheBien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.cboCheBien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCheBien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCheBien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCheBien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCheBien.FocusedState.Parent = this.cboCheBien;
            this.cboCheBien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCheBien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCheBien.HoverState.Parent = this.cboCheBien;
            this.cboCheBien.ItemHeight = 30;
            this.cboCheBien.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3"});
            this.cboCheBien.ItemsAppearance.Parent = this.cboCheBien;
            this.cboCheBien.Location = new System.Drawing.Point(137, 180);
            this.cboCheBien.Name = "cboCheBien";
            this.cboCheBien.ShadowDecoration.Parent = this.cboCheBien;
            this.cboCheBien.Size = new System.Drawing.Size(214, 36);
            this.cboCheBien.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quản lý:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Thu ngân:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "Chế biến:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(476, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 32);
            this.label6.TabIndex = 31;
            this.label6.Text = "Order:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboOrder
            // 
            this.cboOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.cboOrder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrder.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboOrder.FocusedState.Parent = this.cboOrder;
            this.cboOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboOrder.HoverState.Parent = this.cboOrder;
            this.cboOrder.ItemHeight = 30;
            this.cboOrder.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3"});
            this.cboOrder.ItemsAppearance.Parent = this.cboOrder;
            this.cboOrder.Location = new System.Drawing.Point(570, 180);
            this.cboOrder.Name = "cboOrder";
            this.cboOrder.ShadowDecoration.Parent = this.cboOrder;
            this.cboOrder.Size = new System.Drawing.Size(213, 36);
            this.cboOrder.TabIndex = 30;
            // 
            // btnPhanCongQL
            // 
            this.btnPhanCongQL.CheckedState.Parent = this.btnPhanCongQL;
            this.btnPhanCongQL.CustomImages.Parent = this.btnPhanCongQL;
            this.btnPhanCongQL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanCongQL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanCongQL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhanCongQL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhanCongQL.DisabledState.Parent = this.btnPhanCongQL;
            this.btnPhanCongQL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(173)))), ((int)(((byte)(23)))));
            this.btnPhanCongQL.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCongQL.ForeColor = System.Drawing.Color.White;
            this.btnPhanCongQL.HoverState.Parent = this.btnPhanCongQL;
            this.btnPhanCongQL.Location = new System.Drawing.Point(357, 102);
            this.btnPhanCongQL.Name = "btnPhanCongQL";
            this.btnPhanCongQL.ShadowDecoration.Parent = this.btnPhanCongQL;
            this.btnPhanCongQL.Size = new System.Drawing.Size(67, 34);
            this.btnPhanCongQL.TabIndex = 32;
            this.btnPhanCongQL.Text = "XẾP";
            this.btnPhanCongQL.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.AllowUserToAddRows = false;
            this.dgvPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(173)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(173)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvPhanCong.EnableHeadersVisualStyles = false;
            this.dgvPhanCong.Location = new System.Drawing.Point(48, 256);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.RowHeadersVisible = false;
            this.dgvPhanCong.RowHeadersWidth = 51;
            this.dgvPhanCong.RowTemplate.Height = 24;
            this.dgvPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanCong.Size = new System.Drawing.Size(657, 246);
            this.dgvPhanCong.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDNV";
            this.Column1.HeaderText = "ID nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayLam";
            this.Column3.HeaderText = "Ngày làm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CaLam";
            this.Column4.HeaderText = "Ca làm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiemDanh";
            this.Column5.HeaderText = "Điểm danh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 32);
            this.label7.TabIndex = 34;
            this.label7.Text = "Quản lý:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuanLy
            // 
            this.lblQuanLy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLy.Location = new System.Drawing.Point(173, 517);
            this.lblQuanLy.Name = "lblQuanLy";
            this.lblQuanLy.Size = new System.Drawing.Size(46, 32);
            this.lblQuanLy.TabIndex = 35;
            this.lblQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThuNgan
            // 
            this.lblThuNgan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuNgan.Location = new System.Drawing.Point(398, 517);
            this.lblThuNgan.Name = "lblThuNgan";
            this.lblThuNgan.Size = new System.Drawing.Size(46, 32);
            this.lblThuNgan.TabIndex = 37;
            this.lblThuNgan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(296, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 32);
            this.label9.TabIndex = 36;
            this.label9.Text = "Thu ngân:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrder
            // 
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(604, 517);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(46, 32);
            this.lblOrder.TabIndex = 39;
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(519, 517);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 32);
            this.label.TabIndex = 38;
            this.label.Text = "Order:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCheBien
            // 
            this.lblCheBien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheBien.Location = new System.Drawing.Point(814, 517);
            this.lblCheBien.Name = "lblCheBien";
            this.lblCheBien.Size = new System.Drawing.Size(42, 32);
            this.lblCheBien.TabIndex = 41;
            this.lblCheBien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(724, 517);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 32);
            this.label13.TabIndex = 40;
            this.label13.Text = "Chế biến:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPhanCongCB
            // 
            this.btnPhanCongCB.CheckedState.Parent = this.btnPhanCongCB;
            this.btnPhanCongCB.CustomImages.Parent = this.btnPhanCongCB;
            this.btnPhanCongCB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanCongCB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanCongCB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhanCongCB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhanCongCB.DisabledState.Parent = this.btnPhanCongCB;
            this.btnPhanCongCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(173)))), ((int)(((byte)(23)))));
            this.btnPhanCongCB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCongCB.ForeColor = System.Drawing.Color.White;
            this.btnPhanCongCB.HoverState.Parent = this.btnPhanCongCB;
            this.btnPhanCongCB.Location = new System.Drawing.Point(357, 182);
            this.btnPhanCongCB.Name = "btnPhanCongCB";
            this.btnPhanCongCB.ShadowDecoration.Parent = this.btnPhanCongCB;
            this.btnPhanCongCB.Size = new System.Drawing.Size(67, 34);
            this.btnPhanCongCB.TabIndex = 42;
            this.btnPhanCongCB.Text = "XẾP";
            this.btnPhanCongCB.Click += new System.EventHandler(this.btnPhanCongCB_Click);
            // 
            // btnPhanCongTN
            // 
            this.btnPhanCongTN.CheckedState.Parent = this.btnPhanCongTN;
            this.btnPhanCongTN.CustomImages.Parent = this.btnPhanCongTN;
            this.btnPhanCongTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanCongTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanCongTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhanCongTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhanCongTN.DisabledState.Parent = this.btnPhanCongTN;
            this.btnPhanCongTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(173)))), ((int)(((byte)(23)))));
            this.btnPhanCongTN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCongTN.ForeColor = System.Drawing.Color.White;
            this.btnPhanCongTN.HoverState.Parent = this.btnPhanCongTN;
            this.btnPhanCongTN.Location = new System.Drawing.Point(789, 102);
            this.btnPhanCongTN.Name = "btnPhanCongTN";
            this.btnPhanCongTN.ShadowDecoration.Parent = this.btnPhanCongTN;
            this.btnPhanCongTN.Size = new System.Drawing.Size(67, 34);
            this.btnPhanCongTN.TabIndex = 43;
            this.btnPhanCongTN.Text = "XẾP";
            this.btnPhanCongTN.Click += new System.EventHandler(this.btnPhanCongTN_Click);
            // 
            // btnPhanCongOrder
            // 
            this.btnPhanCongOrder.CheckedState.Parent = this.btnPhanCongOrder;
            this.btnPhanCongOrder.CustomImages.Parent = this.btnPhanCongOrder;
            this.btnPhanCongOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanCongOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanCongOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhanCongOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhanCongOrder.DisabledState.Parent = this.btnPhanCongOrder;
            this.btnPhanCongOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(173)))), ((int)(((byte)(23)))));
            this.btnPhanCongOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCongOrder.ForeColor = System.Drawing.Color.White;
            this.btnPhanCongOrder.HoverState.Parent = this.btnPhanCongOrder;
            this.btnPhanCongOrder.Location = new System.Drawing.Point(789, 182);
            this.btnPhanCongOrder.Name = "btnPhanCongOrder";
            this.btnPhanCongOrder.ShadowDecoration.Parent = this.btnPhanCongOrder;
            this.btnPhanCongOrder.Size = new System.Drawing.Size(67, 34);
            this.btnPhanCongOrder.TabIndex = 44;
            this.btnPhanCongOrder.Text = "XẾP";
            this.btnPhanCongOrder.Click += new System.EventHandler(this.btnPhanCongOrder_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 559);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 32);
            this.label8.TabIndex = 45;
            this.label8.Text = "Thiếu:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCheBienThieu
            // 
            this.lblCheBienThieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheBienThieu.ForeColor = System.Drawing.Color.Red;
            this.lblCheBienThieu.Location = new System.Drawing.Point(814, 559);
            this.lblCheBienThieu.Name = "lblCheBienThieu";
            this.lblCheBienThieu.Size = new System.Drawing.Size(42, 32);
            this.lblCheBienThieu.TabIndex = 49;
            this.lblCheBienThieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderThieu
            // 
            this.lblOrderThieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderThieu.ForeColor = System.Drawing.Color.Red;
            this.lblOrderThieu.Location = new System.Drawing.Point(604, 559);
            this.lblOrderThieu.Name = "lblOrderThieu";
            this.lblOrderThieu.Size = new System.Drawing.Size(46, 32);
            this.lblOrderThieu.TabIndex = 48;
            this.lblOrderThieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThuNganThieu
            // 
            this.lblThuNganThieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuNganThieu.ForeColor = System.Drawing.Color.Red;
            this.lblThuNganThieu.Location = new System.Drawing.Point(398, 559);
            this.lblThuNganThieu.Name = "lblThuNganThieu";
            this.lblThuNganThieu.Size = new System.Drawing.Size(46, 32);
            this.lblThuNganThieu.TabIndex = 47;
            this.lblThuNganThieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuanLyThieu
            // 
            this.lblQuanLyThieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyThieu.ForeColor = System.Drawing.Color.Red;
            this.lblQuanLyThieu.Location = new System.Drawing.Point(173, 559);
            this.lblQuanLyThieu.Name = "lblQuanLyThieu";
            this.lblQuanLyThieu.Size = new System.Drawing.Size(46, 32);
            this.lblQuanLyThieu.TabIndex = 46;
            this.lblQuanLyThieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHuy
            // 
            this.btnHuy.CheckedState.Parent = this.btnHuy;
            this.btnHuy.CustomImages.Parent = this.btnHuy;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.DisabledState.Parent = this.btnHuy;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.HoverState.Parent = this.btnHuy;
            this.btnHuy.Location = new System.Drawing.Point(728, 434);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ShadowDecoration.Parent = this.btnHuy;
            this.btnHuy.Size = new System.Drawing.Size(128, 68);
            this.btnHuy.TabIndex = 50;
            this.btnHuy.Text = "HỦY XẾP LỊCH";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // UC_XepLich
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblCheBienThieu);
            this.Controls.Add(this.lblOrderThieu);
            this.Controls.Add(this.lblThuNganThieu);
            this.Controls.Add(this.lblQuanLyThieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPhanCongOrder);
            this.Controls.Add(this.btnPhanCongTN);
            this.Controls.Add(this.btnPhanCongCB);
            this.Controls.Add(this.lblCheBien);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblThuNgan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblQuanLy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvPhanCong);
            this.Controls.Add(this.btnPhanCongQL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCheBien);
            this.Controls.Add(this.cboThuNgan);
            this.Controls.Add(this.cboQuanLy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateNgayLam);
            this.Controls.Add(this.cboCaLam);
            this.Name = "UC_XepLich";
            this.Size = new System.Drawing.Size(906, 607);
            this.Load += new System.EventHandler(this.UC_XepLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgayLam;
        private Guna.UI2.WinForms.Guna2ComboBox cboCaLam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cboQuanLy;
        private Guna.UI2.WinForms.Guna2ComboBox cboThuNgan;
        private Guna.UI2.WinForms.Guna2ComboBox cboCheBien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cboOrder;
        private Guna.UI2.WinForms.Guna2Button btnPhanCongQL;
        private System.Windows.Forms.DataGridView dgvPhanCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblQuanLy;
        private System.Windows.Forms.Label lblThuNgan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblCheBien;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button btnPhanCongCB;
        private Guna.UI2.WinForms.Guna2Button btnPhanCongTN;
        private Guna.UI2.WinForms.Guna2Button btnPhanCongOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCheBienThieu;
        private System.Windows.Forms.Label lblOrderThieu;
        private System.Windows.Forms.Label lblThuNganThieu;
        private System.Windows.Forms.Label lblQuanLyThieu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}
