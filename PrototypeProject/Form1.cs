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
        int i;
        int x = 97;
        int y = 131;
        int a = 0;
        int b = 0;
        int n = 0;
        int k = 0;
        int check = 0;
        int check1 = 0;
        int check2 = 0;
        int length = 0;
        int replace = 0;
        int value;
        int j = 0;
        int l = 0;
        public Form1()
        {
            InitializeComponent();
           
            btnAscending.Enabled = false;
            btnDecending.Enabled = false;
            btnRandom.Enabled = false;
            //button4.Enabled = false;
            btnsort.Enabled = false;
            comboBox1.Enabled = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

                                  //ASCENDING NUMBER BUTTON


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < txttxt.Length; i++)
                {
                    txttxt[i].Text = val.ToString();
                    val++;
                } //End for
                btnsort.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("sorry","Error");
            }
            
        }//End button1

                                 //DECENDING ORDER BUTTON   
 

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int val1 = Convert.ToInt32(textBox1.Text);
                for (int j = 0; j < txttxt.Length; j++)
                {
                    txttxt[j].Text = val1.ToString();
                    val1--;
                } //End for  
                btnsort.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry","Error");
            }
        }// End button 2

                                //RANDOM NUMBER BUTTON
 
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Random rn = new Random();
                for (int i = 0; i < txttxt.Length; i++)
                {
                    txttxt[i].Text = rn.Next(1, 200).ToString();
                }//End for
                btnsort.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry","Error");
            }
        }//End button 3

                                    //SORTING BUTTON

        private void button4_Click(object sender, EventArgs e)
        {
           // btnsort.Enabled = false;
            btnsort.Enabled = false;           
            try
            {
                lablab = new Label[Convert.ToInt32(textBox1.Text)];
                value = Convert.ToInt32(textBox1.Text);
                if (value <= 1)
                {
                    MessageBox.Show("Please check your input value should be greater than one ","Error");
                }
                else {
                    if (chkElement())
                    {
                        if (check != 0)
                        {
                            for (int i = 0; i < lablab.Length; i++)
                            {
                                lablab[i].Dispose();
                            }//End for
                        }  //End if              
                        if ((String)comboBox1.Text == "Selection Sort")
                        {

                            btnsort.Enabled = true;
                            comboBox1.Enabled = false;
                            btnAscending.Enabled = false;
                            btnDecending.Enabled = false;
                            btnGenerate.Enabled = false;
                            btnRandom.Enabled = false;
                            k = 0;
                            n = 0;
                            replace = 0;
                            lablab = new Label[Convert.ToInt32(textBox1.Text)];
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
                                Sortpanel.Controls.Add(lablab[i]);
                                lablab[i].Visible = true;
                            }// End for 
                            x = 97;
                            check++;
                            timer1.Start();
                            btnsort.Enabled = false;
                        }// End of selection sort if
                        if ((String)comboBox1.Text == "Insertion Sort")
                        {
                            btnsort.Enabled = true;
                            comboBox1.Enabled = false;
                            btnAscending.Enabled = false;
                            btnDecending.Enabled = false;
                            btnGenerate.Enabled = false;
                            btnRandom.Enabled = false;
                            if (check != 0)
                            {
                                for (int i = 0; i < value; i++)
                                {
                                    lablab[i].Dispose();
                                }//End for
                            }//End if
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
                                Sortpanel.Controls.Add(lablab[i]);
                                lablab[i].Visible = true;
                            } //End for                 
                            x = 0;
                            check++;
                            // btnsort.Enabled = true;
                            timer3.Start();
                            btnsort.Enabled = false;
                        }// End of insertion sort if
                        if ((String)comboBox1.Text == "Bubble Sort")
                        {
                            btnsort.Enabled = true;
                            comboBox1.Enabled = false;
                            btnAscending.Enabled = false;
                            btnDecending.Enabled = false;
                            btnGenerate.Enabled = false;
                            btnRandom.Enabled = false;
                            if (check != 0)
                            {
                                for (int i = 0; i < txttxt.Length; i++)
                                {
                                    lablab[i].Dispose();
                                }// End for
                            }// End if
                            lablab = new Label[Convert.ToInt32(textBox1.Text)];
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
                                Sortpanel.Controls.Add(lablab[i]);
                                lablab[i].Visible = true;
                            }// End for
                            x = 0;
                            check++;
                            // btnsort.Enabled = true;
                            timer5.Start();
                            btnsort.Enabled = false;
                        }// End bubble sort if
                    }
                   /* else if ((String)comboBox1.Text == "")
                    {
                        MessageBox.Show("Select option");
                        btnsort.Enabled = true;
                    }*/
                }
                if ((String)comboBox1.Text == "")
                {
                    MessageBox.Show("Select option","Error");
                    btnsort.Enabled = true;
                }
            } //End try
            catch (Exception )
            {
                MessageBox.Show("check");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {          
                if (k == n)
                {
                    lablab[k].BackColor = Color.Yellow;
                    k++;
                }//End if
                else if (k <= lablab.Length - 1)
                {
                    lablab[k - 1].BackColor = Color.White;
                    lablab[k].BackColor = Color.Yellow;
                    k++;
                }// End else if
                else if (k == lablab.Length)
                {
                    lablab[k - 1].BackColor = Color.White;
                    lablab[minimum()].BackColor = Color.Red;
                    k++;
                } //End else if
                else if (n > lablab.Length)
                {
                    timer1.Stop();
                    // timer2.Start();
                }// End else if
                else
                {
                    k = 0;
                    timer1.Stop();
                    timer2.Start();
                }
            //btnsort.Enabled = false;
        }
                                             //GENERATE TEXT BOX BUTTON 

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("TextBox cannot be empty","Error");
                }
                int CHECKVALUE = Convert.ToInt32(textBox1.Text);
                if (CHECKVALUE <= 1)
                {
                    MessageBox.Show("Enter a value greater than one","Error");
                    btnGenerate.Enabled = true;
                }
                else
                {
                    try
                    {
                        if (check1 != 0)
                        {
                            for (int i = 0; i < txttxt.Length; i++)
                            {
                                txttxt[i].Dispose();
                            }// End for
                        }// End if
                        txttxt = new TextBox[Convert.ToInt32(textBox1.Text)];
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Field cannot be empty","Error");
                        }
                        for (int i = 0; i < txttxt.Length; i++)
                        {

                            txttxt[i] = new TextBox();
                            txttxt[i].Location = new Point(a, b);
                            a = a + 50;
                            txttxt[i].Width = 50;
                            txttxt[i].Height = 28;
                            panel1.Controls.Add(txttxt[i]);
                            txttxt[i].Visible = true;
                        }// End of for
                        a = 0;
                        check1++;
                        btnAscending.Enabled = true;
                        btnDecending.Enabled = true;
                        btnRandom.Enabled = true;
                        comboBox1.Enabled = true;
                        btnsort.Enabled = true;
                    } //End try
                    catch (Exception)
                    {
                        MessageBox.Show("Please Enter Integer Value","Error");
                    }

                }// End of else
            }
            catch (Exception)
            {
                MessageBox.Show("Check your input","Error");
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            int aa, bb, cc, dd;
            if (check2 == 0)
            {
                length = lablab[minimum()].Location.X - lablab[replace].Location.X;
            }
            if (check2 < 100)
            {
                aa = lablab[minimum()].Location.X;
                bb = lablab[minimum()].Location.Y;
                cc = lablab[replace].Location.X;
                dd = lablab[replace].Location.Y;
                if (length == 0)
                {
                    Point qqq = new Point(cc, dd - 1);
                    lablab[replace].Location = qqq;
                }
                else
                {
                    Point pp = new Point(aa, bb - 1);
                    lablab[minimum()].Location = pp;
                    Point qq = new Point(cc, dd + 1);
                    lablab[replace].Location = qq;
                }
                check2++;
            }
            else if (check2 < length + 100)
            {
                aa = lablab[minimum()].Location.X;
                bb = lablab[minimum()].Location.Y;
                cc = lablab[replace].Location.X;
                dd = lablab[replace].Location.Y;
                if (length == 0)
                {

                }
                else
                {
                    Point pp = new Point(aa - 1, bb);
                    lablab[minimum()].Location = pp;
                    Point qq = new Point(cc + 1, dd);
                    lablab[replace].Location = qq;
                }
                check2++;
            }
            else if (check2 < length + 200)
            {
                aa = lablab[minimum()].Location.X;
                bb = lablab[minimum()].Location.Y;
                cc = lablab[replace].Location.X;
                dd = lablab[replace].Location.Y;
                if (length == 0)
                {
                    Point qqq = new Point(cc, dd + 1);
                    lablab[replace].Location = qqq;
                }
                else
                {
                    Point pp = new Point(aa, bb + 1);
                    lablab[minimum()].Location = pp;

                    Point qq = new Point(cc, dd - 1);
                    lablab[replace].Location = qq;
                }
                check2++;
            }
            else
            {
                check2 = 0;
                Label temp = lablab[minimum()];
                lablab[minimum()] = lablab[replace];
                lablab[replace] = temp;
                n++;
                k = n;
                replace++;
                timer2.Stop();
                lablab[replace - 1].BackColor = Color.CornflowerBlue;

                if (k == lablab.Length)
                {
                    MessageBox.Show("Sorting completed !!!!");
                    /*btnAscending.Enabled = true;
                    btnDecending.Enabled = true;
                    btnGenerate.Enabled = true;
                    btnRandom.Enabled = true;
                    btnsort.Enabled = true;
                    for (int q = 0; q < lablab.Length; q++)
                    {
                        txttxt[q].Text = "";
                        
                    }
                    if (check != 0)
                    {
                        for (int i = 0; i < lablab.Length; i++)
                        {
                            lablab[i].Dispose();
                        }//End for
                    } */ //End if       
                    //this.Close();                    
                }
                else
                {
                    timer1.Start();
                }
            }
        }
        public int  minimum()
        {
            int min = n;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Text box can not be empty","Error");
            }
            else
            {               
                    for (int j = n; j < lablab.Length; j++)
                    {

                        for (i = j + 1; i < lablab.Length; i++)
                        {

                            if (Convert.ToInt32(lablab[i].Text) < Convert.ToInt32(lablab[min].Text))
                                min = i;
                        }
                    }
            }           
                return min;                                       
        }
        public bool chkElement()
        {
            try
            {
                for (i = 1; i < lablab.Length; i++)
                {
                    int chk = Convert.ToInt32(txttxt[i].Text);
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Please Check Inputs !!",
                "Error");
                btnsort.Enabled = true;
                return false;
            }
        }               
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Size s1 = new Size(155, 40);
            btnRandom.Size = s1;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnRandom.Size = new Size(148, 33);
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnDecending.Size = new Size(155, 40);
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnDecending.Size = new Size(148, 33);
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnAscending.Size = new Size(155, 40);
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnAscending.Size = new Size(148, 33);
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            btnGenerate.Size = new Size(155, 40);
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            btnGenerate.Size = new Size(148, 33);
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            btnsort.Size = new Size(100, 40);
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnsort.Size = new Size(96, 30);
        }
        private void refreshToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }        
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (j != 0)
            {
                if (k == 1)
                {
                    if (j != lablab.Length)
                    {
                        lablab[j - 1].BackColor = Color.Yellow;
                        k++;
                    }
                    else
                    {
                        k++;
                    }
                }
                else if (k == 2)
                {
                    lablab[j - 1].BackColor = Color.White;
                    if (j != lablab.Length)
                    {
                        lablab[j].BackColor = Color.Yellow;
                        k++;
                    }
                    else
                    {
                        timer3.Stop();
                    }
                }
                else if (Convert.ToInt32(lablab[j - 1].Text) > Convert.ToInt32(lablab[j].Text))
                {
                    k = 1;
                    lablab[j].BackColor = Color.Red;
                    timer3.Stop();
                    timer4.Start();
                    lablab[j].BackColor = Color.White;
                }
                else
                {
                    if (j == lablab.Length - 1)
                    {                        
                        timer3.Stop();
                        lablab[j].BackColor = Color.White;
                        MessageBox.Show("Sorting Completed!!");
                      /*  btnAscending.Enabled = true;
                        btnDecending.Enabled = true;
                        btnGenerate.Enabled = true;
                        btnRandom.Enabled = true;
                        btnsort.Enabled = true;
                        for (int q = 0; q < lablab.Length; q++)
                        {
                            txttxt[q].Text = "";

                        }
                        if (check != 0)
                        {
                            for (int i = 0; i < lablab.Length; i++)
                            {
                                lablab[i].Dispose();
                            }//End for
                        }  //End if       
                        this.Close();*/                    
                    }
                    else
                    {
                        k = 1;
                        timer3.Stop();
                        j++;
                        timer3.Start();
                    }
                }
            }
            else
            {
                k = 1;
                j = n;
                n++;
                lablab[j].BackColor = Color.White;
                timer3.Stop();
                timer3.Start();
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (check2 < 100)
            {
                int a = lablab[j].Location.X;
                int b = lablab[j].Location.Y;
                int c = lablab[j - 1].Location.X;
                int d = lablab[j - 1].Location.Y;
                Point p = new Point(a - 1, b);
                lablab[j].Location = p;
                Point q = new Point(c + 1, d);
                lablab[j - 1].Location = q;
                check2++;
            }
            else
            {
                timer4.Stop();
                k = 1;
                check2 = 0;
                Label temp = lablab[j - 1];
                lablab[j - 1] = lablab[j];
                lablab[j] = temp;
                j--;
                timer3.Start();
            }
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (l == lablab.Length - 1)
            {
                l = 0;
                //MessageBox.Show("ok");
            }
            else if (l == lablab.Length)
            {
                l = 0;
                //MessageBox.Show("OK");
            }
            else if (Convert.ToInt32(lablab[l].Text) > Convert.ToInt32(lablab[l + 1].Text))
            {
                timer5.Stop();
                lablab[l].BackColor = Color.Yellow;
                lablab[l + 1].BackColor = Color.White;
                timer6.Start();
            }
            else
            {
                l++;
            }
                   }
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (check1 < 100)
            {
                int a2 = lablab[l].Location.X;
                int b2 = lablab[l].Location.Y;
                int c2 = lablab[l + 1].Location.X;
                int d2 = lablab[l + 1].Location.Y;
                Point p1 = new Point(a2 + 1, b2);
                lablab[l].Location = p1;
                Point q1 = new Point(c2 - 1, d2);
                lablab[l + 1].Location = q1;
                check1++;
            }
            else
            {
                check1 = 0;
                Label temp = lablab[l + 1];
                lablab[l + 1] = lablab[l];
                lablab[l] = temp;
                lablab[l].BackColor = Color.Gray;
                lablab[l + 1].BackColor = Color.Gray;
                timer6.Stop();
                timer5.Start();
               // MessageBox.Show("ok");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btnback_Click(object sender, EventArgs e)
        {
           Form1 checkform = new Form1();            
                //checkform.Visible = false;
                Main checkmain = new Main();
                //checkmain.Visible = true;
                //checkmain.Close();
                //checkform.Close();
                this.Hide();
                checkmain.Show();                                  
        }
        private void btnback_MouseLeave(object sender, EventArgs e)
        {
            btnback.Size = new Size(471, 23);
        }

        private void btnback_MouseMove(object sender, MouseEventArgs e)
        {
            btnback.Size = new Size(480,30);
        }        
    }
}