using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnQuanLySanPham_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ucSanPham banhang = new ucSanPham();
            panel1.Controls.Add(banhang);
            
            banhang.Dock = DockStyle.Fill;
            banhang.BringToFront();
        }

        private void mnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ucNhanVien banhang = new ucNhanVien();
            panel1.Controls.Add(banhang);

            banhang.Dock = DockStyle.Fill;
            banhang.BringToFront();
        }

        private void mnQuanLyNCC_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ucNhaCungCap banhang = new ucNhaCungCap();
            panel1.Controls.Add(banhang);

            banhang.Dock = DockStyle.Fill;
            banhang.BringToFront();
        }

        private void mnQuanLyNSX_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ucNhaSanXuat banhang = new ucNhaSanXuat();
            panel1.Controls.Add(banhang);

            banhang.Dock = DockStyle.Fill;
            banhang.BringToFront();
        }

        private void mnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ucKhachHang banhang = new ucKhachHang();
            panel1.Controls.Add(banhang);

            banhang.Dock = DockStyle.Fill;
            banhang.BringToFront();
        }

        private void mnNhapHang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ucNhapHang banhang = new ucNhapHang();
            panel1.Controls.Add(banhang);

            banhang.Dock = DockStyle.Fill;
            banhang.BringToFront();
        }

        private void mnBanHang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ucBanHang banhang = new ucBanHang();
            panel1.Controls.Add(banhang);

            banhang.Dock = DockStyle.Fill;
            banhang.BringToFront();
        }
    }
}
