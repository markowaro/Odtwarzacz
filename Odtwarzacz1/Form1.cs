using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odtwarzacz1
{
    public partial class Form1 : Form
    {
        string[] files, paths;
        double savedPosition;
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 50;
            label2.Text = 50 + "%";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSTOP_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            progressBar1.Value = 0;
        }

        private void buttonPAUSE_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            savedPosition = player.Ctlcontrols.currentPosition;
        }

        private void buttonPLAY_Click(object sender, EventArgs e)
        {
            if(listView1.FocusedItem == null)
            {
                MessageBox.Show("Nie wybrano utworu");
                return;
            }
            player.URL = paths[listView1.FocusedItem.Index];
            player.Ctlcontrols.play();
            player.Ctlcontrols.currentPosition = savedPosition;
        }

        private void buttonREMOVE_Click(object sender, EventArgs e)
        {
            //remove selected item from listview
            for(int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listView1.Items.Remove(listView1.SelectedItems[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)player.Ctlcontrols.currentPosition;
            }
            try
            {
                labelSTART.Text = player.Ctlcontrols.currentPositionString;
                labelSONG_LENGTH.Text = player.Ctlcontrols.currentItem.durationString;
            }
            catch
            {

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
            label2.Text = trackBar1.Value.ToString() + "%";
        }

        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / progressBar1.Width;
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for(int i = 0; i < files.Length; i++)
                {
                    string fileName = Path.GetFileName(files[i]);
                    listView1.Items.Add(fileName);
                }
            }
        }
    }
}
