
namespace ThucAnNhanh.Order
{
    partial class UC_ItemMenu
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTen = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGiaKM = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.pic, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 93);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.FillColor = System.Drawing.Color.Transparent;
            this.pic.ImageRotate = 0F;
            this.pic.Location = new System.Drawing.Point(189, 0);
            this.pic.Margin = new System.Windows.Forms.Padding(0);
            this.pic.Name = "pic";
            this.pic.ShadowDecoration.Parent = this.pic;
            this.pic.Size = new System.Drawing.Size(127, 93);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 6;
            this.pic.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblTen, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(183, 86);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // lblTen
            // 
            this.lblTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.lblTen.Location = new System.Drawing.Point(3, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(177, 43);
            this.lblTen.TabIndex = 7;
            this.lblTen.Text = "label1";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblGiaKM, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblGiaBan, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(177, 37);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // lblGiaKM
            // 
            this.lblGiaKM.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGiaKM.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaKM.ForeColor = System.Drawing.Color.Red;
            this.lblGiaKM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGiaKM.Location = new System.Drawing.Point(3, 0);
            this.lblGiaKM.Name = "lblGiaKM";
            this.lblGiaKM.Size = new System.Drawing.Size(65, 37);
            this.lblGiaKM.TabIndex = 9;
            this.lblGiaKM.Text = "35000";
            this.lblGiaKM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGiaBan.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(24)))), ((int)(((byte)(6)))));
            this.lblGiaBan.Location = new System.Drawing.Point(108, 0);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(66, 37);
            this.lblGiaBan.TabIndex = 8;
            this.lblGiaBan.Text = "35000";
            this.lblGiaBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_ItemMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "UC_ItemMenu";
            this.Size = new System.Drawing.Size(316, 125);
            this.Load += new System.EventHandler(this.UC_ItemMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblTen;
        private Guna.UI2.WinForms.Guna2PictureBox pic;
        private System.Windows.Forms.Label lblGiaKM;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
