namespace QLKhachSan
{
    partial class QLPhong
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
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDPhong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgPhong = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(656, 562);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(523, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(656, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Thông Tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Danh Sách Phòng";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnXoa.Location = new System.Drawing.Point(1007, 441);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(172, 65);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa Phòng";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.IndianRed;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSua.Location = new System.Drawing.Point(833, 441);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(172, 65);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa Thông Tin";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.IndianRed;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnThem.Location = new System.Drawing.Point(659, 441);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 65);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm Phòng";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtTinhTrang);
            this.panel1.Controls.Add(this.cbLoaiPhong);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtIDPhong);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(659, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 327);
            this.panel1.TabIndex = 12;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtTinhTrang.Location = new System.Drawing.Point(158, 115);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.ReadOnly = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(326, 28);
            this.txtTinhTrang.TabIndex = 9;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(158, 173);
            this.cbLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(326, 29);
            this.cbLoaiPhong.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(26, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 19);
            this.label13.TabIndex = 7;
            this.label13.Text = "Loại Phòng:";
            // 
            // txtGia
            // 
            this.txtGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtGia.Location = new System.Drawing.Point(158, 230);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(326, 28);
            this.txtGia.TabIndex = 5;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(26, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Giá Phòng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(26, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tình Trạng:";
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtIDPhong.Location = new System.Drawing.Point(158, 57);
            this.txtIDPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.ReadOnly = true;
            this.txtIDPhong.Size = new System.Drawing.Size(326, 28);
            this.txtIDPhong.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(26, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID Phòng:";
            // 
            // dtgPhong
            // 
            this.dtgPhong.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dtgPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhong.GridColor = System.Drawing.Color.RosyBrown;
            this.dtgPhong.Location = new System.Drawing.Point(24, 48);
            this.dtgPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgPhong.Name = "dtgPhong";
            this.dtgPhong.RowHeadersWidth = 51;
            this.dtgPhong.RowTemplate.Height = 24;
            this.dtgPhong.Size = new System.Drawing.Size(604, 593);
            this.dtgPhong.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dtgPhong);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1206, 666);
            this.panel2.TabIndex = 19;
            // 
            // QLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1230, 690);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "QLPhong";
            this.Text = "QLPhong";
            this.Load += new System.EventHandler(this.QLPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIDPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgPhong;
        private System.Windows.Forms.Panel panel2;
    }
}