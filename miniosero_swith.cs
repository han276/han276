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
        List<Button> btname = new List<Button>();
        List<int> blackpoint = new List<int>();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            btname.Add(button1);
            btname.Add(button2);
            btname.Add(button3);
            btname.Add(button4);
            btname.Add(button5);

            for (int a = 0; a <= 4; a++)
            {
                btname[a].BackColor = Color.Green;
            }

            textBox1.Text = "始めてください";
            button8.Enabled = false;

        }
        
        private void Button_clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            i = i + 1;

            int turn = i % 2;   
            btn.Enabled = false;

                if (turn == 1)
                {
                    btn.BackColor = Color.Black;
                }
                else
                {
                    btn.BackColor = Color.White;
                }

            button_push.Add(1);

            label2.Text = Convert.ToString(i);

            button_sum = button_push.Sum();

            switch (button_sum)
            {
                case 3:
                    for (int b = 1; b <= 3; b++)
                    {
                        if (btname[b].Enabled == false)
                        {
                            if (btname[b - 1].BackColor == btname[b + 1].BackColor)
                            {
                                btname[b].BackColor = btn.BackColor;
                            }
                        }
                    }
                    break;
                case 4:
                    for (int c = 1; c <= 3; c++)
                    {
                        if (btname[c].Enabled == false)
                        {
                            if ((btname[c - 1].BackColor == btname[c + 1].BackColor) && (btname[c].BackColor != btname[c - 1].BackColor))
                            {
                                btname[c].BackColor = btn.BackColor;
                            }
                        }
                    }
                    if (button3.Enabled == false)
                    {
                        if (button1.BackColor == button4.BackColor)
                        {
                            button2.BackColor = btn.BackColor;
                            button3.BackColor = btn.BackColor;
                        }
                        if (button2.BackColor == button5.BackColor)
                        {
                            button3.BackColor = btn.BackColor;
                            button4.BackColor = btn.BackColor;
                        }
                    }
                        break;
                case 5:
                    for ( int d = 1; d <= 3; d++)
                    {
                        if (btname[d].Enabled == false)
                        {
                            if ((btname[d - 1].BackColor == btname[d + 1].BackColor) && (btname[d].BackColor != btname[d - 1].BackColor))
                            {
                                btname[d].BackColor = btn.BackColor;
                            }
                        }
                    }
                    if (button3.Enabled == false)
                    {
                        if (button1.BackColor == button4.BackColor)
                        {
                            if (button2.BackColor == button3.BackColor)
                            {

                            }
                            else
                            {
                                button2.BackColor = btn.BackColor;
                                button3.BackColor = btn.BackColor;
                            }
                        }
                        if (button2.BackColor == button5.BackColor)
                        {
                            if (button2.BackColor == button3.BackColor)
                            {

                            }
                            else
                            {
                                button3.BackColor = btn.BackColor;
                                button4.BackColor = btn.BackColor;
                            }
                        }
                    }
                    if(button1.BackColor == button5.BackColor)
                        for(int g=0; g<=4;g++)
                        {
                            btname[g].BackColor = btn.BackColor;
                        }
                    break;
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

            for (int i = 0; i <= btname.Count -1; i++)
            {
                if (btname[i].BackColor == Color.Black);
                {
                    blackpoint.Add(1);
                }
            }

            blackpoint_sum = blackpoint.Sum();
            whitepoint_sum = button_sum - blackpoint_sum;

            label7.Text = Convert.ToString(blackpoint_sum);
            label8.Text = Convert.ToString(whitepoint_sum);

            button9.Enabled = true;
            button8.Enabled = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            blackpoint.Clear();
            button8.Enabled = true;
            button9.Enabled = false;

        }
    }
}
