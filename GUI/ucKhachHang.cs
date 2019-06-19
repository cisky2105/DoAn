using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class ucKhachHang : UserControl
    {
        public ucKhachHang()
        {
            InitializeComponent();
        }

        List<clsKhachHang_DTO> lsKhachHang = new List<clsKhachHang_DTO>();
        clsKhachHang_BUS kh_BUS = new clsKhachHang_BUS();
        clsKhachHang_DTO khChon_DTO = null;
        int tam = 0;//0 them, 1 sua
        private void ucKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = false;
            DanhSachKhachHang();
            DisGiaoDien();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            ClearGiaoDien();
            EnGiaoDien();
            khChon_DTO = null;
            tam = 0;
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            EnGiaoDien();            
            tam = 1;
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            GetDataChiTiet();
            DialogResult dir = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (dir == DialogResult.Yes)
                {
                    if (kh_BUS.XoaKhachHang(txtSDTKH.Text))
                        MessageBox.Show("Bạn đã xóa khách hàng!", "Thông báo");
                    else
                        MessageBox.Show("Xóa khách hàng không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DanhSachKhachHang();
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (tam == 0)
                {
                    GetDataChiTiet();
                    if (kh_BUS.ThemKhachHang(khChon_DTO))
                    {
                        MessageBox.Show("Thêm khách hàng thành công!");
                        DanhSachKhachHang();
                        DisGiaoDien();
                    }
                }
                if (tam == 1)
                {
                    GetDataChiTiet();
                    if (kh_BUS.CapNhatKhachHang(khChon_DTO))
                    {
                        MessageBox.Show("Sửa khách hàng thành công!");
                        DanhSachKhachHang();
                        DisGiaoDien();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnGiaoDien()
        {
            txtSDTKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtDiaChiKH.Enabled = true;
            txtEmailKH.Enabled = true;
        }
        private void DisGiaoDien()
        {
            txtSDTKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtDiaChiKH.Enabled = false;
            txtEmailKH.Enabled = false;
        }
        private void ClearGiaoDien()
        {
            txtSDTKH.Clear();
            txtTenKH.Clear();
            txtDiaChiKH.Clear();
            txtEmailKH.Clear();
        }

        private void BindingChiTiet()
        {
            if (khChon_DTO != null)
            {
                txtSDTKH.Text = khChon_DTO.SDTKH;
                txtTenKH.Text = khChon_DTO.TenKH;
                txtDiaChiKH.Text = khChon_DTO.DiaChi;                
                if (khChon_DTO.GioiTinh == true)
                    radNam.Checked = true;
                if (khChon_DTO.GioiTinh == false)
                    radNu.Checked = true;
                txtEmailKH.Text = khChon_DTO.Email;
            }
            else
            {
                ClearGiaoDien();
            }
        }

        private void GetDataChiTiet()
        {
            if (khChon_DTO == null)
                khChon_DTO = new clsKhachHang_DTO();
            khChon_DTO.SDTKH = txtSDTKH.Text;
            khChon_DTO.TenKH = txtTenKH.Text;
            khChon_DTO.DiaChi = txtDiaChiKH.Text;
            khChon_DTO.Email = txtEmailKH.Text;
            if (radNam.Checked == true)
                khChon_DTO.GioiTinh = true;
            if (radNu.Checked == true)
                khChon_DTO.GioiTinh = false;            
        }
        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
                khChon_DTO = (clsKhachHang_DTO)dgvKhachHang.SelectedRows[0].DataBoundItem;
            else
                khChon_DTO = null;
            BindingChiTiet();
        }
         private void DanhSachKhachHang()
        {
            lsKhachHang = kh_BUS.DanhSachKhachHang();
            dgvKhachHang.DataSource = lsKhachHang;
        }
        private void dgvKhachHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvKhachHang.Columns[e.ColumnIndex].Name == "colGioiTinhKH")
            {
                e.Value = (bool)e.Value == true ? "Nam" : "Nữ";
            }
        }
    }
}
