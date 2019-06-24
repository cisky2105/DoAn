namespace GUI
{
    partial class ucBanHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBanHang));
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.colMaSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSLTonKho = new System.Windows.Forms.TextBox();
            this.txtGiaKM = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnResetPhieu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboNSX = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiDT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSoLuongMua = new System.Windows.Forms.NumericUpDown();
            this.btnXoaSLM = new System.Windows.Forms.Button();
            this.btnCongSLM = new System.Windows.Forms.Button();
            this.btnTruSLM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pboHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnTimSanPham = new System.Windows.Forms.Button();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            this.lvwSanPham = new System.Windows.Forms.ListView();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imlSanPham = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.txtTimTenSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHDXuat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongMua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToAddRows = false;
            this.dgvChiTietHoaDon.AllowUserToDeleteRows = false;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSp,
            this.colTenSP,
            this.colSoLuong,
            this.colDonGia,
            this.colGiaKM,
            this.colThanhTien});
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(22, 408);
            this.dgvChiTietHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.ReadOnly = true;
            this.dgvChiTietHoaDon.RowHeadersVisible = false;
            this.dgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(677, 247);
            this.dgvChiTietHoaDon.TabIndex = 34;
            // 
            // colMaSp
            // 
            this.colMaSp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaSp.DataPropertyName = "MaSP";
            this.colMaSp.HeaderText = "Mã sản phẩm";
            this.colMaSp.Name = "colMaSp";
            this.colMaSp.ReadOnly = true;
            // 
            // colTenSP
            // 
            this.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSP.DataPropertyName = "MaSP";
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            this.colTenSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSoLuong
            // 
            this.colSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colGiaKM
            // 
            this.colGiaKM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiaKM.DataPropertyName = "GiaKM";
            this.colGiaKM.HeaderText = "Giảm giá";
            this.colGiaKM.Name = "colGiaKM";
            this.colGiaKM.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(575, 34);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(204, 39);
            this.label14.TabIndex = 40;
            this.label14.Text = "BÁN HÀNG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 320);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 22);
            this.label10.TabIndex = 32;
            this.label10.Text = "Số lượng tồn:";
            // 
            // txtSLTonKho
            // 
            this.txtSLTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSLTonKho.Location = new System.Drawing.Point(187, 314);
            this.txtSLTonKho.Margin = new System.Windows.Forms.Padding(2);
            this.txtSLTonKho.Multiline = true;
            this.txtSLTonKho.Name = "txtSLTonKho";
            this.txtSLTonKho.Size = new System.Drawing.Size(132, 28);
            this.txtSLTonKho.TabIndex = 31;
            // 
            // txtGiaKM
            // 
            this.txtGiaKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaKM.Location = new System.Drawing.Point(187, 385);
            this.txtGiaKM.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaKM.Multiline = true;
            this.txtGiaKM.Name = "txtGiaKM";
            this.txtGiaKM.Size = new System.Drawing.Size(357, 28);
            this.txtGiaKM.TabIndex = 30;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaBan.Location = new System.Drawing.Point(187, 348);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaBan.Multiline = true;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(357, 28);
            this.txtGiaBan.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 392);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 28;
            this.label9.Text = "Khuyến mãi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 354);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "Giá Bán:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSP.Location = new System.Drawing.Point(186, 27);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(292, 28);
            this.txtMaSP.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mã sản phẩm:";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhTien.Image")));
            this.btnTinhTien.Location = new System.Drawing.Point(950, 620);
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(2);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(156, 80);
            this.btnTinhTien.TabIndex = 38;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnResetPhieu
            // 
            this.btnResetPhieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResetPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPhieu.Image")));
            this.btnResetPhieu.Location = new System.Drawing.Point(1155, 620);
            this.btnResetPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetPhieu.Name = "btnResetPhieu";
            this.btnResetPhieu.Size = new System.Drawing.Size(156, 80);
            this.btnResetPhieu.TabIndex = 37;
            this.btnResetPhieu.Text = "Reset phiếu";
            this.btnResetPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetPhieu.UseVisualStyleBackColor = false;
            this.btnResetPhieu.Click += new System.EventHandler(this.btnResetPhieu_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTenSP);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cboNSX);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboLoaiDT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nudSoLuongMua);
            this.panel1.Controls.Add(this.btnXoaSLM);
            this.panel1.Controls.Add(this.btnCongSLM);
            this.panel1.Controls.Add(this.btnTruSLM);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pboHinhAnh);
            this.panel1.Controls.Add(this.btnTimSanPham);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSLTonKho);
            this.panel1.Controls.Add(this.txtGiaKM);
            this.panel1.Controls.Add(this.txtGiaBan);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtMaSP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(721, 142);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 474);
            this.panel1.TabIndex = 36;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSP.Location = new System.Drawing.Point(188, 242);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(354, 28);
            this.txtTenSP.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 242);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 22);
            this.label12.TabIndex = 52;
            this.label12.Text = "Tên sản phẩm:";
            // 
            // cboNSX
            // 
            this.cboNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboNSX.FormattingEnabled = true;
            this.cboNSX.Location = new System.Drawing.Point(382, 311);
            this.cboNSX.Margin = new System.Windows.Forms.Padding(2);
            this.cboNSX.Name = "cboNSX";
            this.cboNSX.Size = new System.Drawing.Size(160, 33);
            this.cboNSX.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "NSX:";
            // 
            // cboLoaiDT
            // 
            this.cboLoaiDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLoaiDT.FormattingEnabled = true;
            this.cboLoaiDT.Location = new System.Drawing.Point(187, 278);
            this.cboLoaiDT.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoaiDT.Name = "cboLoaiDT";
            this.cboLoaiDT.Size = new System.Drawing.Size(355, 33);
            this.cboLoaiDT.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 47;
            this.label3.Text = "Loại sản phẩm:";
            // 
            // nudSoLuongMua
            // 
            this.nudSoLuongMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuongMua.Location = new System.Drawing.Point(291, 424);
            this.nudSoLuongMua.Margin = new System.Windows.Forms.Padding(2);
            this.nudSoLuongMua.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuongMua.Name = "nudSoLuongMua";
            this.nudSoLuongMua.Size = new System.Drawing.Size(72, 30);
            this.nudSoLuongMua.TabIndex = 46;
            this.nudSoLuongMua.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnXoaSLM
            // 
            this.btnXoaSLM.Location = new System.Drawing.Point(495, 418);
            this.btnXoaSLM.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaSLM.Name = "btnXoaSLM";
            this.btnXoaSLM.Size = new System.Drawing.Size(48, 46);
            this.btnXoaSLM.TabIndex = 42;
            this.btnXoaSLM.Text = "x";
            this.btnXoaSLM.UseVisualStyleBackColor = true;
            this.btnXoaSLM.Click += new System.EventHandler(this.btnXoaSLM_Click);
            // 
            // btnCongSLM
            // 
            this.btnCongSLM.Location = new System.Drawing.Point(394, 418);
            this.btnCongSLM.Margin = new System.Windows.Forms.Padding(2);
            this.btnCongSLM.Name = "btnCongSLM";
            this.btnCongSLM.Size = new System.Drawing.Size(53, 46);
            this.btnCongSLM.TabIndex = 41;
            this.btnCongSLM.Text = "+";
            this.btnCongSLM.UseVisualStyleBackColor = true;
            this.btnCongSLM.Click += new System.EventHandler(this.btnCongSLM_Click);
            // 
            // btnTruSLM
            // 
            this.btnTruSLM.Location = new System.Drawing.Point(200, 418);
            this.btnTruSLM.Margin = new System.Windows.Forms.Padding(2);
            this.btnTruSLM.Name = "btnTruSLM";
            this.btnTruSLM.Size = new System.Drawing.Size(57, 46);
            this.btnTruSLM.TabIndex = 40;
            this.btnTruSLM.Text = "-";
            this.btnTruSLM.UseVisualStyleBackColor = true;
            this.btnTruSLM.Click += new System.EventHandler(this.btnTruSLM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 431);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Số Lượng Mua:";
            // 
            // pboHinhAnh
            // 
            this.pboHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboHinhAnh.Location = new System.Drawing.Point(223, 66);
            this.pboHinhAnh.Margin = new System.Windows.Forms.Padding(2);
            this.pboHinhAnh.Name = "pboHinhAnh";
            this.pboHinhAnh.Size = new System.Drawing.Size(198, 169);
            this.pboHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboHinhAnh.TabIndex = 37;
            this.pboHinhAnh.TabStop = false;
            // 
            // btnTimSanPham
            // 
            this.btnTimSanPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimSanPham.BackgroundImage")));
            this.btnTimSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimSanPham.Location = new System.Drawing.Point(513, 26);
            this.btnTimSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimSanPham.Name = "btnTimSanPham";
            this.btnTimSanPham.Size = new System.Drawing.Size(33, 28);
            this.btnTimSanPham.TabIndex = 36;
            this.btnTimSanPham.UseVisualStyleBackColor = true;
            this.btnTimSanPham.Click += new System.EventHandler(this.btnTimSanPham_Click);
            // 
            // btnLuuPhieu
            // 
            this.btnLuuPhieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuuPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuPhieu.Image")));
            this.btnLuuPhieu.Location = new System.Drawing.Point(748, 620);
            this.btnLuuPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(156, 80);
            this.btnLuuPhieu.TabIndex = 39;
            this.btnLuuPhieu.Text = "Lưu phiếu";
            this.btnLuuPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuPhieu.UseVisualStyleBackColor = false;
            this.btnLuuPhieu.Click += new System.EventHandler(this.btnLuuPhieu_Click);
            // 
            // lvwSanPham
            // 
            this.lvwSanPham.HideSelection = false;
            this.lvwSanPham.Location = new System.Drawing.Point(22, 142);
            this.lvwSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.lvwSanPham.MultiSelect = false;
            this.lvwSanPham.Name = "lvwSanPham";
            this.lvwSanPham.Size = new System.Drawing.Size(678, 202);
            this.lvwSanPham.TabIndex = 41;
            this.lvwSanPham.UseCompatibleStateImageBehavior = false;
            this.lvwSanPham.SelectedIndexChanged += new System.EventHandler(this.lvwSanPham_SelectedIndexChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Location = new System.Drawing.Point(406, 672);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(292, 28);
            this.txtTongTien.TabIndex = 43;
            this.txtTongTien.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 678);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tổng Tiền:";
            // 
            // imlSanPham
            // 
            this.imlSanPham.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlSanPham.ImageSize = new System.Drawing.Size(16, 16);
            this.imlSanPham.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Nhân Viên:";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDTKH.Location = new System.Drawing.Point(498, 358);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDTKH.Multiline = true;
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(200, 32);
            this.txtSDTKH.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(395, 364);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 22);
            this.label11.TabIndex = 46;
            this.label11.Text = "SDTKH :";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(136, 359);
            this.cboNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(206, 33);
            this.cboNhanVien.TabIndex = 49;
            // 
            // txtTimTenSP
            // 
            this.txtTimTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimTenSP.Location = new System.Drawing.Point(212, 108);
            this.txtTimTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimTenSP.Multiline = true;
            this.txtTimTenSP.Name = "txtTimTenSP";
            this.txtTimTenSP.Size = new System.Drawing.Size(488, 28);
            this.txtTimTenSP.TabIndex = 51;
            this.txtTimTenSP.TextChanged += new System.EventHandler(this.txtTimTenSP_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 22);
            this.label7.TabIndex = 50;
            this.label7.Text = " Tìm tên sản phẩm:";
            // 
            // txtMaHDXuat
            // 
            this.txtMaHDXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHDXuat.Location = new System.Drawing.Point(855, 102);
            this.txtMaHDXuat.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHDXuat.Multiline = true;
            this.txtMaHDXuat.Name = "txtMaHDXuat";
            this.txtMaHDXuat.Size = new System.Drawing.Size(456, 28);
            this.txtMaHDXuat.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(717, 108);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 22);
            this.label13.TabIndex = 55;
            this.label13.Text = "Mã hóa đơn:";
            // 
            // ucBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMaHDXuat);
            this.Controls.Add(this.txtTimTenSP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.txtSDTKH);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwSanPham);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnResetPhieu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLuuPhieu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucBanHang";
            this.Size = new System.Drawing.Size(1334, 717);
            this.Load += new System.EventHandler(this.ucBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongMua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSLTonKho;
        private System.Windows.Forms.TextBox txtGiaKM;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnResetPhieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.Button btnTimSanPham;
        private System.Windows.Forms.ListView lvwSanPham;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboHinhAnh;
        private System.Windows.Forms.Button btnXoaSLM;
        private System.Windows.Forms.Button btnCongSLM;
        private System.Windows.Forms.Button btnTruSLM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSoLuongMua;
        private System.Windows.Forms.ImageList imlSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLoaiDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNSX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSp;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.TextBox txtTimTenSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaHDXuat;
        private System.Windows.Forms.Label label13;
    }
}
