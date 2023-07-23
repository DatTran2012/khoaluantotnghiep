
namespace ThucAnNhanh.NhanVien
{
    partial class UC_UserItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_UserItem));
            this.picAnh = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // picAnh
            // 
            this.picAnh.Image = ((System.Drawing.Image)(resources.GetObject("picAnh.Image")));
            this.picAnh.ImageRotate = 0F;
            this.picAnh.Location = new System.Drawing.Point(21, 8);
            this.picAnh.Name = "picAnh";
            this.picAnh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAnh.ShadowDecoration.Parent = this.picAnh;
            this.picAnh.Size = new System.Drawing.Size(50, 50);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 2;
            this.picAnh.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(109, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(184, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Chu Nguyễn Gia Hân";
            // 
            // UC_UserItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.lblName);
            this.Name = "UC_UserItem";
            this.Size = new System.Drawing.Size(589, 71);
            this.Load += new System.EventHandler(this.UC_UserItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox picAnh;
        private System.Windows.Forms.Label lblName;
    }
}
