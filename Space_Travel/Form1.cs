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
    public partial class Form1 : Form
    {
        int poz, raza, cx, cy;
        int[,] coord;
        int nr = 9;
        Mercur f1;  Venus f2; Terra f3; Marte f4; Jupiter f5; Saturn f6; Uranus f7; Neptun f8; Pluto f9;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                //******************** M E R C U R ********************
                if (coord[poz, 0] == 751 && coord[poz, 1] == 94)
                {
                    f1 = new Mercur();
                    f1.Show();
                }
                //******************** V E N U S ********************
                if (coord[poz, 0] == 921 && coord[poz, 1] == 237)
                {
                    f2 = new Venus();
                    f2.Show();
                }
                //******************** T E R R A ********************
                if (coord[poz, 0] == 960 && coord[poz, 1] == 456)
                {
                    f3 = new Terra();
                    f3.Show();
                }
                //******************** M A R T E ********************
                if (coord[poz, 0] == 848 && coord[poz, 1] == 648)
                {
                    f4 = new Marte();
                    f4.Show();
                }
                //******************** J U P I T E R ********************
                if (coord[poz, 0] == 640 && coord[poz, 1] == 725)
                {
                    f5 = new Jupiter();
                    f5.Show();
                }
                //******************** S A T U R N ********************
                if (coord[poz, 0] == 431 && coord[poz, 1] == 648)
                {
                    f6 = new Saturn();
                    f6.Show();
                }
                //******************** U R A N U S ********************
                if (coord[poz, 0] == 319 && coord[poz, 1] == 456)
                {
                    f7 = new Uranus();
                    f7.Show();
                }
                //******************** N E P T U N ********************
                if (coord[poz, 0] == 358 && coord[poz, 1] == 237)
                {
                    f8 = new Neptun();
                    f8.Show();
                }
                //******************** P L U T O ********************
                if (coord[poz, 0] == 528 && coord[poz, 1] == 94)
                {
                    f9 = new Pluto();
                    f9.Show();
                }


            }

        }

        private void b1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            double unghi = 360.0 / nr, ur = 3.1415 * unghi / 180;
            InitializeComponent();
            poz = 0;
            raza = 325; 
            coord = new int[nr, 2]; 
            cx = this.Width / 2 -60;  
            cy = this.Height / 2;
            for (int i = 0; i < nr; i++)
            {
                coord[i, 0] = (int)(cx + raza * Math.Sin(i * ur));
                coord[i, 1] = (int)(cy + raza * Math.Cos(i * ur));
            }
            b1.Top = coord[poz, 1];
            b1.Left = coord[poz, 0];
            this.MouseWheel += MyMouseWheel;
        }
        private void MyMouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0) poz++;
            else poz--;
            poz = (poz + nr) % nr; 
            b1.Top = coord[poz, 1];
            b1.Left = coord[poz, 0];
            Form1.ActiveForm.Text = "x= " + coord[poz, 0].ToString()+" "+"y= " + coord[poz, 1].ToString();
           // Form1.ActiveForm.Invalidate();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
