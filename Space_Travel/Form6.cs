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
    public partial class Jupiter : Form
    {
        public Jupiter()
        {
            InitializeComponent();
        }

        private void Jupiter_Load(object sender, EventArgs e)
        {

        }
        int i;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void istoricNumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = true;
            textBox1.Text = "Mercur și-a lăsat numele în denumirea zilei săptămânii care urmează după marți, " +
                "și anume miercuri, din sintagma latină: Mercurii dies / Mercuris dies.";
        }

        private void posibilitateaExistențeiViețiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox2.Text = "În 1974, sonda Mariner 10, aparţinând NASA, a survolat planeta Mercur şi a observat terenul accidentat, " +
                "presărat cu cratere. În prezent, conform unei noi teorii, aspectul haotic al peisajului ar putea fi rezultatul acţiunii substanţelor " +
                "volatile - elemente şi compuşi care pot trece uşor dintr-o stare de agregare în alta - din subsolul planetei." +
                "Substanţele volatile, categorie de substanţe din care face parte şi apa, sunt esenţiale pentru apariţia şi " +
                "susţinerea vieţii aşa cum este aceasta pe Pământ. Astfel, potenţiala lor prezenţă pe Mercur are implicaţii interesante." +
                " Noul studiu, coordonat de Alexis P.Rodriguez, cercetător la Institutul de Ştiinţe Planetare din Arizona, " +
                "a examinat îndeaproape caracteristicile peisajului haotic de pe Mercur şi posibilitatea ca acesta să fie rezultatul " +
                "acţiunii substanţelor volatile din subsol. La suprafaţă, temperaturile medii pe Mercur sunt suficient de ridicate pentru " +
                "a topi plumbul, motiv din care oamenii de ştiinţă au presupus dintotdeauna că această planetă este complet inospitalieră " +
                "pentru viaţă.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i <= 4)
            {
                pictureBox1.Image = imageList1.Images[i];
                i++;
            }
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
    }
}
