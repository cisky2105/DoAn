using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class clsNhaSanXuat_DAO
    {
        public List<clsNhaSanXuat_DTO> DanhSachNhaSanXuat()
        {
            List<clsNhaSanXuat_DTO> lsResult = new List<clsNhaSanXuat_DTO>();
            string strQuery = "Select * From NhaSanXuat Where TrangThai = 1";            
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strQuery, conn);
            while (sdr.Read())
            {
                clsNhaSanXuat_DTO _nsxdto = new clsNhaSanXuat_DTO();
                _nsxdto.Mansx = sdr["MaNSX"].ToString();
                _nsxdto.Tennsx = sdr["TenNSX"].ToString();
                _nsxdto.Trangthai = bool.Parse(sdr["TrangThai"].ToString());
                lsResult.Add(_nsxdto);
            }
            sdr.Close();
            conn.Close();
            return lsResult;

        }
    }
}
