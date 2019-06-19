namespace GUI
{
    partial class ucNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNhaCungCap));
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuuNCC = new System.Windows.Forms.Button();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnSuaNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.txtEmailNCC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvNhaCungCap = new System.Windows.Forms.DataGridView();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDTNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNCC.Location = new System.Drawing.Point(1045, 22);
            this.txtDiaChiNCC.Multiline = true;
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(237, 34);
            this.txtDiaChiNCC.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(906, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtSDTNCC
            // 
            this.txtSDTNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNCC.Location = new System.Drawing.Point(509, 122);
            this.txtSDTNCC.Multiline = true;
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.Size = new System.Drawing.Size(237, 34);
            this.txtSDTNCC.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "Số điện thoại:";
            // 
            // btnLuuNCC
            // 
            this.btnLuuNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuuNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuNCC.Image")));
            this.btnLuuNCC.Location = new System.Drawing.Point(1150, 214);
            this.btnLuuNCC.Name = "btnLuuNCC";
            this.btnLuuNCC.Size = new System.Drawing.Size(237, 98);
            this.btnLuuNCC.TabIndex = 36;
            this.btnLuuNCC.Text = "Lưu";
            this.btnLuuNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuNCC.UseVisualStyleBackColor = false;
            this.btnLuuNCC.Click += new System.EventHandler(this.btnLuuNCC_Click);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNCC.Image")));
            this.btnXoaNCC.Location = new System.Drawing.Point(857, 214);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(237, 98);
            this.btnXoaNCC.TabIndex = 35;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaNCC.UseVisualStyleBackColor = false;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNCC.Image")));
            this.btnSuaNCC.Location = new System.Drawing.Point(530, 214);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(237, 98);
            this.btnSuaNCC.TabIndex = 34;
            this.btnSuaNCC.Text = "   Sửa";
            this.btnSuaNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaNCC.UseVisualStyleBackColor = false;
            this.btnSuaNCC.Click += new System.EventHandler(this.btnSuaNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNCC.Image")));
            this.btnThemNCC.Location = new System.Drawing.Point(241, 214);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(237, 98);
            this.btnThemNCC.TabIndex = 33;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // txtEmailNCC
            // 
            this.txtEmailNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailNCC.Location = new System.Drawing.Point(1045, 122);
            this.txtEmailNCC.Multiline = true;
            this.txtEmailNCC.Name = "txtEmailNCC";
            this.txtEmailNCC.Size = new System.Drawing.Size(237, 34);
            this.txtEmailNCC.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(919, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Email:";
            // 
            // dgvNhaCungCap
            // 
            this.dgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNCC,
            this.colTenNCC,
            this.colSDTNCC,
            this.colEmailNCC,
            this.colDiaChiNCC});
            this.dgvNhaCungCap.Location = new System.Drawing.Point(6, 3);
            this.dgvNhaCungCap.MultiSelect = false;
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.ReadOnly = true;
            this.dgvNhaCungCap.RowTemplate.Height = 24;
            this.dgvNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaCungCap.Size = new System.Drawing.Size(1769, 447);
            this.dgvNhaCungCap.TabIndex = 29;
            this.dgvNhaCungCap.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // colMaNCC
            // 
            this.colMaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaNCC.DataPropertyName = "MaNCC";
            this.colMaNCC.HeaderText = "Mã nhà cung cấp";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.ReadOnly = true;
            // 
            // colTenNCC
            // 
            this.colTenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNCC.DataPropertyName = "TenNCC";
            this.colTenNCC.HeaderText = "Tên nhà cung cấp";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.ReadOnly = true;
            // 
            // colSDTNCC
            // 
            this.colSDTNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSDTNCC.DataPropertyName = "SDT";
            this.colSDTNCC.HeaderText = "Số điện thoại";
            this.colSDTNCC.Name = "colSDTNCC";
            this.colSDTNCC.ReadOnly = true;
            // 
            // colEmailNCC
            // 
            this.colEmailNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmailNCC.DataPropertyName = "Email";
            this.colEmailNCC.HeaderText = "Email";
            this.colEmailNCC.Name = "colEmailNCC";
            this.colEmailNCC.ReadOnly = true;
            // 
            // colDiaChiNCC
            // 
            this.colDiaChiNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiaChiNCC.DataPropertyName = "DiaChi";
            this.colDiaChiNCC.HeaderText = "Địa chỉ";
            this.colDiaChiNCC.Name = "colDiaChiNCC";
            this.colDiaChiNCC.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvNhaCungCap);
            this.panel2.Location = new System.Drawing.Point(3, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1772, 453);
            this.panel2.TabIndex = 41;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(509, 67);
            this.txtTenNCC.Multiline = true;
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(237, 34);
            this.txtTenNCC.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên nhà cung cấp:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(509, 17);
            this.txtMaNCC.Multiline = true;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(237, 34);
            this.txtMaNCC.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(592, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 48);
            this.label1.TabIndex = 40;
            this.label1.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDiaChiNCC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSDTNCC);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnLuuNCC);
            this.panel1.Controls.Add(this.btnXoaNCC);
            this.panel1.Controls.Add(this.btnSuaNCC);
            this.panel1.Controls.Add(this.btnThemNCC);
            this.panel1.Controls.Add(this.txtEmailNCC);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTenNCC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaNCC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1772, 327);
            this.panel1.TabIndex = 39;
            // 
            // ucNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ucNhaCungCap";
            this.Size = new System.Drawing.Size(1778, 883);
            this.Load += new System.EventHandler(this.ucNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuuNCC;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnSuaNCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.TextBox txtEmailNCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvNhaCungCap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDTNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiNCC;
    }
}
