using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmQLKS : Form
    {
        private int childFormNumber = 0;

        public frmQLKS()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new Form();
            // Make it a child of this MDI form before showing it.
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            /*
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                // TODO: Add code here to open the file.
            }
            */
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                // TODO: Add code here to save the current contents of the form to a file.
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard.GetText() or System.Windows.Forms.GetData to retrieve information from the clipboard.
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmQLKS_Load(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = "Quản Lý Khách Sạn";
            timer1.Enabled = true;
            timer1.Start();
            toolBarToolStripMenuItem.Checked = false;
            toolStrip.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = DateTime.Now.ToString();
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                toolStripStatusLabel1.Text = activeChild.Text;
            }
            else
                toolStripStatusLabel1.Text = "Quản Lý Khách Sạn";
        }

        private void LapDanhMucPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LapHoaDonThanhToanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon Child = new frmHoaDon();
            Child.MdiParent = this;
            Child.Show();
        }

        private void TraCuuPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuPhong child = new frmTraCuuPhong();
            child.MdiParent = this;
            child.Show();
        }

        private void LapPhieuThuePhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuThuePhong Child = new frmPhieuThuePhong();
            Child.MdiParent = this;
            Child.Show();
        }

        private void ThayDoiQuiDinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiCacQuyDinh Child = new frmThayDoiCacQuyDinh();
            Child.MdiParent = this;
            Child.Show();
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien child = new frmQuanLyNhanVien();
            child.MdiParent = this;
            child.Show();
        }

        private void dangnhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap child = new frmDangNhap();
            child.MdiParent = this;
            child.Show();
        }

        private void LapBaoCaoThangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLapBaoCaoDoanhThu child = new frmLapBaoCaoDoanhThu();
            child.MdiParent = this;
            child.Show();
        }
    }
}
