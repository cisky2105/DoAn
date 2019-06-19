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
    public partial class ucNhaCungCap : UserControl
    {
        public ucNhaCungCap()
        {
            InitializeComponent();
        }

        List<clsNhaCungCap_DTO> lsNCC = new List<clsNhaCungCap_DTO>();
        clsNhaCungCap_DTO nccChon_DTO = null;
        clsNhaCungCap_BUS ncc_BUS = new clsNhaCungCap_BUS();
        int tam = 0; //0 la them, 1 la sua       

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            ClearGiaoDien();
            EnGiaoDien();
            tam = 0;
            nccChon_DTO = null;
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            EnGiaoDien();
            tam = 1;
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            GetDataChiTiet();
            DialogResult dir = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (dir == DialogResult.Yes)
                {
                    if (ncc_BUS.XoaNhaCungCap(nccChon_DTO.MaNCC))
                        MessageBox.Show("Bạn đã xóa nhà cung cấp!", "Thông báo");
                    else
                        MessageBox.Show("Xóa nhà cung cấp không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DanhSachNhaCungCap();
        }

        private void btnLuuNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (tam == 0)
                {
                    GetDataChiTiet();
                    if (ncc_BUS.ThemNhaCungCap(nccChon_DTO))
                    {
                        MessageBox.Show("Thêm nhà cung cấp thành công!");
                        DanhSachNhaCungCap();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhà cung cấp không thành công!");
                        nccChon_DTO = null;
                    }
                }
                if (tam == 1)
                {
                    GetDataChiTiet();
                    if (ncc_BUS.CapNhatNhaCungCap(nccChon_DTO))
                    {
                        MessageBox.Show("Sửa nhà cung cấp thành công!");
                        DanhSachNhaCungCap();
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhà cung cấp không thành công!");
                        nccChon_DTO = null;
                    }
                }
                DisGiaoDien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnGiaoDien()
        {
            txtTenNCC.Enabled = true;
            txtDiaChiNCC.Enabled = true;
            txtEmailNCC.Enabled = true;
            txtSDTNCC.Enabled = true;
        }
        private void DisGiaoDien()
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtDiaChiNCC.Enabled = false;
            txtEmailNCC.Enabled = false;
            txtSDTNCC.Enabled = false;
        }

        private void ClearGiaoDien()
        {
            txtTenNCC.Clear();
            txtDiaChiNCC.Clear();
            txtEmailNCC.Clear();
            txtSDTNCC.Clear();
            txtMaNCC.Text = ncc_BUS.LayMaNCCTiepTheo();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.SelectedRows.Count > 0)
                nccChon_DTO = (clsNhaCungCap_DTO)dgvNhaCungCap.SelectedRows[0].DataBoundItem;
            else
                nccChon_DTO = null;
            BindingChiTiet();
        }

        private void DanhSachNhaCungCap()
        {
            lsNCC = ncc_BUS.DanhSachNhaCungCap();
            dgvNhaCungCap.DataSource = lsNCC;
        }

        private void BindingChiTiet()
        {
            if(nccChon_DTO != null)
            {
                txtMaNCC.Text = nccChon_DTO.MaNCC;
                txtTenNCC.Text = nccChon_DTO.TenNCC;
                txtDiaChiNCC.Text = nccChon_DTO.DiaChi;
                txtEmailNCC.Text = nccChon_DTO.Email;
                txtSDTNCC.Text = nccChon_DTO.SDT;
            }
            else
            {
                txtMaNCC.Clear();
                txtTenNCC.Clear();
                txtDiaChiNCC.Clear();
                txtEmailNCC.Clear();
                txtSDTNCC.Clear();
            }
        }
        private void GetDataChiTiet()
        {
            if(nccChon_DTO == null)
            {
                nccChon_DTO = new clsNhaCungCap_DTO();
                nccChon_DTO.MaNCC = txtMaNCC.Text;
            }
            nccChon_DTO.TenNCC = txtTenNCC.Text;
            nccChon_DTO.Email = txtEmailNCC.Text;
            nccChon_DTO.SDT = txtSDTNCC.Text;
            nccChon_DTO.DiaChi = txtDiaChiNCC.Text;
        }

        private void ucNhaCungCap_Load(object sender, EventArgs e)
        {
            DanhSachNhaCungCap();
            DisGiaoDien();
            txtMaNCC.Enabled = false;
        }
    }
}
