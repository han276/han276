using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herogame_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Hero h = new Hero("ミナト");
        public Creric c = new Creric("アサカ");
        public Slim m = new Slim("スライム",50,5,3);
        public Slim m1 = new Slim("キングスライム", 100, 15, 5);
        Slim[] slims = new Slim[4];
        int i;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            human_picture.ImageLocation = @"C:\herogame_picture\hero.bmp";
            int index = comboBox1.SelectedIndex;
            switch(index)
            {
                case 0:
                    h.Attack(slims[i]);
                    textBox1.Text=(h.name + "は" + slims[i].name + "に" + h.damage.ToString() + "のダメージを与えた！");
                        break;
                case 1:
                    h.Defence();
                    textBox1.Text=(h.name + "は守りを固めた！");
                    break;
                case 2:
                    h.Defend_party();
                    break;
            }

            comboBox2.Enabled = true;
            comboBox1.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            human_picture.ImageLocation= @"C:\herogame_picture\creric.bmp";
            int index = comboBox2.SelectedIndex;
            switch (index)
            {
                case 0:
                    c.Attack(slims[i]);
                    textBox1.Text=(c.name + "は" + slims[i].name + "に" + c.damage.ToString() + "のダメージを与えた！");
                    break;
                case 1:
                    c.Heal(h);
                    textBox1.Text=(c.name + "はホイミを唱えた!"+h.name + "はHPが" + c.heal_point.ToString() + "回復！");
                    break;
                case 2:
                    c.Prey();
                    textBox1.Text=(c.name + "は神に祈りを捧げた！"+c.name + "はMPが" + c.prey_point.ToString() + "回復！");
                    break;
                case 3:
                    c.Self_aid();
                    textBox1.Text=(c.name + "はHPが5回復！");
                    break;
            }
          
            timer2.Enabled = true;
            comboBox2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = h.hp.ToString();
            label6.Text = h.mp.ToString();
            label9.Text = c.hp.ToString();
            label10.Text = c.mp.ToString();
            label11.Text = slims[i].name;
            label12.Text = slims[i].hp.ToString();
            label14.Text = h.name;
            label15.Text = c.name;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            comboBox1.Enabled = true;
            System.Threading.Thread.Sleep(3000);


            if (h.sacrifice == true)
            {
                slims[i].Attack(h);
                
                textBox1.Text=(h.name+"は" + c.name + "をかばった！"+" " +slims[i].name + "は" + h.name + "に" + slims[i].damage.ToString() + "のダメージを与えた！");
                h.sacrifice = false;

            }
            else
            {
                Random a = new Random();
                int index = a.Next(1, 3);

                switch (index)
                {
                    case 1:
                        slims[i].Attack(h);
                        textBox1.Text=(slims[i].name + "は" + h.name + "に" + slims[i].damage.ToString() + "のダメージを与えた！");
                        break;
                    case 2:
                        slims[i].Attack(c);
                        textBox1.Text=(slims[i].name + "は" + c.name + "に" + slims[i].damage.ToString() + "のダメージを与えた！");
                        break;
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            timer2.Enabled = false;
            slims[0] = m;
            slims[1] = m1;
        }

        private void buttle_start_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            i = a.Next(0, 2);
            timer1.Enabled = true;

            switch(i)
            {
                case 0:
                    monstor_picture.ImageLocation = @"C:\herogame_picture\slim.bmp";
                    break;
                case 1:
                    monstor_picture.ImageLocation = @"C:\herogame_picture\kingslim.bmp";
                    break;
            }
        }
    }
}
