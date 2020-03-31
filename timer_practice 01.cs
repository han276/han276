using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_practice_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i;
        int turn;
        float x1, x2, y1, y2;

       // private void Form1_Load(object sender, EventArgs e)
       // {

       // }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            x1 = 0;
            y1 = 0;
            i = 0;
            //       g.Dispose();
            Application.Restart();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i + 1;
            turn = i % 2;
            const int slidelength = 20 ;

            Graphics g = this.CreateGraphics();
            Pen thispen = new Pen(Color.Red, 2);

           

            switch (turn)
            {
                case 0:
                    x2 = x1 + slidelength;
                    y2 = y1;
                        break;
                case 1:
                    x2 = x1;
                    y2 = y1 + slidelength;
                        break;
            }
            g.DrawLine(thispen, x1, y1, x2, y2);
            x1 = x2;
            y1 = y2;

                
            label1.Text = Convert.ToString(i);
            label2.Text = Convert.ToString(x1);
            label3.Text = Convert.ToString(x2);
            label4.Text = Convert.ToString(y1);
            label5.Text = Convert.ToString(y2);

            if (x2 > this.ClientSize.Width || y2 > this.ClientSize.Height)
                timer1.Enabled = false;
        }


    }
}
