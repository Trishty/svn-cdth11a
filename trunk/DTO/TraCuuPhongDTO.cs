using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TraCuuPhongDTO
    {
        #region Các thuộc tính
        private string _strMaPhong;
        #endregion

        #region Các phương thức
        public string StrMaPhong
        {
            get { return _strMaPhong; }
            set { _strMaPhong = value; }
        }
        #endregion
    }
}
