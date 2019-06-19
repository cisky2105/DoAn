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
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
        }
        clsNhanVien_BUS nv_BUS = new clsNhanVien_BUS();
        clsNhanVien_DTO nvChon_DTO = null;
        clsQuyen_BUS quyen_BUS = new clsQuyen_BUS();

        List<clsQuyen_DTO> lsQuyen = new List<clsQuyen_DTO>();
        List<clsNhanVien_DTO> lsNhanVien = new List<clsNhanVien_DTO>();

        int tam = 0; //0 la them, 1 la sua        

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            dgvQLNhanVien.AutoGenerateColumns = false;
            DisGiaoDien();
            DanhSachNhanVien();
            DanhSachQuyen();            
        }

        private void DanhSachNhanVien()
        {
            lsNhanVien = nv_BUS.DanhSachNhanVien();
            dgvQLNhanVien.DataSource = lsNhanVien;

            lsQuyen = quyen_BUS.DanhSachQuyenNV();
            colQuyen.DataSource = lsQuyen;
            colQuyen.DisplayMember = "TenQuyen";
            colQuyen.ValueMember = "MaQuyen";
        }

        private void DanhSachQuyen()
        {
            lsQuyen = quyen_BUS.DanhSachQuyenNV();
            cboQuyen.DataSource = lsQuyen;
            cboQuyen.DisplayMember = "TenQuyen";
            cboQuyen.ValueMember = "MaQuyen";
        }

        private void dgvQLNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dgvQLNhanVien.Columns[e.ColumnIndex].Name == "colGioiTinh")
            {
                e.Value = (bool)e.Value == true ? "Nam" : "Nữ";
            }
        }

        private void BindingChiTiet()
        {
            if(nvChon_DTO!= null)
            {
                txtMaNV.Text = nvChon_DTO.CMNDNV.ToString();
                txtTenNV.Text = nvChon_DTO.HoVaTen;
                txtDiaChi.Text = nvChon_DTO.DiaChi;
                dtpNgaySinh.Value = nvChon_DTO.NgaySinh;
                if (nvChon_DTO.GioiTinh == true)
                    radNam.Checked = true;
                if(nvChon_DTO.GioiTinh == false)
                    radNu.Checked = true;
                txtSDTNV.Text = nvChon_DTO.SDT;
                txtMatKhau.Text = nvChon_DTO.MatKhau;
                cboQuyen.SelectedValue = nvChon_DTO.Quyen;
            }
            else
            {
                txtMaNV.Clear();
                txtTenNV.Clear();
                txtDiaChi.Clear();
                dtpNgaySinh.ResetText();
                txtSDTNV.Clear();
                txtMatKhau.Clear();
                cboQuyen.SelectedValue = -1;
            }
        }

        private void DisGiaoDien()
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDTNV.Enabled = false;
            dtpNgaySinh.Enabled = false;
            radNam.Enabled = false;
            radNu.Enabled = false;
            txtMatKhau.Enabled = false; ;
            cboQuyen.Enabled = false;
        }

        private void EnGiaoDien()
        {
            txtMaNV.Enabled = true;
            txtTenNV.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDTNV.Enabled = true;
            dtpNgaySinh.Enabled = true;
            radNam.Enabled = true;
            radNu.Enabled = true;
            txtMatKhau.Enabled = true;
            cboQuyen.Enabled = true;
        }

        private void ClearGiaoDien()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.ResetText();
            txtSDTNV.Clear();
            txtMatKhau.Clear();
            cboQuyen.SelectedValue = -1;
        }
        private void dgvQLNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLNhanVien.SelectedRows.Count > 0)            
                nvChon_DTO = (clsNhanVien_DTO)dgvQLNhanVien.SelectedRows[0].DataBoundItem;                       
            else
                nvChon_DTO = null;
            BindingChiTiet();
        }


        private void GetDataChiTiet()
        {
            if (nvChon_DTO == null)
                nvChon_DTO = new clsNhanVien_DTO();
            nvChon_DTO.CMNDNV = int.Parse(txtMaNV.Text);
            nvChon_DTO.HoVaTen = txtTenNV.Text;
            nvChon_DTO.DiaChi = txtDiaChi.Text;
            nvChon_DTO.MatKhau = txtMaNV.Text;
            if (radNam.Checked == true)
                nvChon_DTO.GioiTinh = true;
            if (radNu.Checked == true)
                nvChon_DTO.GioiTinh = false;
            nvChon_DTO.NgaySinh = dtpNgaySinh.Value;
            nvChon_DTO.Quyen = cboQuyen.SelectedValue.ToString();
            nvChon_DTO.SDT = txtSDTNV.Text;             
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            ClearGiaoDien();
            EnGiaoDien();
            nvChon_DTO = null;
            tam = 0;
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            GetDataChiTiet();
            DialogResult dir = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (dir == DialogResult.Yes)
                {
                    if (nv_BUS.XoaNhanVien(int.Parse(txtMaNV.Text)))
                        MessageBox.Show("Bạn đã xóa nhân viên!", "Thông báo");
                    else
                        MessageBox.Show("Xóa nhân viên không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DanhSachNhanVien();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            EnGiaoDien();
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            tam = 1;
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            try
            {                
                if (tam == 0)
                {
                    GetDataChiTiet();
                    if (nv_BUS.ThemNhanVien(nvChon_DTO))
                    {
                        MessageBox.Show("Thêm nhân viên thành công!");
                        DanhSachNhanVien();
                        DisGiaoDien();
                    }
                }
                if(tam == 1)
                {
                    GetDataChiTiet();
                    if (nv_BUS.CapNhatNhanVien(nvChon_DTO))
                    {
                        MessageBox.Show("Sửa nhân viên thành công!");
                        DanhSachNhanVien();
                        DisGiaoDien();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
