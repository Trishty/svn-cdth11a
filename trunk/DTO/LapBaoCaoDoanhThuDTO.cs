using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LapBaoCaoDoanhThuDTO
    {
        private int iMaPhieuThue;
        private DateTime dNgayThue;
        private DateTime dNgayTra;
        private int iMaPhong;
        private int iMaKH;
        private int iMaLK;

        public int MaPhieuThue
        {
            get { return iMaPhieuThue; }
            set { iMaPhieuThue = value; }
        }

        public DateTime NgayThue
        {
            get { return dNgayThue; }
            set { dNgayThue = value; }
        }

        public DateTime NgayTra
        {
            get { return dNgayTra; }
            set { dNgayTra = value; }
        }

        public int MaPhong
        {
            get { return iMaPhong; }
            set { iMaPhong = value; }
        }

        public int MaKH
        {
            get { return iMaKH; }
            set { iMaKH = value; }
        }

        public int MaLK
        {
            get { return iMaLK; }
            set { iMaLK = value; }
        }
    }
}
