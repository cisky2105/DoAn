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
            this.dgvNhaSanXuat = new System.Windows.Forms.DataGridView();
            this.colMaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuuNSX = new System.Windows.Forms.Button();
            this.btnXoaNSX = new System.Windows.Forms.Button();
            this.btnSuaNSX = new System.Windows.Forms.Button();
            this.btnThemNSX = new System.Windows.Forms.Button();
            this.txtTenNSX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNSX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaSanXuat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvNhaSanXuat);
            this.panel2.Location = new System.Drawing.Point(3, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1772, 453);
            this.panel2.TabIndex = 44;
            // 
            // dgvNhaSanXuat
            // 
            this.dgvNhaSanXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaSanXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNSX,
            this.colTenNCC});
            this.dgvNhaSanXuat.Location = new System.Drawing.Point(6, 3);
            this.dgvNhaSanXuat.MultiSelect = false;
            this.dgvNhaSanXuat.Name = "dgvNhaSanXuat";
            this.dgvNhaSanXuat.ReadOnly = true;
            this.dgvNhaSanXuat.RowTemplate.Height = 24;
            this.dgvNhaSanXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaSanXuat.Size = new System.Drawing.Size(1769, 447);
            this.dgvNhaSanXuat.TabIndex = 29;
            this.dgvNhaSanXuat.SelectionChanged += new System.EventHandler(this.dgvNhaSanXuat_SelectionChanged);
            // 
            // colMaNSX
            // 
            this.colMaNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaNSX.DataPropertyName = "MaNSX";
            this.colMaNSX.HeaderText = "Mã nhà sản xuất";
            this.colMaNSX.Name = "colMaNSX";
            // 
            // colTenNCC
            // 
            this.colTenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNCC.DataPropertyName = "TenNSX";
            this.colTenNCC.HeaderText = "Tên nhà sản xuất";
            this.colTenNCC.Name = "colTenNCC";
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
            this.panel1.Controls.Add(this.btnLuuNSX);
            this.panel1.Controls.Add(this.btnXoaNSX);
            this.panel1.Controls.Add(this.btnSuaNSX);
            this.panel1.Controls.Add(this.btnThemNSX);
            this.panel1.Controls.Add(this.txtTenNSX);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaNSX);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1772, 289);
            this.panel1.TabIndex = 42;
            // 
            // btnLuuNSX
            // 
            this.btnLuuNSX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuuNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNSX.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuNSX.Image")));
            this.btnLuuNSX.Location = new System.Drawing.Point(1150, 162);
            this.btnLuuNSX.Name = "btnLuuNSX";
            this.btnLuuNSX.Size = new System.Drawing.Size(237, 98);
            this.btnLuuNSX.TabIndex = 36;
            this.btnLuuNSX.Text = "Lưu";
            this.btnLuuNSX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuNSX.UseVisualStyleBackColor = false;
            this.btnLuuNSX.Click += new System.EventHandler(this.btnLuuNSX_Click);
            // 
            // btnXoaNSX
            // 
            this.btnXoaNSX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNSX.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNSX.Image")));
            this.btnXoaNSX.Location = new System.Drawing.Point(857, 162);
            this.btnXoaNSX.Name = "btnXoaNSX";
            this.btnXoaNSX.Size = new System.Drawing.Size(237, 98);
            this.btnXoaNSX.TabIndex = 35;
            this.btnXoaNSX.Text = "Xóa";
            this.btnXoaNSX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaNSX.UseVisualStyleBackColor = false;
            this.btnXoaNSX.Click += new System.EventHandler(this.btnXoaNSX_Click);
            // 
            // btnSuaNSX
            // 
            this.btnSuaNSX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNSX.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNSX.Image")));
            this.btnSuaNSX.Location = new System.Drawing.Point(530, 162);
            this.btnSuaNSX.Name = "btnSuaNSX";
            this.btnSuaNSX.Size = new System.Drawing.Size(237, 98);
            this.btnSuaNSX.TabIndex = 34;
            this.btnSuaNSX.Text = "   Sửa";
            this.btnSuaNSX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaNSX.UseVisualStyleBackColor = false;
            this.btnSuaNSX.Click += new System.EventHandler(this.btnSuaNSX_Click);
            // 
            // btnThemNSX
            // 
            this.btnThemNSX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNSX.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNSX.Image")));
            this.btnThemNSX.Location = new System.Drawing.Point(241, 162);
            this.btnThemNSX.Name = "btnThemNSX";
            this.btnThemNSX.Size = new System.Drawing.Size(237, 98);
            this.btnThemNSX.TabIndex = 33;
            this.btnThemNSX.Text = "Thêm";
            this.btnThemNSX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNSX.UseVisualStyleBackColor = false;
            this.btnThemNSX.Click += new System.EventHandler(this.btnThemNSX_Click);
            // 
            // txtTenNSX
            // 
            this.txtTenNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNSX.Location = new System.Drawing.Point(1062, 17);
            this.txtTenNSX.Multiline = true;
            this.txtTenNSX.Name = "txtTenNSX";
            this.txtTenNSX.Size = new System.Drawing.Size(237, 34);
            this.txtTenNSX.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(820, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên nhà sản xuất:";
            // 
            // txtMaNSX
            // 
            this.txtMaNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNSX.Location = new System.Drawing.Point(509, 17);
            this.txtMaNSX.Multiline = true;
            this.txtMaNSX.Name = "txtMaNSX";
            this.txtMaNSX.Size = new System.Drawing.Size(237, 34);
            this.txtMaNSX.TabIndex = 14;
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
            this.Load += new System.EventHandler(this.ucNhaSanXuat_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaSanXuat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvNhaSanXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLuuNSX;
        private System.Windows.Forms.Button btnXoaNSX;
        private System.Windows.Forms.Button btnSuaNSX;
        private System.Windows.Forms.Button btnThemNSX;
        private System.Windows.Forms.TextBox txtTenNSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNSX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC;
    }
}
