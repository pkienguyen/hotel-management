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
    public partial class ThongTinKH : Form
    {
        public ThongTinKH()
        {
            InitializeComponent();
        }

        private void ThongTinKH_Load(object sender, EventArgs e)
        {
            LoadKhachHang(dtgKhachHang);
        }

        void LoadKhachHang(DataGridView dtgv)   //Hiện danh sách khách hàng lên datagridview
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                var source = from k in db.KhachHang
                             select new
                             {
                                 ID = k.ID,
                                 CMND = k.Cmnd,
                                 Tên = k.Ten,
                                 NgàySinh = k.NgaySinh,
                                 GiớiTính = k.GioiTinh,
                                 ĐịaChỉ = k.DiaChi,
                                 SĐT = k.SDT,
                                 QuốcTịch = k.QuocTich,
                             };
                dtgv.DataSource = source.ToList();
            }
            HienThongTinKhachHang(dtgKhachHang);
        }

        void HienThongTinKhachHang(DataGridView dtgPhong)    //Hiện thông khách hàng lên bảng thông tin khi chọn vào một mục
        {
            Binding bdID = new Binding("Text", dtgKhachHang.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIDKhach.DataBindings.Clear();
            txtIDKhach.DataBindings.Add(bdID);

            Binding bdCmnd = new Binding("Text", dtgPhong.DataSource, "Cmnd", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add(bdCmnd);

            Binding bdTen = new Binding("Text", dtgPhong.DataSource, "Tên", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTenKh.DataBindings.Clear();
            txtTenKh.DataBindings.Add(bdTen);

            Binding bdNgaySinh = new Binding("Text", dtgPhong.DataSource, "NgàySinh", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add(bdNgaySinh);

            Binding bdGioiTinh = new Binding("Text", dtgPhong.DataSource, "GiớiTính", true, DataSourceUpdateMode.OnPropertyChanged);
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add(bdGioiTinh);

            Binding bdSDT = new Binding("Text", dtgPhong.DataSource, "SĐT", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add(bdSDT);

            Binding bdDiaChi = new Binding("Text", dtgPhong.DataSource, "ĐịaChỉ", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add(bdDiaChi);

            Binding bdQuocTich = new Binding("Text", dtgPhong.DataSource, "QuốcTịch", true, DataSourceUpdateMode.OnPropertyChanged);
            txtQuocTich.DataBindings.Clear();
            txtQuocTich.DataBindings.Add(bdQuocTich);
        }

        void ThemKhachHang()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = (Int32.Parse(db.KhachHang.Select(t => t.ID).Max()) + 1).ToString();
                string ten = txtTenKh.Text;
                int cmnd = Int32.Parse(txtCMND.Text);

                if (db.KhachHang.Select(k => k.Cmnd).Contains(cmnd))
                {
                    MessageBox.Show("Số CMND đã tồn tại");
                    return;
                }

                DateTime ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
                string gioitinh = cbGioiTinh.Text;
                string diachi = txtDiaChi.Text;
                string sdt = txtSDT.Text;
                string quoctich = txtQuocTich.Text;

                KhachHang p = new KhachHang()
                {
                    ID = id,
                    Ten = ten,
                    Cmnd = cmnd,
                    NgaySinh = ngaysinh,
                    GioiTinh = gioitinh,
                    DiaChi = diachi,
                    SDT = sdt,
                    QuocTich = quoctich,
                };

                db.KhachHang.Add(p);
                db.SaveChanges();
                MessageBox.Show("Thêm Thành Công");
                LoadKhachHang(dtgKhachHang);
            }
        }

        void SuaKhachHang()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = txtIDKhach.Text;
                KhachHang khach = db.KhachHang.Find(id);
                string ten = txtTenKh.Text;
                int cmnd = Int32.Parse(txtCMND.Text);
                DateTime ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
                string gioitinh = cbGioiTinh.Text;
                string diachi = txtDiaChi.Text;
                string sdt = txtSDT.Text;
                string quoctich = txtQuocTich.Text;

                khach.Ten = ten;
                khach.Cmnd = cmnd;
                khach.NgaySinh = ngaysinh;
                khach.GioiTinh = gioitinh;
                khach.DiaChi = diachi;
                khach.SDT = sdt;
                khach.QuocTich = quoctich;


                db.SaveChanges();
                MessageBox.Show("Sửa Thành Công");
                LoadKhachHang(dtgKhachHang);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThemKhachHang();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SuaKhachHang();
        }
    }
}
