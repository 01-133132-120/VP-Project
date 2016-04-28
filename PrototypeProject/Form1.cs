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
        TextBox[] txttxt;
        Label[] lablab;            
       /* TextBox[] mytextbox = new TextBox[7];
        Label[] mylabel = new Label[7];*/
        int x = 0;
        int y = 0;
        int a = 0;
        int b = 0;
        int n = 0;
        int k = 0;
        int check = 0;
        int check1 = 0;
        int value;
        public Form1()
        {           
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            //button4.Enabled = false;
            comboBox1.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            int val = Convert.ToInt32( textBox1.Text);
            for (int i = 0; i < txttxt.Length; i++)
            {
                txttxt[i].Text = val.ToString();
               val++;
            }           
        }
        private void button2_Click(object sender, EventArgs e)
        {            
            int val1 =Convert.ToInt32( textBox1.Text);
            for (int j = 0; j < txttxt.Length; j++)
            {
                txttxt[j].Text = val1.ToString();
                val1--;
            }            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            for (int i = 0; i < txttxt.Length; i++)
            {
                txttxt[i].Text = rn.Next(1, 200).ToString();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            lablab = new Label[Convert.ToInt32(textBox1.Text)];
            value = Convert.ToInt32(textBox1.Text);
            try
            {
                k = 0;
                n = 0;
                if (check != 0)
                {
                    for (int i = 0; i <txttxt.Length; i++)
                    {
                        lablab[i].Dispose();
                    }
                }                
                if ((String)comboBox1.Text == "Selection Sort")
                {
                    lablab = new Label [Convert.ToInt32(textBox1.Text)];
                    for (int i = 0; i < value; i++)
                    {
                        lablab[i] = new Label();
                        lablab[i].Location = new Point(x, y);
                        x = x + 100;
                        lablab[i].Width = 80;
                        lablab[i].Height = 80;
                        lablab[i].Text = txttxt[i].Text;
                        lablab[i].TextAlign = ContentAlignment.MiddleCenter;
                        lablab[i].BorderStyle = BorderStyle.FixedSingle;
                        lablab[i].BackColor = Color.White;
                        panel2.Controls.Add(lablab[i]);
                        lablab[i].Visible = true;
                   }                   
                    x = 0;
                    check++;
                    timer1.Start();                    
                }
                if ((String)comboBox1.Text == "Insertion Sort")
                {
                    k = 1;
                    n = 1;
                    if (check != 0)
                    {
                        for (int i = 0; i < value; i++)
                        {
                            lablab[i].Dispose();
                        }
                    }
                    
                    for (int i = 0; i < txttxt.Length; i++)
                    {
                        lablab[i] = new Label();
                        lablab[i].Location = new Point(x, y);
                        x = x + 100;
                        lablab[i].Width = 80;
                        lablab[i].Height = 80;
                        lablab[i].Text = txttxt[i].Text;
                        lablab[i].TextAlign = ContentAlignment.MiddleCenter;
                        lablab[i].BorderStyle = BorderStyle.FixedSingle;
                        lablab[i].BackColor = Color.White;
                        panel2.Controls.Add(lablab[i]);
                        lablab[i].Visible = true;
                    }                    
                    x = 0;
                    check++;
                    timer1.Start();
                }
                if ((String)comboBox1.Text == "Bubble Sort")
                {
                    if (check != 0)
                    {
                        for (int i = 0; i < txttxt.Length; i++)
                        {
                            lablab[i].Dispose();
                        }
                    }
                    lablab = new Label[Convert.ToInt32(textBox1.Text)];
                    for ( int i = 0; i < value; i++)
                    {
                        lablab[i] = new Label();
                        lablab[i].Location = new Point(x, y);
                        x = x + 100;
                        lablab[i].Width = 80;
                        lablab[i].Height = 80;
                        lablab[i].Text = txttxt[i].Text;
                        lablab[i].TextAlign = ContentAlignment.MiddleCenter;
                        lablab[i].BorderStyle = BorderStyle.FixedSingle;
                        lablab[i].BackColor = Color.White;
                        panel2.Controls.Add(lablab[i]);
                        lablab[i].Visible = true;                                               
                    }
                        x = 0;
                    check++;
                    timer1.Start();
                    timer2.Start();
                }
                else if ((String)comboBox1.Text == "")
                {
                    MessageBox.Show("Select option");
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.StackTrace);
            }                       
        }        
        private void timer1_Tick(object sender, EventArgs e)
        {
                if (k == n)
                {
                    lablab[k].BackColor = Color.Yellow;
                    k++;
                }
                else if (k <lablab.Length)
                {
                    lablab[k - 1].BackColor = Color.White;
                    lablab[k].BackColor = Color.Yellow;
                    k++;
                }
                else if (k == lablab.Length)
                {
                    lablab[k - 1].BackColor = Color.White;
                    lablab[minimum()].BackColor = Color.Red;
                    k++;
                }
                else if (n > lablab.Length)
                {
                    timer1.Stop();
                }
                else
                {
                    k = 0;
                    timer1.Stop();
                }
                button4.Enabled = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("TextBox cannot be empty ");
            }
            else
            {
                try
                {
                    if (check1 != 0)
                    {
                        for (int i = 0; i <txttxt.Length; i++)
                        {
                            txttxt[i].Dispose();
                        }
                    }
                  txttxt = new TextBox[Convert.ToInt32(textBox1.Text)];
                    for (int i = 0; i < txttxt.Length; i++)
                    {
                        txttxt[i] = new TextBox();
                        txttxt[i].Location = new Point(a, b);
                        a = a + 50;
                        txttxt[i].Width = 50;
                        panel1.Controls.Add(txttxt[i]);
                        txttxt[i].Visible = true;
                    }
                    a = 0;
                    check1++;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    comboBox1.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter Integer Value");
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
           /* int data = 0;//timer 2 
            int p = 0;//label jis kai sath replace krna hai.
            int length=0;//distance between 
            if (data == 0)
            {
                length = lablab[minimum()].Location.X-lablab[p].Location.X;
               
            }
            MessageBox.Show("length" + length);*/
           // int length = 0;
                lablab[minimum()].Location = new Point(lablab[minimum()].Location.X , lablab[minimum()].Location.Y+1);
                if (lablab[minimum()].Location.Y > 100) {
                    timer2.Stop();
                }

        }
        public int minimum()
        {
            int min = n;
            for (int i = n; i < lablab.Length; i++)
            {
                for (int j = i; j < lablab.Length; j++)
                {
                    if (Convert.ToInt32(lablab[i].Text) < Convert.ToInt32(lablab[min].Text))
                        min = i;
                }
            }
            return min;
        }
        }
    }