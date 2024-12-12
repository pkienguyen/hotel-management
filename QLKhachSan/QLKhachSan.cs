using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class QLKhachSan : Form
    {
        public QLKhachSan()
        {
            InitializeComponent();
        }

        //QUẢN LÝ PHÒNG
        void LoaiPhong(ComboBox cb) //Hiện loại phòng lên ComboBox Loại Phòng
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                cb.DataSource = db.LoaiPhong.ToList();
                cb.DisplayMember = "TenLoai";
            }
        }

        void IDKhachHang(ComboBox cb) //Hiện id khách hàng lên ComboBox ID Khách Hàng
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                cb.DataSource = db.KhachHang.ToList();
                cb.DisplayMember = "ID";
            }
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

        void HienThongTinTraPhong(DataGridView dtgThuePhong)
        {
            Binding bdID = new Binding("Text", dtgThuePhong.DataSource, "IDPhòng", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIDThuePhong.DataBindings.Clear();
            txtIDThuePhong.DataBindings.Add(bdID);

            Binding bdIDKhach = new Binding("Text", dtgThuePhong.DataSource, "IDKhách", true, DataSourceUpdateMode.OnPropertyChanged);
            cbIDKhach.DataBindings.Clear();
            cbIDKhach.DataBindings.Add(bdIDKhach);

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


            cbIDKhach.Text = null;
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
            
            txtIDBangTP.Text = null;
            cbIDKhach.Text= null;
            txtTenKhach.Text= null;
            dtpNgayDat.Text = null;
            txtSoNguoi.Text = "1";

            cbIDKhach.Enabled = true;
            txtTenKhach.Enabled = true;
            dtpNgayDat.Enabled = true;
            txtSoNguoi.Enabled = true;

            btnDatPhong.Enabled = true;
            btnTraPhong.Enabled = false;
            btnThanhToan.Enabled = false;
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

            cbIDKhach.Enabled = false;
            txtTenKhach.Enabled = false;
            dtpNgayDat.Enabled = false;
            txtSoNguoi.Enabled = false;

            btnDatPhong.Enabled = false;
            btnTraPhong.Enabled = true;
            btnThanhToan.Enabled = true;
        }

        void DatPhong()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = (Int32.Parse(db.BangThuePhong.Select(t => t.ID).Max()) + 1).ToString();
                string idphong = txtIDThuePhong.Text;
                string idkhach = cbIDKhach.Text;
                DateTime ngaydat= dtpNgayDat.Value;
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
                LoadPhong(dtgPhong);
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

        private void Home_Load(object sender, EventArgs e)
        {
            tmiTen.Text = Login.Login.LoginNhanVien.Ten;    //Hiện tên nhân viên lên tab thông tin cá nhân
            tmiID.Text = "ID Nhân Viên: " + Login.Login.LoginNhanVien.ID;
            LoadPhong(dtgPhong);
            IDKhachHang(cbIDKhach);
            LoadPhong(dtgThuePhong);
            LoadKhachHang(dtgKhachHang);
            LoadHoaDon(dtgHoaDon);
            

            cbIDKhach.Enabled = false;
            txtIDThuePhong.Enabled = false;
            dtpNgayDat.Enabled = false;
            txtSoNguoi.Enabled = false;
            btnTraPhong.Enabled = false;
            btnThanhToan.Enabled = false;
            btnDatPhong.Enabled = false;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if(cbIDKhach.Text == null)
            {
                MessageBox.Show("");
            }
            else
            {
                DatPhong();
                LoadPhong(dtgPhong);
                LoadPhongTrong(dtgThuePhong);
            }          
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            TraPhong();
            LoadPhong(dtgPhong);
            LoadPhongTrong(dtgThuePhong);
            LoadPhongDaDat(dtgThuePhong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemPhong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaPhong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaPhong();
        }

        private void cbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chon = cbChon.Text;
            if (chon == "Còn Trống")
                LoadPhongTrong(dtgThuePhong);
            else
                LoadPhongDaDat(dtgThuePhong);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void dtgPhong_SelectionChanged(object sender, EventArgs e)
        {

            if (txtTinhTrang.Text == "Đã Đặt")
                btnXoa.Enabled = false;
            else
                btnXoa.Enabled = true;
        }

        private void tmiTen_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan f = new ThongTinCaNhan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void tmiID_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan f = new ThongTinCaNhan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }




        //QUẢN LÝ KHÁCH HÀNG
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
                    Ten= ten,
                    Cmnd = cmnd,
                    NgaySinh= ngaysinh,
                    GioiTinh= gioitinh,
                    DiaChi= diachi,
                    SDT=sdt,
                    QuocTich= quoctich,
                };

                db.KhachHang.Add(p);
                db.SaveChanges();
                MessageBox.Show("Thêm Thành Công");
                LoadKhachHang(dtgKhachHang);
                IDKhachHang(cbIDKhach);
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
                khach.Cmnd= cmnd;
                khach.NgaySinh= ngaysinh;
                khach.GioiTinh= gioitinh;
                khach.DiaChi= diachi;
                khach.SDT= sdt;
                khach.QuocTich= quoctich;


                db.SaveChanges();
                MessageBox.Show("Sửa Thành Công");
                LoadKhachHang(dtgKhachHang);
                IDKhachHang(cbIDKhach);
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




        //QUẢN LÝ HÓA ĐƠN
        void LoadHoaDon(DataGridView dtgv)
        {
            using(QLKhachSanEntities db = new QLKhachSanEntities())
            {
                var source = from h in db.HoaDon
                             select new
                             {
                                 MãHóaĐơn = h.ID,
                                 IDKháchHàng = h.IDKhachHang,
                                 TênKháchHàng = h.TenKhachHang,
                                 IDPhòng = h.IDPhong,
                                 LoạiPhòng = h.LoaiPhong,
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

        void TaoHoaDon()
        {
            using (QLKhachSanEntities db = new QLKhachSanEntities())
            {
                string id = (Int32.Parse(db.HoaDon.Select(t => t.ID).Max()) + 1).ToString();
                string idkhach = cbIDKhach.Text;
                string ten = txtTenKhach.Text;
                string idphong = txtIDThuePhong.Text;
                string loai = txtLoaiPhong.Text;               

                DateTime ngaydat = DateTime.Parse(dtpNgayDat.Text);
                DateTime ngaythanhtoan = DateTime.Now;
                TimeSpan demngay = ngaythanhtoan.Subtract(ngaydat);

                int songuoi = Int32.Parse(txtSoNguoi.Text);
                int songay = Convert.ToInt32(demngay.TotalDays);
                decimal gia = decimal.Parse(txtGiaPhong.Text);
                decimal tongtien = gia * songay * songuoi;


                HoaDon p = new HoaDon()
                {
                    ID = id,
                    IDKhachHang = idkhach,
                    TenKhachHang = ten,
                    IDPhong= idphong,
                    LoaiPhong= loai,
                    NgayDat= ngaydat,
                    NgayThanhToan= ngaythanhtoan,
                    SoNgayO = songay,
                    SoNguoi= songuoi,
                    TongTien= tongtien,
                };

                db.HoaDon.Add(p);
                db.SaveChanges();
                MessageBox.Show("Đã Tạo Hóa Đơn");
                LoadHoaDon(dtgHoaDon);
            }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            XoaHoaDon();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            TaoHoaDon();
        }















        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtgPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }        

        private void button2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
