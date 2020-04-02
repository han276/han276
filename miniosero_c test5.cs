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
  //      List<int> whitepoint = new List<int>();


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
            this.Refresh();

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
                }
                else
                {
                    btn.BackColor = Color.White;
                }
            }

            button_push.Add(1);

            label2.Text = Convert.ToString(i);

            button_sum = button_push.Sum();

            this.Refresh();


            if (button_sum <= 2)

            {
                textBox1.Text = "ボタンを押してください";
            }


            else if ((button_sum == 3) && (button1.BackColor == button3.BackColor))
            {
                button2.BackColor = btn.BackColor;
                this.Refresh();
               
            }
            else if ((button_sum == 3) && (button2.BackColor == button4.BackColor))
            {
                button3.BackColor = btn.BackColor;
                this.Refresh();
            
            }
            else if ((button_sum == 3) && (button3.BackColor == button5.BackColor))
            {
                button4.BackColor = btn.BackColor;
                this.Refresh();
               
            }
            else if ((button_sum == 4) && (button1.BackColor == button4.BackColor))
            {
                
                button2.BackColor = btn.BackColor;
                button3.BackColor = btn.BackColor;
                this.Refresh();
            }
            else if ((button_sum == 4) && (button2.BackColor == button5.BackColor))
            {
              
                button3.BackColor = btn.BackColor;
                button4.BackColor = btn.BackColor;
                this.Refresh();
            }
            else if ((button_sum == 4) && (button1.BackColor == button3.BackColor))
            {
               
                button2.BackColor = btn.BackColor;
                this.Refresh();
            }
            else if ((button_sum == 4) && (button2.BackColor == button4.BackColor))
            {
               
                button3.BackColor = btn.BackColor;
                this.Refresh();

            }
            else if ((button_sum == 4) && (button3.BackColor == button5.BackColor))
            {
                
                button4.BackColor = btn.BackColor;
                this.Refresh();
            }
            else if ((button_sum == 5) && (button1.BackColor == button5.BackColor))
            {
               
                for (int b = 0; b <= 4; b++)
                {
                    btname[b].BackColor = btn.BackColor;
                }
                this.Refresh();
            }
            else if ((button_sum == 5) && (button1.BackColor == button4.BackColor))
            {
                
                for (int c = 0; c <= 3; c++)
                {
                    btname[c].BackColor = btn.BackColor;
                }
                this.Refresh();
            }
            else if ((button_sum == 5) && (button2.BackColor == button5.BackColor))
            {
                
                for (int d = 1; d <= 4; d++)
                {
                    btname[d].BackColor = btn.BackColor;
                }
                  this.Refresh();
            }
            else if ((button_sum == 5) && (button1.BackColor == button3.BackColor))
            {
                
                button2.BackColor = btn.BackColor;
                this.Refresh();
            }
            else if ((button_sum == 5) && (button2.BackColor == button4.BackColor))
            {
               
                button3.BackColor = btn.BackColor;
                this.Refresh();
            }
            else if ((button_sum == 5) && (button3.BackColor == button5.BackColor))
            {
                
                button4.BackColor = btn.BackColor;
                this.Refresh();
            }
            else
            {

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

            this.Refresh();

            if (button1.BackColor == Color.Black)
            {
                blackpoint.Add(1);
            }
            if(button2.BackColor == Color.Black)
            {
                blackpoint.Add(1);
            }
            if (button3.BackColor == Color.Black)
            {
                blackpoint.Add(1);
            }
            if (button4.BackColor == Color.Black)
            {
                blackpoint.Add(1);
            }
            if (button5.BackColor == Color.Black)
            {
                blackpoint.Add(1);
            }
            blackpoint_sum = blackpoint.Sum();
            whitepoint_sum = button_sum - blackpoint_sum;

            label7.Text = Convert.ToString(blackpoint_sum);
            label8.Text = Convert.ToString(whitepoint_sum);


        }
                  
        
    }
}
