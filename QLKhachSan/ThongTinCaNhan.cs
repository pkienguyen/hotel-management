using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class ThongTinCaNhan : Form
    {
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {

        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            string ns = Login.Login.LoginNhanVien.NgaySinh.ToString();
            DateTime nss = DateTime.Parse(ns);
            string nsss = nss.ToString("dd/MM/yyyy");

            lblTenNV.Text = Login.Login.LoginNhanVien.Ten;
            lblTenNV1.Text = Login.Login.LoginNhanVien.Ten;
            lblID.Text = Login.Login.LoginNhanVien.ID;
            lblNgaySinh.Text = nsss;
            lblSDT.Text = Login.Login.LoginNhanVien.SDT;
            lblDiaChi.Text = Login.Login.LoginNhanVien.DiaChi;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
