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
    public partial class Pluto : Form
    {
        public Pluto()
        {
            InitializeComponent();
        }
        int i;
        private void numeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = true;
            textBox1.Text = "Numele Pluto, după zeul grec/roman al lumii subterane, a fost propus de Venetia Burney (1918–2009)," +
                " o elevă de unsprezece ani din Oxford, Anglia, care era interesată de mitologia clasică." +
                " Ea a sugerat denumirea într-o conversație cu bunicul ei Falconer Madan, un fost bibliotecar " +
                "la Biblioteca Bodleian a Universității din Oxford, care a spus apoi numele profesorului de astronomie Herbert Hall Turner," +
                " care la rândul săi l-a transmis prin cablu colegilor din Statele Unite.";
        }

        private void posibilitateaExistențeiViețiiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox2.Text = "Planeta Pluto nu mai exista, dar cu toate acestea Pluto era o lume extrem de rece, " +
                "cu temperaturi foarte scăzute, iar atmosfera sa era subțire și compusă în principal din azot și metan." +
                " Nu exista apă lichidă la suprafață, iar lipsa unei atmosfere dense contribuie la imposibilitatea existenței " +
                "unui mediu stabil pentru forme de viață cunoscute.";
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

        private void curiozitățiToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void play_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            pictureBox1.Visible = true;
            timer1.Enabled = true;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            play.Visible = false;
            pause.Visible = false;
            stop.Visible = false;
            inutil1.Visible = false;
            inutil2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i <= 4)
            {
                pictureBox1.Image = imageList1.Images[i];
                i++;
            }
        }
    }
}
