
namespace ThucAnNhanh.ThongKe
{
    partial class Form1
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
            this.uC_ThongKe1 = new ThucAnNhanh.ThongKe.UC_ThongKe();
            this.SuspendLayout();
            // 
            // uC_ThongKe1
            // 
            this.uC_ThongKe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.uC_ThongKe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_ThongKe1.Location = new System.Drawing.Point(0, 0);
            this.uC_ThongKe1.Name = "uC_ThongKe1";
            this.uC_ThongKe1.Size = new System.Drawing.Size(800, 450);
            this.uC_ThongKe1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uC_ThongKe1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_ThongKe uC_ThongKe1;
    }
}