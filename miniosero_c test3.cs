using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniosero_c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int i;
        List<int> button_push = new List<int>();
        int button_sum;
        List<Color> btname = new List<Color>();
        List<int> blackpoint = new List<int>();
        List<int> whitepoint = new List<int>();


        private void Form1_Load(object sender, EventArgs e)
        {
            btname.Add(button1.BackColor);
            btname.Add(button2.BackColor);
            btname.Add(button3.BackColor);
            btname.Add(button4.BackColor);
            btname.Add(button5.BackColor);

            for (int c = 0; c <= 4; c++)
            {
                btname[c] = Color.Green;
            }

        }

        private void Button_clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            i = i + 1;

            int turn = i % 2;

            if (btn.Name.Equals("button1") || btn.Name.Equals("button2") || btn.Name.Equals("button3") || btn.Name.Equals("button4") || btn.Name.Equals("button5"))
            { 
              {
                btn.Enabled = false;
              }
            
                if (turn == 1)
                {
                    btn.BackColor = Color.Black;
                    blackpoint.Add(1);
                }
                else
                { 
                    btn.BackColor = Color.White;
                    whitepoint.Add(1);
                }
            }

            button_push.Add(1);

            label2.Text = Convert.ToString(i);


            button_sum = button_push.Sum();


            if ((button_sum == 5) && (button1.BackColor == button5.BackColor))
            {
                {
                    for (int j = 0; j <= 4; j++)
                        btname[j] = btn.BackColor;

                    if (btn.BackColor == Color.Black)
                    {
                        blackpoint.Add(5);
                    }
                    else if (btn.BackColor == Color.White)
                    {
                        whitepoint.Add(5);
                    }
                    else
                    {
                    }
                }
            }
            if ((button_sum == 5) && (button1.BackColor == button4.BackColor))
            {
                {
                    for (int a = 0; a <= 3; a++)
                        btname[a] = btn.BackColor;
                }
                if (btn.BackColor == Color.Black)
                {
                    blackpoint.Add(4);
                    whitepoint.Add(1);                      
                }
                else
                {
                    blackpoint.Add(1);
                    whitepoint.Add(4);
                }

            }
            if ((button_sum == 5) && (button2.BackColor == button5.BackColor))
            {
                {
                    for (int b = 1; b <= 4; b++)
                        btname[b] = btn.BackColor;
                }
                if (btn.BackColor == Color.Black)
                {
                    blackpoint.Add(4);
                    whitepoint.Add(1);
                }
                else
                {
                  blackpoint.Add(1);
                  whitepoint.Add(4);
                }
            }
            if ((button_sum == 5) && (button3.BackColor == button5.BackColor))
            {
                {
                    button4.BackColor = btn.BackColor;
                }
                if (btn.BackColor == Color.Black)
                {
                    blackpoint.Add(3);
                    whitepoint.Add(2);
                }
                else
                {
                   blackpoint.Add(2);
                   whitepoint.Add(3);
                }
            }
            if ((button_sum == 5) && (button1.BackColor == button3.BackColor))
            {
                {
                    button2.BackColor = btn.BackColor;
                }
                if (btn.BackColor == Color.Black)
                {
                    blackpoint.Add(3);
                    whitepoint.Add(2);
                }
                else
                {
                   blackpoint.Add(2);
                   whitepoint.Add(3);
                }
            }

            if ((button_sum == 4) && (button1.BackColor == button4.BackColor))
            {
                {
                    for (int a = 0; a <= 3; a++)
                        btname[a] = btn.BackColor;
                }
                if (btn.BackColor == Color.Black)
                {
                    blackpoint.Add(4);
                    whitepoint.Add(0);
                }
                else
                {
                   blackpoint.Add(0);
                   whitepoint.Add(4);
                }

            }
            if ((button_sum == 4) && (button2.BackColor == button5.BackColor))
            {
                {
                    for (int a = 1; a <= 4; a++)
                        btname[a] = btn.BackColor;
                }

                if (btn.BackColor == Color.Black)
                {
                    blackpoint.Add(4);
                    whitepoint.Add(0);
                }
               else
                {
                    blackpoint.Add(0);
                    whitepoint.Add(4);
                }

            }
            if ((button_sum == 4) && (button1.BackColor == button3.BackColor))
            {
                {
                    button2.BackColor = btn.BackColor;
                }
                if (btn.BackColor == Color.Black)
                {
                    blackpoint.Add(3);
                    whitepoint.Add(1);
                }
               else
                {
                    blackpoint.Add(1);
                    whitepoint.Add(3);
                }
            }
            if ((button_sum == 4) && (button3.BackColor == button5.BackColor))
            {
                {
                    button4.BackColor = btn.BackColor;
                }
                if (btn.BackColor == Color.Black)
                {
                      blackpoint.Add(3);
                      whitepoint.Add(1);
                }
                else
                {
                     blackpoint.Add(1);
                     whitepoint.Add(3);
                }
            }

            if ((button_sum == 3) && (button1.BackColor == button3.BackColor) && (button2.Enabled = false))
            {
                {
                    button2.BackColor = btn.BackColor;
                }
                if (btn.BackColor == Color.Black)
                {
                    blackpoint.Add(3);
                    whitepoint.Add(0);
                }
                else
                {
                   blackpoint.Add(0);
                   whitepoint.Add(3);
                }
            }

            if ((button_sum == 3) && (button2.BackColor == button4.BackColor) && (button3.Enabled= false))
            {
                {
                    button3.BackColor = btn.BackColor;
                }
                if (btn.BackColor == Color.Black)
                {
                    blackpoint.Add(3);
                    whitepoint.Add(0);
                }
                else
                {
                    blackpoint.Add(0);
                    whitepoint.Add(3);
                }
            }

            if ((button_sum == 3) && (button3.BackColor == button5.BackColor) && (button4.Enabled = false))
            {
                {
                    button4.BackColor = btn.BackColor;
                }
                if (btn.BackColor == Color.Black)
                {
                        blackpoint.Add(3);
                        whitepoint.Add(0);
                }
                else
                {
                     blackpoint.Add(0);
                     whitepoint.Add(3);
                }
            }
            label3.Text = Convert.ToString(button_sum);

        }  

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            i = i + 1;
            label2.Text = Convert.ToString(i);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int blackpoint_sum;
            int whitepoint_sum;
            if (button_sum <= 2)
            {
                blackpoint_sum = blackpoint.Sum();
                whitepoint_sum = whitepoint.Sum();
                label7.Text = Convert.ToString(blackpoint_sum);
                label8.Text = Convert.ToString(whitepoint_sum);
            }
            else if (button_sum >= 3)
            {
                blackpoint_sum = (int)blackpoint.Last();
                whitepoint_sum = (int)whitepoint.Last();
                label7.Text = Convert.ToString(blackpoint_sum);
                label8.Text = Convert.ToString(whitepoint_sum);
            }
            else
            {

            }
  
           
       
        }
    }
}
