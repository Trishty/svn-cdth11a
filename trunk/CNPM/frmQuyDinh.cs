using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmQuyDinh : Form
    {
        public frmQuyDinh()
        {
            InitializeComponent();
        }
        //lay gia tri gui form cha
        private int m_iViTri = frmThayDoiCacQuyDinh.p_iViTri;
        private string m_strText = frmThayDoiCacQuyDinh.p_strText;
        private string m_strGiaTri = frmThayDoiCacQuyDinh.p_strGiaTri;
        //khoi tao cac gia tri co the thay doi
        public static string p_strMaPhong1 = null;
        public static string p_strMaPhong2 = null;
        public static string p_strMaPhong3 = null;
        public static string p_strMaPhong4 = null;
        public static string p_strMaPhong5 = null;
        public static string p_strMaLoaiKhach = null;
        public static string p_strSoLuongPhong = null;
        public static string p_strGiaVN = null;
        public static string p_strGiaNN = null;
        public static string p_strTiLePhuThu = null;
        public static string p_strSoLuongKhachToiDa = null;
        public static string p_strHeSoLoaiKhach = null;
        //
        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            if (m_strGiaTri == null)
            {
                this.Close();
            }
            XuLy();
            LoadTen();
        }

        private void XuLy()
        {
            txtMa.Text = m_strGiaTri.Substring(m_strGiaTri.IndexOf('<')+1, m_strGiaTri.LastIndexOf('>')-m_strGiaTri.IndexOf('<')-1);
            txtTen.Text = m_strGiaTri.Substring(m_strGiaTri.IndexOf('[') + 1, m_strGiaTri.LastIndexOf(']') - m_strGiaTri.IndexOf('[')-1);
            if (m_iViTri == 2)
            {
                string strGiaTri = m_strGiaTri.Substring(m_strGiaTri.IndexOf('{') + 1, m_strGiaTri.LastIndexOf('}') - m_strGiaTri.IndexOf('{') - 1).Trim();
                txtGiaTri.Text = strGiaTri.Substring(0, strGiaTri.IndexOf('V'));
            }
            else if (m_iViTri == 3)
            {
                string strGiaTri = m_strGiaTri.Substring(m_strGiaTri.IndexOf('{') + 1, m_strGiaTri.LastIndexOf('}') - m_strGiaTri.IndexOf('{') - 1).Trim();
                txtGiaTri.Text = strGiaTri.Substring(0, strGiaTri.IndexOf('$'));
            }
            else if (m_iViTri == 4)
            {
                string strGiaTri = m_strGiaTri.Substring(m_strGiaTri.IndexOf('{') + 1, m_strGiaTri.LastIndexOf('}') - m_strGiaTri.IndexOf('{') - 1).Trim();
                txtGiaTri.Text = strGiaTri.Substring(0, strGiaTri.IndexOf('%'));
            }
            else 
            {
                txtGiaTri.Text = m_strGiaTri.Substring(m_strGiaTri.IndexOf('{') + 1, m_strGiaTri.LastIndexOf('}') - m_strGiaTri.IndexOf('{') - 1).Trim();
            }
            
        }
        private void LoadTen()
        {
            this.Text = m_strText;
            if (m_iViTri == 1 || m_iViTri == 2 || m_iViTri == 3 || m_iViTri == 4 || m_iViTri == 5)
            {
                lblMa.Text = "Mã loại phòng:";
                lblTen.Text = "Tên loại phòng:";
                if (m_iViTri == 1)
                {
                    lblGiaTri.Text = "Số lượng phòng:";
                }else if (m_iViTri == 2)
                {
                    lblGiaTri.Text = "Đơn giá loại phòng(VN):";
                }
                else if (m_iViTri == 3)
                {
                    lblGiaTri.Text = "Đơn giá loại phòng(NN):";
                }
                else if (m_iViTri == 4)
                {
                    lblGiaTri.Text = "Tỉ lệ phụ thu:";
                }
                else if (m_iViTri == 5)
                {
                    lblGiaTri.Text = "Số lượng khách tối đa:";
                }
            }
            if (m_iViTri == 6)
            {
                lblMa.Text = "Mã loại khách:";
                lblTen.Text = "Tên loại khách:";
                lblGiaTri.Text = "Hệ số loại khách:";
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            m_iViTri = 0;
            m_strGiaTri = null;
            m_strText = null;
            this.Close();
        }

        private void btnDanhDauLuu_Click(object sender, EventArgs e)
        {
            if (m_iViTri == 1)
            {
                p_strMaPhong1 = txtMa.Text.Trim();
                p_strSoLuongPhong = txtGiaTri.Text.Trim();
                this.Close();
            }
            else if (m_iViTri == 2)
            {
                p_strMaPhong2 = txtMa.Text.Trim();
                p_strGiaVN = txtGiaTri.Text.Trim();
                this.Close();
            }
            else if (m_iViTri == 3)
            {
                p_strMaPhong3 = txtMa.Text.Trim();
                p_strGiaNN = txtGiaTri.Text.Trim();
                this.Close();
            }
            else if (m_iViTri == 4)
            {
                p_strMaPhong4 = txtMa.Text.Trim();
                p_strTiLePhuThu = txtGiaTri.Text.Trim();
                this.Close();
            }
            else if (m_iViTri == 5)
            {
                p_strMaPhong5 = txtMa.Text.Trim();
                p_strSoLuongKhachToiDa = txtGiaTri.Text.Trim();
                this.Close();
            }
            else if (m_iViTri == 6)
            {
                p_strMaLoaiKhach = txtMa.Text.Trim();
                p_strHeSoLoaiKhach = txtGiaTri.Text.Trim();
                this.Close();
            }
        }

        private void txtGiaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            int iDem = 0;
            string str = txtGiaTri.Text;
            for (int i = 0; i < txtGiaTri.Text.Length; i++)
            {
                if (str[i] == '.') iDem++;
            }
            if (iDem != 0 && e.KeyChar == '.')
            {
                e.Handled = true;
            }
            else if (!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}