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
    public partial class Neptun : Form
    {
        public Neptun()
        {
            InitializeComponent();
        }
        int i;
        private void Neptun_Load(object sender, EventArgs e)
        {

        }

        private void numeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = true;
            play.Visible = false;
            pause.Visible = false;
            stop.Visible = false;
            inutil1.Visible = false;
            inutil2.Visible = false;
            textBox1.Text = "Cele mai multe limbi de astăzi, chiar și în țările care nu au " +
                "legătură directă cu cultura greco-romană, utilizează câteva variante ale denumirii" +
                " „Neptun” pentru planetă; în limba chineză, japoneză și coreeană, denumirea planetei " +
                "a fost tradusă literal ca „steaua regele mării” (海王星), dat fiind că Neptun este zeul mărilor." +
                " În limba greacă modernă, planeta se numește Poseidon (Ποσειδώνας: Poseidonas), omologul grec al zeului Neptun.";
        }

        private void posibilitateaExistențeiViețiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            play.Visible = false;
            pause.Visible = false;
            stop.Visible = false;
            inutil1.Visible = false;
            inutil2.Visible = false;
            textBox2.Text = "Neptun este o planetă gazoasă și extrem de rece din sistemul solar." +
                " Cu toate acestea, condițiile de pe Neptun sunt considerate și mai extreme, cu temperaturi" +
                " mai scăzute și vânturi puternice care suflă prin atmosfera sa densă, compusă în principal " +
                "din hidrogen, heliu și metan. Nu există dovezi sau date care să susțină existența vieții pe Neptun. " +
                "În general, căutarea vieții se concentrează pe planetele sau luni care prezintă caracteristici care" +
                " pot susține existența apei lichide, un ingredient esențial pentru viața pe care o cunoaștem. " +
                "Condițiile extreme de pe Neptun, în special temperatura extrem de scăzută și absența unei suprafețe solide," +
                " nu par să ofere mediul potrivit pentru susținerea vieții. Până în prezent, cercetările și observațiile nu au " +
                "furnizat nicio dovadă a prezenței vieții pe Neptun sau pe oricare dintre celelalte planete din sistemul solar, " +
                "în afară de Pământ.";
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
