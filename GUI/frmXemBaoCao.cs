using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Microsoft.Reporting.WinForms;



namespace GUI
{
    public partial class frmXemBaoCao : Form
    {
        List<clsSanPham_DTO> _lsSanPham = new List<clsSanPham_DTO>();
        public frmXemBaoCao()
        {
            InitializeComponent();
        }

        private void frmXemBaoCao_Load(object sender, EventArgs e)
        {
            this.rpvXemBaoCao.RefreshReport();
        }

        public void InHoaDon(clsHoaDonXuat_DTO _hoaDon, List<clsChiTietHDXuat_DTO> _lsChiTiet)
        {
            _lsSanPham = (new clsSanPham_BUS()).DanhSachSanPham();
            //Chọn Report hiển thị
            rpvXemBaoCao.LocalReport.ReportEmbeddedResource = "GUI.rptHoaDon.rdlc";

            rpvXemBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LayTenSanPhamCTHD);
            //Đổ dữ liệu 
            rpvXemBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsChiTiet", _lsChiTiet));

            //Set Parameter
            rpvXemBaoCao.LocalReport.SetParameters(new ReportParameter("paMaHDXuat", _hoaDon.MaHDXuat));
            rpvXemBaoCao.LocalReport.SetParameters(new ReportParameter("paCMNDNV", _hoaDon.CMNDNV.ToString()));
            rpvXemBaoCao.LocalReport.SetParameters(new ReportParameter("paSDTKH", _hoaDon.SDTKH));
            rpvXemBaoCao.LocalReport.SetParameters(new ReportParameter("paNgayXuat", _hoaDon.NgayXuat.ToString("dd/MM/yyyy")));

            //Hiển thị
            this.rpvXemBaoCao.RefreshReport();
        }

        private void LayTenSanPhamCTHD(object sender, SubreportProcessingEventArgs e)
        {
            //Lấy mã sản phẩm sữa của dòng chi tiết
            string masp = e.Parameters["paSanPham"].Values[0].ToString();
            List<clsSanPham_DTO> _lsTimSanPham = _lsSanPham.FindAll(o => o.MaSP == masp);
            //Đổ dữ liệu vào subreport
            e.DataSources.Add(new ReportDataSource("dsSanPham", _lsTimSanPham));
        }

        //public void TatCaSanPham()
        //{
        //    List<clsSanPham_DTO> lsToy = (new clsSanPham_BUS()).DanhSachSanPham();

        //    rpvXemBaoCao.LocalReport.ReportEmbeddedResource = "GUI.rptTatCaSPToy.rdlc";

        //    rpvXemBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsAllToy", lsToy));

        //    rpvXemBaoCao.RefreshReport();
        //}

        //public void SanPhamTheoLoai(clsLoaiDT_DTO _loaiChon)
        //{
        //    List<clsSanPham_DTO> _lsAllSP = (new clsSanPham_BUS()).DanhSachSanPham();
        //    List<clsSanPham_DTO> _lsSPTheoLoai = _lsAllSP.FindAll(o => o.MaLoaiDT == _loaiChon.Maloaidt);

        //    rpvXemBaoCao.LocalReport.ReportEmbeddedResource = "GUI.rptToyTheoLoai.rdlc";

        //    rpvXemBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsToyTheoLoai", _lsSPTheoLoai));

        //    rpvXemBaoCao.LocalReport.SetParameters(new ReportParameter("paLoai", _loaiChon.Tenloaidt.ToUpper()));

        //    rpvXemBaoCao.RefreshReport();

        //}
        //public void NhomSanPhamTheoLoai()
        //{
        //    _lsSanPham = (new clsSanPham_BUS()).DanhSachSanPham();

        //    List<clsLoaiDT_DTO> _lsLoaiSP = (new clsLoaiDT_BUS()).DanhSachLoaiDT();
        //    rpvXemBaoCao.LocalReport.ReportEmbeddedResource = "GUI.rptNhomToyTheoLoai.rdlc";

        //    rpvXemBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LaySanPhamTheoLoai);
        //    rpvXemBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsLoaiToy", _lsLoaiSP));

        //}

        //private void LaySanPhamTheoLoai(object sender, SubreportProcessingEventArgs e)
        //{
        //    int strMaLoai = int.Parse(e.Parameters["paLoai"].Values[0].ToString());
        //    //List<clsSanPham_DTO> _lsSPTheoLoai = _lsSanPham.FindAll(o => o.MaLoaiDT == strMaLoai);
        //    //e.DataSources.Add(new ReportDataSource("dsNhomToyTheoLoai", _lsSPTheoLoai));
        //}
    }
}
