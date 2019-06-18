using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsNhaSanXuat_DTO
    {
        private string _mansx;
        private string _tennsx;
        private bool _trangthai;

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

        public string Tennsx
        {
            get
            {
                return _tennsx;
            }

            set
            {
                _tennsx = value;
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
    }
}
