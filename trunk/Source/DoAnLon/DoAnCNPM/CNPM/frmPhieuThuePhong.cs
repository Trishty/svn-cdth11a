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
    public partial class frmPhieuThuePhong : Form
    {
        public frmPhieuThuePhong()
        {
            InitializeComponent();
        }

        int iSTT = 0;
        int rownum = 0;

        #region PageLoad
        private void frmPhieuThuePhong_Load(object sender, EventArgs e)
        {
            txtMa.Enabled = false;
            btnLuu.Enabled = false;
        }
        #endregion

        #region Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //lay thong tin phieu thue
            PhieuThueDTO ptDTO = new PhieuThueDTO();
            ptDTO.MaPT = txtMa.Text;
            ptDTO.Phong = txtPhong.Text;
            ptDTO.NgayThue = dtThue.Text;
            ptDTO.NgayTra = dtTra.Text;
            if (PhieuThueBUS.ThemPT(ptDTO) == true)
            {
                MessageBox.Show("Lập phiếu thuê thành công!");
            }
            else
            {
                MessageBox.Show("Lập phiếu thuê thất bại!");
            }
            btnLuu.Enabled = false;
        }
        #endregion

        #region Huỷ
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtPhong.Text = "";
            //dtThue.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtTra.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            iSTT = 0;
            rownum = 0;
            dataGridView1.Rows.Clear();
            //dataGridView1.Refresh();
            btnLuu.Enabled = false;
        }
        #endregion

        #region Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Tạo STT tự động
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
                iSTT += 1;
                dataGridView1.Rows[rownum].Cells["STT"].Value = iSTT;
                rownum += 1;
            //}
        }
        #endregion

        #region Mở nút Lưu
        private void txtPhong_TextChanged(object sender, EventArgs e)
        {
            if(txtPhong.Text != "")
                btnLuu.Enabled = true;
            else
                btnLuu.Enabled = false;
        }
        #endregion
    }
}