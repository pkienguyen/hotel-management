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
    public partial class DSHoaDon : Form
    {
        public DSHoaDon()
        {
            InitializeComponent();
        }

        private void DSHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon(dtgHoaDon);
        }

        void LoadHoaDon(DataGridView dtgv)
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                var source = from h in db.HoaDon
                             from p in db.Phong
                             where p.ID.Equals(h.IDPhong)
                             select new
                             {
                                 MãHóaĐơn = h.ID,
                                 IDKháchHàng = h.IDKhachHang,
                                 TênKháchHàng = h.TenKhachHang,
                                 IDPhòng = h.IDPhong,
                                 LoạiPhòng = h.LoaiPhong,
                                 GiáPhòng = p.Gia,
                                 NgàyĐặt = h.NgayDat,
                                 NgàyThanhToán = h.NgayThanhToan,
                                 SốNgàyThuê = h.SoNgayO,
                                 SốNgười = h.SoNguoi,
                                 TổngTiền = h.TongTien,
                             };
                dtgv.DataSource = source.ToList();
            }
            HienThongTinHoaDon(dtgHoaDon);
        }

        void HienThongTinHoaDon(DataGridView dtgv)
        {
            Binding bdID = new Binding("Text", dtgHoaDon.DataSource, "MãHóaĐơn", true, DataSourceUpdateMode.OnPropertyChanged);
            lblID.DataBindings.Clear();
            lblID.DataBindings.Add(bdID);

            Binding bdIDKhach = new Binding("Text", dtgHoaDon.DataSource, "IDKháchHàng", true, DataSourceUpdateMode.OnPropertyChanged);
            lblIDKhach.DataBindings.Clear();
            lblIDKhach.DataBindings.Add(bdIDKhach);

            Binding bdTen = new Binding("Text", dtgHoaDon.DataSource, "TênKháchHàng", true, DataSourceUpdateMode.OnPropertyChanged);
            lblTen.DataBindings.Clear();
            lblTen.DataBindings.Add(bdTen);

            Binding bdIDPhong = new Binding("Text", dtgHoaDon.DataSource, "IDPhòng", true, DataSourceUpdateMode.OnPropertyChanged);
            lblIDPhong.DataBindings.Clear();
            lblIDPhong.DataBindings.Add(bdIDPhong);

            Binding bdLoaiPhong = new Binding("Text", dtgHoaDon.DataSource, "LoạiPhòng", true, DataSourceUpdateMode.OnPropertyChanged);
            lblLoaiPhong.DataBindings.Clear();
            lblLoaiPhong.DataBindings.Add(bdLoaiPhong);

            Binding bdGiaPhong = new Binding("Text", dtgHoaDon.DataSource, "GiáPhòng", true, DataSourceUpdateMode.OnPropertyChanged);
            lblGiaPhong.DataBindings.Clear();
            lblGiaPhong.DataBindings.Add(bdGiaPhong);

            Binding bdNgayDat = new Binding("Text", dtgHoaDon.DataSource, "NgàyĐặt", true, DataSourceUpdateMode.OnPropertyChanged);
            lblNgayDat.DataBindings.Clear();
            lblNgayDat.DataBindings.Add(bdNgayDat);

            Binding bdNgayTT = new Binding("Text", dtgHoaDon.DataSource, "NgàyThanhToán", true, DataSourceUpdateMode.OnPropertyChanged);
            lblNgayTT.DataBindings.Clear();
            lblNgayTT.DataBindings.Add(bdNgayTT);

            Binding bdSoNgay = new Binding("Text", dtgHoaDon.DataSource, "SốNgàyThuê", true, DataSourceUpdateMode.OnPropertyChanged);
            lblSoNgay.DataBindings.Clear();
            lblSoNgay.DataBindings.Add(bdSoNgay);

            Binding bdSoNguoi = new Binding("Text", dtgHoaDon.DataSource, "SốNgười", true, DataSourceUpdateMode.OnPropertyChanged);
            lblSoNguoi.DataBindings.Clear();
            lblSoNguoi.DataBindings.Add(bdSoNguoi);

            Binding bdTongTien = new Binding("Text", dtgHoaDon.DataSource, "TổngTiền", true, DataSourceUpdateMode.OnPropertyChanged);
            lblTongTien.DataBindings.Clear();
            lblTongTien.DataBindings.Add(bdTongTien);
        }

        void XoaHoaDon()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = lblID.Text;

                db.HoaDon.Remove(db.HoaDon.Find(id));
                db.SaveChanges();
                MessageBox.Show("Xóa Thành Công");
                LoadHoaDon(dtgHoaDon);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XoaHoaDon();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                var hoadon = db.HoaDon.Where(t => t.ID == lblID.Text).ToList();

                HoaDon h = new HoaDon();
                h.SetDataSource(hoadon);

                BaoCao f = new BaoCao();
                f.crystalReportViewer1.ReportSource = h;
                f.ShowDialog();
            }
        }






















        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
