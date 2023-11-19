using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Travel
{
    public partial class Venus : Form
    {
        public Venus()
        {
            InitializeComponent();
        }
        int i;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }
        private void numeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = true;
            textBox1.Text = "Venus cunoscut și ca Luceafărul este a doua planetă de la Soare. " +
                "Este numită după zeița romană a iubirii și frumuseții.";

        }

        private void posibilitateaExistențeiViețiiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox2.Text = "Posibilitatea existenței vieții pe Venus a fost mult timp un subiect de speculații, " +
                "iar în ultimii ani s-au făcut cercetări active în acest sens. În urma unei observații din 2019 conform căreia " +
                "absorbția luminii straturilor de nori superiori a fost în concordanță cu prezența microorganismelor, " +
                "un articol din septembrie 2020 din Nature Astronomy a anunțat detectarea gazului fosfină, un biomarker," +
                " în concentrații mai mari decât poate fi explicat de orice sursă abiotică cunoscută. Cu toate acestea, " +
                "s-au exprimat îndoieli cu privire la aceste observații din cauza problemelor de prelucrare a datelor și " +
                "a eșecului de a detecta fosfina la alte lungimi de undă. Până la sfârșitul lunii octombrie 2020, re-analiza " +
                "datelor cu o scădere adecvată a condițiilor nu a dus la detectarea fosfinei. ";
        }

        private void pozeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            pictureBox1.Visible = true;
            play.Visible = true;
            pause.Visible = true;
            stop.Visible = true;
            inutil1.Visible = true;
            inutil2.Visible = true;
            i = 0;
        }

        private void curiozitățiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            play.Visible = false;
            pause.Visible = false;
            stop.Visible = false;
            inutil1.Visible = false;
            inutil2.Visible = false;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (i <= 4)
            {
                pictureBox1.Image = imageList1.Images[i];
                i++;
            }
        }

        private void play_Click_1(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            pictureBox1.Visible = true;
            timer1.Enabled = true;
        }

        private void pause_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void stop_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            play.Visible = false;
            pause.Visible = false;
            stop.Visible = false;
            inutil1.Visible = false;
            inutil2.Visible = false;
        }
    }
}

