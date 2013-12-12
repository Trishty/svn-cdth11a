using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace CNPM
{
    public partial class frmLapBaoCaoDoanhThu : Form
    {
        public frmLapBaoCaoDoanhThu()
        {
            InitializeComponent();
        }
        #region khai báo biến
        DataSet dsLoaiPhong = new DataSet();
        DataSet dsPhieuThuePhong = new DataSet();
        private double m_dDoanhThuTrongThangGiaVN = 0;
        private double m_dDoanhThuTrongThangGiaNN = 0;
        private double m_dTongDoanhDuKienThuThongThangGiaVN = 0;
        private double m_dTongDoanhDuKienThuThongThangGiaNN = 0;
        private int m_iTongSoNgayThue = 0;
        private int m_iPhongThueCuaThang = 0;
        private double m_dGiaPhongVN = 0;
        private double m_dGiaPhongNN = 0;
        private int m_iSTT = 0;
        private int m_iflag = 0;
        #endregion

        #region form load
        private void frmLapBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            LoadLoaiPhong();
            LoadThang();
            LoadDoanhThuVaMatDo();
        }
        #endregion

        #region lấy tổng số lần thuê phòng trong tháng chọn
        private int LayTongSoLanThuePhongTrongThang(int iThangChon)
        {
            DataSet dsPhieuThue = new DataSet();
            dsPhieuThue = LapBaoCaoDoanhThuBUS.bAllLayPhieuThuePhong();
            int iSoLanThuePhong = 0;
            foreach (DataRow dr in dsPhieuThue.Tables[0].Rows)
            {
                int iThangBatDau = (Convert.ToDateTime(dr["NgayThuePhong"].ToString())).Month;
                int iThangKetThuc = (Convert.ToDateTime(dr["NgayTraPhong"].ToString())).Month;
                if (iThangBatDau == iThangChon || iThangKetThuc == iThangChon)
                {
                    iSoLanThuePhong++;
                }
            }
            return iSoLanThuePhong;
        }
        #endregion

        #region lấy số lần đặt phòng
        private int LaySoLanDatPhong(int iThangChon, int iPhong)
        {
            DataSet dsPhieuThue = new DataSet();
            dsPhieuThue = LapBaoCaoDoanhThuBUS.bAllLayPhieuThuePhong();
            int iSoLanDat = 0;
            foreach (DataRow dr in dsPhieuThue.Tables[0].Rows)
            {
                int iThangBatDau = (Convert.ToDateTime(dr["NgayThuePhong"].ToString())).Month;
                int iThangKetThuc = (Convert.ToDateTime(dr["NgayTraPhong"].ToString())).Month;
                if (iThangBatDau == iThangChon || iThangKetThuc == iThangChon)
                {
                    if (int.Parse(dr["MaPhong"].ToString()) == iPhong)
                    {
                        iSoLanDat++;
                    }
                }
            }
            return iSoLanDat;
        }
        #endregion

        #region tính tỉ lệ
        private int TinhTiLe(int iThangChon, int iMaPhong, int iSoNgayTrongThang)
        {

            int iSoNgayThuePhong = 0;
            int iNgayBatDau = 0;
            int iNgayKetThuc = 0;
            int iThangBatDau = 0;
            int iThangKetThuc = 0;
            int iMaLP = 0;
            int iMaPT = 0;
            string strGiaVN = null;
            string strGiaNN = null;
            double dGiaVN = 0;
            float fGiaNN = 0;
            dsPhieuThuePhong = LapBaoCaoDoanhThuBUS.bLayPhieuThuePhong(iMaPhong);
            foreach (DataRow dr in dsPhieuThuePhong.Tables[0].Rows)
            {
                iThangBatDau = (Convert.ToDateTime(dr["NgayThuePhong"].ToString())).Month;
                iThangKetThuc = (Convert.ToDateTime(dr["NgayTraPhong"].ToString())).Month;
                if (iThangBatDau == iThangChon || iThangKetThuc == iThangChon)
                {
                    if (iThangBatDau == iThangChon) iNgayBatDau = (Convert.ToDateTime(dr["NgayThuePhong"].ToString())).Day;
                    else iNgayBatDau = 1;

                    if (iThangKetThuc == iThangChon) iNgayKetThuc = (Convert.ToDateTime(dr["NgayTraPhong"].ToString())).Day;
                    else iNgayKetThuc = GoToEndOfMonth(iThangChon, (Convert.ToDateTime(dr["NgayTraPhong"].ToString())).Year).Day;
                    iSoNgayThuePhong += (iNgayKetThuc - iNgayBatDau) + 1;
                    ////xu ly tinh tien
                    iMaLP = int.Parse(LapBaoCaoDoanhThuBUS.bLayMaLoaiPhongTheoPhong(iMaPhong));
                    dsLoaiPhong = LapBaoCaoDoanhThuBUS.bLayThongTinLoaiPhong(iMaLP);
                    strGiaVN = dsLoaiPhong.Tables[0].Rows[0]["GiaVN"].ToString();
                    strGiaNN = dsLoaiPhong.Tables[0].Rows[0]["GiaNN"].ToString();
                    dGiaVN = double.Parse(strGiaVN.Substring(0).ToString().Trim());
                    fGiaNN = float.Parse(strGiaNN.Substring(0, strGiaNN.LastIndexOf('$')).ToString().Trim());
                    iMaPT = int.Parse(dr["MaPhieuThue"].ToString());
                    m_dDoanhThuTrongThangGiaVN += (iNgayKetThuc - iNgayBatDau + 1) * dGiaVN;
                    m_dDoanhThuTrongThangGiaNN += (iNgayKetThuc - iNgayBatDau + 1) * fGiaNN;
                    m_dTongDoanhDuKienThuThongThangGiaVN += (Convert.ToDateTime(dr["NgayTraPhong"].ToString())).Day * dGiaVN;
                    m_dTongDoanhDuKienThuThongThangGiaNN += (Convert.ToDateTime(dr["NgayTraPhong"].ToString())).Day * fGiaNN;
                    m_iPhongThueCuaThang++;
                    m_iTongSoNgayThue += iSoNgayThuePhong;
                    m_dGiaPhongVN = dGiaVN;
                    m_dGiaPhongNN = fGiaNN;
                    ////
                    string strTenKH = LapBaoCaoDoanhThuBUS.bLayKhachHangTheoMaPT(iMaPT);
                    m_iSTT++;
                    ThemVaoListViewCT(m_iSTT, iMaPhong, dsLoaiPhong.Tables[0].Rows[0]["TenLP"].ToString(), strTenKH, Convert.ToDateTime(dr["NgayThuePhong"].ToString()), Convert.ToDateTime(dr["NgayTraPhong"].ToString()), strGiaVN, strGiaNN, iThangChon);
                    ////
                }

            }

            return iSoNgayThuePhong;
        }
        #endregion

        #region thêm vào listview chi tiết
        private void ThemVaoListViewCT(int iSTT, int iPhong, string strLoaiPhong, string strTenKH, DateTime dNgayThue, DateTime dNgayTra, string strGiaVN, string strGiaNN, int iThang)
        {
            int iSoLanThuePhong = LayTongSoLanThuePhongTrongThang(iThang);//gan tong ngay thue phong
            //lay mat do
            int iSoPhong = LaySoLanDatPhong(iThang, iPhong);
            double dMatDo = (float)((int)((((float)iSoPhong / iSoLanThuePhong) + 0.05) * 10)) / 10;
            //
            ListViewItem item = new ListViewItem();
            item.Text = iSTT.ToString();
            item.SubItems.Add(iPhong.ToString());
            item.SubItems.Add(strLoaiPhong);
            item.SubItems.Add(strTenKH);
            item.SubItems.Add(dNgayThue.ToShortDateString());
            item.SubItems.Add(dNgayTra.ToShortDateString());
            item.SubItems.Add(strGiaVN);
            item.SubItems.Add(strGiaNN);
            item.SubItems.Add(dMatDo.ToString());
            lvwHienThiDS.Items.Add(item);
        }
        #endregion

        #region hiển thị textbox
        private void HienThiTextBox(int iSoNgayTrongThang)
        {
            string strName = "";
            int iFlag = 0;
            int iSoNgayThue = 0;
            int isl = int.Parse(cbbThang.SelectedItem.ToString().Substring(cbbThang.SelectedItem.ToString().IndexOf(' ')));
            foreach (Control ctgp in this.flpHienThi.Controls)
            {
                if (ctgp is GroupBox)
                {
                    iFlag = 0;
                    iSoNgayThue = 0;
                    foreach (Control ct in ctgp.Controls)
                    {
                        if (ct is TextBox)
                        {
                            if (iFlag == 0)
                            {
                                strName = ct.Name.Substring(3);
                                iSoNgayThue = TinhTiLe(isl, int.Parse(strName), iSoNgayTrongThang);
                                ((TextBox)ct).Text = iSoNgayThue.ToString();
                                iFlag = 1;
                            }
                            else
                            {
                                if (iSoNgayThue != 0)
                                {
                                    int iTiLeDoanhThuLP = (int)((float)((iSoNgayThue * m_dGiaPhongVN) * 100 / (iSoNgayTrongThang * m_dGiaPhongVN)));
                                    ((TextBox)ct).Text = iTiLeDoanhThuLP.ToString() + "%";
                                }
                                else ((TextBox)ct).Text = "0%";
                            }
                        }
                        if (ct is Label)
                        {
                            if (((Label)ct).Name.Length > 5)
                            {
                                if (((Label)ct).Name.Substring(0, 5) == "lblvn")
                                {
                                    ((Label)ct).Text = m_dGiaPhongVN.ToString();
                                }
                                else if (((Label)ct).Name.Substring(0, 5) == "lblnn")
                                {
                                    ((Label)ct).Text = m_dGiaPhongNN.ToString();
                                }
                            }
                        }
                    }
                    m_dGiaPhongNN = 0;
                    m_dGiaPhongVN = 0;
                }
            }
        }
        #endregion

        #region lấy ngày cuối cùng trong tháng
        public DateTime GoToEndOfMonth(int iThang, int iNam)
        {
            if (iThang == 12)
            {
                return new DateTime(iNam, iThang, 31);
            }
            DateTime tem = new DateTime(iNam, iThang + 1, 1);
            return tem.AddDays(-1);
        }
        #endregion

        #region load danh sách tháng
        private void LoadThang()
        {
            cbbThang.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cbbThang.Items.Add("Tháng " + i.ToString());
            }
        }
        #endregion

        #region load loại phòng
        public void LoadLoaiPhong()
        {
            dsLoaiPhong = LapBaoCaoDoanhThuBUS.bLayDanhSachLoaiPhong();
            foreach (DataRow drLP in dsLoaiPhong.Tables[0].Rows)
            {
                //label danh dau don giavn
                Label lbvn = new Label();
                lbvn.Name = "lblvn" + drLP["MaLP"].ToString();
                lbvn.Size = new Size(0, 25);
                //
                //label danh dau don giavn
                Label lbnn = new Label();
                lbnn.Name = "lblnn" + drLP["MaLP"].ToString();
                lbnn.Size = new Size(0, 25);
                //
                //label
                Label lbsl = new Label();
                lbsl.Text = "Số ngày: ";
                lbsl.Location = new Point(10, 25);
                lbsl.Size = new Size(50, 25);
                //xu ly ngaythue
                TextBox tb = new TextBox();
                tb.Name = "txt" + drLP["MaLP"].ToString();
                tb.Location = new Point(60, 20);
                tb.Size = new Size(90, 20);
                tb.ReadOnly = true;
                //label
                Label lb = new Label();
                lb.Text = "Tỉ lệ DT: ";
                lb.Location = new Point(155, 25);
                lb.Size = new Size(50, 25);
                //textbox ti le
                TextBox tbtl = new TextBox();
                tbtl.Name = "txtPT" + drLP["MaLP"].ToString();
                tbtl.Size = new Size(90, 20);
                tbtl.Location = new Point(205, 20);
                tbtl.ReadOnly = true;
                // xu ly gruop box
                GroupBox gb = new GroupBox();
                gb.Text = "Loại phòng " + drLP["TenLP"].ToString();
                gb.Size = new Size(320, 52);
                gb.Controls.Add(tb);
                gb.Controls.Add(lbsl);
                gb.Controls.Add(lb);
                gb.Controls.Add(tbtl);
                gb.Controls.Add(lbvn);
                gb.Controls.Add(lbnn);
                flpHienThi.Controls.Add(gb);
            }
        }
        #endregion

        #region thêm mật độ
        private int ThemMatDo()
        {
            int iDong = lvwHienThiDS.Items.Count;
            int iMaMD = 0;
            int iMaPhong = 0;
            int iThang = int.Parse(cbbThang.SelectedItem.ToString().Substring(cbbThang.SelectedItem.ToString().IndexOf(' ')));
            float fTiLeMD = 0;
            int iDem = 0;
            for (int i = 0; i < iDong; i++)
            {
                try
                {
                    iMaMD = int.Parse(LapBaoCaoDoanhThuBUS.bMaxMaMD()) + 1;
                }
                catch
                {
                    iMaMD = 1;
                }
                iMaPhong = int.Parse(lvwHienThiDS.Items[i].SubItems[1].Text);
                fTiLeMD = float.Parse(lvwHienThiDS.Items[i].SubItems[8].Text);
                if (LapBaoCaoDoanhThuBUS.bThemMatDo(iMaMD, iDong, fTiLeMD, iMaPhong, iThang))
                {
                    iDem++;
                }
            }
            return iDem;
        }
        #endregion

        #region thêm doanh thu
        private int ThemDoanhThu()
        {
            int iDem = 0;
            foreach (Control ctgp in this.flpHienThi.Controls)
            {
                if (ctgp is GroupBox)
                {
                    int iMaDT = 0;
                    try
                    {
                        iMaDT = int.Parse(LapBaoCaoDoanhThuBUS.bMaxMaDT()) + 1;
                    }
                    catch
                    {
                        iMaDT = 1;
                    }
                    int iThang = int.Parse(cbbThang.SelectedItem.ToString().Substring(cbbThang.SelectedItem.ToString().IndexOf(' ')));
                    int iMaLP = 0;
                    int iTiLeDT = 0;
                    int iDoanhThuVN = 0;
                    int iDonGiaVN = 0;
                    double dDoanhThuNN = 0;
                    float fDonGiaNN = 0;
                    int iSoNgay = 0;
                    foreach (Control ct in ctgp.Controls)
                    {
                        if (ct is Label)
                        {
                            if (((Label)ct).Name.Length > 5)
                            {
                                if (((Label)ct).Name.Substring(0, 5) == "lblvn")
                                {
                                    iDonGiaVN = int.Parse(((Label)ct).Text);
                                }
                            }
                            if (((Label)ct).Name.Length > 5)
                            {
                                if (((Label)ct).Name.Substring(0, 5) == "lblnn")
                                {
                                    fDonGiaNN = float.Parse(((Label)ct).Text);
                                }
                            }
                        }
                        if (ct is TextBox)
                        {
                            if (((TextBox)ct).Name.Length > 5)
                            {
                                if (((TextBox)ct).Name.Substring(0, 5) == "txtPT")
                                {
                                    iMaLP = int.Parse(((TextBox)ct).Name.Substring(5));//lay malp
                                    iTiLeDT = int.Parse(((TextBox)ct).Text.Substring(0, ((TextBox)ct).Text.Length - 1));
                                }
                            }
                            else if (((TextBox)ct).Name.Length > 3)
                            {
                                if (((TextBox)ct).Name.Substring(0, 3) == "txt")
                                {
                                    iSoNgay = int.Parse(((TextBox)ct).Text);
                                }
                            }
                        }
                    }
                    //tinh gia
                    iDoanhThuVN = iSoNgay * iDonGiaVN;
                    dDoanhThuNN = (double)iSoNgay * fDonGiaNN;
                    float fTiLeDT = (float)iTiLeDT / 100;
                    if (LapBaoCaoDoanhThuBUS.bThemDoanhThu(iMaDT, iDoanhThuVN, dDoanhThuNN, fTiLeDT, iMaLP, iThang))
                    {
                        iDem++;
                    }
                }
            }
            return iDem;
        }
        #endregion

        #region button thống kê
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cbbThang.SelectedIndex != -1)
            {
                if (lvwHienThiDS.Items.Count != 0)
                {
                    int iTK = ThemDoanhThu();
                    int iMD = ThemMatDo();
                    if (iTK != 0 || iMD != 0)
                    {
                        MessageBox.Show("Đã thêm " + iTK + " thông tin doanh thu và " + iMD + " thông tin mật độ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Không thể lập thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbThang.SelectedIndex = -1;
                }
                else MessageBox.Show("Không có dữ liệu để thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Chưa chọn tháng cần thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDoanhThuVaMatDo();
        }
        #endregion

        #region combobox tháng SelectedIndexChanged
        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwHienThiDS.Items.Clear();

            if (cbbThang.SelectedIndex != -1)
            {
                int iThang = int.Parse(cbbThang.SelectedItem.ToString().Substring(cbbThang.SelectedItem.ToString().IndexOf(' ')));
                DateTime dt = DateTime.Now;
                int iSoNgayTrongThang = GoToEndOfMonth(iThang, dt.Year).Day;
                HienThiTextBox(iSoNgayTrongThang);
                txtTienThue_GiaVN.Text = m_dDoanhThuTrongThangGiaVN.ToString() + "VNĐ";
                txtTienThue_GiaNN.Text = m_dDoanhThuTrongThangGiaNN.ToString() + "$";
                txtTongTienThue_GiaVN.Text = m_dTongDoanhDuKienThuThongThangGiaVN.ToString() + "VNĐ";
                txtTongTienThue_GiaNN.Text = m_dTongDoanhDuKienThuThongThangGiaNN.ToString() + "$";
                txtNgayThue.Text = m_iTongSoNgayThue.ToString();
                int iTongNgayThueDuKien = m_iPhongThueCuaThang * iSoNgayTrongThang;
                if (iTongNgayThueDuKien != 0)
                {
                    int iTiLeThuePhong = (int)((float)m_iTongSoNgayThue * 100 / iTongNgayThueDuKien);
                    txtTongNgayThueDuKien.Text = iTongNgayThueDuKien.ToString();
                    txtTileNgayThue.Text = iTiLeThuePhong.ToString() + "%";
                }
                else txtTileNgayThue.Text = "0%";
                if (m_dTongDoanhDuKienThuThongThangGiaVN != 0)
                {
                    int iTiLeDoanhThu = (int)((float)m_dDoanhThuTrongThangGiaVN * 100 / m_dTongDoanhDuKienThuThongThangGiaVN);
                    txtTileDoanhThu.Text = iTiLeDoanhThu.ToString() + "%";
                }
                else txtTileDoanhThu.Text = "0%";
                ////
                m_dDoanhThuTrongThangGiaVN = 0;
                m_dDoanhThuTrongThangGiaNN = 0;
                m_dTongDoanhDuKienThuThongThangGiaVN = 0;
                m_dTongDoanhDuKienThuThongThangGiaNN = 0;
                m_iPhongThueCuaThang = 0;
                m_iTongSoNgayThue = 0;
                m_dGiaPhongVN = 0;
                m_dGiaPhongNN = 0;
            }
        }
        #endregion

        #region xử lý danh sách phòng
        private void XuLyDSPhong()
        {
            int iMaLP = 0;
            DataSet dsPhong = new DataSet();
            dsPhong = LapBaoCaoDoanhThuBUS.bLayDSPhong();
            foreach (DataRow drPhong in dsPhong.Tables[0].Rows)
            {
                iMaLP = int.Parse(drPhong["MaLP"].ToString());
            }
        }
        #endregion

        #region load doanh thu và mật độ
        private void LoadDoanhThuVaMatDo()
        {
            lvwDoanhThu.Items.Clear();
            lvwMatDo.Items.Clear();
            //load doanh thu
            DataSet dsDoanhThu = new DataSet();
            dsDoanhThu = LapBaoCaoDoanhThuBUS.bLayDSDoanhThu();
            int iSTT = 0;
            foreach (DataRow dr in dsDoanhThu.Tables[0].Rows)
            {
                iSTT++;
                ListViewItem item = new ListViewItem();
                item.Text = iSTT.ToString();
                item.SubItems.Add(dr["MADT"].ToString());
                item.SubItems.Add(dr["DTThang"].ToString());
                item.SubItems.Add(dr["DoanhThu"].ToString());
                item.SubItems.Add(dr["TyLeDT"].ToString());
                item.SubItems.Add(LapBaoCaoDoanhThuBUS.bLayTenLoaiPhongTheoMaPhong(int.Parse(dr["MaLP"].ToString())).ToString());
                item.SubItems.Add(dr["Thang"].ToString());
                lvwDoanhThu.Items.Add(item);
            }
            //
            //load mat do
            DataSet dsMatDo = new DataSet();
            dsMatDo = LapBaoCaoDoanhThuBUS.bLayDSMatDo();
            iSTT = 0;
            foreach (DataRow dr in dsMatDo.Tables[0].Rows)
            {
                iSTT++;
                ListViewItem item = new ListViewItem();
                item.Text = iSTT.ToString();
                item.SubItems.Add(dr["MaMD"].ToString());
                item.SubItems.Add(dr["MDThang"].ToString());
                item.SubItems.Add(dr["TyLeMD"].ToString());
                item.SubItems.Add(dr["MaPhong"].ToString());
                item.SubItems.Add(dr["Thang"].ToString());
                lvwMatDo.Items.Add(item);
            }
        }
        #endregion

        #region button xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (m_iflag == 1)
            {
                int iDong = lvwDoanhThu.SelectedItems.Count;
                int iDem = 0;
                if (iDong != 0)
                {
                    DialogResult ms = MessageBox.Show("Bạn muốn xóa " + iDong + " thông tin doanh thu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ms == DialogResult.Yes)
                    {
                        for (int i = 0; i < iDong; i++)
                        {
                            int iMaDT = int.Parse(lvwDoanhThu.SelectedItems[i].SubItems[1].Text);
                            if (LapBaoCaoDoanhThuBUS.bXoaDoanThu(iMaDT))
                            {
                                iDem++;

                            }
                        }
                    }
                    MessageBox.Show("Đã xóa " + iDem + " thông tin doanh thu", "Thông báo");
                }
            }
            else if (m_iflag == 2)
            {
                int iDong = lvwMatDo.SelectedItems.Count;
                int iDem = 0;
                if (iDong != 0)
                {
                    DialogResult ms = MessageBox.Show("Bạn muốn xóa " + iDong + " thông tin mật độ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ms == DialogResult.Yes)
                    {
                        for (int i = 0; i < iDong; i++)
                        {
                            int iMaMD = int.Parse(lvwMatDo.SelectedItems[i].SubItems[1].Text);
                            if (LapBaoCaoDoanhThuBUS.bXoaMatDo(iMaMD))
                            {
                                iDem++;

                            }
                        }
                    }
                    MessageBox.Show("Đã xóa " + iDem + " thông tin mật độ", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn thông tin cần xóa");
            }
            LoadDoanhThuVaMatDo();
            m_iflag = 0;
        }
        #endregion

        #region gắn cờ cho listview doanh thu và mật độ
        private void lvwDoanhThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_iflag = 1;
        }

        private void lvwMatDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_iflag = 2;
        }
        #endregion

        #region button thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlms = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlms == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion



    }
}