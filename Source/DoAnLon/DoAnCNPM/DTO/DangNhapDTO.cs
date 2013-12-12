using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DangNhapDTO
    {
        private string strTenDN = null;
        private string strMatKhau = null;
        public string TenDN
        {
            get { return strTenDN; }
            set { strTenDN = value; }
        }
        public string MatKhau
        {
            get { return strMatKhau; }
            set { strMatKhau = value; }
        }
    }
}
