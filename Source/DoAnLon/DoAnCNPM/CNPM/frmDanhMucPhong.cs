using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace CNPM
{
    public partial class frmDanhMucPhong : Form
    {
        public frmDanhMucPhong()
        {
            InitializeComponent();
        }
        DanhMucPhongDTO dmDTO = new DanhMucPhongDTO();
        int iMaPhong = 0;
        int rownum = 0;
        Boolean bFlag = false;

        #region PageLoad
        private void frmDanhMucPhong_Load(object sender, EventArgs e)
        {
            CreateListView();
            dataGridView1.Enabled = false;
            btnLuu.Enabled = false;

            btnLuuTD.Enabled = false;
            txtPhong.Enabled = false;
            DataSet dsLoaiPhong = new DataSet();
            dsLoaiPhong = DanhMucPhongBUS.LayDanhSachLoaiPhong();
            cboLoaiPhong.Enabled = false;
            cboLoaiPhong.DataSource = dsLoaiPhong.Tables[0];
            cboLoaiPhong.DisplayMember = "TenLP";
            cboLoaiPhong.ValueMember = "MaLP";
            cboLoaiPhong.SelectedIndex = -1;
            cboTinhTrang.Enabled = false;
            cboTinhTrang.Items.Add("Còn phòng");
            cboTinhTrang.Items.Add("Có khách");
            cboTinhTrang.Items.Add("Sửa chữa");
            cboTinhTrang.SelectedIndex = -1;
            txtGhiChu.Enabled = false;

        }
        #endregion

        //Lập danh mục
        #region Tạo DataGridView
        private void CreateDataGridView()
        {
            dataGridView1.Columns.Clear();
            DataGridViewTextBoxColumn MaPhong = new DataGridViewTextBoxColumn();
            DataGridViewComboBoxColumn LoaiPhong = new DataGridViewComboBoxColumn();
            //DataGridViewComboBoxColumn TinhTrang = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn TinhTrang = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn GhiChu = new DataGridViewTextBoxColumn();

            DataSet dsLoaiPhong = new DataSet();
            dsLoaiPhong = DanhMucPhongBUS.LayDanhSachLoaiPhong();
            LoaiPhong.DataSource = dsLoaiPhong.Tables[0];
            LoaiPhong.DisplayMember = "TenLP";
            LoaiPhong.ValueMember = "MaLP";

            //TinhTrang.Items.Add("Cón trống");
            //TinhTrang.Items.Add("Có khách");
            //TinhTrang.Items.Add("Sửa chữa");

            MaPhong.HeaderText = "Mã Phòng";
            LoaiPhong.HeaderText = "Loại Phòng";
            TinhTrang.HeaderText = "Tình Trạng";
            GhiChu.HeaderText = "Ghi Chú";

            dataGridView1.Columns.Add(MaPhong);
            dataGridView1.Columns.Add(LoaiPhong);
            dataGridView1.Columns.Add(TinhTrang);
            dataGridView1.Columns.Add(GhiChu);

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 200;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
        }
        #endregion

        #region Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int iDong = dataGridView1.Rows.Count - 1;
            for (int i = 0; i < iDong; i++)
            {
                dmDTO.MaPhong = dataGridView1.Rows[i].Cells[0].Value.ToString();
                dmDTO.LoaiPhong = dataGridView1.Rows[i].Cells[1].Value.ToString();
                //string strTinhTrang = dataGridView1.Rows[i].Cells[2].Value.ToString();
                //if (strTinhTrang == "Cón trống")
                //    dmDTO.TinhTrang = "0";
                //if (strTinhTrang == "Có khách")
                //    dmDTO.TinhTrang = "1";
                //if (strTinhTrang == "Sửa chữa")
                //    dmDTO.TinhTrang = "2";
                string strTinhTrang = dataGridView1.Rows[i].Cells[2].Value.ToString();
                if (strTinhTrang == "Còn trống")
                    dmDTO.TinhTrang = "0";
                if (dataGridView1.Rows[i].Cells[3].Value != null)
                    dmDTO.GhiChu = dataGridView1.Rows[i].Cells[3].Value.ToString();
                else
                    dmDTO.GhiChu = "";
                if (DanhMucPhongBUS.ThemPhong(dmDTO) == false)
                {
                    MessageBox.Show("Thêm danh mục phòng thất bại!");
                    break;
                }
                else
                {
                    CreateListView();
                }
            }
            bFlag = false;
            dataGridView1.Enabled = false;
            dataGridView1.DataSource = null;
            CreateDataGridView();
            btnLuu.Enabled = false;

        }
        #endregion

        #region Làm mới
        private void btnHuy_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            dataGridView1.DataSource = null;
            CreateDataGridView();
            iMaPhong = DanhMucPhongBUS.LayMaPhongTuDong();
            dataGridView1.Rows[0].Cells[0].Value = iMaPhong + 1;
            dataGridView1.Rows[0].Cells[2].Value = "Còn trống";
            bFlag = true;
            btnLuu.Enabled = true;
        }
        #endregion

        #region Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Thêm dòng
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (bFlag)
            {
                iMaPhong += 1;
                dataGridView1.Rows[rownum].Cells[0].Value = iMaPhong;
                rownum += 1;
            }
        }
        #endregion

        //Sửa danh mục
        #region tạo ListView
        private void CreateListView()
        {
            lvwDMPhong.Columns.Clear();
            lvwDMPhong.View = View.Details;
            lvwDMPhong.GridLines = true;
            lvwDMPhong.FullRowSelect = true;
            ColumnHeader clMaPhong = new ColumnHeader();
            clMaPhong.Text = "Mã Phòng";
            clMaPhong.Width = 130;

            ColumnHeader clMaLP = new ColumnHeader();
            clMaLP.Text = "Loại Phòng";
            clMaLP.Width = 130;

            ColumnHeader clTinhTrang = new ColumnHeader();
            clTinhTrang.Text = "Tình Trạng";
            clTinhTrang.Width = 130;

            ColumnHeader clGhiChu = new ColumnHeader();
            clGhiChu.Text = "Ghi Chú";
            clGhiChu.Width = 200;

            lvwDMPhong.Columns.Add(clMaPhong);
            lvwDMPhong.Columns.Add(clMaLP);
            lvwDMPhong.Columns.Add(clTinhTrang);
            lvwDMPhong.Columns.Add(clGhiChu);

            lvwDMPhong.Items.Clear();
            DataSet dsDMPhong = new DataSet();
            dsDMPhong = DanhMucPhongBUS.LayDanhSachPhong();
            foreach (DataRow drw in dsDMPhong.Tables[0].Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = drw["MaPhong"].ToString();

                dmDTO.LoaiPhong = drw["MaLP"].ToString();
                lvi.SubItems.Add(DanhMucPhongBUS.LayTenPhong(dmDTO));

                if (drw["TinhTrang"].ToString() == "0")
                {
                    lvi.SubItems.Add("Còn phòng");
                }
                else
                    if (drw["TinhTrang"].ToString() == "1")
                    {
                        lvi.SubItems.Add("Có khách");
                    }
                    else
                        lvi.SubItems.Add("Sửa chữa");

                lvi.SubItems.Add(drw["GhiChu"].ToString());

                lvwDMPhong.Items.Add(lvi);
            }
        }
        #endregion

        #region Chọn
        private void lvwDMPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDMPhong.SelectedItems != null)
            {
                cboLoaiPhong.Enabled = true;
                cboTinhTrang.Enabled = true;
                txtGhiChu.Enabled = true;
                btnLuuTD.Enabled = true;
                foreach (ListViewItem lvi in lvwDMPhong.SelectedItems)
                {
                    txtPhong.Text = lvi.SubItems[0].Text;

                    cboLoaiPhong.Text = lvi.SubItems[1].Text;

                    if (lvi.SubItems[2].Text == "Còn phòng")
                        cboTinhTrang.SelectedIndex = 0;
                    else if (lvi.SubItems[2].Text == "Có khách")
                        cboTinhTrang.SelectedIndex = 1;
                    else
                        cboTinhTrang.SelectedIndex = 2;

                    txtGhiChu.Text = lvi.SubItems[3].Text;
                }
            }
            else
            {
                cboLoaiPhong.Enabled = false;
                cboTinhTrang.Enabled = false;
                txtGhiChu.Enabled = false;
                btnLuuTD.Enabled = false;
            }
        }
        #endregion

        #region Lưu
        private void btnLuuTD_Click(object sender, EventArgs e)
        {
            if (lvwDMPhong.SelectedItems != null)
            {
                dmDTO.MaPhong = txtPhong.Text;
                dmDTO.LoaiPhong = cboLoaiPhong.SelectedValue.ToString();
                if (cboTinhTrang.SelectedIndex == 0)
                    dmDTO.TinhTrang = "0";
                else if (cboTinhTrang.SelectedIndex == 1)
                    dmDTO.TinhTrang = "1";
                else
                    dmDTO.TinhTrang = "2";
                dmDTO.GhiChu = txtGhiChu.Text;

                if (DanhMucPhongBUS.SuaPhong(dmDTO) == false)
                {
                    MessageBox.Show("Sửa danh mục phòng thất bại!");
                }
                else
                    CreateListView();

                btnLuuTD.Enabled = false;
            }
        }
        #endregion

        #region Thoát
        private void btnThoatTD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}