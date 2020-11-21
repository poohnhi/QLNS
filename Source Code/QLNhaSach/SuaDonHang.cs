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
using System.Globalization;

namespace QLNhaSach
{
    public partial class SuaDonHang : Form
    {
        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
        string ID;
        string MaDH;
        int temp;
        int tien;
        int tongtien;
        public SuaDonHang(string Username, string MaDonHang)
        {
            ID = Username;
            MaDH = MaDonHang;
            InitializeComponent();
        }

        private void DonGiaoHang_Load(object sender, EventArgs e)
        {
            nfi.NumberDecimalDigits = 0;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.;Database=QLNS;Trusted_Connection=true";
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from DONDATHANG where MaDonHang ='" + MaDH + "'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            ChonSach.Text = dt.Rows[0][0].ToString();
            BoxGhiChu.Text = dt.Rows[0][5].ToString();
            tbSoLuong.Text = dt.Rows[0][2].ToString();
            temp = Int32.Parse(tbSoLuong.Text);
            tongtien = Int32.Parse(dt.Rows[0][6].ToString());
            tien = (tongtien / temp);
            GiaTien.Text = tongtien.ToString("N", nfi) + " VNĐ";
            TenSach.Text = dt.Rows[0][3].ToString();
            con.Close();
        }

        private void ChangeSoLuong(object sender, EventArgs e)
        {
            nfi.NumberDecimalDigits = 0;
            string SL = tbSoLuong.Text;
            Int32.TryParse(SL, out temp);
            tongtien = temp * tien;
            GiaTien.Text = tongtien.ToString("N", nfi) + " VNĐ";
        }
        bool InputHopLe()
        {
            Error.Clear();
            bool bError = false;
            string Ten = ChonSach.Text;
            string SL = tbSoLuong.Text;
            if (Ten == "XXXX")
            {
                Error.SetError(ChonSach, "Hãy chọn mã sách!");
                bError = true;
            }
            if(!Int32.TryParse(SL, out temp))
            {
                Error.SetError(tbSoLuong, "Nhập giá trị số!");
                bError = true;
            }
            else if (temp <= 0)
            {
                Error.SetError(tbSoLuong, "Không thể mua ít hơn 1!");
                bError = true;
            }
            else if (temp > 100)
            {
                Error.SetError(tbSoLuong, "Không thể mua nhiều hơn 100!");
                bError = true;
            }
            if (bError == true)
            {
                return false;
            }
            else
            {
                Error.Clear();
            }
            return true;
        }
        private void NutDatHang_Click(object sender, EventArgs e)
        {
            if (InputHopLe() == false)
            {
                return;
            }
            ChinhSuaDonHang();
            MessageBox.Show("Chỉnh sửa đơn hàng thành công!", "Thông báo");
            this.Close();
        }
        private void ChinhSuaDonHang()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.;Database=QLNS;Trusted_Connection=true";
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE DONDATHANG SET SoLuong=@SL, GiaTien=@GT, GhiChu=@GC where MaDonHang='" + MaDH + "'", con);
            cmd.Parameters.AddWithValue("@SL", temp);
            cmd.Parameters.AddWithValue("@GT", tongtien);
            cmd.Parameters.AddWithValue("@GC", BoxGhiChu.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
