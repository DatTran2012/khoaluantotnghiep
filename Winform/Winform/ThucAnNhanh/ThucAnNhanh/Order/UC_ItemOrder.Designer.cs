
namespace ThucAnNhanh.Order
{
    partial class UC_ItemOrder
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
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.ForeColor = System.Drawing.Color.Black;
            this.lblTenKH.Location = new System.Drawing.Point(101, 16);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(159, 25);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "Trần Huyền Trang";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChi.Location = new System.Drawing.Point(102, 53);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(334, 23);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Ấp Vĩnh Lộc A, huyện Bình Chánh, TPHCM";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.DisabledState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(173)))), ((int)(((byte)(23)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(34, 16);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(65, 65);
            this.guna2CircleButton1.TabIndex = 2;
            this.guna2CircleButton1.Text = "20";
            // 
            // UC_ItemOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTenKH);
            this.Name = "UC_ItemOrder";
            this.Size = new System.Drawing.Size(498, 100);
            this.Load += new System.EventHandler(this.UC_ItemOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblDiaChi;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}
