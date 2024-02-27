using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSpotifyClone
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarCancionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReadSong formReadSong = new FormReadSong();
            formReadSong.ShowDialog();
        }

        private void cancionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
