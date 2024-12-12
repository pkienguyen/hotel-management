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
    public partial class Home_NV : Form
    {
        public Home_NV()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTTKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinKH());
            label1.Text = btnTTKH.Text;
        }
        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLPhong());
            label1.Text = btnQLPhong.Text;
        }  
        private void btnPhongTrong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhongTrong());
            label1.Text = btnPhongTrong.Text;
        }
        private void btnPhongDaDat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhongDaDat());
            label1.Text = btnPhongDaDat.Text;
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DSHoaDon());
            label1.Text = btnHoaDon.Text;
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_NV_Load(object sender, EventArgs e)
        {
            label2.Text = Login.Login.LoginNhanVien.Ten;    //Hiện tên nhân viên lên tab thông tin cá nhân
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan f = new ThongTinCaNhan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
    }
}
