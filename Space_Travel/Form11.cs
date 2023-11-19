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
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }
        //******************************************** I N T R E B A R E A **** 1 *************************************
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            progressBar1.Value++;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox1.Enabled = false;
            groupBox2.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox1.Enabled = false;
            groupBox2.Visible = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox1.Enabled = false;
            groupBox2.Visible = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox1.Enabled = false;
            groupBox2.Visible = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox1.Enabled = false;
            groupBox2.Visible = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox1.Enabled = false;
            groupBox2.Visible = true;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox1.Enabled = false;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox1.Enabled = false;
        }
        //******************************************** I N T R E B A R E A **** 2 *************************************
        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox2.Enabled = false;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox2.Enabled = false;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox2.Enabled = false;
        }
        
        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            progressBar1.Value++;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox2.Enabled = false;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox2.Enabled = false;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox2.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox2.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox2.Enabled = false;
        }
        //******************************************** I N T R E B A R E A **** 2 *************************************
        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            progressBar1.Value++;
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox3.Enabled = false;
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox3.Enabled = false;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox3.Enabled = false;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox3.Enabled = false;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox3.Enabled = false;
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox3.Enabled = false;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox3.Enabled = false;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox3.Enabled = false;
        }
        //******************************************** I N T R E B A R E A **** 4 *************************************
        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            progressBar1.Value++;
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox4.Enabled = false;
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox4.Enabled = false;
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox4.Enabled = false;
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox4.Enabled = false;
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox4.Enabled = false;

        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox4.Enabled = false;

        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox4.Enabled = false;
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox4.Enabled = false;
        }
        //******************************************** I N T R E B A R E A **** 5 *************************************
        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Enabled = false;
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            progressBar1.Value++;
        }

        private void radioButton45_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            groupBox5.Enabled = false;
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            groupBox5.Enabled = false;
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            groupBox5.Enabled = false;

        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            groupBox5.Enabled = false;
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            groupBox5.Enabled = false;
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            groupBox5.Enabled = false;
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            groupBox5.Enabled = false;
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            groupBox5.Enabled = false;
        }
        //******************************************** I N T R E B A R E A **** 6 *************************************
        private void radioButton50_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Enabled = false;
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            progressBar1.Value++;
        }

        private void radioButton51_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            groupBox6.Enabled = false;
        }

        private void radioButton52_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            groupBox6.Enabled = false;
        }

        private void radioButton53_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            groupBox6.Enabled = false;
        }

        private void radioButton54_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            groupBox6.Enabled = false;
        }

        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            groupBox6.Enabled = false;

        }

        private void radioButton48_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            groupBox6.Enabled = false;
        }

        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            groupBox6.Enabled = false;
        }

        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            groupBox6.Enabled = false;

        }
    }
}
