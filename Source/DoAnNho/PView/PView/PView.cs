using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test
{
    public partial class PView : Form, IMessageFilter
    {
        public PView()
        {
            InitializeComponent();
        }

        string path;
        int vitri;

        //Page Load
        private void Form3_Load(object sender, EventArgs e)
        {
            //Application.AddMessageFilter(this);
            openFileDialog1.Filter = "Video, Music Files (*.mp3, *.wav, *.wma, *.avi, *wmv, *.mpg)|*.mp3;*.wav;*.wma;*.avi;*wmv;*.mpg";
            openFileDialog2.Filter = "Video, Music Files (*.mp3, *.wav, *.wma, *.avi, *wmv, *.mpg)|*.mp3;*.wav;*.wma;*.avi;*wmv;*.mpg";
            openFileDialog3.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            openFileDialog4.Filter = "Txt Files (*.txt)|*.txt";
            controlToolStripMenuItem.Enabled = false;
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.uiMode = "none";
            trackBar1.Value = 50;
            listBox1.Visible = false;
            pictureBox1.Visible = false;
            btnPre.Visible = false;
            btnPlay.Visible = false;
            btnPause.Visible = false;
            btnStop.Visible = false;
            btnNext.Visible = false;
            btnFS.Visible = false;
            btnmute.Visible = false;
            trackBar1.Visible = false;
            trackBar2.Visible = false;
            chksf.Visible = false;
            chkre.Visible = false;
        }


        private void PView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.RemoveMessageFilter(this);
        }

        #region IMessageFilter Members
        private const UInt32 WM_KEYDOWN = 0x0100;
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_KEYDOWN)
            {
                Keys keyCode = (Keys)(int)m.WParam & Keys.KeyCode;
                if (keyCode == Keys.F8)
                {
                    if (this.axWindowsMediaPlayer1.settings.mute == true)
                    {
                        this.axWindowsMediaPlayer1.settings.mute = false;
                        btnmute.ImageIndex = 0;
                    }
                    else
                    {
                        this.axWindowsMediaPlayer1.settings.mute = true;
                        btnmute.ImageIndex = 1;
                    }
                }
                if (keyCode == Keys.F9)
                {
                    this.axWindowsMediaPlayer1.settings.volume -= 10;
                    if (trackBar1.Value > 0)
                        trackBar1.Value -= 10;
                }
                if (keyCode == Keys.F10)
                {
                    this.axWindowsMediaPlayer1.settings.volume += 10;
                    if (trackBar1.Value < 100)
                        trackBar1.Value += 10;
                }
                if (keyCode == Keys.F11)
                {
                    this.axWindowsMediaPlayer1.fullScreen = true;
                    //this.axWindowsMediaPlayer1.uiMode = "full";
                }
                if (keyCode == Keys.F12)
                {
                    this.axWindowsMediaPlayer1.fullScreen = false;
                    this.axWindowsMediaPlayer1.uiMode = "none";
                }

                return true;
            }
            return false;
        }
        #endregion

        //List Box selected
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vitri = listBox1.SelectedIndex;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.URL = path + listBox1.Items[vitri].ToString();
        }

        //Open Image
        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.Visible = false;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                listBox1.Visible = false;
                pictureBox1.Visible = false;
                btnPre.Visible = false;
                btnPlay.Visible = false;
                btnPause.Visible = false;
                btnStop.Visible = false;
                btnNext.Visible = false;
                btnFS.Visible = false;
                btnmute.Visible = false;
                trackBar1.Visible = false;
                trackBar2.Visible = false;
                pictureBox1.Visible = true;
                chksf.Visible = false;
                chkre.Visible = false;
                pictureBox1.ImageLocation = openFileDialog3.FileName;
            }
        }

        //Timer timebar (track2)
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (trackBar2.Value < trackBar2.Maximum)
                trackBar2.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            else
                trackBar2.Value = trackBar2.Minimum;
        }

        //Media playstate
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3)
               trackBar2.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
                {
                    if (listBox1.SelectedIndex < listBox1.Items.Count)
                    {
                        if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
                            listBox1.SelectedIndex = 0;
                        else
                            listBox1.SelectedIndex += 1;
                    }
                }
        }

        //Change timebar position
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar2.Value;
        }

        //Change volume
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        //Pre media
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != 0)
            {
                listBox1.SelectedIndex -= 1;
                axWindowsMediaPlayer1.URL = path + listBox1.Items[vitri].ToString();
            }
        }

        //Play media
        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        //Pause media
        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        //Stop media
        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        //Next media
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count)
            {
                if(listBox1.SelectedIndex == listBox1.Items.Count - 1)
                    listBox1.SelectedIndex = 0;
                else
                    listBox1.SelectedIndex += 1;
                axWindowsMediaPlayer1.URL = path + listBox1.Items[vitri].ToString();
            }
        }

        //FullScreen
        private void btnFS_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "full";
            axWindowsMediaPlayer1.fullScreen = true;   
        }

        //Mute
        private void btnmute_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.settings.mute == true)
            {
                axWindowsMediaPlayer1.settings.mute = false;
                btnmute.ImageIndex = 0;
            }
            else
            {
                axWindowsMediaPlayer1.settings.mute = true;
                btnmute.ImageIndex = 1;
            }
        }

        //Controls Tool Strip Menu
        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFS_Click(sender, e);
        }

        private void preToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPre_Click(sender, e);
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNext_Click(sender, e);
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPlay_Click(sender, e);
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPause_Click(sender, e);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);
        }

        private void muteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnmute_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialrs;
            dialrs = MessageBox.Show("Do you want to exit PView?", "Announcement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialrs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Open 1 media file
        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.AddMessageFilter(this);
                listBox1.Items.Clear();
                controlToolStripMenuItem.Enabled = true;
                preToolStripMenuItem.Enabled = false;
                nextToolStripMenuItem.Enabled = false;
                btnPre.Enabled = false;
                btnNext.Enabled = false;
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                axWindowsMediaPlayer1.Visible = true;
                listBox1.Visible = false;
                pictureBox1.Visible = true;
                btnPre.Visible = true;
                btnPlay.Visible = true;
                btnPause.Visible = true;
                btnStop.Visible = true;
                btnNext.Visible = true;
                btnFS.Visible = true;
                btnmute.Visible = true;
                trackBar1.Visible = true;
                trackBar2.Visible = true;
                pictureBox1.Visible = false;
                chksf.Visible = false;
                chksf.Enabled = false;
                chkre.Visible = true;
            }
        }

        //Open multi media files
        private void multiFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                Application.AddMessageFilter(this);
                listBox1.Items.Clear();
                foreach (string media in openFileDialog2.SafeFileNames)
                {
                    string fullPath = openFileDialog2.FileName;
                    string fileName = openFileDialog2.SafeFileName;
                    path = fullPath.Replace(fileName, "");
                    listBox1.Items.Add(media);
                }

                if (listBox1.Items.Count > 0)
                {
                    vitri = 0;
                    listBox1.SelectedIndex = 0;
                    axWindowsMediaPlayer1.URL = path + listBox1.Items[vitri].ToString(); 
                }

                controlToolStripMenuItem.Enabled = true;
                preToolStripMenuItem.Enabled = true;
                nextToolStripMenuItem.Enabled = true;
                btnPre.Enabled = true;
                btnNext.Enabled = true;
                axWindowsMediaPlayer1.Visible = true;
                listBox1.Visible = true;
                pictureBox1.Visible = true;
                btnPre.Visible = true;
                btnPlay.Visible = true;
                btnPause.Visible = true;
                btnStop.Visible = true;
                btnNext.Visible = true;
                btnFS.Visible = true;
                btnmute.Visible = true;
                trackBar1.Visible = true;
                trackBar2.Visible = true;
                pictureBox1.Visible = false;
                chksf.Visible = false;
                chksf.Enabled = true;
                chkre.Visible = true;
            }
        }

        //Increase volume
        private void PView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                axWindowsMediaPlayer1.settings.volume += 10;
                if (trackBar1.Value < 100)
                    trackBar1.Value += 10;
            }
        }

        //Hot Keys
        private void hotKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strhotkeys = "Hot Keys list ";
            strhotkeys += "\nF8  - Mute";
            strhotkeys += "\nF9 - Increase Volume";
            strhotkeys += "\nF10 - Decrease Volume";
            strhotkeys += "\nF11 - FullScreen";
            strhotkeys += "\nF12 - Exit FullScreen";
            MessageBox.Show(strhotkeys, "Hot Keys", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //About
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strinfo = "PView made by Group 4 \nClass CDTH11A \nCao Thang Technical College";
            MessageBox.Show(strinfo, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);   
        }

        //Repeat
        private void chkre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkre.Checked)
                axWindowsMediaPlayer1.settings.setMode("loop", true);
            else
                axWindowsMediaPlayer1.settings.setMode("loop", false);
        }

        //Shuffle
        private void chksf_CheckedChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int iIndex = rnd.Next(0, listBox1.Items.Count);
            if (chksf.Checked)
            {
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
                    listBox1.SelectedIndex = iIndex;
            }
        }

        //Save Playlist
        private void savePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Luu = new SaveFileDialog();
            Luu.Filter = "TXT file(*.txt)|*.txt";
            Luu.ShowDialog();
            //
            string strLuu = "";
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                strLuu += path + listBox1.Items[i].ToString() + Environment.NewLine;
            }
            //
            string strName = Luu.FileName;
            File.WriteAllText(strName, strLuu);
        }

        //Open Playlist
        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {
                Application.AddMessageFilter(this);
                listBox1.Items.Clear();
                string strPlaylist = openFileDialog4.FileName.ToString();

                StreamReader sr = new StreamReader(@strPlaylist);
                string strLine = "";
                while ((strLine = sr.ReadLine()) != null)
                {
                    string ilst = "";
                    ilst = strLine.Substring(strLine.LastIndexOf("\\") + 1);
                    path = strLine.Replace(ilst, "");
                    listBox1.Items.Add(ilst);
                }

                if (listBox1.Items.Count > 0)
                {
                    vitri = 0;
                    listBox1.SelectedIndex = 0;
                    axWindowsMediaPlayer1.URL = path + listBox1.Items[vitri].ToString();
                }

                controlToolStripMenuItem.Enabled = true;
                preToolStripMenuItem.Enabled = true;
                nextToolStripMenuItem.Enabled = true;
                btnPre.Enabled = true;
                btnNext.Enabled = true;
                axWindowsMediaPlayer1.Visible = true;
                listBox1.Visible = true;
                pictureBox1.Visible = true;
                btnPre.Visible = true;
                btnPlay.Visible = true;
                btnPause.Visible = true;
                btnStop.Visible = true;
                btnNext.Visible = true;
                btnFS.Visible = true;
                btnmute.Visible = true;
                trackBar1.Visible = true;
                trackBar2.Visible = true;
                pictureBox1.Visible = false;
                chksf.Visible = false;
                chksf.Enabled = true;
                chkre.Visible = true;
            }
        }
    }
}