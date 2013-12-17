using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class KhachHangDTO
    {
        #region Các thuộc tính
        private int _iMaKH;
        private string _strTenKH;
        private long _lGiayToTuyThan;
        private bool _bGioiTinh;
        private string _strDiaChi;
        private string _strSoDienThoai;
        private int _iMaLK;
        private int _iMaPhieuThue;
        #endregion

        #region Các phương thức
        public int IMaKH
        {
            get { return _iMaKH; }
            set { _iMaKH = value; }
        }
        public string StrTenKH
        {
            get { return _strTenKH; }
            set { _strTenKH = value; }
        }
        public long LGiayToTuyThan
        {
            get { return _lGiayToTuyThan; }
            set { _lGiayToTuyThan = value; }
        }
        public bool BGioiTinh
        {
            get { return _bGioiTinh; }
            set { _bGioiTinh = value; }
        }
        public string StrDiaChi
        {
            get { return _strDiaChi; }
            set { _strDiaChi = value; }
        }
        public string StrSoDienThoai
        {
            get { return _strSoDienThoai; }
            set { _strSoDienThoai = value; }
        }
        public int IMaLK
        {
            get { return _iMaLK; }
            set { _iMaLK = value; }
        }
        public int IMaPhieuThue
        {
            get { return _iMaPhieuThue; }
            set { _iMaPhieuThue = value; }
        }
        #endregion
    }
}
