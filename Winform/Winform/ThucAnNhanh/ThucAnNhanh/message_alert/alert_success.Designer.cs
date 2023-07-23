
namespace ThucAnNhanh.message_alert
{
    partial class alert_success
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alert_success));
            this.label1 = new System.Windows.Forms.Label();
            this.picIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(96, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message test";
            // 
            // picIcon
            // 
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.ImageRotate = 0F;
            this.picIcon.Location = new System.Drawing.Point(30, 35);
            this.picIcon.Name = "picIcon";
            this.picIcon.ShadowDecoration.Parent = this.picIcon;
            this.picIcon.Size = new System.Drawing.Size(60, 60);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 2;
            this.picIcon.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(304, 37);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 60);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btncClose_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(96, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 53);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message test";
            // 
            // alert_success
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(376, 134);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alert_success";
            this.Text = "alert_success";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox picIcon;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
    }
}