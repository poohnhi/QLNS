﻿namespace QLNhaSach
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.NhaSachVietNam = new System.Windows.Forms.Label();
            this.NutGioiThieu = new System.Windows.Forms.Button();
            this.NutDangNhap = new System.Windows.Forms.Button();
            this.NutDangKy = new System.Windows.Forms.Button();
            this.NutLienHe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NhaSachVietNam
            // 
            this.NhaSachVietNam.AutoSize = true;
            this.NhaSachVietNam.BackColor = System.Drawing.Color.Transparent;
            this.NhaSachVietNam.Font = new System.Drawing.Font("Times New Roman", 56F);
            this.NhaSachVietNam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NhaSachVietNam.Location = new System.Drawing.Point(12, 28);
            this.NhaSachVietNam.Name = "NhaSachVietNam";
            this.NhaSachVietNam.Size = new System.Drawing.Size(797, 85);
            this.NhaSachVietNam.TabIndex = 0;
            this.NhaSachVietNam.Text = "NHÀ SÁCH VIỆT NAM";
            this.NhaSachVietNam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NutGioiThieu
            // 
            this.NutGioiThieu.BackColor = System.Drawing.SystemColors.Window;
            this.NutGioiThieu.Font = new System.Drawing.Font("Verdana", 15F);
            this.NutGioiThieu.Location = new System.Drawing.Point(327, 134);
            this.NutGioiThieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NutGioiThieu.Name = "NutGioiThieu";
            this.NutGioiThieu.Size = new System.Drawing.Size(153, 62);
            this.NutGioiThieu.TabIndex = 1;
            this.NutGioiThieu.Text = "Giới thiệu";
            this.NutGioiThieu.UseVisualStyleBackColor = false;
            this.NutGioiThieu.Click += new System.EventHandler(this.NutGioiThieu_Click);
            // 
            // NutDangNhap
            // 
            this.NutDangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.NutDangNhap.Font = new System.Drawing.Font("Verdana", 15F);
            this.NutDangNhap.Location = new System.Drawing.Point(327, 211);
            this.NutDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NutDangNhap.Name = "NutDangNhap";
            this.NutDangNhap.Size = new System.Drawing.Size(153, 62);
            this.NutDangNhap.TabIndex = 2;
            this.NutDangNhap.Text = "Đăng nhập";
            this.NutDangNhap.UseVisualStyleBackColor = false;
            this.NutDangNhap.Click += new System.EventHandler(this.NutDangNhap_Click);
            // 
            // NutDangKy
            // 
            this.NutDangKy.BackColor = System.Drawing.SystemColors.Window;
            this.NutDangKy.Font = new System.Drawing.Font("Verdana", 15F);
            this.NutDangKy.Location = new System.Drawing.Point(327, 288);
            this.NutDangKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NutDangKy.Name = "NutDangKy";
            this.NutDangKy.Size = new System.Drawing.Size(153, 62);
            this.NutDangKy.TabIndex = 3;
            this.NutDangKy.Text = "Đăng ký";
            this.NutDangKy.UseVisualStyleBackColor = false;
            this.NutDangKy.Click += new System.EventHandler(this.NutDangKy_Click);
            // 
            // NutLienHe
            // 
            this.NutLienHe.BackColor = System.Drawing.SystemColors.Window;
            this.NutLienHe.Font = new System.Drawing.Font("Verdana", 15F);
            this.NutLienHe.Location = new System.Drawing.Point(327, 365);
            this.NutLienHe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NutLienHe.Name = "NutLienHe";
            this.NutLienHe.Size = new System.Drawing.Size(153, 62);
            this.NutLienHe.TabIndex = 4;
            this.NutLienHe.Text = "Liên hệ";
            this.NutLienHe.UseVisualStyleBackColor = false;
            this.NutLienHe.Click += new System.EventHandler(this.NutLienHe_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLNhaSach.DataHinhAnh.Books3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.NutLienHe);
            this.Controls.Add(this.NutGioiThieu);
            this.Controls.Add(this.NutDangKy);
            this.Controls.Add(this.NutDangNhap);
            this.Controls.Add(this.NhaSachVietNam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà sách Việt Nam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NhaSachVietNam;
        private System.Windows.Forms.Button NutGioiThieu;
        private System.Windows.Forms.Button NutDangNhap;
        private System.Windows.Forms.Button NutDangKy;
        private System.Windows.Forms.Button NutLienHe;
    }
}

