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
    public partial class Uranus : Form
    {
        public Uranus()
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
            textBox1.Text = "Numele lui Uranus face referire la vechea zeitate greacă a cerului, " +
                "Uranus (greaca veche: Οὐρανός), tatăl lui Cronos (Saturn) și bunicul lui Zeus (Jupiter)," +
                " care în latină a devenit Ūranus. Consensul asupra numelui nu a fost atins decât la " +
                "aproape 70 de ani de la descoperirea planetei. În timpul discuțiilor inițiale care au urmat descoperirii," +
                " Maskelyne i - a cerut lui Herschel să „facă lumii astronomice faverul(sic!) pentru a da un nume planetei voastre," +
                " care este în întregime a voastră, [și] de care vă suntem atât de obligați pentru descoperire”. " +
                "Ca răspuns la cererea lui Maskelyne, Herschel a decis să numească obiectul Georgium Sidus(„Steaua lui George”) " +
                "sau „Planeta Georgiană” în onoarea noului său patron, regele George al III-lea.";
        }

        private void posibilitateaExistențeiViețiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            timer1.Enabled = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox2.Text = "Este foarte puțin probabil ca Uranus să poată găzdui forme de viață:" +
                " având în vedere natura sa de gigant gazos, nu are o suprafață solidă definită. " +
                "Chiar și atmosfera este inadecvată: dincolo de compoziția sa (hidrogenul, metanul " +
                "și amoniacul sunt compuși prea simpli pentru a genera viață), are presiuni și temperaturi extreme." +
                " În partea superioară a atmosferei, temperaturile sunt foarte scăzute, în jur de 50 K (−223 ° C), " +
                "iar acolo unde acestea devin favorabile, presiunea împreună cu lipsa luminii solare și, prin urmare, " +
                "a unei surse de energie, împiedică procesele chimice avansate care stau la baza oricărei forme de viață. " +
                "Pentru sateliții planetei, întrebarea este diferită: dacă cel mai mare dintre ei posedă oceane de apă " +
                "lichidă sub scoarța de gheață, așa cum se întâmplă pe sateliții lui Jupiter: Europa, Ganymede sau Titan," +
                " atunci colonii de organisme foarte simple s - ar putea forma în apropierea punctelor fierbinți termice de pe fundul mării.";
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

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
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
