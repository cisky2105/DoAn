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
using System.IO;

namespace GUI
{
    public partial class ucSanPham : UserControl
    {
        public ucSanPham()
        {
            InitializeComponent();
            dgvQLSanPham.AutoGenerateColumns = false;           
            this.dgvQLSanPham.DefaultCellStyle.Font = new Font("Arial", 12);
        }

        clsSanPham_BUS sp_BUS = new clsSanPham_BUS();
        clsNhaSanXuat_BUS nsx_BUS = new clsNhaSanXuat_BUS();
        clsLoaiDT_BUS loaidt_BUS = new clsLoaiDT_BUS();
        clsSanPham_DTO spChon_DTO = null;
        int tam = 0; // 0 la them, 1 la sua
        string strPath = @"images\";

        List<clsSanPham_DTO> lsSanPham = new List<clsSanPham_DTO>();
        List<clsNhaSanXuat_DTO> lsNhaSanXuat = new List<clsNhaSanXuat_DTO>();
        List<clsLoaiDT_DTO> lsLoaiDT = new List<clsLoaiDT_DTO>();
        private void ucSanPham_Load(object sender, EventArgs e)
        {
            
            txtMaSP.Enabled = false;
            DisGiaoDien();
            LoadDSSP();
            LoadDSNSX();
            LoadLoaiDT();
        }

        private void LoadDSSP()
        {
            lsSanPham = sp_BUS.DanhSachSanPham();
            dgvQLSanPham.DataSource = lsSanPham;

            lsNhaSanXuat = nsx_BUS.DanhSachNhaSanXuat();
            lsLoaiDT = loaidt_BUS.DanhSachLoaiDT();

            colNhaSanXuat.DataSource = lsNhaSanXuat;
            colNhaSanXuat.DisplayMember = "TenNSX";
            colNhaSanXuat.ValueMember = "MaNSX";

            colLoaiSanPham.DataSource = lsLoaiDT;
            colLoaiSanPham.DisplayMember = "TenLoaiDT";
            colLoaiSanPham.ValueMember = "MaLoaiDT";
        }


        private void LoadDSNSX()
        {
            lsNhaSanXuat = nsx_BUS.DanhSachNhaSanXuat();
            cboNhaSanXuat.DataSource = lsNhaSanXuat;
            cboNhaSanXuat.DisplayMember = "TenNSX";
            cboNhaSanXuat.ValueMember = "MaNSX";
        }

        private void LoadLoaiDT()
        {
            lsLoaiDT = loaidt_BUS.DanhSachLoaiDT();
            cboLoaiDT.DataSource = lsLoaiDT;
            cboLoaiDT.DisplayMember = "TenLoaiDT";
            cboLoaiDT.ValueMember = "MaLoaiDT";
        }

        private void BindingChiTiet()
        {
            if(spChon_DTO != null)
            {
                txtMaSP.Text = spChon_DTO.MaSP;
                txtTenSP.Text = spChon_DTO.TenSP;
                txtGiaSP.Text = spChon_DTO.GiaBan.ToString();
                txtKhuyenMai.Text = spChon_DTO.GiaKM.ToString();
                cboNhaSanXuat.SelectedValue = spChon_DTO.MaNSX;
                cboLoaiDT.SelectedValue = spChon_DTO.MaLoaiDT;
                if (File.Exists(strPath + spChon_DTO.HinhAnh))
                {
                    byte[] byteHA = File.ReadAllBytes(strPath + spChon_DTO.HinhAnh);
                    MemoryStream ms = new MemoryStream(byteHA);
                    picSanPham.Image = Image.FromStream(ms);
                }
                else
                {
                    picSanPham.Image = null;
                }
            }
            else
            {
                txtMaSP.Clear();
                txtTenSP.Clear();
                txtGiaSP.Clear();
                txtKhuyenMai.Clear();
                cboLoaiDT.SelectedValue = -1;
                cboNhaSanXuat.SelectedValue = -1;
                picSanPham.Image = null;
            }
        }
    


