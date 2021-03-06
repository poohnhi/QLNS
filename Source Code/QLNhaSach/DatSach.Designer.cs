﻿namespace QLNhaSach
{
    partial class DatSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatSach));
            this.NutDatHang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LuuY = new System.Windows.Forms.Label();
            this.GhiChu = new System.Windows.Forms.Label();
            this.BoxGhiChu = new System.Windows.Forms.TextBox();
            this.LabelGiaTien = new System.Windows.Forms.Label();
            this.GiaTien = new System.Windows.Forms.Label();
            this.LabelTenSach = new System.Windows.Forms.Label();
            this.TenSach = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.ChonSach = new System.Windows.Forms.Label();
            this.Label_SoLuong = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.sACHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NutDatHang
            // 
            this.NutDatHang.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutDatHang.Location = new System.Drawing.Point(110, 245);
            this.NutDatHang.Name = "NutDatHang";
            this.NutDatHang.Size = new System.Drawing.Size(131, 58);
            this.NutDatHang.TabIndex = 1;
            this.NutDatHang.Text = "Đặt hàng";
            this.NutDatHang.UseVisualStyleBackColor = true;
            this.NutDatHang.Click += new System.EventHandler(this.NutDatHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LuuY);
            this.groupBox1.Location = new System.Drawing.Point(357, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Một số lưu ý khi đặt hàng";
            // 
            // LuuY
            // 
            this.LuuY.AutoSize = true;
            this.LuuY.Location = new System.Drawing.Point(12, 28);
            this.LuuY.Name = "LuuY";
            this.LuuY.Size = new System.Drawing.Size(198, 156);
            this.LuuY.TabIndex = 0;
            this.LuuY.Text = "Lưu ý:\r\n\r\nGiá tiền chưa bao gồm tiền ship.\r\n\r\nMiễn phí ship tại các khu vực nội t" +
    "hành.\r\n\r\nHàng đã mua miễn trả lại.\r\n\r\nMọi thắc mắc xin liên hệ email:\r\n\r\ninfo@ns" +
    "vn.com\r\n\r\n";
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSize = true;
            this.GhiChu.Location = new System.Drawing.Point(25, 136);
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Size = new System.Drawing.Size(44, 13);
            this.GhiChu.TabIndex = 3;
            this.GhiChu.Text = "Ghi chú";
            // 
            // BoxGhiChu
            // 
            this.BoxGhiChu.Location = new System.Drawing.Point(24, 155);
            this.BoxGhiChu.Multiline = true;
            this.BoxGhiChu.Name = "BoxGhiChu";
            this.BoxGhiChu.Size = new System.Drawing.Size(296, 82);
            this.BoxGhiChu.TabIndex = 4;
            // 
            // LabelGiaTien
            // 
            this.LabelGiaTien.AutoSize = true;
            this.LabelGiaTien.Location = new System.Drawing.Point(25, 76);
            this.LabelGiaTien.Name = "LabelGiaTien";
            this.LabelGiaTien.Size = new System.Drawing.Size(43, 13);
            this.LabelGiaTien.TabIndex = 7;
            this.LabelGiaTien.Text = "Giá tiền";
            // 
            // GiaTien
            // 
            this.GiaTien.AutoSize = true;
            this.GiaTien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaTien.Location = new System.Drawing.Point(24, 98);
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.Size = new System.Drawing.Size(68, 23);
            this.GiaTien.TabIndex = 8;
            this.GiaTien.Text = "0 VNĐ";
            // 
            // LabelTenSach
            // 
            this.LabelTenSach.AutoSize = true;
            this.LabelTenSach.Location = new System.Drawing.Point(25, 9);
            this.LabelTenSach.Name = "LabelTenSach";
            this.LabelTenSach.Size = new System.Drawing.Size(52, 13);
            this.LabelTenSach.TabIndex = 9;
            this.LabelTenSach.Text = "Tên sách";
            // 
            // TenSach
            // 
            this.TenSach.AutoSize = true;
            this.TenSach.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenSach.Location = new System.Drawing.Point(24, 35);
            this.TenSach.Name = "TenSach";
            this.TenSach.Size = new System.Drawing.Size(167, 23);
            this.TenSach.TabIndex = 10;
            this.TenSach.Text = "Hãy chọn mã sách";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // ChonSach
            // 
            this.ChonSach.AutoSize = true;
            this.ChonSach.Font = new System.Drawing.Font("000 Spellcaster [TeddyBear]", 16F, System.Drawing.FontStyle.Italic);
            this.ChonSach.Location = new System.Drawing.Point(605, 303);
            this.ChonSach.Name = "ChonSach";
            this.ChonSach.Size = new System.Drawing.Size(51, 34);
            this.ChonSach.TabIndex = 11;
            this.ChonSach.Text = "----";
            // 
            // Label_SoLuong
            // 
            this.Label_SoLuong.AutoSize = true;
            this.Label_SoLuong.Location = new System.Drawing.Point(227, 76);
            this.Label_SoLuong.Name = "Label_SoLuong";
            this.Label_SoLuong.Size = new System.Drawing.Size(49, 13);
            this.Label_SoLuong.TabIndex = 12;
            this.Label_SoLuong.Text = "Số lượng";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuong.Location = new System.Drawing.Point(230, 98);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(90, 29);
            this.tbSoLuong.TabIndex = 13;
            this.tbSoLuong.Text = "1";
            this.tbSoLuong.TextChanged += new System.EventHandler(this.ChangeSoLuong);
            // 
            // sACHBindingSource1
            // 
            this.sACHBindingSource1.DataMember = "SACH";
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            // 
            // DatSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 315);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.Label_SoLuong);
            this.Controls.Add(this.ChonSach);
            this.Controls.Add(this.TenSach);
            this.Controls.Add(this.LabelTenSach);
            this.Controls.Add(this.GiaTien);
            this.Controls.Add(this.LabelGiaTien);
            this.Controls.Add(this.BoxGhiChu);
            this.Controls.Add(this.GhiChu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NutDatHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DatSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt sách";
            this.Load += new System.EventHandler(this.DonGiaoHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NutDatHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LuuY;
        private System.Windows.Forms.Label GhiChu;
        private System.Windows.Forms.TextBox BoxGhiChu;
        private System.Windows.Forms.Label LabelGiaTien;
        private System.Windows.Forms.Label GiaTien;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private System.Windows.Forms.BindingSource sACHBindingSource1;
        private System.Windows.Forms.Label LabelTenSach;
        private System.Windows.Forms.Label TenSach;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.Label ChonSach;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label Label_SoLuong;
    }
}