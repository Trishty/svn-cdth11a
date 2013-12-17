using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ThayDoiQuyDinhDTO
    {
        private int iMaLP = 0;
        private string strTenLP = null;
        private int iSLPhong = 0;
        private int iSLKhachToiDa = 0;
        private string strGiaVN = null;
        private string strGiaNN = null;
        private int iTyLePhuThu = 0;

        public int MaLP
        {
            get { return iMaLP; }
            set { iMaLP = value; }
        }
        public string TenLP
        {
            get { return strTenLP; }
            set { strTenLP = value; }
        }
        public int SLPhong
        {
            get { return iSLPhong; }
            set { iSLPhong = value; }
        }
        public int SLKhachToiDa
        {
            get { return iSLKhachToiDa; }
            set { iSLKhachToiDa = value; }
        }
        public string GiaVN 
        {
            get { return strGiaVN; }
            set { strGiaVN = value; }
        }
        public string GiaNN
        {
            get { return strGiaNN; }
            set { strGiaNN = value; }
        }
        public int TyLePhuThu
        {
            get { return iTyLePhuThu; }
            set { iTyLePhuThu = value; }
        }
    }
}
