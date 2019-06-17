using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAO
{
    public class clsSanPham_DAO
    {        

        public List<clsSanPham_DTO> DanhSachSanPham()
        {
            List<clsSanPham_DTO> lsResult = new List<clsSanPham_DTO>();

            string strQuery = "Select * From SanPham Where TrangThai = 1";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strQuery, conn);
            while (sdr.Read())
            {
                clsSanPham_DTO _spdto = new clsSanPham_DTO();
                _spdto.Masp = sdr["MaSP"].ToString();
                _spdto.Tensp = sdr["TenSP"].ToString();
                _spdto.Gia = int.Parse(sdr["GiaBan"].ToString());
                _spdto.Giakm = int.Parse(sdr["GiaKM"].ToString());
                _spdto.Mansx = sdr["MaNSX"].ToString();
                _spdto.Soluong = int.Parse(sdr["SLTonKho"].ToString());
                _spdto.Trangthai = bool.Parse(sdr["TrangThai"].ToString());
                lsResult.Add(_spdto);
            }
            sdr.Close();
            conn.Close();
            return lsResult;
        }
    }
}
