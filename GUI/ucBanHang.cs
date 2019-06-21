using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class ucBanHang : UserControl
    {
        public ucBanHang()
        {
            InitializeComponent();
        }

        List<clsSanPham_DTO> _lsSanPham = new List<clsSanPham_DTO>();
        List<clsKhachHang_DTO> _lsKhachHang = new List<clsKhachHang_DTO>();
        clsKhachHang_BUS _khBUS = new clsKhachHang_BUS();
        clsSanPham_BUS _sp_BUS = new clsSanPham_BUS();
        clsSanPham_DTO _spChon = null;
        List<clsChiTietHDXuat_DTO> _lsChiTiet = new List<clsChiTietHDXuat_DTO>();
        clsHoaDonXuat_DTO _hoaDon = null;
        clsHoaDonXuat_BUS _hdBUS = new clsHoaDonXuat_BUS();
        clsChiTietHDXuat_BUS _cthdBUS = new clsChiTietHDXuat_BUS();

        private void ucBanHang_Load(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.AutoGenerateColumns = false;
            imlSanPham.ColorDepth = ColorDepth.Depth32Bit;
            imlSanPham.ImageSize = new System.Drawing.Size(60, 60);
            lvwSanPham.LargeImageList = imlSanPham;
            btnTruSLM.Enabled = false;
            btnXoaSLM.Enabled = false;
            LoadDanhSachLoaiDienThoai();
            
            LoadDanhSachNhanVien();
            LoadDanhSachDienThoai();
            LoadDanhSachNhaSanXuat();
            

        }

        private void LoadDanhSachDienThoai()
        {
             _sp_BUS = new clsSanPham_BUS();
            _lsSanPham = _sp_BUS.DanhSachSanPham().FindAll(o => o.TrangThai == true); //Lay danh sach sp dang kinh doanh
            colTenSP.DataSource = _lsSanPham;
            colTenSP.DisplayMember = "TenSP";
            colTenSP.ValueMember = "MaSP";

            for (int i = 0; i < _lsSanPham.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(_lsSanPham[i].TenSP);
                lvi.SubItems.Add(_lsSanPham[i].MaSP);
                if (File.Exists(_lsSanPham[i].HinhAnh))
                {
                    byte[] byteHA = File.ReadAllBytes(_lsSanPham[i].HinhAnh);
                    MemoryStream ms = new MemoryStream(byteHA);
                    Image img = Image.FromStream(ms);
                    imlSanPham.Images.Add(img);
                    //Thêm hình ảnh vào item 
                    lvi.ImageIndex = imlSanPham.Images.Count - 1;
                }
                lvwSanPham.Items.Add(lvi);
            }
        }

        private void LoadDSTheoTen()// load theo tên chỉ cho phầm tìm kiếm sản phẩm
        {
            _sp_BUS = new clsSanPham_BUS();
            _lsSanPham = _sp_BUS.DanhSachSanPhamTheoTen(txtTimTenSP.Text);
            colTenSP.DisplayMember = "TenSP";
            colTenSP.ValueMember = "MaSP";

            for (int i = 0; i < _lsSanPham.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(_lsSanPham[i].TenSP);
                lvi.SubItems.Add(_lsSanPham[i].MaSP);
                if (File.Exists(_lsSanPham[i].HinhAnh))
                {
                    byte[] byteHA = File.ReadAllBytes(_lsSanPham[i].HinhAnh);
                    MemoryStream ms = new MemoryStream(byteHA);
                    Image img = Image.FromStream(ms);
                    imlSanPham.Images.Add(img);
                    //Thêm hình ảnh vào item 
                    lvi.ImageIndex = imlSanPham.Images.Count - 1;
                }
                lvwSanPham.Items.Add(lvi);
            }
        }

        private void LoadDanhSachLoaiDienThoai()
        {
            clsLoaiDT_BUS _loaiBUS = new clsLoaiDT_BUS();
            cboLoaiDT.DataSource = _loaiBUS.DanhSachLoaiDT();
            cboLoaiDT.DisplayMember = "TenLoaiDT";
            cboLoaiDT.ValueMember = "MaLoaiDT";
        }
        //private int LoadDanhSachSDTKhachHang()
        //{
        //    _khBUS = new clsKhachHang_BUS();
        //    return _khBUS.DanhSachKhachHangTheoSDT(txtSDTKH.Text);
        //}

        private void LoadDanhSachNhaSanXuat()
        {
            clsNhaSanXuat_BUS _nsxBUS = new clsNhaSanXuat_BUS();
            cboNSX.DataSource = _nsxBUS.DanhSachNhaSanXuat();
            cboNSX.DisplayMember = "TenNSX";
            cboNSX.ValueMember = "MaNSX";
        }

        private void LoadDanhSachNhanVien()
        {
            clsNhanVien_BUS _nsxBUS = new clsNhanVien_BUS();
            cboNhanVien.DataSource = _nsxBUS.DanhSachNhanVien();
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.ValueMember = "CMNDNV";
        }


        private void lvwSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lviChon = lvwSanPham.SelectedItems[0];
                _spChon = _lsSanPham.Find(o => o.MaSP == lviChon.SubItems[1].Text);
            }
            else
            {
                _spChon = null;
            }
            BindingChiTiet();
        }

        private void BindingChiTiet()
        {
            if (_spChon != null)
            {
                txtMaSP.Text = _spChon.MaSP;
                txtTenSP.Text = _spChon.TenSP;
                txtSLTonKho.Text = _spChon.SLTonKho.ToString();
                txtGiaBan.Text = _spChon.GiaBan.ToString();
                txtGiaKM.Text = _spChon.GiaKM.ToString();
                cboNSX.SelectedValue = _spChon.MaNSX;
                cboLoaiDT.SelectedValue = _spChon.MaLoaiDT;
                if (File.Exists(_spChon.HinhAnh))
                {
                    byte[] byteHA = File.ReadAllBytes(_spChon.HinhAnh);
                    MemoryStream ms = new MemoryStream(byteHA);
                    pboHinhAnh.Image = Image.FromStream(ms);
                }
                else
                {
                    pboHinhAnh.Image = null;
                }
            }
        }

        private void btnTimSanPham_Click(object sender, EventArgs e)
        {
            _spChon = _lsSanPham.Find(o => o.MaSP == txtMaSP.Text);
            if (_spChon == null)
            {
                MessageBox.Show("Không tồn tại SP");
            }
            BindingChiTiet();
        }

        private void btnResetPhieu_Click(object sender, EventArgs e)
        {
            _lsChiTiet.Clear();
            _hoaDon = null;
            txtTongTien.Text = "0";
            dgvChiTietHoaDon.DataSource = null;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (_hoaDon != null)
            {
                frmXemBaoCao frm = new frmXemBaoCao();
                frm.InHoaDon(_hoaDon, _lsChiTiet);
                frm.ShowDialog();
            }
        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            if (_lsChiTiet.Count > 0)
            {
                _lsKhachHang = _khBUS.DanhSachKhachHangTheoSDT(txtSDTKH.Text);
                _hoaDon = new clsHoaDonXuat_DTO();
                if(_lsKhachHang.Count > 0)
                {
                    
                }
                else
                {
                    try
                    {
                        clsKhachHang_DTO khdto = new clsKhachHang_DTO();
                        khdto.SDTKH = txtSDTKH.Text;
                        khdto.TenKH = txtSDTKH.Text;
                        khdto.GioiTinh = false;
                        khdto.DiaChi = " ";
                        khdto.Email = " ";
                        
                        _khBUS.ThemKhachHang(khdto);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //neu khong them
                    
                    
                }
                _hoaDon.MaHDXuat = _hdBUS.LayMaTiepTheo();
                _hoaDon.SDTKH = txtSDTKH.Text;
                _hoaDon.CMNDNV = 123456;
                //_hoaDon.CMNDNV = ((Form1)this.MdiParent).NhanVienDangNhap.CMNDNV;
                _hoaDon.TongTien = _lsChiTiet.Sum(o => o.ThanhTien);
                _hoaDon.NgayXuat = DateTime.Now;
                try
                {
                    if (_hdBUS.LuuHoaDon(_hoaDon))
                    {
                        foreach (clsChiTietHDXuat_DTO _cthd in _lsChiTiet)
                        {
                            _cthd.MaHDXuat = _hoaDon.MaHDXuat;

                            _cthdBUS.LuuChiTietHoaDon(_cthd);
                        }
                        MessageBox.Show("Lưu Hóa Đơn Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Tạo Hóa Đơn Không Thành Công");
                    }                                                                                  
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
            else
            {
                MessageBox.Show("Không Có sản Phẩm Nào Để Tạo Hóa Đơn");
            }
        }

        private void btnTruSLM_Click(object sender, EventArgs e)
        {
            if (_spChon != null)
            {
                //Tìm xem sp đã được thêm chưa
                clsChiTietHDXuat_DTO _cthd = (clsChiTietHDXuat_DTO)dgvChiTietHoaDon.CurrentRow.DataBoundItem;
                if (_cthd != null) //Đã tồn tại
                {
                    _cthd.SoLuong -= (int)nudSoLuongMua.Value;
                    if (_cthd.SoLuong == 0)
                    {
                        MessageBox.Show("Số Lượng Sản Phẩm Đã Được Xóa Hết!!! :((");
                        _cthd.SoLuong = 0;
                        _lsChiTiet.Remove(_cthd);
                        btnTruSLM.Enabled = false;
                        btnXoaSLM.Enabled = false;
                    }
                }
                txtTongTien.Text = _lsChiTiet.Sum(o => o.ThanhTien).ToString();
                dgvChiTietHoaDon.DataSource = null;
                dgvChiTietHoaDon.DataSource = _lsChiTiet;
            }

        }

        private void btnCongSLM_Click(object sender, EventArgs e)
        {
            btnTruSLM.Enabled = true;
            btnXoaSLM.Enabled = true;
            if (_spChon != null)
            {
                //Tìm xem sp đã được thêm chưa
                clsChiTietHDXuat_DTO _cthd = _lsChiTiet.Find(o => o.MaSP == _spChon.MaSP);
                if (_cthd != null) //Đã tồn tại
                {
                    _cthd.SoLuong += (int)nudSoLuongMua.Value;
                    nudSoLuongMua.Value = 1;
                }
                else
                {
                    _cthd = new clsChiTietHDXuat_DTO();
                    _cthd.MaSP = _spChon.MaSP;
                    _cthd.SoLuong = (int)nudSoLuongMua.Value;
                    nudSoLuongMua.Value = 1;
                    _cthd.DonGia = (int)_spChon.GiaBan;
                    _cthd.GiaKM = (int)_spChon.GiaKM;
                    _lsChiTiet.Add(_cthd);
                }
                txtTongTien.Text = _lsChiTiet.Sum(o => o.ThanhTien).ToString();
                dgvChiTietHoaDon.DataSource = null;
                dgvChiTietHoaDon.DataSource = _lsChiTiet;
            }
        }

        private void btnXoaSLM_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHoaDon.SelectedRows.Count > 0)
            {
                clsChiTietHDXuat_DTO _ctchon = (clsChiTietHDXuat_DTO)dgvChiTietHoaDon.CurrentRow.DataBoundItem;
                DialogResult dlr = MessageBox.Show("Bạn Có Muốn Tất Cả Xóa Sản Phẩm Khỏi Danh Sách ???", "Hóa Đơn", MessageBoxButtons.YesNo);

                if (dlr == DialogResult.Yes)
                {
                    _lsChiTiet.Remove(_ctchon);
                    txtTongTien.Text = _lsChiTiet.Sum(o => o.ThanhTien).ToString();
                    dgvChiTietHoaDon.DataSource = null;
                    dgvChiTietHoaDon.DataSource = _lsChiTiet;
                }
            }
        }

        private void txtTimTenSP_TextChanged(object sender, EventArgs e)
        {
            lvwSanPham.Clear();
            LoadDSTheoTen();
        }
    }
}
