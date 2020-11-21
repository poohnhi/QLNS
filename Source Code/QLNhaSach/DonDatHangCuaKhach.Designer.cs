namespace QLNhaSach
{
    partial class DonDatHangCuaKhach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonDatHangCuaKhach));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maDonHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONDATHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet3 = new QLNhaSach.QLNSDataSet3();
            this.qLNSDataSet = new QLNhaSach.QLNSDataSet();
            this.qLNSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERINFOTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NutXacNhan = new System.Windows.Forms.Button();
            this.dONDATHANGTableAdapter = new QLNhaSach.QLNSDataSet3TableAdapters.DONDATHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONDATHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOTableAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDonHangDataGridViewTextBoxColumn,
            this.maKhachHangDataGridViewTextBoxColumn,
            this.TENSACH,
            this.SoLuong,
            this.GiaTien,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dONDATHANGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(718, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // maDonHangDataGridViewTextBoxColumn
            // 
            this.maDonHangDataGridViewTextBoxColumn.DataPropertyName = "MaDonHang";
            this.maDonHangDataGridViewTextBoxColumn.HeaderText = "Mã đơn hàng";
            this.maDonHangDataGridViewTextBoxColumn.Name = "maDonHangDataGridViewTextBoxColumn";
            this.maDonHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maKhachHangDataGridViewTextBoxColumn
            // 
            this.maKhachHangDataGridViewTextBoxColumn.DataPropertyName = "MaKhachHang";
            this.maKhachHangDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.maKhachHangDataGridViewTextBoxColumn.Name = "maKhachHangDataGridViewTextBoxColumn";
            this.maKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
            this.maKhachHangDataGridViewTextBoxColumn.Width = 125;
            // 
            // TENSACH
            // 
            this.TENSACH.DataPropertyName = "TENSACH";
            this.TENSACH.HeaderText = "Tên sách";
            this.TENSACH.Name = "TENSACH";
            this.TENSACH.ReadOnly = true;
            this.TENSACH.Width = 200;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 75;
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "Tổng tiền";
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            this.GiaTien.Width = 75;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiChuDataGridViewTextBoxColumn.Width = 400;
            // 
            // dONDATHANGBindingSource
            // 
            this.dONDATHANGBindingSource.DataMember = "DONDATHANG";
            this.dONDATHANGBindingSource.DataSource = this.qLNSDataSet3;
            // 
            // qLNSDataSet3
            // 
            this.qLNSDataSet3.DataSetName = "QLNSDataSet3";
            this.qLNSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNSDataSet
            // 
            this.qLNSDataSet.DataSetName = "QLNSDataSet";
            this.qLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNSDataSetBindingSource
            // 
            this.qLNSDataSetBindingSource.DataSource = this.qLNSDataSet;
            this.qLNSDataSetBindingSource.Position = 0;
            // 
            // uSERINFOTableAdapterBindingSource
            // 
            this.uSERINFOTableAdapterBindingSource.DataSource = typeof(QLNhaSach.QLNSDataSetTableAdapters.USERINFOTableAdapter);
            // 
            // NutXacNhan
            // 
            this.NutXacNhan.Font = new System.Drawing.Font("Verdana", 12F);
            this.NutXacNhan.Location = new System.Drawing.Point(285, 276);
            this.NutXacNhan.Name = "NutXacNhan";
            this.NutXacNhan.Size = new System.Drawing.Size(176, 50);
            this.NutXacNhan.TabIndex = 1;
            this.NutXacNhan.Text = "Xác nhận giao hàng";
            this.NutXacNhan.UseVisualStyleBackColor = true;
            this.NutXacNhan.Click += new System.EventHandler(this.NutXacNhan_Click);
            // 
            // dONDATHANGTableAdapter
            // 
            this.dONDATHANGTableAdapter.ClearBeforeFill = true;
            // 
            // DonDatHangCuaKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 331);
            this.Controls.Add(this.NutXacNhan);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DonDatHangCuaKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn đặt hàng của khách";
            this.Load += new System.EventHandler(this.DonDatHangCuaKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONDATHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOTableAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource qLNSDataSetBindingSource;
        private QLNSDataSet qLNSDataSet;
        private QLNSDataSet3 qLNSDataSet3;
        private System.Windows.Forms.BindingSource dONDATHANGBindingSource;
        private QLNSDataSet3TableAdapters.DONDATHANGTableAdapter dONDATHANGTableAdapter;
        private System.Windows.Forms.BindingSource uSERINFOTableAdapterBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn mASACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button NutXacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDonHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
    }
}