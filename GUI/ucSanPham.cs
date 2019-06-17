using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class ucSanPham : UserControl
    {
        public ucSanPham()
        {
            InitializeComponent();
            dgvQLSanPham.AutoGenerateColumns = false;
        }

        clsSanPham_BUS sp_BUS = new clsSanPham_BUS();
        List<clsSanPham_DTO> lsResul = new List<clsSanPham_DTO>();
        private void ucSanPham_Load(object sender, EventArgs e)
        {
            LoadDSSP();
        }

        private void LoadDSSP()
        {
            lsResul = sp_BUS.DanhSachSanPham();
            dgvQLSanPham.DataSource = lsResul;
        }
    }
}
