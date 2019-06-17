namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChiTietHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBaoCaoHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBaoCaoBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLyKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLyBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLyNSX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLyNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLyKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLySanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.hỆTHÔNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnKho
            // 
            this.mnKho.Image = ((System.Drawing.Image)(resources.GetObject("mnKho.Image")));
            this.mnKho.Name = "mnKho";
            this.mnKho.Size = new System.Drawing.Size(306, 46);
            this.mnKho.Text = "Kho";
            // 
            // mnChiTietHoaDon
            // 
            this.mnChiTietHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("mnChiTietHoaDon.Image")));
            this.mnChiTietHoaDon.Name = "mnChiTietHoaDon";
            this.mnChiTietHoaDon.Size = new System.Drawing.Size(306, 46);
            this.mnChiTietHoaDon.Text = "Chi tiết hóa đơn";
            // 
            // mnBaoCaoHoaDon
            // 
            this.mnBaoCaoHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("mnBaoCaoHoaDon.Image")));
            this.mnBaoCaoHoaDon.Name = "mnBaoCaoHoaDon";
            this.mnBaoCaoHoaDon.Size = new System.Drawing.Size(306, 46);
            this.mnBaoCaoHoaDon.Text = "Hóa đơn";
            // 
            // mnBaoCaoBanHang
            // 
            this.mnBaoCaoBanHang.Image = ((System.Drawing.Image)(resources.GetObject("mnBaoCaoBanHang.Image")));
            this.mnBaoCaoBanHang.Name = "mnBaoCaoBanHang";
            this.mnBaoCaoBanHang.Size = new System.Drawing.Size(306, 46);
            this.mnBaoCaoBanHang.Text = "Bán hàng";
            // 
            // mnBaoCao
            // 
            this.mnBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBaoCaoBanHang,
            this.mnBaoCaoHoaDon,
            this.mnChiTietHoaDon,
            this.mnKho});
            this.mnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("mnBaoCao.Image")));
            this.mnBaoCao.Name = "mnBaoCao";
            this.mnBaoCao.Size = new System.Drawing.Size(180, 44);
            this.mnBaoCao.Text = "BÁO CÁO";
            // 
            // mnTonKho
            // 
            this.mnTonKho.Image = ((System.Drawing.Image)(resources.GetObject("mnTonKho.Image")));
            this.mnTonKho.Name = "mnTonKho";
            this.mnTonKho.Size = new System.Drawing.Size(212, 46);
            this.mnTonKho.Text = "Tồn kho";
            // 
            // mnQuanLyKho
            // 
            this.mnQuanLyKho.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTonKho});
            this.mnQuanLyKho.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanLyKho.Image")));
            this.mnQuanLyKho.Name = "mnQuanLyKho";
            this.mnQuanLyKho.Size = new System.Drawing.Size(237, 44);
            this.mnQuanLyKho.Text = "QUẢN LÝ KHO";
            // 
            // mnNhapHang
            // 
            this.mnNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("mnNhapHang.Image")));
            this.mnNhapHang.Name = "mnNhapHang";
            this.mnNhapHang.Size = new System.Drawing.Size(245, 46);
            this.mnNhapHang.Text = "Nhập hàng";
            // 
            // mnBanHang
            // 
            this.mnBanHang.Image = ((System.Drawing.Image)(resources.GetObject("mnBanHang.Image")));
            this.mnBanHang.Name = "mnBanHang";
            this.mnBanHang.Size = new System.Drawing.Size(245, 46);
            this.mnBanHang.Text = "Bán hàng";
            // 
            // mnQuanLyBanHang
            // 
            this.mnQuanLyBanHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBanHang,
            this.mnNhapHang});
            this.mnQuanLyBanHang.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanLyBanHang.Image")));
            this.mnQuanLyBanHang.Name = "mnQuanLyBanHang";
            this.mnQuanLyBanHang.Size = new System.Drawing.Size(319, 44);
            this.mnQuanLyBanHang.Text = "QUẢN LÝ BÁN HÀNG";
            // 
            // mnQuanLyNSX
            // 
            this.mnQuanLyNSX.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanLyNSX.Image")));
            this.mnQuanLyNSX.Name = "mnQuanLyNSX";
            this.mnQuanLyNSX.Size = new System.Drawing.Size(367, 46);
            this.mnQuanLyNSX.Text = "Quản lý nhà sản xuất";
            // 
            // mnQuanLyNCC
            // 
            this.mnQuanLyNCC.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanLyNCC.Image")));
            this.mnQuanLyNCC.Name = "mnQuanLyNCC";
            this.mnQuanLyNCC.Size = new System.Drawing.Size(367, 46);
            this.mnQuanLyNCC.Text = "Quản lý nhà cung cấp";
            // 
            // mnQuanLyKhachHang
            // 
            this.mnQuanLyKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanLyKhachHang.Image")));
            this.mnQuanLyKhachHang.Name = "mnQuanLyKhachHang";
            this.mnQuanLyKhachHang.Size = new System.Drawing.Size(367, 46);
            this.mnQuanLyKhachHang.Text = "Quản lý khách hàng";
            // 
            // mnQuanLyNhanVien
            // 
            this.mnQuanLyNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanLyNhanVien.Image")));
            this.mnQuanLyNhanVien.Name = "mnQuanLyNhanVien";
            this.mnQuanLyNhanVien.Size = new System.Drawing.Size(367, 46);
            this.mnQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.mnQuanLyNhanVien.Click += new System.EventHandler(this.mnQuanLyNhanVien_Click);
            // 
            // mnQuanLySanPham
            // 
            this.mnQuanLySanPham.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanLySanPham.Image")));
            this.mnQuanLySanPham.Name = "mnQuanLySanPham";
            this.mnQuanLySanPham.Size = new System.Drawing.Size(367, 46);
            this.mnQuanLySanPham.Text = "Quản lý sản phẩm";
            this.mnQuanLySanPham.Click += new System.EventHandler(this.mnQuanLySanPham_Click);
            // 
            // mnDanhMuc
            // 
            this.mnDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnQuanLySanPham,
            this.mnQuanLyNhanVien,
            this.mnQuanLyKhachHang,
            this.mnQuanLyNCC,
            this.mnQuanLyNSX});
            this.mnDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("mnDanhMuc.Image")));
            this.mnDanhMuc.Name = "mnDanhMuc";
            this.mnDanhMuc.Size = new System.Drawing.Size(207, 44);
            this.mnDanhMuc.Text = "DANH MỤC";
            // 
            // mnThoat
            // 
            this.mnThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnThoat.Image")));
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(273, 46);
            this.mnThoat.Text = "Thoát";
            // 
            // mnDoiMatKhau
            // 
            this.mnDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("mnDoiMatKhau.Image")));
            this.mnDoiMatKhau.Name = "mnDoiMatKhau";
            this.mnDoiMatKhau.Size = new System.Drawing.Size(273, 46);
            this.mnDoiMatKhau.Text = "Đổi mật khấu";
            // 
            // hỆTHÔNGToolStripMenuItem
            // 
            this.hỆTHÔNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDoiMatKhau,
            this.mnThoat});
            this.hỆTHÔNGToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hỆTHÔNGToolStripMenuItem.Image")));
            this.hỆTHÔNGToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.hỆTHÔNGToolStripMenuItem.Name = "hỆTHÔNGToolStripMenuItem";
            this.hỆTHÔNGToolStripMenuItem.Size = new System.Drawing.Size(197, 44);
            this.hỆTHÔNGToolStripMenuItem.Text = "HỆ THỐNG";
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("mnDangXuat.Image")));
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(215, 44);
            this.mnDangXuat.Text = "ĐĂNG XUẤT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hỆTHÔNGToolStripMenuItem,
            this.mnDanhMuc,
            this.mnQuanLyBanHang,
            this.mnQuanLyKho,
            this.mnBaoCao,
            this.mnDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1882, 48);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(80, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1842, 878);
            this.panel1.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnKho;
        private System.Windows.Forms.ToolStripMenuItem mnChiTietHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnBaoCaoHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnBaoCaoBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnTonKho;
        private System.Windows.Forms.ToolStripMenuItem mnQuanLyKho;
        private System.Windows.Forms.ToolStripMenuItem mnNhapHang;
        private System.Windows.Forms.ToolStripMenuItem mnBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnQuanLyBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnQuanLyNSX;
        private System.Windows.Forms.ToolStripMenuItem mnQuanLyNCC;
        private System.Windows.Forms.ToolStripMenuItem mnQuanLyKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnQuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnQuanLySanPham;
        private System.Windows.Forms.ToolStripMenuItem mnDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem hỆTHÔNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}

