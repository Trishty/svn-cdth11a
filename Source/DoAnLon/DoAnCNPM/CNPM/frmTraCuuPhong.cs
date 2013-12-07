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
    public partial class frmTraCuuPhong : Form
    {
        public frmTraCuuPhong()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text != "")
            { 
                // Lấy dữ liệu
                TraCuuPhongDTO TCP_DTO = new TraCuuPhongDTO();
                TCP_DTO.StrMaPhong = txtMaPhong.Text;

                DataSet ds = TraCuuPhongBUS.TraCuuPhong(TCP_DTO);
                dgrvDanhSachPhong.Columns.Clear();
                dgrvDanhSachPhong.DataSource = ds.Tables[0];
                dgrvDanhSachPhong.Columns[0].HeaderText = "Mã Phòng";
                dgrvDanhSachPhong.Columns[1].HeaderText = "Loại Phòng";
                dgrvDanhSachPhong.Columns[2].HeaderText = "Đơn Giá";
                dgrvDanhSachPhong.Columns[3].HeaderText = "Tình Trạng";

                for (int i = 0; i < dgrvDanhSachPhong.Rows.Count - 1; i++)
                {
                    string strTT = dgrvDanhSachPhong.Rows[i].Cells[3].Value.ToString();
                    if (strTT == "0")
                        dgrvDanhSachPhong.Rows[i].Cells[3].Value = "Phòng trống";
                    else
                        if (strTT == "0")
                            dgrvDanhSachPhong.Rows[i].Cells[3].Value = "Phòng đã đặt";
                        else dgrvDanhSachPhong.Rows[i].Cells[3].Value = "Phòng đang sửa";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}