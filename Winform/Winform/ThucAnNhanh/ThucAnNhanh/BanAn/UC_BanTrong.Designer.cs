
namespace ThucAnNhanh.BanAn
{
    partial class UC_BanTrong
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.rdbTang1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbTang2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbTangTret = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbTatCa = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.guna2Panel1.Controls.Add(this.rdbTang1);
            this.guna2Panel1.Controls.Add(this.rdbTang2);
            this.guna2Panel1.Controls.Add(this.rdbTangTret);
            this.guna2Panel1.Controls.Add(this.rdbTatCa);
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(20, 55);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(862, 80);
            this.guna2Panel1.TabIndex = 28;
            // 
            // rdbTang1
            // 
            this.rdbTang1.AutoSize = true;
            this.rdbTang1.CheckedState.BorderColor = System.Drawing.Color.LawnGreen;
            this.rdbTang1.CheckedState.BorderThickness = 0;
            this.rdbTang1.CheckedState.FillColor = System.Drawing.Color.Chartreuse;
            this.rdbTang1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbTang1.CheckedState.InnerOffset = -4;
            this.rdbTang1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTang1.Location = new System.Drawing.Point(467, 27);
            this.rdbTang1.Name = "rdbTang1";
            this.rdbTang1.Size = new System.Drawing.Size(98, 32);
            this.rdbTang1.TabIndex = 3;
            this.rdbTang1.Text = "Tầng 1";
            this.rdbTang1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbTang1.UncheckedState.BorderThickness = 2;
            this.rdbTang1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbTang1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbTang1.CheckedChanged += new System.EventHandler(this.rdbTatCa_CheckedChanged);
            // 
            // rdbTang2
            // 
            this.rdbTang2.AutoSize = true;
            this.rdbTang2.CheckedState.BorderColor = System.Drawing.Color.LawnGreen;
            this.rdbTang2.CheckedState.BorderThickness = 0;
            this.rdbTang2.CheckedState.FillColor = System.Drawing.Color.Chartreuse;
            this.rdbTang2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbTang2.CheckedState.InnerOffset = -4;
            this.rdbTang2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTang2.Location = new System.Drawing.Point(656, 27);
            this.rdbTang2.Name = "rdbTang2";
            this.rdbTang2.Size = new System.Drawing.Size(98, 32);
            this.rdbTang2.TabIndex = 2;
            this.rdbTang2.Text = "Tầng 2";
            this.rdbTang2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbTang2.UncheckedState.BorderThickness = 2;
            this.rdbTang2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbTang2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbTang2.CheckedChanged += new System.EventHandler(this.rdbTatCa_CheckedChanged);
            // 
            // rdbTangTret
            // 
            this.rdbTangTret.AutoSize = true;
            this.rdbTangTret.CheckedState.BorderColor = System.Drawing.Color.LawnGreen;
            this.rdbTangTret.CheckedState.BorderThickness = 0;
            this.rdbTangTret.CheckedState.FillColor = System.Drawing.Color.Chartreuse;
            this.rdbTangTret.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbTangTret.CheckedState.InnerOffset = -4;
            this.rdbTangTret.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTangTret.Location = new System.Drawing.Point(265, 27);
            this.rdbTangTret.Name = "rdbTangTret";
            this.rdbTangTret.Size = new System.Drawing.Size(121, 32);
            this.rdbTangTret.TabIndex = 1;
            this.rdbTangTret.Text = "Tầng trệt";
            this.rdbTangTret.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbTangTret.UncheckedState.BorderThickness = 2;
            this.rdbTangTret.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbTangTret.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbTangTret.CheckedChanged += new System.EventHandler(this.rdbTatCa_CheckedChanged);
            // 
            // rdbTatCa
            // 
            this.rdbTatCa.AutoSize = true;
            this.rdbTatCa.Checked = true;
            this.rdbTatCa.CheckedState.BorderColor = System.Drawing.Color.LawnGreen;
            this.rdbTatCa.CheckedState.BorderThickness = 0;
            this.rdbTatCa.CheckedState.FillColor = System.Drawing.Color.Chartreuse;
            this.rdbTatCa.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbTatCa.CheckedState.InnerOffset = -4;
            this.rdbTatCa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTatCa.Location = new System.Drawing.Point(81, 27);
            this.rdbTatCa.Name = "rdbTatCa";
            this.rdbTatCa.Size = new System.Drawing.Size(91, 32);
            this.rdbTatCa.TabIndex = 0;
            this.rdbTatCa.TabStop = true;
            this.rdbTatCa.Text = "Tất cả";
            this.rdbTatCa.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbTatCa.UncheckedState.BorderThickness = 2;
            this.rdbTatCa.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbTatCa.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbTatCa.CheckedChanged += new System.EventHandler(this.rdbTatCa_CheckedChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFilter.Location = new System.Drawing.Point(41, 544);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(128, 23);
            this.lblFilter.TabIndex = 27;
            this.lblFilter.Text = "Số bàn trống: 0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 133);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(862, 394);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // UC_BanTrong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_BanTrong";
            this.Size = new System.Drawing.Size(906, 607);
            this.Load += new System.EventHandler(this.UC_BanTrong_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2RadioButton rdbTang1;
        private Guna.UI2.WinForms.Guna2RadioButton rdbTang2;
        private Guna.UI2.WinForms.Guna2RadioButton rdbTangTret;
        private Guna.UI2.WinForms.Guna2RadioButton rdbTatCa;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
