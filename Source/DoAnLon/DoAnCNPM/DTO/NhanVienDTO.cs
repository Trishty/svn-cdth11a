using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NhanVienDTO
    {
        #region Các thuộc tính
        private string _strTenDangNhap;
        private string _strMatKhau;
        private string _strHoTen;
        private string _strChucVu;
        private string _strDiaChi;
        private string _strDienThoai;
        private string _strCMND;
        #endregion

        #region Các phương thức
        public string StrTenDangNhap
        {
            get { return _strTenDangNhap; }
            set { _strTenDangNhap = value; }
        }

        public string StrMatKhau
        {
            get { return _strMatKhau; }
            set { _strMatKhau = value; }
        }

        public string StrHoTen
        {
            get { return _strHoTen; }
            set { _strHoTen = value; }
        }

        public string StrChucVu
        {
            get { return _strChucVu; }
            set { _strChucVu = value; }
        }

        public string StrDiaChi
        {
            get { return _strDiaChi; }
            set { _strDiaChi = value; }
        }

        public string StrDienThoai
        {
            get { return _strDienThoai; }
            set { _strDienThoai = value; }
        }

        public string StrCMND
        {
            get { return _strCMND; }
            set { _strCMND = value; }
        }
        #endregion
    }
}