        private void dgvQLSanPham_SelectionChanged(object sender, EventArgs e)
        {
            DisGiaoDien();
            if (dgvQLSanPham.SelectedRows.Count > 0)
                spChon_DTO = (clsSanPham_DTO)dgvQLSanPham.SelectedRows[0].DataBoundItem;
            else
                spChon_DTO = null;
            BindingChiTiet();
        }

        private void GetDataChiTiet()
        {
            if(spChon_DTO == null)
            {
                spChon_DTO = new clsSanPham_DTO();
                spChon_DTO.MaSP = txtMaSP.Text;
            }

            spChon_DTO.TenSP = txtTenSP.Text;
            spChon_DTO.GiaBan = int.Parse(txtGiaSP.Text.ToString());
            if(txtKhuyenMai.Text == "")            
                spChon_DTO.GiaKM = 0;
            else
                spChon_DTO.GiaKM = int.Parse(txtKhuyenMai.Text.ToString());
            spChon_DTO.MaLoaiDT = cboLoaiDT.SelectedValue.ToString();
            spChon_DTO.MaNSX = cboNhaSanXuat.SelectedValue.ToString();
            spChon_DTO.HinhAnh = spChon_DTO.MaSP + ".jpg";
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            ClearGiaoDien();
            picSanPham.Image = null;
            EnGiaoDien();
            tam = 0;
            spChon_DTO = null;
        }
        private void ClearGiaoDien()
        {
            txtTenSP.Clear();
            txtGiaSP.Clear();
            txtKhuyenMai.Clear();
            txtMaSP.Text = sp_BUS.LayMaSPTiepTheo();
        }

        private  void DisGiaoDien()
        {
            txtTenSP.Enabled = false;
            txtGiaSP.Enabled = false;
            txtKhuyenMai.Enabled = false;
            cboLoaiDT.Enabled = false;
            cboNhaSanXuat.Enabled = false;
            picSanPham.Enabled = false;
        }

        private void EnGiaoDien()
        {
            txtTenSP.Enabled = true;
            txtGiaSP.Enabled = true;
            txtKhuyenMai.Enabled = true;
            cboLoaiDT.Enabled = true;
            cboNhaSanXuat.Enabled = true;
            picSanPham.Enabled = true;
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            EnGiaoDien();               
            tam = 1;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            GetDataChiTiet();
            DialogResult dir = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (dir == DialogResult.Yes)
                {
                    if (sp_BUS.XoaSanPham(spChon_DTO.MaSP))                                           
                        MessageBox.Show("Bạn đã xóa sản phẩm!", "Thông báo");                    
                        
                    else
                        MessageBox.Show("Xóa sản phẩm không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadDSSP();
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (tam == 0)
                {
                    GetDataChiTiet();
                    if (sp_BUS.ThemSanPham(spChon_DTO))
                    {
                        if (picSanPham.Image != null)
                        {
                            picSanPham.Image.Save(spChon_DTO.HinhAnh);
                        }
                        MessageBox.Show("Thêm sản phẩm thành công!");
                        LoadDSSP();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công!");
                        spChon_DTO = null;
                    }
                }
                if (tam == 1)
                {
                    GetDataChiTiet();
                    if (sp_BUS.CapNhatSanPham(spChon_DTO))
                    {
                        if (picSanPham.Image != null)
                        {
                            picSanPham.Image.Save(spChon_DTO.HinhAnh);
                        }
                        MessageBox.Show("Sửa sản phẩm thành công!");
                        LoadDSSP();
                    }
                    else
                    {
                        MessageBox.Show("Sửa sản phẩm không thành công!");
                        spChon_DTO = null;
                    }
                }
                DisGiaoDien();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void picSanPham_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Hình ảnh (jpg) | *.jpg";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                picSanPham.Image = null;
            }
            else
            {
                byte[] byteHA = File.ReadAllBytes(ofd.FileName);
                MemoryStream ms = new MemoryStream(byteHA);
                picSanPham.Image = Image.FromStream(ms);
            }
        }

        private void txtTimKiemSP_TextChanged(object sender, EventArgs e)
        {
            lsSanPham = sp_BUS.DanhSachSanPhamTheoTen(txtTimKiemSP.Text);
            dgvQLSanPham.DataSource = lsSanPham;
        }
    }
}
