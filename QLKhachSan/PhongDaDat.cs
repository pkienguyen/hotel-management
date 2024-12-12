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
    public partial class PhongDaDat : Form
    {
        public PhongDaDat()
        {
            InitializeComponent();
        }

        private void PhongDaDat_Load(object sender, EventArgs e)
        {
            LoadPhongDaDat(dtgThuePhong);
        }

        void LoadPhongDaDat(DataGridView dtgv)   //Hiện danh sách phòng đã đặt lên datagridview
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                var source = from p in db.Phong
                             from t in db.TinhTrangPhong
                             from l in db.LoaiPhong
                             from k in db.KhachHang
                             from b in db.BangThuePhong
                             where p.IDLoai.Equals(l.ID) && p.IDTinhTrang.Equals(t.ID) && p.IDTinhTrang == 1
                             && k.ID.Equals(b.IDKhachHang) && p.ID.Equals(b.IDPhong)
                             select new
                             {
                                 IDPhòng = p.ID,
                                 TìnhTrạng = t.Ten,
                                 GiáPhòng = p.Gia,
                                 LoạiPhòng = l.TenLoai,
                                 IDKhách = k.ID,
                                 TênKháchHàng = k.Ten,
                                 NgàyĐặt = b.NgayDat,
                                 SốNgười = b.SoNguoi,
                                 IDBảngTP = b.ID,
                             };
                dtgv.DataSource = source.ToList();
            }
            HienThongTinTraPhong(dtgThuePhong);
        }

        void HienThongTinTraPhong(DataGridView dtgThuePhong)
        {
            Binding bdID = new Binding("Text", dtgThuePhong.DataSource, "IDPhòng", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIDThuePhong.DataBindings.Clear();
            txtIDThuePhong.DataBindings.Add(bdID);

            Binding bdIDKhach = new Binding("Text", dtgThuePhong.DataSource, "IDKhách", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIDKhach.DataBindings.Clear();
            txtIDKhach.DataBindings.Add(bdIDKhach);

            Binding bdIDBangTP = new Binding("Text", dtgThuePhong.DataSource, "IDBảngTP", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIDBangTP.DataBindings.Clear();
            txtIDBangTP.DataBindings.Add(bdIDBangTP);

            Binding bdNgayDat = new Binding("Text", dtgThuePhong.DataSource, "NgàyĐặt", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpNgayDat.DataBindings.Clear();
            dtpNgayDat.DataBindings.Add(bdNgayDat);

            Binding bdSoNguoi = new Binding("Text", dtgThuePhong.DataSource, "SốNgười", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSoNguoi.DataBindings.Clear();
            txtSoNguoi.DataBindings.Add(bdSoNguoi);

            Binding bdLoaiPhong = new Binding("Text", dtgThuePhong.DataSource, "LoạiPhòng", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLoaiPhong.DataBindings.Clear();
            txtLoaiPhong.DataBindings.Add(bdLoaiPhong);

            Binding bdGia = new Binding("Text", dtgThuePhong.DataSource, "GiáPhòng", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGiaPhong.DataBindings.Clear();
            txtGiaPhong.DataBindings.Add(bdGia);

            Binding bdTen = new Binding("Text", dtgThuePhong.DataSource, "TênKháchHàng", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTenKhach.DataBindings.Clear();
            txtTenKhach.DataBindings.Add(bdTen);
        }

        void TraPhong()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = txtIDThuePhong.Text;
                string idBTP = txtIDBangTP.Text;

                db.BangThuePhong.Remove(db.BangThuePhong.Find(idBTP));

                Phong phong = db.Phong.Find(id);
                phong.IDTinhTrang = 2;
                db.SaveChanges();
                MessageBox.Show("Trả Phòng Thành Công");
                LoadPhongDaDat(dtgThuePhong);
            }
        }

        void SuaThongTin()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = txtIDBangTP.Text;
                BangThuePhong btphong = db.BangThuePhong.Find(id);
                DateTime ngaydat = DateTime.Parse(dtpNgayDat.Text);
                int songuoi = Int32.Parse(txtSoNguoi.Text);

                btphong.NgayDat = ngaydat;
                btphong.SoNguoi = songuoi;
                db.SaveChanges();
                MessageBox.Show("Sửa Thông Tin Thành Công");
                LoadPhongDaDat(dtgThuePhong);
            }
        }

        void TaoHoaDon()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = (Int32.Parse(db.HoaDon.Select(t => t.ID).Max()) + 1).ToString();
                string idkhach = txtIDKhach.Text;
                string ten = txtTenKhach.Text;
                string idphong = txtIDThuePhong.Text;
                string loai = txtLoaiPhong.Text;

                DateTime ngaydat = DateTime.Parse(dtpNgayDat.Text);
                DateTime ngaythanhtoan = DateTime.Now;
                TimeSpan demngay = ngaythanhtoan.Subtract(ngaydat);

                int songuoi = Int32.Parse(txtSoNguoi.Text);
                int songay = Convert.ToInt32(demngay.TotalDays);
                decimal gia = decimal.Parse(txtGiaPhong.Text);
                decimal tongtien = gia * songay;


                HoaDon p = new HoaDon()
                {
                    ID = id,
                    IDKhachHang = idkhach,
                    TenKhachHang = ten,
                    IDPhong = idphong,
                    LoaiPhong = loai,
                    NgayDat = ngaydat,
                    NgayThanhToan = ngaythanhtoan,
                    SoNgayO = songay,
                    SoNguoi = songuoi,
                    TongTien = tongtien,
                };

                db.HoaDon.Add(p);
                db.SaveChanges();
                MessageBox.Show("Đã Tạo Hóa Đơn");
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            TraPhong();
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            SuaThongTin();
        }

        private void btnThToan_Click(object sender, EventArgs e)
        {
            TaoHoaDon();
        }
    }
}
