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
    public partial class ucNhaSanXuat : UserControl
    {
        public ucNhaSanXuat()
        {
            InitializeComponent();
        }
        List<clsNhaSanXuat_DTO> lsReult = new List<clsNhaSanXuat_DTO>();
        clsNhaSanXuat_DTO nsxChon_DTO = null;
        clsNhaSanXuat_BUS nsx_BUS = new clsNhaSanXuat_BUS();
        int tam = 0; //0 them, 1 xoa

        private void DanhSachNhaSanXuat()
        {
            lsReult = nsx_BUS.DanhSachNhaSanXuat();
            dgvNhaSanXuat.DataSource = lsReult;
        }

        private void BindingChiTiet()
        {
            if (nsxChon_DTO != null)
            {
                txtMaNSX.Text = nsxChon_DTO.MaNSX;
                txtTenNSX.Text = nsxChon_DTO.TenNSX;
            }
            else
            {
                txtMaNSX.Clear();
                txtTenNSX.Clear();
                
            }
        }

        private void GetDataChiTiet()
        {
            if(nsxChon_DTO == null)
            {
                nsxChon_DTO = new clsNhaSanXuat_DTO();
                nsxChon_DTO.MaNSX = txtTenNSX.Text;
            }
            nsxChon_DTO.TenNSX = txtTenNSX.Text;
        }
        private void dgvNhaSanXuat_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhaSanXuat.SelectedRows.Count > 0)
                nsxChon_DTO = (clsNhaSanXuat_DTO)dgvNhaSanXuat.SelectedRows[0].DataBoundItem;
            else
                nsxChon_DTO = null;
            BindingChiTiet();
        }

        private void btnThemNSX_Click(object sender, EventArgs e)
        {
            txtMaNSX.Text = nsx_BUS.LayMaTiepTheo();
            txtTenNSX.Enabled = true;
            txtTenNSX.Clear();
            tam = 0;
        }

        private void btnSuaNSX_Click(object sender, EventArgs e)
        {
            txtTenNSX.Enabled = true;
            tam = 1;
        }

        private void btnXoaNSX_Click(object sender, EventArgs e)
        {
            GetDataChiTiet();
            DialogResult dir = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà sản xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (dir == DialogResult.Yes)
                {
                    if (nsx_BUS.XoaNhaSanXuat(nsxChon_DTO.MaNSX))
                        MessageBox.Show("Bạn đã xóa nhà sản xuất!", "Thông báo");
                    else
                        MessageBox.Show("Xóa nhà sản xuất không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DanhSachNhaSanXuat();
        }

        private void btnLuuNSX_Click(object sender, EventArgs e)
        {
            try
            {
                if (tam == 0)
                {
                    GetDataChiTiet();
                    if (nsx_BUS.ThemNhaSanXuat(nsxChon_DTO))
                    {
                        MessageBox.Show("Thêm nhà sản xuất thành công!");
                        DanhSachNhaSanXuat();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhà sản xuất không thành công!");
                        nsxChon_DTO = null;
                    }
                }
                if (tam == 1)
                {
                    GetDataChiTiet();
                    if (nsx_BUS.CapNhatNhaSanXuat(nsxChon_DTO))
                    {
                        MessageBox.Show("Sửa nhà sản xuất thành công!");
                        DanhSachNhaSanXuat();
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhà sản xuất không thành công!");
                        nsxChon_DTO = null;
                    }
                }
                txtTenNSX.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ucNhaSanXuat_Load(object sender, EventArgs e)
        {
            dgvNhaSanXuat.AutoGenerateColumns = false;
            txtTenNSX.Enabled = false;
            txtMaNSX.Enabled = false;
            DanhSachNhaSanXuat();
        }
    }
}
