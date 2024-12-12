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
    public partial class QLPhong : Form
    {
        public QLPhong()
        {
            InitializeComponent();
        }

        private void QLPhong_Load(object sender, EventArgs e)
        {
            LoadPhong(dtgPhong);
        }

        void HienThongTin(DataGridView dtgPhong)    //Hiện thông tin phòng lên bảng thông tin khi chọn vào một phòng
        {
            Binding bdID = new Binding("Text", dtgPhong.DataSource, "IDPhòng", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIDPhong.DataBindings.Clear();
            txtIDPhong.DataBindings.Add(bdID);

            Binding bdTinhTrang = new Binding("Text", dtgPhong.DataSource, "TìnhTrạng", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTinhTrang.DataBindings.Clear();
            txtTinhTrang.DataBindings.Add(bdTinhTrang);

            Binding bdLoaiPhong = new Binding("Text", dtgPhong.DataSource, "LoạiPhòng", true, DataSourceUpdateMode.OnPropertyChanged);
            cbLoaiPhong.DataBindings.Clear();
            cbLoaiPhong.DataBindings.Add(bdLoaiPhong);

            Binding bdGia = new Binding("Text", dtgPhong.DataSource, "GiáPhòng", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add(bdGia);
        }

        void LoadPhong(DataGridView dtgv)   //Hiện danh sách phòng lên datagridview
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                var source = from p in db.Phong
                             from t in db.TinhTrangPhong
                             from l in db.LoaiPhong
                             where p.IDLoai.Equals(l.ID) && p.IDTinhTrang.Equals(t.ID)
                             select new
                             {
                                 IDPhòng = p.ID,
                                 TìnhTrạng = t.Ten,
                                 LoạiPhòng = l.TenLoai,
                                 GiáPhòng = p.Gia
                             };
                dtgv.DataSource = source.ToList();
            }
            HienThongTin(dtgPhong);
            LoaiPhong(cbLoaiPhong);
        }

        void LoaiPhong(ComboBox cb) //Hiện loại phòng lên ComboBox Loại Phòng
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                cb.DataSource = db.LoaiPhong.ToList();
                cb.DisplayMember = "TenLoai";
            }
        }

        void ThemPhong()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = (Int32.Parse(db.Phong.Select(t => t.ID).Max()) + 1).ToString();
                int loaiphong = (cbLoaiPhong.SelectedValue as LoaiPhong).ID;
                decimal gia = decimal.Parse(txtGia.Text);

                Phong p = new Phong()
                {
                    ID = id,
                    IDTinhTrang = 2,
                    IDLoai = loaiphong,
                    Gia = gia,
                };

                db.Phong.Add(p);
                db.SaveChanges();
                MessageBox.Show("Thêm Phòng Thành Công");
                LoadPhong(dtgPhong);
            }
        }

        void XoaPhong()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = txtIDPhong.Text;

                db.Phong.Remove(db.Phong.Find(id));
                db.SaveChanges();
                MessageBox.Show("Xóa Phòng Thành Công");
                LoadPhong(dtgPhong);
            }
        }

        void SuaPhong()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = txtIDPhong.Text;
                Phong phong = db.Phong.Find(id);
                int loaiphong = (cbLoaiPhong.SelectedValue as LoaiPhong).ID;
                decimal gia = decimal.Parse(txtGia.Text);
                phong.IDLoai = loaiphong;
                phong.Gia = gia;

                db.SaveChanges();
                MessageBox.Show("Sửa Phòng Thành Công");
                LoadPhong(dtgPhong);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemPhong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaPhong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaPhong();
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
