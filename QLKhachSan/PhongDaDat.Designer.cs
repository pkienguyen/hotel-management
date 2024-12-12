namespace QLKhachSan
{
    partial class PhongDaDat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgThuePhong = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSuaTT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThToan = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIDKhach = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtIDBangTP = new System.Windows.Forms.TextBox();
            this.lblIDBanTP = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtIDThuePhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThuePhong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgThuePhong
            // 
            this.dtgThuePhong.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dtgThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThuePhong.GridColor = System.Drawing.Color.RosyBrown;
            this.dtgThuePhong.Location = new System.Drawing.Point(30, 62);
            this.dtgThuePhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgThuePhong.Name = "dtgThuePhong";
            this.dtgThuePhong.RowHeadersWidth = 51;
            this.dtgThuePhong.RowTemplate.Height = 24;
            this.dtgThuePhong.Size = new System.Drawing.Size(606, 580);
            this.dtgThuePhong.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnSuaTT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnThToan);
            this.panel1.Controls.Add(this.dtgThuePhong);
            this.panel1.Controls.Add(this.btnTra);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 666);
            this.panel1.TabIndex = 28;
            // 
            // btnSuaTT
            // 
            this.btnSuaTT.BackColor = System.Drawing.Color.IndianRed;
            this.btnSuaTT.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSuaTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSuaTT.Location = new System.Drawing.Point(1010, 577);
            this.btnSuaTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaTT.Name = "btnSuaTT";
            this.btnSuaTT.Size = new System.Drawing.Size(165, 65);
            this.btnSuaTT.TabIndex = 25;
            this.btnSuaTT.Text = "Sủa Thông Tin";
            this.btnSuaTT.UseVisualStyleBackColor = false;
            this.btnSuaTT.Click += new System.EventHandler(this.btnSuaTT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(701, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Thông Tin Thuê Phòng";
            // 
            // btnThToan
            // 
            this.btnThToan.BackColor = System.Drawing.Color.IndianRed;
            this.btnThToan.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnThToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnThToan.Location = new System.Drawing.Point(843, 577);
            this.btnThToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThToan.Name = "btnThToan";
            this.btnThToan.Size = new System.Drawing.Size(165, 65);
            this.btnThToan.TabIndex = 21;
            this.btnThToan.Text = "Thanh Toán";
            this.btnThToan.UseVisualStyleBackColor = false;
            this.btnThToan.Click += new System.EventHandler(this.btnThToan_Click);
            // 
            // btnTra
            // 
            this.btnTra.BackColor = System.Drawing.Color.IndianRed;
            this.btnTra.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTra.Location = new System.Drawing.Point(676, 577);
            this.btnTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(165, 65);
            this.btnTra.TabIndex = 20;
            this.btnTra.Text = "Trả Phòng";
            this.btnTra.UseVisualStyleBackColor = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Danh Sách Phòng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.txtIDKhach);
            this.panel2.Controls.Add(this.txtTenKhach);
            this.panel2.Controls.Add(this.label38);
            this.panel2.Controls.Add(this.txtGiaPhong);
            this.panel2.Controls.Add(this.label39);
            this.panel2.Controls.Add(this.txtIDBangTP);
            this.panel2.Controls.Add(this.lblIDBanTP);
            this.panel2.Controls.Add(this.txtLoaiPhong);
            this.panel2.Controls.Add(this.label37);
            this.panel2.Controls.Add(this.txtSoNguoi);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dtpNgayDat);
            this.panel2.Controls.Add(this.txtIDThuePhong);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(676, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 491);
            this.panel2.TabIndex = 19;
            // 
            // txtIDKhach
            // 
            this.txtIDKhach.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtIDKhach.Location = new System.Drawing.Point(188, 258);
            this.txtIDKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDKhach.Name = "txtIDKhach";
            this.txtIDKhach.ReadOnly = true;
            this.txtIDKhach.Size = new System.Drawing.Size(276, 28);
            this.txtIDKhach.TabIndex = 32;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(188, 320);
            this.txtTenKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.ReadOnly = true;
            this.txtTenKhach.Size = new System.Drawing.Size(275, 28);
            this.txtTenKhach.TabIndex = 31;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(34, 316);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(86, 38);
            this.label38.TabIndex = 30;
            this.label38.Text = "Tên Khách\r\nHàng:";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtGiaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtGiaPhong.Location = new System.Drawing.Point(188, 201);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.ReadOnly = true;
            this.txtGiaPhong.Size = new System.Drawing.Size(276, 28);
            this.txtGiaPhong.TabIndex = 18;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(34, 146);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(100, 19);
            this.label39.TabIndex = 17;
            this.label39.Text = "Loại Phòng:";
            // 
            // txtIDBangTP
            // 
            this.txtIDBangTP.Location = new System.Drawing.Point(188, 31);
            this.txtIDBangTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDBangTP.Name = "txtIDBangTP";
            this.txtIDBangTP.ReadOnly = true;
            this.txtIDBangTP.Size = new System.Drawing.Size(275, 28);
            this.txtIDBangTP.TabIndex = 29;
            // 
            // lblIDBanTP
            // 
            this.lblIDBanTP.AutoSize = true;
            this.lblIDBanTP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblIDBanTP.ForeColor = System.Drawing.Color.Black;
            this.lblIDBanTP.Location = new System.Drawing.Point(34, 25);
            this.lblIDBanTP.Name = "lblIDBanTP";
            this.lblIDBanTP.Size = new System.Drawing.Size(109, 38);
            this.lblIDBanTP.TabIndex = 28;
            this.lblIDBanTP.Text = "ID Bảng Thuê\r\nPhòng:";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtLoaiPhong.Location = new System.Drawing.Point(188, 143);
            this.txtLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.ReadOnly = true;
            this.txtLoaiPhong.Size = new System.Drawing.Size(276, 28);
            this.txtLoaiPhong.TabIndex = 14;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(34, 204);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(94, 19);
            this.label37.TabIndex = 13;
            this.label37.Text = "Giá Phòng:";
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtSoNguoi.Location = new System.Drawing.Point(188, 435);
            this.txtSoNguoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(276, 28);
            this.txtSoNguoi.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(34, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Số Người:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(34, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày Đặt:";
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dtpNgayDat.Location = new System.Drawing.Point(188, 379);
            this.dtpNgayDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(276, 25);
            this.dtpNgayDat.TabIndex = 9;
            // 
            // txtIDThuePhong
            // 
            this.txtIDThuePhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtIDThuePhong.Location = new System.Drawing.Point(188, 86);
            this.txtIDThuePhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDThuePhong.Name = "txtIDThuePhong";
            this.txtIDThuePhong.ReadOnly = true;
            this.txtIDThuePhong.Size = new System.Drawing.Size(276, 28);
            this.txtIDThuePhong.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(34, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Khách Hàng:";
            // 
            // PhongDaDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1230, 690);
            this.Controls.Add(this.panel1);
            this.Name = "PhongDaDat";
            this.Text = "PhongDaDat";
            this.Load += new System.EventHandler(this.PhongDaDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgThuePhong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgThuePhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSuaTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThToan;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtIDBangTP;
        private System.Windows.Forms.Label lblIDBanTP;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.TextBox txtIDThuePhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDKhach;
    }
}