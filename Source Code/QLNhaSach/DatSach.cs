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
    public partial class DatSach : Form
    {
        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
        string ID;
        string BookID;
        int temp;
        int tien;
        int tongtien;
        public DatSach(string Username, string Book)
        {
            ID = Username;
            BookID = Book;
            InitializeComponent();
        }

        private void DonGiaoHang_Load(object sender, EventArgs e)
        {
            nfi.NumberDecimalDigits = 0;
            ChonSach.Text = BookID;
            BoxGhiChu.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.;Database=QLNS;Trusted_Connection=true";
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from SACH where MASACH ='" + BookID + "'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            string SL = tbSoLuong.Text;
            Int32.TryParse(SL, out temp);
            Int32.TryParse(dt.Rows[0][3].ToString(), out tien);
            tongtien = temp * tien;
            GiaTien.Text = tongtien.ToString("N", nfi) + " VNĐ";
            TenSach.Text = dt.Rows[0][1].ToString();
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
            DatHang();
            MessageBox.Show("Đặt hàng thành công!", "Thông báo");
            this.Close();
        }
        private void DatHang()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = "Server=.;Database=QLNS;Trusted_Connection=true";
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO DONDATHANG (MaDonHang,MaKhachHang,MASACH,GhiChu, SoLuong, GiaTien, TENSACH) 
                    VALUES(@MDH,@MKH,@MS,@GC,@SL,@GT, @TS)";
            cmd.Parameters.AddWithValue("@MKH", ID);
            cmd.Parameters.AddWithValue("@MS", ChonSach.Text);
            cmd.Parameters.AddWithValue("@GC", BoxGhiChu.Text);
            cmd.Parameters.AddWithValue("@SL", tbSoLuong.Text);
            tongtien = temp * tien;
            cmd.Parameters.AddWithValue("@GT", tongtien);
            Random rnd = new Random();
            int mdh = rnd.Next(10000, 99999);
            cmd.Parameters.AddWithValue("@MDH", mdh);
            cmd.Parameters.AddWithValue("@TS", TenSach.Text);
            cmd.ExecuteNonQuery();
        }
    }
}
