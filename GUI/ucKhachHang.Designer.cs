namespace GUI
{
    partial class ucKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucKhachHang));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnNhapExcel = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailKH = new System.Windows.Forms.TextBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colSDTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvKhachHang);
            this.panel2.Location = new System.Drawing.Point(2, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1775, 439);
            this.panel2.TabIndex = 5;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSDTKH,
            this.colTenKH,
            this.colGioiTinhKH,
            this.colDiaChiKH,
            this.colEmailKH});
            this.dgvKhachHang.Location = new System.Drawing.Point(4, 3);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(1769, 433);
            this.dgvKhachHang.TabIndex = 28;
            this.dgvKhachHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvKhachHang_CellFormatting);
            this.dgvKhachHang.SelectionChanged += new System.EventHandler(this.dgvKhachHang_SelectionChanged);
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuuKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuKH.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuKH.Image")));
            this.btnLuuKH.Location = new System.Drawing.Point(1150, 239);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(237, 98);
            this.btnLuuKH.TabIndex = 36;
            this.btnLuuKH.Text = "Lưu";
            this.btnLuuKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuKH.UseVisualStyleBackColor = false;
            this.btnLuuKH.Click += new System.EventHandler(this.btnLuuKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKH.Image")));
            this.btnXoaKH.Location = new System.Drawing.Point(857, 239);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(237, 98);
            this.btnXoaKH.TabIndex = 35;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaKH.UseVisualStyleBackColor = false;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKH.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKH.Image")));
            this.btnSuaKH.Location = new System.Drawing.Point(530, 239);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(237, 98);
            this.btnSuaKH.TabIndex = 34;
            this.btnSuaKH.Text = "   Sửa";
            this.btnSuaKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaKH.UseVisualStyleBackColor = false;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKH.Image")));
            this.btnThemKH.Location = new System.Drawing.Point(241, 239);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(237, 98);
            this.btnThemKH.TabIndex = 33;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnNhapExcel
            // 
            this.btnNhapExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNhapExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapExcel.Image")));
            this.btnNhapExcel.Location = new System.Drawing.Point(1150, 122);
            this.btnNhapExcel.Name = "btnNhapExcel";
            this.btnNhapExcel.Size = new System.Drawing.Size(237, 98);
            this.btnNhapExcel.TabIndex = 32;
            this.btnNhapExcel.Text = "Nhập Excel";
            this.btnNhapExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapExcel.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.Location = new System.Drawing.Point(857, 122);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(237, 98);
            this.btnXuatExcel.TabIndex = 31;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(1135, 25);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(56, 28);
            this.radNu.TabIndex = 26;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(852, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Giới tính:";
            // 
            // txtEmailKH
            // 
            this.txtEmailKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailKH.Location = new System.Drawing.Point(458, 186);
            this.txtEmailKH.Multiline = true;
            this.txtEmailKH.Name = "txtEmailKH";
            this.txtEmailKH.Size = new System.Drawing.Size(237, 34);
            this.txtEmailKH.TabIndex = 22;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(1011, 23);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(71, 28);
            this.radNam.TabIndex = 25;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Email:";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.Location = new System.Drawing.Point(458, 124);
            this.txtDiaChiKH.Multiline = true;
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(237, 34);
            this.txtDiaChiKH.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên khách hàng:";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKH.Location = new System.Drawing.Point(458, 17);
            this.txtSDTKH.Multiline = true;
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(237, 34);
            this.txtSDTKH.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số điện thoại:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLuuKH);
            this.panel1.Controls.Add(this.btnXoaKH);
            this.panel1.Controls.Add(this.btnSuaKH);
            this.panel1.Controls.Add(this.btnThemKH);
            this.panel1.Controls.Add(this.btnNhapExcel);
            this.panel1.Controls.Add(this.btnXuatExcel);
            this.panel1.Controls.Add(this.radNu);
            this.panel1.Controls.Add(this.radNam);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtEmailKH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDiaChiKH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSDTKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1772, 348);
            this.panel1.TabIndex = 4;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(458, 67);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(237, 34);
            this.txtTenKH.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(618, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // colSDTKH
            // 
            this.colSDTKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSDTKH.DataPropertyName = "SDTKH";
            this.colSDTKH.HeaderText = "Số điện thoại";
            this.colSDTKH.Name = "colSDTKH";
            this.colSDTKH.ReadOnly = true;
            // 
            // colTenKH
            // 
            this.colTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenKH.DataPropertyName = "TenKH";
            this.colTenKH.HeaderText = "Tên khách hàng";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.ReadOnly = true;
            // 
            // colGioiTinhKH
            // 
            this.colGioiTinhKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGioiTinhKH.DataPropertyName = "GioiTinh";
            this.colGioiTinhKH.HeaderText = "Giới tính";
            this.colGioiTinhKH.Name = "colGioiTinhKH";
            this.colGioiTinhKH.ReadOnly = true;
            // 
            // colDiaChiKH
            // 
            this.colDiaChiKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiaChiKH.DataPropertyName = "DiaChi";
            this.colDiaChiKH.HeaderText = "Địa chỉ";
            this.colDiaChiKH.Name = "colDiaChiKH";
            this.colDiaChiKH.ReadOnly = true;
            // 
            // colEmailKH
            // 
            this.colEmailKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmailKH.DataPropertyName = "Email";
            this.colEmailKH.HeaderText = "Email";
            this.colEmailKH.Name = "colEmailKH";
            this.colEmailKH.ReadOnly = true;
            // 
            // ucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ucKhachHang";
            this.Size = new System.Drawing.Size(1778, 883);
            this.Load += new System.EventHandler(this.ucKhachHang_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnNhapExcel;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailKH;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailKH;
    }
}
