using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;
using System.IO;

namespace CNPM
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        #region button đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtTen.Text.Trim()) && "".Equals(txtMatKhau.Text.Trim()))
            {
                MessageBox.Show("Chưa nhập thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                txtTen.BackColor = Color.Red;
                txtMatKhau.BackColor = Color.Red;
            }
            else if ("".Equals(txtTen.Text.Trim()))
            {
                MessageBox.Show("Chưa nhập tên người dùng!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTen.Focus();
                txtTen.BackColor = Color.Red;
            }
            else if ("".Equals(txtMatKhau.Text.Trim()))
            {
                MessageBox.Show("Chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                txtMatKhau.BackColor = Color.Red;
            }
            else 
            {
                DangNhapDTO dn = new DangNhapDTO();
                dn.TenDN = txtTen.Text.Trim();
                dn.MatKhau = txtMatKhau.Text.Trim();
                int iKiemTraDN = 0;
                iKiemTraDN = int.Parse(DangNhapBUS.bKiemTraDanhNhap(dn));
                if (iKiemTraDN == 0)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTen.Focus();
                }
                else
                {
                    FileStream fs = new FileStream("GhiNhoTaiKhoan.txt", FileMode.Append);
                    StreamWriter writeFile = new StreamWriter(fs, Encoding.UTF8);
                    if (chkGhiNho.Checked == true)
                    {
                        writeFile.WriteLine(txtMatKhau.Text);
                        writeFile.WriteLine(txtTen.Text);           
                        writeFile.Flush();
                    }
                    writeFile.Close();
                    //
                    frmMain fm = new frmMain();
                    fm.Show();
                    this.Hide();
                }
            
            }
        }
        #endregion

        #region xử lý nút enter esc
        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnThoat_Click(sender, e);
            }
        }
        #endregion

        #region button thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlms = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlms == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region gán màu trắng cho textbox và lấy pass nếu đã ghi nhớ
        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtTen.BackColor = Color.White;
            try
            {
                string[] lines = File.ReadAllLines("GhiNhoTaiKhoan.txt");
                int iDong = lines.Length;
                for (int i = iDong-1; i >= 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        if (txtTen.Text == lines[i])
                        {
                            txtMatKhau.Text = lines[i + 1];
                            txtTen.BackColor = Color.Beige;
                            txtMatKhau.BackColor = Color.Beige;
                            break;

                        }
                        else
                        {
                            txtMatKhau.Clear();
                            txtTen.BackColor = Color.White;
                            txtMatKhau.BackColor = Color.White;
                        }
                    }
                }
                
           }
           catch { }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.BackColor = Color.White;
        }
        #endregion

        #region form load
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (!File.Exists("GhiNhoTaiKhoan.txt"))
            {
                FileStream fs;
                fs = new FileStream("GhiNhoTaiKhoan.txt", FileMode.Create);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                sWriter.Flush();
                fs.Close();
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}