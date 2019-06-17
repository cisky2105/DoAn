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
            //panel1.Controls.Clear();
            ucSanPham banhang = new ucSanPham();
            //panel1.Controls.Add(banhang);
            
            banhang.Dock = DockStyle.Fill;
            banhang.BringToFront();
        }

        private void mnQuanLyNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
