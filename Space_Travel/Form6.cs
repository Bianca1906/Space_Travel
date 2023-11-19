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
        private void numeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = true;
            textBox1.Text = "Jupiter este o derivare a lui Jove și pater (latină: tată). " +
                "Numele zeului a fost adoptat drept numele planetei Jupiter " +
                "și a fost punctul de plecare pentru numele zilei de joi a săptămânii " +
                "(rădăcina etimologică este mai vizibilă în limba franceză jeudi, de la Jovis Dies).";
        }

        private void posibilitateaExistențeiViețiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox2.Text = "Nu există dovezi concludente despre existența vieții pe Jupiter, " +
                "dar unele luni ale sale, cum ar fi Europa și Ganymede, prezintă potențial pentru existența apei" +
                " subterane lichide. Cu toate acestea, nu au fost găsite încă dovezi concrete privind existența vieții.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i <= 4)
            {
                pictureBox1.Image = imageList1.Images[i];
                i++;
            }
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

        private void pozeToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
         

        }

        private void pozeToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
    }
}
