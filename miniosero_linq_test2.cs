using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniosero_linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i;
        int turn;
   //     IEnumerable<int> button_color_index = new[] { 0, 0, 0, 0, 0, 0 };
        int[] button_color_index = new[] { 0, 0, 0, 0, 0, 0 };
        bool black_judge;
        bool white_judge;
        List<Button> buttons = new List<Button>();



        private void Button_click(object sender, EventArgs e)
        {
            Button btn = (sender) as Button;
            btn.Enabled = false;
            i = i + 1;
            turn = i % 2;
            
            

            if (turn == 1)
            {
                btn.BackColor = Color.Black;
                button_color_index[btn.TabIndex] = 1;

            }
            else 
            {
                btn.BackColor = Color.White;
                button_color_index[btn.TabIndex] = 2;

            }

            Color_check(1);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);

        }

        private int Color_check(int t)
        {
            var black = button_color_index.Select((p, q) => new { Contains = p, Index = q })
                                          .Where(ano => ano.Contains == 1 && ano.Index >= 1 && ano.Index <= 5)
                                          .Select(ano => ano.Index);
            black.ToList();

            var white = button_color_index.Select((p, q) => new { Contains = p, Index = q })
                                          .Where(ano => ano.Contains == 2 && ano.Index >= 1 && ano.Index <= 5)
                                          .Select(ano => ano.Index);
            white.ToList();

            float black_count;
            float white_count;
            black_count = 1;
            white_count = 1;

            foreach (int j in black)
            {
                black_count *= j;
            }

            foreach(int j in white)
            {
                white_count *= j;
            }

            float black_list_number;
            float white_list_number;
            black_list_number = Factorial(black.Count());
            white_list_number = Factorial(white.Count());
            if (i > 2)
            {
                if (black_count / black_list_number == Convert.ToInt32(black_count / black_list_number))
                {
                    black_judge = true;
                }
                else
                {
                    black_judge = false;
                }
            }

            if (i > 2)
            {
                if (white_count / white_list_number == Convert.ToInt32(white_count / white_list_number))
                {
                    white_judge = true;
                }
                else
                {
                    white_judge = false;
                }
            }

            int n;
            for(int j=1; j<4; j++)
            {
                n = 2 * j;
                if (black.Count() == 2 && black.Contains(n) == true)
                {
                    if((black.Min()+black.Max())%2 !=1)
                    {
                        black_judge = false;
                    }
                }

            }
           if(black.Count() == 3 && black.Sum()==8)
            {
                black_judge = false;
            }

            for (int j = 1; j < 4; j++)
            {
                n = 2 * j;
                if (white.Count() == 2 && white.Contains(n) == true)
                {
                    if ((white.Min() + white.Max()) % 2 != 1)
                    {
                        white_judge = false;
                    }
                }

            }
            if (white.Count() == 3 && white.Sum() == 8)
            {
                white_judge = false;
            }

            if (black.Count() == 0)
            {
                black_judge = false;
            }

            if (white.Count()==0)
            {
                white_judge = false;
            }
                  
            if (turn == 0)
            {
                if (black_judge == true)
                {
                    if (button_color_index[black.Min() - 1] == 2 && button_color_index[black.Max() + 1] == 2)
                    {

                        foreach (int j in black)
                        {
                            button_color_index[j] = 2;
                            buttons[j].BackColor = Color.White;
                        }

                    }
                }
            }
            if (turn == 1)
            {

                if (white_judge == true)
                {
                    if (button_color_index[white.Min() - 1] == 1 && button_color_index[white.Max() + 1] == 1)
                    {
                        foreach (int j in white)
                        {
                            button_color_index[j] = 1;
                            buttons[j].BackColor = Color.Black;
                        }

                    }
                }
            }
         
            return t;

            

          
        }
        public int Factorial(int n)
        {
            if(n==0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            i = i + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //      Console.WriteLine(black.Min());
        //      Console.WriteLine(black.Max());
        //      Console.WriteLine(black_judge);
    }
}
