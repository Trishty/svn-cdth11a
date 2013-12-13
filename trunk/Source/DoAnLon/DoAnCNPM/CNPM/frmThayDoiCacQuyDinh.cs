using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace CNPM
{
    public partial class frmThayDoiCacQuyDinh : Form
    {
        public frmThayDoiCacQuyDinh()
        {
            InitializeComponent();
        }
        #region khai báo biến
        public static int p_iViTri = 0;
        public static string p_strText = null;
        public static string p_strGiaTri = null;
        ThayDoiQuyDinhDTO tdqd = new ThayDoiQuyDinhDTO();
        #endregion

        #region form load
        private void frmThayDoiCacQuyDinh_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            AnAll();
        }
        #endregion

        #region load các combobex
        private void LoadCombobox()
        {
            //
            cbbDonGiaLPNN.Items.Clear();
            cbbDonGiaLPVN.Items.Clear();
            cbbHeSoLoaiKhach.Items.Clear();
            cbbSoLuongKhachToiDa.Items.Clear();
            cbbSoLuongPhong.Items.Clear();
            cbbTiLePhuThu.Items.Clear();
            //
            string strDisplay = null;
            DataSet dsLoaiPhong = new DataSet();
            dsLoaiPhong = LapBaoCaoDoanhThuBUS.bLayDanhSachLoaiPhong();
            foreach (DataRow dr in dsLoaiPhong.Tables[0].Rows)
            {
                //lay so luong phong
                strDisplay = "<" + dr["MaLP"].ToString() + "> " + "Tên loại phòng: [ " + dr["TenLP"].ToString() + " ]     Số lượng phòng: { " + dr["SLPhong"].ToString() + " }";
                cbbSoLuongPhong.Items.Add(strDisplay);
                //lay gia loai phong VN
                strDisplay = "<" + dr["MaLP"].ToString() + "> " + "Tên loại phòng: [ " + dr["TenLP"].ToString() + " ]     Giá phòng: { " + dr["GiaVN"].ToString() + "VNĐ }";
                cbbDonGiaLPVN.Items.Add(strDisplay);
                //lay gia loai phong NN
                strDisplay = "<" + dr["MaLP"].ToString() + "> " + "Tên loại phòng: [ " + dr["TenLP"].ToString() + " ]     Giá phòng: { " + dr["GiaNN"].ToString() + "$ }";
                cbbDonGiaLPNN.Items.Add(strDisplay);
                //so luogn khach toi da trong phong
                strDisplay = "<" + dr["MaLP"].ToString() + "> " + "Tên loại phòng: [ " + dr["TenLP"].ToString() + " ]     Số lượng khách tối đa: { " + dr["SLKhachToiDa"].ToString() + " }";
                cbbSoLuongKhachToiDa.Items.Add(strDisplay);
                //ti le phu thu
                strDisplay = "<" + dr["MaLP"].ToString() + "> " + "Tên loại phòng: [ " + dr["TenLP"].ToString() + " ]     Tỉ lệ phụ thu: { " + dr["TyLePhuThu"].ToString() + "% }";
                cbbTiLePhuThu.Items.Add(strDisplay);
            }
            //// lay he so loai khach
            DataSet dsLoaiKhach = new DataSet();
            dsLoaiKhach = ThayDoiQuyDinhBUS.bLayDanhSachLoaiKhach();
            foreach (DataRow drlk in dsLoaiKhach.Tables[0].Rows)
            {
                strDisplay = "<" + drlk["MaLK"].ToString() + "> " + "Tên loại khách: [ " + drlk["TenLK"].ToString() + " ]     Hệ số: { " + drlk["HeSo"].ToString() + " }";
                cbbHeSoLoaiKhach.Items.Add(strDisplay);
            }
        }
        #endregion

        #region cbbSoLuongPhong_SelectedIndexChanged
        private void cbbSoLuongPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSoLuongPhong.SelectedIndex != -1)
            {
                AnAll();
                cbbDonGiaLPNN.SelectedIndex = -1;
                cbbDonGiaLPVN.SelectedIndex = -1;
                cbbHeSoLoaiKhach.SelectedIndex = -1;
                cbbSoLuongKhachToiDa.SelectedIndex = -1;
                cbbTiLePhuThu.SelectedIndex = -1;
                btnSoLuongLoaiPhong.Enabled = true;
            }
        }
        #endregion

        #region cbbDonGiaLPVN_SelectedIndexChanged
        private void cbbDonGiaLPVN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDonGiaLPVN.SelectedIndex != -1)
            {
                AnAll();
                cbbDonGiaLPNN.SelectedIndex = -1;
                cbbHeSoLoaiKhach.SelectedIndex = -1;
                cbbSoLuongKhachToiDa.SelectedIndex = -1;
                cbbSoLuongPhong.SelectedIndex = -1;
                cbbTiLePhuThu.SelectedIndex = -1;
                btnDonGiaCacLoaiPhongVN.Enabled = true;
            }

        }
        #endregion

        #region cbbDonGiaLPNN_SelectedIndexChanged
        private void cbbDonGiaLPNN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDonGiaLPNN.SelectedIndex != -1)
            {
                AnAll();
                btnDonGiaCacLoaiPhongNN.Enabled = true;
                cbbDonGiaLPVN.SelectedIndex = -1;
                cbbHeSoLoaiKhach.SelectedIndex = -1;
                cbbSoLuongKhachToiDa.SelectedIndex = -1;
                cbbSoLuongPhong.SelectedIndex = -1;
                cbbTiLePhuThu.SelectedIndex = -1;
            }
        }
        #endregion

        #region cbbHeSoLoaiKhach_SelectedIndexChanged
        private void cbbHeSoLoaiKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHeSoLoaiKhach.SelectedIndex != -1)
            {
                AnAll();
                btnHeSoKhach.Enabled = true;
                cbbDonGiaLPNN.SelectedIndex = -1;
                cbbDonGiaLPVN.SelectedIndex = -1;
                cbbSoLuongKhachToiDa.SelectedIndex = -1;
                cbbSoLuongPhong.SelectedIndex = -1;
                cbbTiLePhuThu.SelectedIndex = -1;
            }
        }
        #endregion

        #region cbbSoLuongKhachToiDa_SelectedIndexChanged
        private void cbbSoLuongKhachToiDa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSoLuongKhachToiDa.SelectedIndex != -1)
            {
                AnAll();
                btnSoLuongKhachToiDa.Enabled = true;
                cbbDonGiaLPNN.SelectedIndex = -1;
                cbbDonGiaLPVN.SelectedIndex = -1;
                cbbHeSoLoaiKhach.SelectedIndex = -1;
                cbbSoLuongPhong.SelectedIndex = -1;
                cbbTiLePhuThu.SelectedIndex = -1;
            }
        }
        #endregion

        #region cbbTiLePhuThu_SelectedIndexChanged
        private void cbbTiLePhuThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTiLePhuThu.SelectedIndex != -1)
            {
                AnAll();
                btnTiLePhuThu.Enabled = true;
                cbbDonGiaLPNN.SelectedIndex = -1;
                cbbDonGiaLPVN.SelectedIndex = -1;
                cbbHeSoLoaiKhach.SelectedIndex = -1;
                cbbSoLuongKhachToiDa.SelectedIndex = -1;
                cbbSoLuongPhong.SelectedIndex = -1;
            }
        }
        #endregion

        #region Ẩn các button chỉnh sửa
        private void AnAll()
        {
            btnDonGiaCacLoaiPhongNN.Enabled = false;
            btnDonGiaCacLoaiPhongVN.Enabled = false;
            btnHeSoKhach.Enabled = false;
            btnSoLuongKhachToiDa.Enabled = false;
            btnSoLuongLoaiPhong.Enabled = false;
            btnTiLePhuThu.Enabled = false;

        }
        #endregion

        #region btnSoLuongLoaiPhong_Click
        private void btnSoLuongLoaiPhong_Click(object sender, EventArgs e)
        {
            p_iViTri = 1;
            p_strText = "Thay đổi số lượng của loại phòng";
            p_strGiaTri = cbbSoLuongPhong.SelectedItem.ToString();
            frmQuyDinh fqd = new frmQuyDinh();
            fqd.ShowDialog();
        }
        #endregion

        #region btnDonGiaCacLoaiPhongVN_Click
        private void btnDonGiaCacLoaiPhongVN_Click(object sender, EventArgs e)
        {
            p_iViTri = 2;
            p_strText = "Thay đổi đơn giá(VN) của loại phòng";
            p_strGiaTri = cbbDonGiaLPVN.SelectedItem.ToString();
            frmQuyDinh fqd = new frmQuyDinh();
            fqd.ShowDialog();
        }
        #endregion

        #region btnDonGiaCacLoaiPhongNN_Click
        private void btnDonGiaCacLoaiPhongNN_Click(object sender, EventArgs e)
        {
            p_iViTri = 3;
            p_strText = "Thay đổi đơn giá(NN) của loại phòng";
            p_strGiaTri = cbbDonGiaLPNN.SelectedItem.ToString();
            frmQuyDinh fqd = new frmQuyDinh();
            fqd.ShowDialog();
        }
        #endregion

        #region btnTiLePhuThu_Click
        private void btnTiLePhuThu_Click(object sender, EventArgs e)
        {
            p_iViTri = 4;
            p_strText = "Thay đổi tỉ lệ phụ thu của loại phòng";
            p_strGiaTri = cbbTiLePhuThu.SelectedItem.ToString();
            frmQuyDinh fqd = new frmQuyDinh();
            fqd.ShowDialog();
        }
        #endregion

        #region btnSoLuongKhachToiDa_Click
        private void btnSoLuongKhachToiDa_Click(object sender, EventArgs e)
        {
            p_iViTri = 5;
            p_strText = "Thay đổi số lượng khách tối đa của loại phòng";
            p_strGiaTri = cbbSoLuongKhachToiDa.SelectedItem.ToString();
            frmQuyDinh fqd = new frmQuyDinh();
            fqd.ShowDialog();
        }
        #endregion

        #region btnHeSoKhach_Click
        private void btnHeSoKhach_Click(object sender, EventArgs e)
        {
            p_iViTri = 6;
            p_strText = "Thay đổi hệ số của loại khách";
            p_strGiaTri = cbbHeSoLoaiKhach.SelectedItem.ToString();
            frmQuyDinh fqd = new frmQuyDinh();
            fqd.ShowDialog();
        }
        #endregion

        #region btnThoat_Click
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlms = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlms == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region btnLuuThayDoi_Click
        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            string strMaPhong1 = frmQuyDinh.p_strMaPhong1;
            string strMaPhong2 = frmQuyDinh.p_strMaPhong2;
            string strMaPhong3 = frmQuyDinh.p_strMaPhong3;
            string strMaPhong4 = frmQuyDinh.p_strMaPhong4;
            string strMaPhong5 = frmQuyDinh.p_strMaPhong5;
            string strMaLoaiKhach = frmQuyDinh.p_strMaLoaiKhach;
            string strSoLuongPhong = frmQuyDinh.p_strSoLuongPhong;
            string strGiaVN = frmQuyDinh.p_strGiaVN;
            string strGiaNN = frmQuyDinh.p_strGiaNN;
            string strTiLePhuThu = frmQuyDinh.p_strTiLePhuThu;
            string strSoLuongKhachToiDa = frmQuyDinh.p_strSoLuongKhachToiDa;
            string strHeSoLoaiKhach = frmQuyDinh.p_strHeSoLoaiKhach;
            string str = "Sửa ";
            if (strMaPhong1 != null)
            {
                tdqd.MaLP = int.Parse(strMaPhong1);
                try
                {
                    tdqd.SLPhong = int.Parse(strSoLuongPhong);
                    if (ThayDoiQuyDinhBUS.bSuaSoLuongPhong(tdqd))
                    {
                        str += "[Số lượng phòng] ";
                    }
                }
                catch 
                {
                    MessageBox.Show("Số lượng phòng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            if (strMaPhong2 != null)
            {
                tdqd.MaLP = int.Parse(strMaPhong2);
                try
                {
                    tdqd.GiaVN = strGiaVN;
                    if (ThayDoiQuyDinhBUS.bSuaGiaVN(tdqd))
                    {
                        str += "[Giá VN] ";
                    }
                }
                catch
                {
                    MessageBox.Show("Giá (VN) không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (strMaPhong3 != null)
            {
                tdqd.MaLP = int.Parse(strMaPhong3);
                try
                {
                    tdqd.GiaNN = strGiaNN;
                    if (ThayDoiQuyDinhBUS.bSuaGiaNN(tdqd))
                    {
                        str += "[Giá NN] ";
                    }
                }
                catch
                {
                    MessageBox.Show("Giá (NN) không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (strMaPhong4 != null)
            {
                tdqd.MaLP = int.Parse(strMaPhong4);
                try
                {
                    tdqd.TyLePhuThu = int.Parse(strTiLePhuThu);
                    if (ThayDoiQuyDinhBUS.bSuaTyLePhuThu(tdqd))
                    {
                        str += "[Tỉ lệ phụ thu] ";
                    }
                }
                catch
                {
                    MessageBox.Show("Tỉ lệ phụ thu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (strMaPhong5 != null)
            {
                tdqd.MaLP = int.Parse(strMaPhong5);
                try
                {
                    tdqd.SLKhachToiDa = int.Parse(strSoLuongKhachToiDa);
                    if (ThayDoiQuyDinhBUS.bSuaSLKhachToiDa(tdqd))
                    {
                        str += "[Số lượng khách tối đa] ";
                    }
                }
                catch
                {
                    MessageBox.Show("Số lượng khách tối đa không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if (strMaLoaiKhach != null)
            {
                int iMaLK = int.Parse(strMaLoaiKhach);
                try
                {
                    int iHeSo = int.Parse(strHeSoLoaiKhach);
                    if (ThayDoiQuyDinhBUS.bSuaHeSoLoaiKhach(iMaLK,iHeSo))
                    {
                        str += "[Hệ số loại khách] ";
                    }
                }
                catch
                {
                    MessageBox.Show("Hệ số loại khách không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if(!"Sửa".Equals(str.Trim()))
            {
                str += " thành công!";
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadCombobox();
            btnDonGiaCacLoaiPhongNN.Enabled = false;
            btnDonGiaCacLoaiPhongVN.Enabled = false;
            btnHeSoKhach.Enabled = false;
            btnTiLePhuThu.Enabled = false;
            btnSoLuongKhachToiDa.Enabled = false;
            btnSoLuongLoaiPhong.Enabled = false;
        }
        #endregion
    }
}