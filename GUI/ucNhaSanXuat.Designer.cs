namespace GUI
{
    partial class ucNhaSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNhaSanXuat));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuocGiaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(3, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1772, 453);
            this.panel2.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNSX,
            this.colTenNCC,
            this.colQuocGiaNSX});
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1769, 447);
            this.dataGridView1.TabIndex = 29;
            // 
            // colMaNSX
            // 
            this.colMaNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaNSX.HeaderText = "Mã nhà sản xuất";
            this.colMaNSX.Name = "colMaNSX";
            // 
            // colTenNCC
            // 
            this.colTenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNCC.HeaderText = "Tên nhà sản xuất";
            this.colTenNCC.Name = "colTenNCC";
            // 
            // colQuocGiaNSX
            // 
            this.colQuocGiaNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuocGiaNSX.HeaderText = "Quốc gia";
            this.colQuocGiaNSX.Name = "colQuocGiaNSX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(592, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 48);
            this.label1.TabIndex = 43;
            this.label1.Text = "THÔNG TIN NHÀ SẢN XUẤT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDiaChiKH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnLuuKH);
            this.panel1.Controls.Add(this.btnXoaKH);
            this.panel1.Controls.Add(this.btnSuaKH);
            this.panel1.Controls.Add(this.btnThemKH);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSDTKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1772, 289);
            this.panel1.TabIndex = 42;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(1092, 22);
            this.txtDiaChiKH.Multiline = true;
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(237, 34);
            this.txtDiaChiKH.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(906, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "Quốc gia:";
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuuKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuKH.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuKH.Image")));
            this.btnLuuKH.Location = new System.Drawing.Point(1150, 162);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(237, 98);
            this.btnLuuKH.TabIndex = 36;
            this.btnLuuKH.Text = "Lưu";
            this.btnLuuKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuKH.UseVisualStyleBackColor = false;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKH.Image")));
            this.btnXoaKH.Location = new System.Drawing.Point(857, 162);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(237, 98);
            this.btnXoaKH.TabIndex = 35;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaKH.UseVisualStyleBackColor = false;
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKH.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKH.Image")));
            this.btnSuaKH.Location = new System.Drawing.Point(530, 162);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(237, 98);
            this.btnSuaKH.TabIndex = 34;
            this.btnSuaKH.Text = "   Sửa";
            this.btnSuaKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaKH.UseVisualStyleBackColor = false;
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKH.Image")));
            this.btnThemKH.Location = new System.Drawing.Point(241, 162);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(237, 98);
            this.btnThemKH.TabIndex = 33;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemKH.UseVisualStyleBackColor = false;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(509, 67);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(237, 34);
            this.txtTenKH.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên nhà sản xuất:";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(509, 17);
            this.txtSDTKH.Multiline = true;
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(237, 34);
            this.txtSDTKH.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã nhà sản xuất:";
            // 
            // ucNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ucNhaSanXuat";
            this.Size = new System.Drawing.Size(1778, 883);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuocGiaNSX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label2;
    }
}
