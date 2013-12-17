using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public static class LapBaoCaoDoanhThuBUS
    {
        public static DataSet bLayDanhSachLoaiPhong()
        {
            return LapBaoCaoDoanhThuDAO.dLayDanhSachLoaiPhong();
        }

        public static DataSet bLayPhieuThuePhong(int iMaPhong)
        {
            return LapBaoCaoDoanhThuDAO.dLayPhieuThuePhong(iMaPhong);
        }
        public static DataSet bLayDSPhong()
        {
            return LapBaoCaoDoanhThuDAO.dLayDanhSachLoaiPhong();
        }
        public static DataSet bLayThongTinLoaiPhong(int iMaLoaiPhong)
        {
            return LapBaoCaoDoanhThuDAO.dLayThongTinLoaiPhong(iMaLoaiPhong);
        }

        public static string bLayMaLoaiPhongTheoPhong(int iMaPhong)
        {
            return LapBaoCaoDoanhThuDAO.dLayMaLoaiPhongTheoPhong(iMaPhong);
        }

        public static string bLayKhachHangTheoMaPT(int iMaPT)
        {
            return LapBaoCaoDoanhThuDAO.dLayKhachHangTheoMaPT(iMaPT);
        }
        public static DataSet bAllLayPhieuThuePhong()
        {
            return LapBaoCaoDoanhThuDAO.dAllLayPhieuThuePhong();
        }
        public static DataSet bLayDSDoanhThu()
        {
            return LapBaoCaoDoanhThuDAO.dLayDSDoanhThu();
        }

        public static DataSet bLayDSMatDo()
        {
            return LapBaoCaoDoanhThuDAO.dLayDSMatDo();
        }

        public static string bLayTenLoaiPhongTheoMaPhong(int iMaLP)
        {
            return LapBaoCaoDoanhThuDAO.dLayTenLoaiPhongTheoMaPhong(iMaLP);
        }
        public static bool bXoaDoanThu(int iMaDT)
        {
            return LapBaoCaoDoanhThuDAO.dXoaDoanThu(iMaDT);
        }
        public static bool bXoaMatDo(int iMaMD)
        {
            return LapBaoCaoDoanhThuDAO.dXoaMatDo(iMaMD);
        }
        public static string bMaxMaDT()
        {
            return LapBaoCaoDoanhThuDAO.dMaxMaDT();
        }
        public static string bMaxMaMD()
        {
            return LapBaoCaoDoanhThuDAO.dMaxMaMD();
        }
        public static bool bThemDoanhThu(int iMaDT, int iDoanhThuVND, double dDoanhThuUSD, float fTiLeDT, int iMaLP, int iThang)
        {
            return LapBaoCaoDoanhThuDAO.dThemDoanhThu(iMaDT, iDoanhThuVND, dDoanhThuUSD, fTiLeDT, iMaLP, iThang);
        }
        public static bool bThemMatDo(int iMaMD, int iMatDoThang, float fTiLeMD, int iMaPhong, int iThang)
        {
            return LapBaoCaoDoanhThuDAO.dThemMatDo(iMaMD, iMatDoThang, fTiLeMD, iMaPhong, iThang);
        }
    }
}
