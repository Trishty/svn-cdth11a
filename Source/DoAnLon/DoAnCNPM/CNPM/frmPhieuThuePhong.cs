using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            btnLuu.Enabled = false;
        }
        #endregion

        #region Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {

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
        }
}