namespace QLKhachSan
{
    partial class PhongTrong
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.cbIDKhach = new System.Windows.Forms.ComboBox();
            this.txtIDThuePhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgThuePhong = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThuePhong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.IndianRed;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnThanhToan.Location = new System.Drawing.Point(1010, 487);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(165, 65);
            this.btnThanhToan.TabIndex = 25;
            this.btnThanhToan.Text = "Xem Phòng Thường";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click_1);
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
            // btnTraPhong
            // 
            this.btnTraPhong.BackColor = System.Drawing.Color.IndianRed;
            this.btnTraPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnTraPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTraPhong.Location = new System.Drawing.Point(843, 487);
            this.btnTraPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(165, 65);
            this.btnTraPhong.TabIndex = 21;
            this.btnTraPhong.Text = "Xem Phòng VIP";
            this.btnTraPhong.UseVisualStyleBackColor = false;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click_1);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.IndianRed;
            this.btnDatPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDatPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDatPhong.Location = new System.Drawing.Point(676, 487);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(165, 65);
            this.btnDatPhong.TabIndex = 20;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.txtGiaPhong);
            this.panel2.Controls.Add(this.label39);
            this.panel2.Controls.Add(this.txtLoaiPhong);
            this.panel2.Controls.Add(this.label37);
            this.panel2.Controls.Add(this.txtSoNguoi);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dtpNgayDat);
            this.panel2.Controls.Add(this.cbIDKhach);
            this.panel2.Controls.Add(this.txtIDThuePhong);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(676, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 370);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtGiaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtGiaPhong.Location = new System.Drawing.Point(185, 142);
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
            this.label39.Location = new System.Drawing.Point(31, 87);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(100, 19);
            this.label39.TabIndex = 17;
            this.label39.Text = "Loại Phòng:";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtLoaiPhong.Location = new System.Drawing.Point(185, 84);
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
            this.label37.Location = new System.Drawing.Point(31, 145);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(94, 19);
            this.label37.TabIndex = 13;
            this.label37.Text = "Giá Phòng:";
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtSoNguoi.Location = new System.Drawing.Point(185, 311);
            this.txtSoNguoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(276, 28);
            this.txtSoNguoi.TabIndex = 12;
            this.txtSoNguoi.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(31, 313);
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
            this.label8.Location = new System.Drawing.Point(31, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày Đặt:";
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dtpNgayDat.Location = new System.Drawing.Point(185, 255);
            this.dtpNgayDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(276, 25);
            this.dtpNgayDat.TabIndex = 9;
            // 
            // cbIDKhach
            // 
            this.cbIDKhach.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbIDKhach.FormattingEnabled = true;
            this.cbIDKhach.Location = new System.Drawing.Point(185, 199);
            this.cbIDKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIDKhach.Name = "cbIDKhach";
            this.cbIDKhach.Size = new System.Drawing.Size(276, 29);
            this.cbIDKhach.TabIndex = 6;
            // 
            // txtIDThuePhong
            // 
            this.txtIDThuePhong.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtIDThuePhong.Location = new System.Drawing.Point(185, 27);
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
            this.label6.Location = new System.Drawing.Point(31, 29);
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
            this.label3.Location = new System.Drawing.Point(31, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Khách Hàng:";
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
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTraPhong);
            this.panel1.Controls.Add(this.dtgThuePhong);
            this.panel1.Controls.Add(this.btnDatPhong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 666);
            this.panel1.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(676, 594);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(499, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------------";
            // 
            // PhongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1230, 690);
            this.Controls.Add(this.panel1);
            this.Name = "PhongTrong";
            this.Text = "PhongTrong";
            this.Load += new System.EventHandler(this.PhongTrong_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThuePhong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cbIDKhach;
        private System.Windows.Forms.TextBox txtIDThuePhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgThuePhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label label14;
    }
}