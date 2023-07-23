
namespace ThucAnNhanh.XepLich
{
    partial class FrmXepLich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCaLam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tabNV = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pnQuanLy = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pnThuNgan = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.pnOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.pnCheBien = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLapLich = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabNV.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.tabNV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(262, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 367);
            this.panel2.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cboCaLam);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 51);
            this.panel4.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Chọn ca làm:";
            // 
            // cboCaLam
            // 
            this.cboCaLam.BackColor = System.Drawing.Color.Transparent;
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
            "Ca 1 (8h - 13h)",
            "Ca 2 (13h - 18h)",
            "Ca 3 (18h - 22h)"});
            this.cboCaLam.ItemsAppearance.Parent = this.cboCaLam;
            this.cboCaLam.Location = new System.Drawing.Point(119, 9);
            this.cboCaLam.Name = "cboCaLam";
            this.cboCaLam.ShadowDecoration.Parent = this.cboCaLam;
            this.cboCaLam.Size = new System.Drawing.Size(236, 36);
            this.cboCaLam.TabIndex = 22;
            // 
            // tabNV
            // 
            this.tabNV.Controls.Add(this.tabPage4);
            this.tabNV.Controls.Add(this.tabPage5);
            this.tabNV.Controls.Add(this.tabPage6);
            this.tabNV.Controls.Add(this.tabPage7);
            this.tabNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabNV.Font = new System.Drawing.Font("Century Gothic", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNV.ItemSize = new System.Drawing.Size(73, 40);
            this.tabNV.Location = new System.Drawing.Point(0, 51);
            this.tabNV.Name = "tabNV";
            this.tabNV.SelectedIndex = 0;
            this.tabNV.Size = new System.Drawing.Size(372, 316);
            this.tabNV.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabNV.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabNV.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabNV.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabNV.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabNV.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabNV.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tabNV.TabButtonIdleState.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNV.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabNV.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabNV.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabNV.TabButtonSelectedState.FillColor = System.Drawing.Color.Black;
            this.tabNV.TabButtonSelectedState.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNV.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabNV.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabNV.TabButtonSize = new System.Drawing.Size(73, 40);
            this.tabNV.TabIndex = 22;
            this.tabNV.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tabNV.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.tabNV.Tag = "Quản lý";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pnQuanLy);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(364, 268);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Quản lý";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pnQuanLy
            // 
            this.pnQuanLy.AutoScroll = true;
            this.pnQuanLy.BackColor = System.Drawing.Color.White;
            this.pnQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnQuanLy.Location = new System.Drawing.Point(3, 3);
            this.pnQuanLy.Name = "pnQuanLy";
            this.pnQuanLy.Size = new System.Drawing.Size(358, 262);
            this.pnQuanLy.TabIndex = 14;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pnThuNgan);
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(364, 268);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Thu ngân";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pnThuNgan
            // 
            this.pnThuNgan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThuNgan.Location = new System.Drawing.Point(3, 3);
            this.pnThuNgan.Name = "pnThuNgan";
            this.pnThuNgan.Size = new System.Drawing.Size(358, 262);
            this.pnThuNgan.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.pnOrder);
            this.tabPage6.Location = new System.Drawing.Point(4, 44);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(364, 268);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Order";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // pnOrder
            // 
            this.pnOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnOrder.Location = new System.Drawing.Point(0, 0);
            this.pnOrder.Name = "pnOrder";
            this.pnOrder.Size = new System.Drawing.Size(364, 268);
            this.pnOrder.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.pnCheBien);
            this.tabPage7.Location = new System.Drawing.Point(4, 44);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(364, 268);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "Chế biến";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // pnCheBien
            // 
            this.pnCheBien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCheBien.Location = new System.Drawing.Point(0, 0);
            this.pnCheBien.Name = "pnCheBien";
            this.pnCheBien.Size = new System.Drawing.Size(364, 268);
            this.pnCheBien.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.guna2Panel1);
            this.panel3.Controls.Add(this.btnLapLich);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(634, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 367);
            this.panel3.TabIndex = 22;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dataGridView1);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(296, 322);
            this.guna2Panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // btnLapLich
            // 
            this.btnLapLich.BackColor = System.Drawing.Color.Transparent;
            this.btnLapLich.CheckedState.Parent = this.btnLapLich;
            this.btnLapLich.CustomImages.Parent = this.btnLapLich;
            this.btnLapLich.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLapLich.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLapLich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLapLich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLapLich.DisabledState.Parent = this.btnLapLich;
            this.btnLapLich.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLapLich.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(173)))), ((int)(((byte)(23)))));
            this.btnLapLich.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapLich.ForeColor = System.Drawing.Color.White;
            this.btnLapLich.HoverState.Parent = this.btnLapLich;
            this.btnLapLich.Location = new System.Drawing.Point(0, 322);
            this.btnLapLich.Name = "btnLapLich";
            this.btnLapLich.ShadowDecoration.Parent = this.btnLapLich;
            this.btnLapLich.Size = new System.Drawing.Size(296, 45);
            this.btnLapLich.TabIndex = 1;
            this.btnLapLich.Text = "LẬP LỊCH";
            this.btnLapLich.Click += new System.EventHandler(this.btnLapLich_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mỗi ca tối thiểu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 76);
            this.label2.TabIndex = 22;
            this.label2.Text = "- 1 quản lý\r\n- 1 thu ngân\r\n- 2 order\r\n- 2 chế biến";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.Controls.Add(this.panel2);
            this.guna2CustomGradientPanel1.Controls.Add(this.panel1);
            this.guna2CustomGradientPanel1.Controls.Add(this.panel3);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 46);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(930, 367);
            this.guna2CustomGradientPanel1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.guna2Panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 367);
            this.panel1.TabIndex = 20;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.monthCalendar1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(262, 226);
            this.guna2Panel2.TabIndex = 23;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 21;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
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
            this.guna2ControlBox1.TabIndex = 24;
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
            this.guna2ControlBox2.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(296, 271);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "loainv";
            this.Column3.HeaderText = "Loại nhân viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "btnXoa";
            this.Column4.HeaderText = "Xóa";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // FrmXepLich
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(954, 425);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmXepLich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmXepLich";
            this.Load += new System.EventHandler(this.FrmXepLich_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabNV.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnLapLich;
        private Guna.UI2.WinForms.Guna2TabControl tabNV;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FlowLayoutPanel pnQuanLy;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.FlowLayoutPanel pnThuNgan;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.FlowLayoutPanel pnOrder;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.FlowLayoutPanel pnCheBien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cboCaLam;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}