using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class clsSanPham_BUS
    {

        clsSanPham_DAO sp_DAO = new clsSanPham_DAO();
        public List<clsSanPham_DTO> DanhSachSanPham()
        {
            return sp_DAO.DanhSachSanPham();
        }
    }
}
