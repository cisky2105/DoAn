using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsHoaDonXuat_DTO
    {
        private string _MaHDXuat;
        private string _SDTKH;
        private int _CMNDNV;
        private DateTime _NgayXuat;
        private int _TongTien;
        private bool _TrangThai;

        public string MaHDXuat { get => _MaHDXuat; set => _MaHDXuat = value; }
        public string SDTKH { get => _SDTKH; set => _SDTKH = value; }
        public int CMNDNV { get => _CMNDNV; set => _CMNDNV = value; }
        public DateTime NgayXuat { get => _NgayXuat; set => _NgayXuat = value; }
        public int TongTien { get => _TongTien; set => _TongTien = value; }
        public bool TrangThai { get => _TrangThai; set => _TrangThai = value; }
    }
}
