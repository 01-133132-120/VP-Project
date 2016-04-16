using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeProject
{
    public partial class Form1 : Form
    {
        TextBox[] mytextbox = new TextBox[7];
        Label[] mylabel = new Label[7];
        int x = 0;
        int y = 0;
        int a = 0;
        int b = 0;
        int Countertime = 1;
        int trackSort = 1;
        int k = 0;
        int n = 0;
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                for (int i = 0; i < 7; i++)
                {
                    mytextbox[i] = new TextBox();
                    mytextbox[i].Location = new Point(x, y);
                    mytextbox[i].Width = 50;
                    x = x + 50;
                    panel1.Controls.Add(mytextbox[i]);
                    mytextbox[i].Visible = true;
                }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val = 1;
            for (int i = 0; i < 7; i++)
            {

                mytextbox[i].Text = val.ToString();
                val++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int val1 = 7;
            for (int j = 0; j < 7; j++)
            {
                mytextbox[j].Text = val1.ToString();
                val1--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            for (int i = 0; i < 7; i++)
            {
                mytextbox[i].Text = rn.Next(1, 200).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

                for (int i = 0; i < 7; i++)
                {
                    mylabel[i] = new Label();
                    mylabel[i].Location = new Point(a, b);
                    a = a + 100;
                    mylabel[i].Height = 80;
                    mylabel[i].Width = 80;
                    mylabel[i].BackColor = Color.Gold;
                    mylabel[i].Text = mytextbox[i].Text;
                    panel2.Controls.Add(mylabel[i]);
                    mylabel[i].TextAlign = ContentAlignment.MiddleCenter;
                    //mylabel[i].BorderStyle=fixed();
                    mylabel[i].Visible = true;

                }
               
                timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (k == n)
            {
                mylabel[k].BackColor = System.Drawing.Color.Yellow;
                k++;
            }
            
        }


    }

}