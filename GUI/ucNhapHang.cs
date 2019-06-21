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
    public partial class ucNhapHang : UserControl
    {
        public ucNhapHang()
        {
            InitializeComponent();
            this.dgvSanPhamTonKho.DefaultCellStyle.Font = new Font("Arial", 12);
        }
        List<clsSanPham_DTO> lsSanPham = new List<clsSanPham_DTO>();
        List<clsNhaCungCap_DTO> lsNhaCungCap = new List<clsNhaCungCap_DTO>();
        List<clsChiTietHDNhap_DTO> lsChiTiet = new List<clsChiTietHDNhap_DTO>();
        List<clsChiTietHDNhap_DTO> lsRong = new List<clsChiTietHDNhap_DTO>();
        List<clsNhanVien_DTO> lsNhanVien = new List<clsNhanVien_DTO>();

        clsSanPham_DTO spChon_DTO = null;
        clsHoaDonNhap_DTO hdn_DTO = null;

        clsSanPham_BUS sp_BUS = new clsSanPham_BUS();
        clsNhaCungCap_BUS ncc_BUS = new clsNhaCungCap_BUS();
        clsNhanVien_BUS nv_BUS = new clsNhanVien_BUS();
        clsHoaDonNhap_BUS hdn_BUS = new clsHoaDonNhap_BUS();
        clsChiTietHDNhap_BUS cthd_BUS = new clsChiTietHDNhap_BUS();

        private void LoadDanhSachSP()
        {
            lsSanPham = sp_BUS.DanhSachSanPham();
            dgvSanPhamTonKho.DataSource = lsSanPham;
        }

        private void LoadNhaCungCap()
        {
            lsNhaCungCap = ncc_BUS.DanhSachNhaCungCap();
            cboNhaCungCap.DataSource = lsNhaCungCap;
            cboNhaCungCap.DisplayMember = "TenNCC";
            cboNhaCungCap.ValueMember = "MaNCC";
        }

        private void LoadDanhSachNhanVien()
        {
            lsNhanVien = nv_BUS.DanhSachNhanVien();
            cboNhanVien.DataSource = lsNhanVien;
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.ValueMember = "CMNDNV";
        }

        private void dgvSanPhamTonKho_SelectionChanged(object sender, EventArgs e)
        {
            
        }


        private void dgvSanPhamTonKho_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSanPhamTonKho.Columns[e.ColumnIndex].Name == "colTrangThai")
            {
                e.Value = (bool)e.Value == true ? "Có" : "Không";
            }
        }

        private void ucNhapHang_Load(object sender, EventArgs e)
        {
            dtpNhayNhap.Value = DateTime.Now;
            dgvSanPhamTonKho.AutoGenerateColumns = false;
            LoadDanhSachSP();
            LoadDanhSachNhanVien();
            LoadNhaCungCap();
            txtMaHDNhap.Text = hdn_BUS.LayMaTiepTheo();
            txtGiaSP.Enabled = false;
            txtMaHDNhap.Enabled = false;
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtThanhTien.Enabled = false;
            txtGiaSP.Enabled = false;
            cboNhaCungCap.Enabled = false;
            dtpNhayNhap.Enabled = false;
            cboNhanVien.Enabled = false;
            btnNhapHang.Enabled = false;
            btnLuuHoaDon.Enabled = false;
        }
         private void BindingChiTiet()
        {
            if(spChon_DTO != null)
            {
                txtMaSP.Text = spChon_DTO.MaSP;
                txtTenSP.Text = spChon_DTO.TenSP;
                txtGiaSP.Text = spChon_DTO.GiaBan.ToString();
            }
        }

        private void dgvSanPhamTonKho_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPhamTonKho.SelectedRows.Count > 0)
            {
                spChon_DTO = (clsSanPham_DTO)dgvSanPhamTonKho.SelectedRows[0].DataBoundItem;
            }
            else
                spChon_DTO = null;
            BindingChiTiet();
            txtGiaSP.Enabled = true;
            txtSoLuongNhap.Enabled = true;
            btnNhapHang.Enabled = true;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            txtMaHDNhap.Text = hdn_BUS.LayMaTiepTheo();
            if(spChon_DTO != null)
            {
                clsChiTietHDNhap_DTO ct = lsChiTiet.Find(o => o.MaSP == spChon_DTO.MaSP);
                if (ct != null)
                {
                    ct.SoLuong += int.Parse(txtSoLuongNhap.Text);
                }
                else
                {
                    //ct.MaHDNhap = txtMaHDNhap.Text;
                    ct = new clsChiTietHDNhap_DTO();
                    ct.MaSP = spChon_DTO.MaSP;
                    ct.MaHDNhap = txtMaHDNhap.Text;
                    ct.SoLuong = int.Parse(txtSoLuongNhap.Text);
                    ct.DonGia = spChon_DTO.GiaBan;
                    lsChiTiet.Add(ct);
                }
                txtThanhTien.Text = lsChiTiet.Sum(o => o.ThanhTien).ToString();
                dgvChiTietHoaDon.DataSource = lsRong;
                dgvChiTietHoaDon.DataSource = lsChiTiet;
                btnLuuHoaDon.Enabled = true;
            }
        }        

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsChiTiet.Count > 0)
                {
                    hdn_DTO = new clsHoaDonNhap_DTO();
                    hdn_DTO.MaHDNhap = txtMaHDNhap.Text;
                    hdn_DTO.TongTien = lsChiTiet.Sum(o => o.ThanhTien);
                    hdn_DTO.MaNCC = cboNhaCungCap.SelectedValue.ToString();
                    hdn_DTO.CMNDNV = int.Parse(cboNhanVien.SelectedValue.ToString());
                    hdn_DTO.NgayNhap = DateTime.Now;
                    if (hdn_BUS.LuuHoaDonNhap(hdn_DTO))
                    {
                        foreach(clsChiTietHDNhap_DTO ct in lsChiTiet)
                        {
                            if (cthd_BUS.LuuChiTietHoaDon(ct)) continue;
                            else return;
                        }
                        MessageBox.Show("Luu thanh cong");
                        LoadDanhSachSP();
                        lsChiTiet = null;
                        spChon_DTO = null;
                        txtMaHDNhap.Text = hdn_BUS.LayMaTiepTheo();
                        dgvChiTietHoaDon.DataSource = lsRong;
                        btnLuuHoaDon.Enabled = false;
                        txtThanhTien.Clear();
                        txtGiaSP.Clear();
                        txtMaHDNhap.Clear();
                        txtMaSP.Clear();
                        txtTenSP.Clear();
                        txtGiaSP.Clear();
                        btnNhapHang.Enabled = false;
                        txtGiaSP.Enabled = false;
                        txtSoLuongNhap.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            lsSanPham = sp_BUS.DanhSachSanPhamTheoTen(txtTimKiem.Text);
            dgvSanPhamTonKho.DataSource = lsSanPham;
        }
    }
}
