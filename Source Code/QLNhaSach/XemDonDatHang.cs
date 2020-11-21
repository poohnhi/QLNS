using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;


namespace QLNhaSach
{
    public partial class XemDonDatHang : Form
    {
        string ID = "";
        string MaKhachHang;
        public XemDonDatHang(string Username)
        {
            MaKhachHang = Username;
            InitializeComponent();
        }

        private void DonDatHangCuaKhach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet3.DONDATHANG' table. You can move, or remove it, as needed.
            this.dONDATHANGTableAdapter.Fill(this.qLNSDataSet3.DONDATHANG);
            this.dONDATHANGTableAdapter.FillBy(this.qLNSDataSet3.DONDATHANG, MaKhachHang);

        }
        private void DisplayData()
        {
            this.dONDATHANGTableAdapter.FillBy(this.qLNSDataSet3.DONDATHANG, MaKhachHang);
        }
        private void NutSuaSoLuong_Click(object sender, EventArgs e) {
            if (ID != "")
            {
                this.Hide();
                SuaDonHang SDH = new SuaDonHang(MaKhachHang, ID);
                SDH.ShowDialog();
            }
            else
                MessageBox.Show("Hãy chọn đơn hàng cần chỉnh sửa!");
            DisplayData();
            ClearData();
            this.Show();
        }

        private void NutHuyDonHang_Click(object sender, EventArgs e)
        {

            if (ID != "")
            {
                DialogResult rs = MessageBox.Show("Xác nhận huỷ đơn hàng?", "Xác nhận", MessageBoxButtons.YesNo);
                if (rs == DialogResult.No)
                {
                    return;
                }
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=QLNS;Trusted_Connection=true";
                con.Open();
                SqlCommand cmd = new SqlCommand("delete DONDATHANG where MaDonHang='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Thành công!");
            }
            else
                MessageBox.Show("Hãy chọn đơn hàng cần huỷ!");
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void ClearData()
        {
            ID = "";
        }

    }
}
