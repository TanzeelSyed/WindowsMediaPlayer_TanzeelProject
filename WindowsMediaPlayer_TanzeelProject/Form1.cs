using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMediaPlayer_TanzeelProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Browse MP3 or MP4 Video File";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string F in openFileDialog1.FileNames) 
            { 
                media.URL=openFileDialog1.FileName;
                listBox1.Items.Add(F);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            media.URL = listBox1.Text;
        }
    }
}
