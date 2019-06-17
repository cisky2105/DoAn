using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsSanPham_DTO
    {
        private string _masp;       
        private string _tensp;
        private int _gia;
        private int _giakm;
        private string _mansx;
        private int _soluong;
        private bool _trangthai;

        public string Masp
        {
            get
            {
                return _masp;
            }

            set
            {
                _masp = value;
            }
        }

        public string Tensp
        {
            get
            {
                return _tensp;
            }

            set
            {
                _tensp = value;
            }
        }

        public int Gia
        {
            get
            {
                return _gia;
            }

            set
            {
                _gia = value;
            }
        }

        public int Giakm
        {
            get
            {
                return _giakm;
            }

            set
            {
                _giakm = value;
            }
        }

        public string Mansx
        {
            get
            {
                return _mansx;
            }

            set
            {
                _mansx = value;
            }
        }

        public int Soluong
        {
            get
            {
                return _soluong;
            }

            set
            {
                _soluong = value;
            }
        }

        public bool Trangthai
        {
            get
            {
                return _trangthai;
            }

            set
            {
                _trangthai = value;
            }
        }

        //public clsSanPham_DTO(string masp, string tensp, int gia, int giakm, string mansx, int soluong, bool trangthai)
        //{
        //    this.Masp = masp;
        //    this.Tensp = tensp;
        //    this.Gia = gia;
        //    this.Giakm = giakm;
        //    this.Mansx = mansx;
        //    this.Soluong = soluong;
        //    this.Trangthai = trangthai;
        //}
    }
}
