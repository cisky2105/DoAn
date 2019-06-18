using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class clsNhanVien_DAO
    {
        public List<clsNhanVien_DTO> DanhSachNhanVien()
        {
            List<clsNhanVien_DTO> lsResult = new List<clsNhanVien_DTO>();
            string strQuery = "Select * From NhanVien Where TrangThai = 1";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strQuery, conn);
            while (sdr.Read())
            {
                clsNhanVien_DTO nv_dto = new clsNhanVien_DTO();
                nv_dto.CMNDNV = int.Parse(sdr["CMNDNV"].ToString());
                nv_dto.HoVaTen = sdr["HoVaTen"].ToString();
                nv_dto.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                nv_dto.GioiTinh = bool.Parse(sdr["GioiTInh"].ToString());
                nv_dto.SDT = sdr["SDT"].ToString();
                nv_dto.DiaChi = sdr["DiaChi"].ToString();
                nv_dto.Quyen = sdr["Quyuen"].ToString();
                nv_dto.TrangThai = bool.Parse(sdr["TrangThai"].ToString());
                lsResult.Add(nv_dto);
            }
            sdr.Close();
            conn.Close();
            return lsResult;
        }
    }
}
