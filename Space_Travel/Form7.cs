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
    public partial class Saturn : Form
    {
        public Saturn()
        {
            InitializeComponent();
        }
        int i;
        private void Saturn_Load(object sender, EventArgs e)
        {

        }

        private void numeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = true;
            textBox1.Text = "Numele Saturn derivă de la zeul omonim al mitologiei romane, omologul titanul Cronos," +
                " din mitologia greacă; simbolul său astronomic (♄) este o reprezentare stilizată a secerei zeului agriculturii.";
        }

        private void posibilitateaExistențeiViețiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox2.Text = "Saturn este o planetă gigant gazoasă și nu oferă condiții propice pentru existența vieții așa cum o cunoaștem." +
                "  Saturn nu are o suprafață solidă, iar atmosfera sa este compusă în mare parte din hidrogen și heliu. " +
                "Căutarea vieții se concentrează, în general, pe planetele sau luni care prezintă caracteristici care pot susține " +
                "existența apei lichide, deoarece apa este esențială pentru viața pe care o cunoaștem. Saturn nu pare să aibă astfel " +
                "de condiții, iar condițiile extreme de pe această planetă, inclusiv presiunea și temperatura, nu susțin existența vieții." +
                " În concluzie, până în prezent, nu există dovezi științifice care să susțină existența vieții pe Saturn.";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i <= 4)
            {
                pictureBox1.Image = imageList1.Images[i];
                i++;
            }
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
    }
}
