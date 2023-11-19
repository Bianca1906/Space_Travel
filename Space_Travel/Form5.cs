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
    public partial class Terra : Form
    {
        public Terra()
        {
            InitializeComponent();
        }

        private void Terra_Load(object sender, EventArgs e)
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
            textBox1.Text = "Pământul este singura planetă din Sistemul Solar al cărei nume nu derivă" +
                " din mitologia greacă sau romană. Toate celelalte planete au fost denumite după zei și zeițe " +
                "din mitologia greco-romană. În română, cuvântul „pământ” este moștenit din latină pavimentum," +
                " care înseamnă „pământ bătătorit și nivelat”, „pardoseală cu lespezi sau mozaic”, „pavaj”, „podea”, „drum pietruit”," +
                " „loc neted”, „bătătură”." +
                "Terra provine din latinescul tĕrra(pământ, sol), care la rândul său derivă din termenul de origine indo-europeană terse," +
                " cu sensul de „parte uscată”, opus „părții apoase”. Dar Terra a mai fost denumită în trecut și ca orbe terracqueo." +
                " Cuvântul latin orbe a avut mai întâi semnificația „cerc” și apoi de „lume”.";
        }

        private void posibilitateaExistențeiViețiiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox2.Text = "Există viață pe Terra. Formele de viață ale unei planete locuiesc în ecosisteme," +
                " al căror total formează biosfera.Biosfera este împărțită într-un număr de biomuri, locuite de o populație de" +
                " floră și faună aproximativ asemănătoare.Pe uscat, biomurile sunt separate în primul rând prin diferențe de latitudine," +
                " înălțime deasupra nivelului mării și umiditate. ";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void pozeToolStripMenuItem_Click_1(object sender, EventArgs e)
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



