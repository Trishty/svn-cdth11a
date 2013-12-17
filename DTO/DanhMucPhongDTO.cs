using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DanhMucPhongDTO
    {
        private string _MaPhong;

        public string MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }
        private string _LoaiPhong;

        public string LoaiPhong
        {
            get { return _LoaiPhong; }
            set { _LoaiPhong = value; }
        }
        private string _TinhTrang;

        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
    }
}
