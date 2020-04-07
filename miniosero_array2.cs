using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniosero_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i;
        int turn;
        int[] button_color_index = { 0, 0, 0, 0, 0, 0 };　　//押されていない0、白なら1、黒なら2を配列に入れるための箱
        List<Button> buttons = new List<Button>();
        List<int> blackpoint = new List<int>();
        List<int> whitepoint = new List<int>();
        List<int> button_sum = new List<int>();
        public void Button_click(object sender, EventArgs e)
        {
            Button btn = (sender) as Button;
            i = i + 1;　　　//手数を積み上げる
            turn = i % 2;　　//黒番・白番を決める
            button_sum.Add(1);　　//押したボタンの総数を決めるためのしかけ
            label2.Text = Convert.ToString(i);

            switch(turn)
            {
                case 0:   //white turn
                    btn.BackColor = Color.White;
                    button_color_index[btn.TabIndex] = 1;　　　　//押したボタンとボタンindex配列はTabindexで紐づけ

                    for (int g = btn.TabIndex +1; g <= buttons.Count - 1; g++)  //右に色をチェック
                    {
                        if ((button_color_index[g] == 1) || (button_color_index[g] == 0)||(g == buttons.Count -1))  //隣が同じ色、または押されてないならbreak
                        {
                            break;
                        }
                        if (button_color_index[g] == 2)　　　//右側が違う色ならその先に白があったらひっくり返る
                        {
                            for (int gg = g + 1; gg <= buttons.Count - 1; gg++)
                            {
                                if (button_color_index[gg] == 1)　　//ひっくり返すために端に白があるか探しに行く仕掛け
                                {
                                    for (int s = g; s <= gg - 1; s++)
                                    {
                                        button_color_index[s] = 1;　　　　//挟まれている黒の色と、ボタンindexの配列の数値を変える
                                        buttons[s].BackColor = Color.White;
                                    }
                                    break;
                                }
                            }
                        }
                    }

                    for (int h = btn.TabIndex -1; h >= 0; h--)  //左に色をチェック仕掛けは上記と同様
                    {
                        if ((button_color_index[h] == 1) || (button_color_index[h] == 0)||(h==0))
                        {
                            break;
                        }
                        if (button_color_index[h] == 2)　　
                        {
                            for (int hh = h -1 ; hh>=0; hh--)
                            {
                                if (button_color_index[hh] == 1)
                                {
                                    for (int t = h; t>= hh + 1; t--)
                                    {
                                        button_color_index[t] = 1;
                                        buttons[t].BackColor = Color.White;
                                    }
                                    break;
                                }
                            }
                        }

                    }
                  break;

                case 1:   //black turn
                    btn.BackColor = Color.Black;
                    button_color_index[btn.TabIndex] = 2;　　//黒の場合ボタンindex配列に2が入る
                    for (int j = btn.TabIndex +1; j <= buttons.Count - 1; j++)  //右に色をチェック
                    {
                        if ((button_color_index[j] == 2) || (button_color_index[j] == 0)||(j==buttons.Count -1))
                        {
                            break;
                        }
                        if (button_color_index[j] == 1)　　　
                        {
                            for (int jj = j + 1; jj <= buttons.Count - 1; jj++)
                            {
                                if (button_color_index[jj] == 2)
                                {
                                    for (int u = j; u <= jj - 1; u++)
                                    {
                                        button_color_index[u] = 2;
                                        buttons[u].BackColor = Color.Black;
                                        
                                    }
                                    break;
                                }
                            }
                        }
                       
                    }

                    for (int k = btn.TabIndex -1; k >= 0; k--)  //左に色をチェック
                    {
                        if ((button_color_index[k] == 2) || (button_color_index[k] == 0)||(k==0))
                        {
                            break;
                        }
                        if (button_color_index[k] == 1)
                        {
                            for (int kk = k - 1; kk >= 0; kk--)
                            {
                                if (button_color_index[kk] == 2)
                                {
                                    for (int y = k; y>=kk+1; y--)
                                    {
                                        button_color_index[y] = 2;
                                        buttons[y].BackColor = Color.Black;
                                    }
                                    break;
                                }
                            }
                        }

                    }
                 break;                    
            }

            //以下点数計算
            for(int a=0; a <=buttons.Count -1;a++)
            {
                if(button_color_index[a]==1)
                {
                    whitepoint.Add(1);
                }
            }

            for (int b = 0; b <= buttons.Count - 1; b++)
            {
                if (button_color_index[b] == 2)
                {
                    blackpoint.Add(1);
                }
            }
            label5.Text = Convert.ToString(blackpoint.Sum());　//現時点での黒と白の総数の表示
            label6.Text = Convert.ToString(whitepoint.Sum());
            if (button_sum.Sum() < buttons.Count)  //勝敗決定ボタンの時にクリアーされてると困るのでifで制限
            {
                blackpoint.Clear();
                whitepoint.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttons.Add(button1);   //各ボタンをリストに追加
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);

            textBox1.Text = "ボタンを押してください";
            button7.Enabled = false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(button_sum.Sum()==buttons.Count)　　//ボタンをすべて押したときのみ結果がコメントに出るボタンが機能する仕掛け
            {
                button7.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (blackpoint.Sum() > whitepoint.Sum())　//黒と白の枚数を数えて結果を出すボタン
            {
                textBox1.Text = "黒の勝ち";
            }
            else if (blackpoint.Sum() == whitepoint.Sum())
            {
                textBox1.Text = "引き分け";
            }
            else if (blackpoint.Sum() < whitepoint.Sum())
                textBox1.Text = "白の勝ち";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            i = i + 1;
            label2.Text = Convert.ToString(i);　　//パスボタン
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
