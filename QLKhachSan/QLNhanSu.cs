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
    public partial class QLNhanSu : Form
    {
        public QLNhanSu()
        {
            InitializeComponent();
        }

        private void QLNhanSu_Load(object sender, EventArgs e)
        {
            LoadNhanVien(dtgNhanVien);
        }

        void HienThongTin(DataGridView dtgNhanVien)    //Hiện thông tin nhân viên lên bảng thông tin khi chọn vào một mục
        {
            Binding bdID = new Binding("Text", dtgNhanVien.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIDNV.DataBindings.Clear();
            txtIDNV.DataBindings.Add(bdID);

            Binding bdTen = new Binding("Text", dtgNhanVien.DataSource, "Tên", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add(bdTen);

            Binding bdChucDanh = new Binding("Text", dtgNhanVien.DataSource, "ChứcDanh", true, DataSourceUpdateMode.OnPropertyChanged);
            txtChucDanh.DataBindings.Clear();
            txtChucDanh.DataBindings.Add(bdChucDanh);

            Binding bdNgaySinh = new Binding("Text", dtgNhanVien.DataSource, "NgàySinh", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add(bdNgaySinh);

            Binding bdDiaChi = new Binding("Text", dtgNhanVien.DataSource, "ĐịaChỉ", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add(bdDiaChi);

            Binding bdSDT = new Binding("Text", dtgNhanVien.DataSource, "SĐT", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add(bdSDT);
        }

        void LoadNhanVien(DataGridView dtgv)   //Hiện danh sách nhân viên lên datagridview
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                var source = from n in db.NhanVien
                             where n.IDChucDanh == 2
                             select new
                             {
                                 ID = n.ID,
                                 Tên = n.Ten,
                                 ChứcDanh = "Nhân Viên",
                                 NgàySinh = n.NgaySinh,
                                 SĐT = n.SDT,
                                 ĐịaChỉ = n.DiaChi,
                             };
                dtgv.DataSource = source.ToList();
            }
            HienThongTin(dtgNhanVien);
        }

        void ThemNhanVien()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = (Int32.Parse(db.NhanVien.Select(t => t.ID).Max()) + 1).ToString();
                string ten = txtTenNV.Text;
                DateTime ngaysinh = dtpNgaySinh.Value;
                string diachi = txtDiaChi.Text;
                string sdt = txtSDT.Text;

                NhanVien p = new NhanVien()
                {
                    ID = id,
                    Ten = ten,
                    NgaySinh = ngaysinh,
                    DiaChi = diachi,
                    SDT = sdt,
                    IDChucDanh = 2,
                };

                db.NhanVien.Add(p);

                string iduser = (Int32.Parse(db.Users.Select(t => t.ID).Max()) + 1).ToString();

                Users u = new Users()
                {
                    ID = iduser,
                    Pass = "123",
                    IDNhanVien = id,
                };

                db.Users.Add(u);
                db.SaveChanges();

                MessageBox.Show("Thêm Thành Công");
                LoadNhanVien(dtgNhanVien);
            }
        }

        void XoaNhanVien()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = txtIDNV.Text;

                db.NhanVien.Remove(db.NhanVien.Find(id));
                db.Users.Remove(db.Users.Find(id));
                db.SaveChanges();
                MessageBox.Show("Xóa Thành Công");
                LoadNhanVien(dtgNhanVien);
            }
        }


        void SuaNhanVien()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = txtIDNV.Text;
                NhanVien nv = db.NhanVien.Find(id);
                string ten = txtTenNV.Text;
                DateTime ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
                string diachi = txtDiaChi.Text;
                string sdt = txtSDT.Text;

                nv.Ten = ten;
                nv.NgaySinh = ngaysinh;
                nv.DiaChi = diachi;
                nv.SDT = sdt;

                db.SaveChanges();
                MessageBox.Show("Sửa Thành Công");
                LoadNhanVien(dtgNhanVien);
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThemNhanVien();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SuaNhanVien();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XoaNhanVien();
        }
    }
}
