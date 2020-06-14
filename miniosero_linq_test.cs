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
           

        }

        private int Color_check(int t)
        {
            var black = button_color_index.Select((p, q) => new { Contains = p, Index = q })
                                          .Where(ano => ano.Contains == 1 && ano.Index >= 1 && ano.Index <= button_color_index.Length - 1)
                                          .Select(ano => ano.Index);
            black.ToList();

            var white = button_color_index.Select((p, q) => new { Contains = p, Index = q })
                                          .Where(ano => ano.Contains == 2 && ano.Index >= 1 && ano.Index <= button_color_index.Length - 1)
                                          .Select(ano => ano.Index);
            white.ToList();

            float black_count;
            float white_count;
            black_count = 1;
            white_count = 1;

            foreach (int i in black)
            {
                black_count *= i;
            }

            foreach(int i in white)
            {
                white_count *= i;
            }

            float black_list_number;
            float white_list_number;
            black_list_number = Factorial(black.Count());
            white_list_number = Factorial(white.Count());

            if(black_count/black_list_number == Convert.ToInt32(black_count / black_list_number))
            {
                black_judge = true;
            }
            else
            {
                black_judge = false;
            }
         
            if(white_count/white_list_number == Convert.ToInt32(black_count / black_list_number))
            {
                white_judge = true;
            }
            else
            {
                white_judge = false;
            }
            Console.WriteLine(black_count);
            Console.WriteLine(black_list_number);
            Console.WriteLine(black_judge);
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
    }
}
