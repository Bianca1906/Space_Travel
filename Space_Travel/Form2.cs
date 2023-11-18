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
    public partial class Marte : Form
    {
        public Marte()
        {
            InitializeComponent();
        }
        int i;

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = true;
            textBox1.Text = "Planeta este numită după zeul roman al războiului, Mars, o asociere făcută " +
                "datorită culorii sale roșiatice care sugerează sângele. În limba greacă, " +
                "planeta este cunoscută sub numele de Ἄρης Arēs, cu rădăcina inflexională Ἄρε- Are-." +
                " De aici rezultă termeni tehnici, precum areologie (geologia lui Marte) și numele stelei Antares." +
                "„Mars” este, de asemenea, baza numelui lunii martie(din latinescul Martius mēnsis „luna lui Marte”)";

        }

        private void posibilitateaExistențeiViețiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox2.Text = "Există cercetări în curs de desfășurare care evaluează potențialul de locuibilitate din trecut al lui Marte, " +
                "precum și posibilitatea existenței vieții. Sunt planificate viitoare misiuni de astrobiologie," +
                " cum ar fi roverul Rosalind Franklin al Agenției Spațiale Europene. Apa lichidă nu poate exista pe suprafața planetei Marte " +
                "din cauza presiunii atmosferice scăzute, care este mai mică de 1% din presiunea atmosferică pe Terra, cu excepția unor mici creșteri " +
                "pentru perioade scurte. Cele două calote glaciare polare par a fi făcute în mare parte din apă. Volumul de apă din calota glaciară" +
                " a Polului Sud, dacă este topită, ar fi suficient pentru a acoperi întreaga suprafață planetară până la o adâncime de 11 metri." +
                " În noiembrie 2016, NASA a raportat găsirea unei cantități mari de gheață subterană în regiunea Utopia Planitia de pe Marte. " +
                "Se estimează că volumul de apă detectat este echivalent cu volumul de apă din Lacul Superior.";
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
