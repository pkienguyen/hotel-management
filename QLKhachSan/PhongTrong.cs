using CrystalDecisions.Windows.Forms;
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
    public partial class PhongTrong : Form
    {
        public PhongTrong()
        {
            InitializeComponent();
        }

        private void PhongTrong_Load(object sender, EventArgs e)
        {
            LoadPhongTrong(dtgThuePhong);
            IDKhachHang(cbIDKhach);
        }

        void LoadPhongTrong(DataGridView dtgv)   //Hiện danh sách phòng trống lên datagridview
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                var source = from p in db.Phong
                             from t in db.TinhTrangPhong
                             from l in db.LoaiPhong
                             where p.IDLoai.Equals(l.ID) && p.IDTinhTrang.Equals(t.ID) && p.IDTinhTrang == 2
                             select new
                             {
                                 IDPhòng = p.ID,
                                 TìnhTrạng = t.Ten,
                                 LoạiPhòng = l.TenLoai,
                                 GiáPhòng = p.Gia
                             };
                dtgv.DataSource = source.ToList();
            }
            HienThongTinDatPhong(dtgThuePhong);
        }

        void LoadPhongVip(DataGridView dtgv)   //Hiện danh sách phòng trống lên datagridview
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                var source = from p in db.Phong
                             from t in db.TinhTrangPhong
                             from l in db.LoaiPhong
                             where p.IDLoai.Equals(l.ID) && p.IDTinhTrang.Equals(t.ID) && p.IDTinhTrang == 2 && p.IDLoai == 1
                             select new
                             {
                                 IDPhòng = p.ID,
                                 TìnhTrạng = t.Ten,
                                 LoạiPhòng = l.TenLoai,
                                 GiáPhòng = p.Gia
                             };
                dtgv.DataSource = source.ToList();
            }
            HienThongTinDatPhong(dtgThuePhong);
        }

        void LoadPhongThuong(DataGridView dtgv)   //Hiện danh sách phòng trống lên datagridview
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                var source = from p in db.Phong
                             from t in db.TinhTrangPhong
                             from l in db.LoaiPhong
                             where p.IDLoai.Equals(l.ID) && p.IDTinhTrang.Equals(t.ID) && p.IDTinhTrang == 2 && p.IDLoai == 2
                             select new
                             {
                                 IDPhòng = p.ID,
                                 TìnhTrạng = t.Ten,
                                 LoạiPhòng = l.TenLoai,
                                 GiáPhòng = p.Gia
                             };
                dtgv.DataSource = source.ToList();
            }
            HienThongTinDatPhong(dtgThuePhong);     
        }

        void HienThongTinDatPhong(DataGridView dtgThuePhong)
        {
            Binding bdID = new Binding("Text", dtgThuePhong.DataSource, "IDPhòng", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIDThuePhong.DataBindings.Clear();
            txtIDThuePhong.DataBindings.Add(bdID);

            Binding bdLoaiPhong = new Binding("Text", dtgThuePhong.DataSource, "LoạiPhòng", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLoaiPhong.DataBindings.Clear();
            txtLoaiPhong.DataBindings.Add(bdLoaiPhong);

            Binding bdGia = new Binding("Text", dtgThuePhong.DataSource, "GiáPhòng", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGiaPhong.DataBindings.Clear();
            txtGiaPhong.DataBindings.Add(bdGia);
        }

        void IDKhachHang(ComboBox cb) //Hiện id khách hàng lên ComboBox ID Khách Hàng
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                cb.DataSource = db.KhachHang.ToList();
                cb.DisplayMember = "ID";
            }
        }

        void DatPhong()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = (Int32.Parse(db.BangThuePhong.Select(t => t.ID).Max()) + 1).ToString();
                string idphong = txtIDThuePhong.Text;
                string idkhach = cbIDKhach.Text;
                DateTime ngaydat = dtpNgayDat.Value;
                int songuoi = Int32.Parse(txtSoNguoi.Text);

                BangThuePhong p = new BangThuePhong()
                {
                    ID = id,
                    IDPhong = idphong,
                    IDKhachHang = idkhach,
                    NgayDat = ngaydat,
                    SoNguoi = songuoi,
                    IDTinhTrang = 1,
                };
                db.BangThuePhong.Add(p);
                Phong phong = db.Phong.Find(idphong);
                phong.IDTinhTrang = 1;
                db.SaveChanges();
                MessageBox.Show("Đặt Phòng Thành Công");
            }
        }

        private void btnTraPhong_Click_1(object sender, EventArgs e)
        {
            LoadPhongVip(dtgThuePhong);
        }
        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            LoadPhongThuong(dtgThuePhong);
        }
        private void btnDatPhong_Click_1(object sender, EventArgs e)
        {
            DatPhong();
            LoadPhongTrong(dtgThuePhong);
        }




















        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void cbChon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
