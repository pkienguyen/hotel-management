using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login.Login.LoginNhanVien = null;   //Xóa thông tin người đăng nhập -> Ko trùng với người đăng nhập sau
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Form f = nextForm(txtUser.Text, txtPass.Text);
            if (f == null)
                return;
            f.StartPosition = FormStartPosition.CenterScreen;    //Form mới khi mở lên ở giữa màn hình
            f.Show();

            this.Hide();        //Khi nhấn "đăng nhập" sẽ ẩn form này

            f.FormClosed += F_FormClosed;

            ClearTxtBox();      //Xóa dữ liệu UserName và Password
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();        //Khi tắt form cũ sẽ hiện lại form này
        }

        void ClearTxtBox()
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        Form nextForm(string id, string pass)
        {
            Form f = new Form();

            int role = 0;
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                var t = db.Users.Where(p => p.IDNhanVien.Equals(id) && p.Pass.Equals(pass));       //Kiểm tra UserName và Password từ csdl
                Users u = t.Count() == 1 ? t.Single() : null;
                if (u != null)
                {
                    NhanVien nv = db.NhanVien.Where(p => u.IDNhanVien.Equals(p.ID)).Single();
                    role = (int)nv.ChucDanh.Role;

                    Login.Login.LoginNhanVien = nv;
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    return null;
                }
            }

            switch (role)
            {
                case 1:
                    f = new Home_QL();
                    break;
                case 2:
                    f = new Home_NV();
                    break;
            }
            return f;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
