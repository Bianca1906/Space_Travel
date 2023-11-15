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

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
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
            //Form1.ActiveForm.Text = "x= " + coord[poz, 0].ToString()+" "+"y= " + coord[poz, 0].ToString();
           // Form1.ActiveForm.Invalidate();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
