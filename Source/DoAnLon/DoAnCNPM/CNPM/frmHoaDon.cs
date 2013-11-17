using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        int iSTT = 0;
        int rownum = 0;

        #region PageLoad
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            btnTinh.Enabled = false;
            btnLuu.Enabled = false;
        }
        #endregion

        #region Tính
        private void btnTinh_Click(object sender, EventArgs e)
        {
            double dTriGia = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                double dTongTien = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                dTriGia += dTongTien;
                txtTriGia.Text = dTriGia.ToString();
            }
            btnTinh.Enabled = false;
            btnLuu.Enabled = true;
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
            txtMaHD.Text = "";
            txtMaKH.Text = "";
            txtMaNV.Text = "";
            txtTenKH.Text = "";
            txtDC.Text = "";
            txtTriGia.Text = "";       
            iSTT = 0;
            rownum = 0;
            dataGridView1.Rows.Clear();
            btnTinh.Enabled = false;
            btnLuu.Enabled = false;
        }
        #endregion

        #region Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Cột thay đổi
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                double dSLKH = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                if (dSLKH == 3)
                    dataGridView1.Rows[i].Cells[5].Value = "25";
                else
                    dataGridView1.Rows[i].Cells[5].Value = "0";

                if (dataGridView1.Rows[i].Cells[3].Value != "" 
                    && dataGridView1.Rows[i].Cells[4].Value != "")
                {
                    double dSoNgayThue = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    double dDonGia = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                    double dPhuThu = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    double dHeSo = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                    double dThanhTien = dSoNgayThue * dDonGia + (dDonGia*(dPhuThu / 100)) * dHeSo;
                    dataGridView1.Rows[i].Cells[4].Value = dThanhTien.ToString();
                    btnTinh.Enabled = true;
                    btnLuu.Enabled = false;
                }
                else
                    dataGridView1.Rows[i].Cells[4].Value = "";  
            }
        }
        #endregion

        #region Tạo STT tự động
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            iSTT += 1;
            dataGridView1.Rows[rownum].Cells[0].Value = iSTT;
            rownum += 1;
        }
        #endregion
    }
}