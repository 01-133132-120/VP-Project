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

             

       
       
       /* TextBox[] mytextbox = new TextBox[7];
        Label[] mylabel = new Label[7];*/
        int x = 0;
        int y = 0;
        int a = 0;
        int b = 0;
        //int Countertime = 1;
        //int trackSort = 1;
       // int k = 0;
        //int n = 0;
        int c = 0;
        int d = 0;
        //int e = 0;
        //int f = 0;
       
        public Form1()
        {
            

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
               /* for (int i = 0; i < 7; i++)
                {
                    mytextbox[i] = new TextBox();
                    mytextbox[i].Location = new Point(x, y);
                    mytextbox[i].Width = 50;
                    x = x + 50;
                    panel1.Controls.Add(mytextbox[i]);
                    mytextbox[i].Visible = true;
                }*/
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] txtbox = new TextBox[Convert.ToInt32(textBox1.Text)];
            Label[] lab1 = new Label[Convert.ToInt32(textBox1.Text)];
            
            for (int i = 0; i < txtbox.Length; i++)
            {
                
                txtbox[i] = new TextBox();
                txtbox[i].Location = new Point(a, b);
                a = a + 50;
                txtbox[i].Width = 50;
                panel1.Controls.Add(txtbox[i]);
                txtbox[i].Visible = true;
                //lab1[i] = new Label();
                //lab1[i].Location=new Point(a,b);
                //a=a+100;
            }
            int val = Convert.ToInt32( textBox1.Text);
            for (int i = 0; i < txtbox.Length; i++)
            {

                txtbox[i].Text = val.ToString();
                val++;
            }
            for (int i = 0; i < txtbox.Length; i++)
            {
                lab1[i] = new Label();
                lab1[i].Location = new Point(x, y);
                x = x + 100;
                lab1[i].Width = 80;
                lab1[i].Height = 80;
                lab1[i].Text = txtbox[i].Text;
                panel2.Controls.Add(lab1[i]);
                lab1[i].BackColor = Color.White;
                lab1[i].Visible = true;
            }
           
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox[] txtbox1 = new TextBox[Convert.ToInt32(textBox1.Text)];
            Label[] lab2 = new Label[Convert.ToInt32(textBox1.Text)];
            for (int j = 0; j < txtbox1.Length; j++)
            {
                txtbox1[j] = new TextBox();
                txtbox1[j].Location = new Point(c, d);
                c = c + 50;
                txtbox1[j].Width = 50;
                panel1.Controls.Add(txtbox1[j]);
                txtbox1[j].Visible = true;
            }
            int val1 =Convert.ToInt32( textBox1.Text);
            for (int j = 0; j < txtbox1.Length; j++)
            {
                txtbox1[j].Text = val1.ToString();
                val1--;
            }
            for (int j = 0; j < txtbox1.Length; j++)
            {
                lab2[j] = new Label();
                lab2[j].Location = new Point(x,y);
                x = x + 100;
                lab2[j].BackColor = Color.White;
                lab2[j].Text = txtbox1[j].Text;
                lab2[j].Width = 80;
                lab2[j].Height = 80;
                panel2.Controls.Add(lab2[j]);
                lab2[j].Visible = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Random rn = new Random();
            for (int i = 0; i < 7; i++)
            {
                mytextbox[i].Text = rn.Next(1, 200).ToString();
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBox[] txtbox3 = new TextBox[Convert.ToInt32(textBox1.Text)];
            Label[] lab3 = new Label[Convert.ToInt32(textBox1.Text)];
            //string  value =textBox1.Text;
            //int value = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < txtbox3.Length; i++)
            {
                txtbox3[i] = new TextBox();
               // txtbox3[i].Location = new Point(a, b);
                //a = a + 50;
                //txtbox3[i].Width = 50;
                //panel1.Controls.Add(txtbox3[i]);
                txtbox3[i].Visible = true;
            }
            
                for (int i = 0; i < txtbox3.Length; i++)
                {
                    lab3[i] = new Label();
                    lab3[i].Location = new Point(x, y);
                    x = x + 100;
                    lab3[i].Width = 80;
                    lab3[i].Height = 80;
                    lab3[i].Text = txtbox3[i].Text;
                    lab3[i].BackColor = Color.White;
                    panel2.Controls.Add(lab3[i]);
                    lab3[i].Visible = true;
                    
                }
            
               /* for (int i = 0; i < 7; i++)
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
               
                timer1.Start();*/
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           /* if (k == n)
            {
                mylabel[k].BackColor = System.Drawing.Color.Yellow;
                k++;
            }*/
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox[] txtbox2 = new TextBox[Convert.ToInt32(textBox1.Text)];
            Label[] lab3 = new Label[Convert.ToInt32(textBox1.Text)];
            for (int i = 0; i < txtbox2.Length; i++)
            {
                txtbox2[i] = new TextBox();
                txtbox2[i].Location = new Point(a, b);
                a = a + 50;
                txtbox2[i].Width = 50;
                panel1.Controls.Add(txtbox2[i]);
                txtbox2[i].Visible = true;
            }
            

            
               /* for (int i = 0; i < txtbox2.Length; i++)
                {
                    
                }*/
        }


    }

}