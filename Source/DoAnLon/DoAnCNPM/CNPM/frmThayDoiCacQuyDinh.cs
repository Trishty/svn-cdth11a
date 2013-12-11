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
    public partial class frmThayDoiCacQuyDinh : Form
    {
        public frmThayDoiCacQuyDinh()
        {
            InitializeComponent();
        }
        private void frmThayDoiCacQuyDinh_Load(object sender, EventArgs e)
        {
            LoadCombobox();
        }
        
        private void LoadCombobox()
        {
            DataSet dsLoaiPhong = new DataSet();
            dsLoaiPhong = LapBaoCaoDoanhThuBUS.bLayDanhSachLoaiPhong();
            //
            cbbSoLuongPhong.DataSource = dsLoaiPhong.Tables[0];
           // cbbSoLuongPhong.DisplayMember =  tenlp;
           // cbbSoLuongPhong.ValueMember = "malp";
            //
        }
    }
}