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
using QLNhaSach.Properties;
using System.Reflection;
using System.Resources;
namespace QLNhaSach
{
    public partial class ThuVien : Form
    {
        ResourceManager rm = QLNhaSach.DataHinhAnh.ResourceManager;
        public ThuVien()
        {
            InitializeComponent();
        }

        private void LoadAnh(string Ma)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=POOHNHI;Database=QLNS;Trusted_Connection=true";
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select TENSACH, GIABAN, LOAI, NXB from SACH where MASACH = '" + Ma + "'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            SqlDataAdapter cmd2 = new SqlDataAdapter("select TENLOAI from LOAISACH where MALOAI='" + dt.Rows[0][2] + "'", con);
            DataTable dt2 = new DataTable();
            cmd2.Fill(dt2);
            SqlDataAdapter cmd3 = new SqlDataAdapter("select TENNXB from NHAXUATBAN where MANXB='" + dt.Rows[0][3] + "'", con);
            DataTable dt3 = new DataTable();
            cmd3.Fill(dt3);
            NoiDung.Text = "- Tên sách: " + dt.Rows[0][0]
                + Environment.NewLine
                + Environment.NewLine + "- Giá: " + dt.Rows[0][1]
                + Environment.NewLine
                + Environment.NewLine + "- Loại: " + dt2.Rows[0][0]
                + Environment.NewLine
                + Environment.NewLine + "- Nhà xuất bản: " + dt3.Rows[0][0];
        }
        
        private void Picture_Click(object sender, EventArgs e)
        {
            var picBox = (PictureBox)sender;
            string a = picBox.Name;
            SachTo.Image = (Image)rm.GetObject(a);
            LoadAnh(a);
        }
    }
}
