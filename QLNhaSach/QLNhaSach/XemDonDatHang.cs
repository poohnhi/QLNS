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


namespace QLNhaSach
{
    public partial class XemDonDatHang : Form
    {
        string ID = "";
        string MaKhachHang = "";
        string MaSach = "";
        string GhiChu = "";
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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.;Database=QLNS;Trusted_Connection=true";
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from DONDATHANG WHERE TenDangNhap = '" + MaKhachHang + "'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void NutXacNhan_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            MaKhachHang = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            MaSach = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            GhiChu = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

    }
}
