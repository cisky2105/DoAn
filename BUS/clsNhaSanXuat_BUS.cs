using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class clsNhaSanXuat_BUS
    {
        clsNhaSanXuat_DAO nsx_DAO = new clsNhaSanXuat_DAO();
        public List<clsNhaSanXuat_DTO> DanhSachNhaSanXuat()
        {
            return nsx_DAO.DanhSachNhaSanXuat();
        }
    }
}
