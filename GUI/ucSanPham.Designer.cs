namespace GUI
{
    partial class ucSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSanPham));
            this.cboNhaSanXuat = new System.Windows.Forms.ComboBox();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboLoaiDT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTimKiemSP = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dgvQLSanPham = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiSanPham = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNhaSanXuat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnLuuSP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSanPham)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // cboNhaSanXuat
            // 
            this.cboNhaSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhaSanXuat.FormattingEnabled = true;
            this.cboNhaSanXuat.Location = new System.Drawing.Point(942, 8);
            this.cboNhaSanXuat.Name = "cboNhaSanXuat";
            this.cboNhaSanXuat.Size = new System.Drawing.Size(341, 34);
            this.cboNhaSanXuat.TabIndex = 88;
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhuyenMai.Location = new System.Drawing.Point(251, 128);
            this.txtKhuyenMai.Multiline = true;
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(341, 34);
            this.txtKhuyenMai.TabIndex = 87;
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaSP.Location = new System.Drawing.Point(251, 88);
            this.txtGiaSP.Multiline = true;
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(341, 34);
            this.txtGiaSP.TabIndex = 86;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(251, 48);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(341, 34);
            this.txtTenSP.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 26);
            this.label6.TabIndex = 83;
            this.label6.Text = "Giá khuyến mãi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 26);
            this.label5.TabIndex = 81;
            this.label5.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(743, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 26);
            this.label4.TabIndex = 79;
            this.label4.Text = "Nhà sản xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 26);
            this.label3.TabIndex = 77;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 75;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboLoaiDT);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboNhaSanXuat);
            this.panel1.Controls.Add(this.txtKhuyenMai);
            this.panel1.Controls.Add(this.txtGiaSP);
            this.panel1.Controls.Add(this.txtTenSP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaSP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 178);
            this.panel1.TabIndex = 84;
            // 
            // cboLoaiDT
            // 
            this.cboLoaiDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiDT.FormattingEnabled = true;
            this.cboLoaiDT.Location = new System.Drawing.Point(942, 50);
            this.cboLoaiDT.Name = "cboLoaiDT";
            this.cboLoaiDT.Size = new System.Drawing.Size(341, 34);
            this.cboLoaiDT.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(727, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 26);
            this.label7.TabIndex = 89;
            this.label7.Text = "Loại điện thoại:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(251, 8);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(341, 34);
            this.txtMaSP.TabIndex = 76;
            // 
            // txtTimKiemSP
            // 
            this.txtTimKiemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemSP.Location = new System.Drawing.Point(257, 97);
            this.txtTimKiemSP.Multiline = true;
            this.txtTimKiemSP.Name = "txtTimKiemSP";
            this.txtTimKiemSP.Size = new System.Drawing.Size(341, 34);
            this.txtTimKiemSP.TabIndex = 82;
            this.txtTimKiemSP.TextChanged += new System.EventHandler(this.txtTimKiemSP_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(81, 105);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 26);
            this.label22.TabIndex = 81;
            this.label22.Text = "Tìm kiếm:";
            // 
            // dgvQLSanPham
            // 
            this.dgvQLSanPham.AllowUserToAddRows = false;
            this.dgvQLSanPham.AllowUserToDeleteRows = false;
            this.dgvQLSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colLoaiSanPham,
            this.colNhaSanXuat,
            this.colGiaBan,
            this.colGiaKhuyenMai});
            this.dgvQLSanPham.Location = new System.Drawing.Point(4, 4);
            this.dgvQLSanPham.MultiSelect = false;
            this.dgvQLSanPham.Name = "dgvQLSanPham";
            this.dgvQLSanPham.ReadOnly = true;
            this.dgvQLSanPham.RowHeadersVisible = false;
            this.dgvQLSanPham.RowTemplate.Height = 24;
            this.dgvQLSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLSanPham.Size = new System.Drawing.Size(1768, 429);
            this.dgvQLSanPham.TabIndex = 0;
            this.dgvQLSanPham.SelectionChanged += new System.EventHandler(this.dgvQLSanPham_SelectionChanged);
            // 
            // colMaSP
            // 
            this.colMaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaSP.DataPropertyName = "MaSP";
            this.colMaSP.HeaderText = "Mã sản phẩm";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            this.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSP.DataPropertyName = "TenSP";
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            // 
            // colLoaiSanPham
            // 
            this.colLoaiSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLoaiSanPham.DataPropertyName = "MaLoaiDT";
            this.colLoaiSanPham.HeaderText = "Loại sản phẩm";
            this.colLoaiSanPham.Name = "colLoaiSanPham";
            this.colLoaiSanPham.ReadOnly = true;
            this.colLoaiSanPham.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLoaiSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colNhaSanXuat
            // 
            this.colNhaSanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNhaSanXuat.DataPropertyName = "MaNSX";
            this.colNhaSanXuat.HeaderText = "Nhà sản xuất";
            this.colNhaSanXuat.Name = "colNhaSanXuat";
            this.colNhaSanXuat.ReadOnly = true;
            this.colNhaSanXuat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNhaSanXuat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colGiaBan
            // 
            this.colGiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiaBan.DataPropertyName = "GiaBan";
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            // 
            // colGiaKhuyenMai
            // 
            this.colGiaKhuyenMai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiaKhuyenMai.DataPropertyName = "GiaKM";
            this.colGiaKhuyenMai.HeaderText = "Giá khuyến mãi";
            this.colGiaKhuyenMai.Name = "colGiaKhuyenMai";
            this.colGiaKhuyenMai.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQLSanPham);
            this.panel2.Location = new System.Drawing.Point(2, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1775, 436);
            this.panel2.TabIndex = 80;
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSP.Image")));
            this.btnSuaSP.Location = new System.Drawing.Point(1038, 334);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(237, 98);
            this.btnSuaSP.TabIndex = 76;
            this.btnSuaSP.Text = "   Sửa";
            this.btnSuaSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaSP.UseVisualStyleBackColor = false;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSP.Image")));
            this.btnThemSP.Location = new System.Drawing.Point(257, 334);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(237, 98);
            this.btnThemSP.TabIndex = 75;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSP.Image")));
            this.btnXoaSP.Location = new System.Drawing.Point(656, 338);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(237, 98);
            this.btnXoaSP.TabIndex = 77;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnLuuSP
            // 
            this.btnLuuSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuuSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuSP.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuSP.Image")));
            this.btnLuuSP.Location = new System.Drawing.Point(1413, 338);
            this.btnLuuSP.Name = "btnLuuSP";
            this.btnLuuSP.Size = new System.Drawing.Size(237, 98);
            this.btnLuuSP.TabIndex = 78;
            this.btnLuuSP.Text = "Lưu";
            this.btnLuuSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuSP.UseVisualStyleBackColor = false;
            this.btnLuuSP.Click += new System.EventHandler(this.btnLuuSP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 48);
            this.label1.TabIndex = 79;
            this.label1.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // picSanPham
            // 
            this.picSanPham.Location = new System.Drawing.Point(1375, 18);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(300, 300);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSanPham.TabIndex = 85;
            this.picSanPham.TabStop = false;
            this.picSanPham.Click += new System.EventHandler(this.picSanPham_Click);
            // 
            // ucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picSanPham);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTimKiemSP);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnLuuSP);
            this.Controls.Add(this.label1);
            this.Name = "ucSanPham";
            this.Size = new System.Drawing.Size(1778, 883);
            this.Load += new System.EventHandler(this.ucSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSanPham)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNhaSanXuat;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.TextBox txtGiaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTimKiemSP;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dgvQLSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnLuuSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiSanPham;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaKhuyenMai;
    }
}
