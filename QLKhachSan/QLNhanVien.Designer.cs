namespace QLKhachSan
{
    partial class QLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLNhanVien));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiTen = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiID = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIDNV = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1401, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.homeToolStripMenuItem.Text = "Quản Lý Khách Sạn";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiTen,
            this.tmiID});
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông Tin Cá Nhân";
            // 
            // tmiTen
            // 
            this.tmiTen.Name = "tmiTen";
            this.tmiTen.Size = new System.Drawing.Size(187, 26);
            this.tmiTen.Text = "Tên Nhân Viên";
            this.tmiTen.Click += new System.EventHandler(this.tmiID_Click);
            // 
            // tmiID
            // 
            this.tmiID.Name = "tmiID";
            this.tmiID.Size = new System.Drawing.Size(187, 26);
            this.tmiID.Text = "ID Nhân Viên";
            this.tmiID.Click += new System.EventHandler(this.tmiID_Click_1);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 50);
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1376, 698);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.dtgNhanVien);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1368, 640);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Nhân Sự";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(896, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Thông Tin";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(32, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 16);
            this.label16.TabIndex = 37;
            this.label16.Text = "Danh Sách Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtIDNV);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Location = new System.Drawing.Point(881, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 433);
            this.panel1.TabIndex = 36;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(133, 266);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(287, 22);
            this.dtpNgaySinh.TabIndex = 75;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(133, 195);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(287, 22);
            this.txtSDT.TabIndex = 73;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label23.Location = new System.Drawing.Point(36, 199);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 16);
            this.label23.TabIndex = 72;
            this.label23.Text = "SĐT";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(133, 341);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(287, 22);
            this.txtDiaChi.TabIndex = 71;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label22.Location = new System.Drawing.Point(36, 345);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 16);
            this.label22.TabIndex = 70;
            this.label22.Text = "Địa Chỉ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label20.Location = new System.Drawing.Point(36, 271);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 16);
            this.label20.TabIndex = 68;
            this.label20.Text = "Ngày Sinh";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(133, 122);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(287, 22);
            this.txtTenNV.TabIndex = 67;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(36, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 16);
            this.label18.TabIndex = 66;
            this.label18.Text = "Tên";
            // 
            // txtIDNV
            // 
            this.txtIDNV.Location = new System.Drawing.Point(133, 49);
            this.txtIDNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDNV.Name = "txtIDNV";
            this.txtIDNV.ReadOnly = true;
            this.txtIDNV.Size = new System.Drawing.Size(287, 22);
            this.txtIDNV.TabIndex = 65;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(36, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 16);
            this.label17.TabIndex = 64;
            this.label17.Text = "ID";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1193, 546);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 57);
            this.button4.TabIndex = 35;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1037, 546);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 57);
            this.button5.TabIndex = 34;
            this.button5.Text = "Sửa";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.IndianRed;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(881, 546);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 57);
            this.button6.TabIndex = 33;
            this.button6.Text = "Thêm";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Location = new System.Drawing.Point(35, 66);
            this.dtgNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.RowHeadersWidth = 51;
            this.dtgNhanVien.RowTemplate.Height = 24;
            this.dtgNhanVien.Size = new System.Drawing.Size(821, 537);
            this.dtgNhanVien.TabIndex = 32;
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1401, 743);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.QLNhanVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem tmiTen;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dtgNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIDNV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tmiID;
    }
}