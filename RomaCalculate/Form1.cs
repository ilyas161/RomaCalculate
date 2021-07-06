using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomaCalculate
{
        public partial class Form1 : Form
        {
            string a = "", b = "";
            char c = '=';
            public Form1()
            {
                InitializeComponent();
                
                this.BackColor = Color.Gray;
            }

            private void button1_Click(object sender, EventArgs e)
            {
            // this.Close();
            //  richTextBox1.Text = RomaCalculate(Translate("VII"));
                a += "I";
            if(b == "")
                richTextBox1.Text = a;
            else
                richTextBox1.Text = b + c + a;
        }


        private void button22_Click(object sender, EventArgs e)
        {
            a += "V";
            if (b == "")
                richTextBox1.Text = a;
            else
                richTextBox1.Text = b + c + a;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            a += "X";
            if (b == "")
                richTextBox1.Text = a;
            else
                richTextBox1.Text = b + c + a;
            //  MessageBox.Show(Convert.ToString(Translate(a)));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a += "L";
            if (b == "")
                richTextBox1.Text = a;
            else
                richTextBox1.Text = b + c + a;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a += "C";
            if (b == "")
                richTextBox1.Text = a;
            else
                richTextBox1.Text = b + c + a;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a += "D";
            if (b == "")
                richTextBox1.Text = a;
            else
                richTextBox1.Text = b + c + a;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a += "M";
            if (b == "")
                richTextBox1.Text = a;
            else
                richTextBox1.Text = b + c + a;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            c = '+';
            richTextBox1.Text = a + c;
            b = a;
            a = "";
           // if (a != "")
          //  MessageBox.Show(Convert.ToString(Translate(a)));

        }
        private void button13_Click(object sender, EventArgs e)
        {
           
            c = '-';
            richTextBox1.Text = a + c;
            b = a;
            a = "";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            
            c = '/';
            richTextBox1.Text = a + c;
            b = a;
            a = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            c = '*';
            richTextBox1.Text = a + c;
            b = a;
            a = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            c = '%';
            richTextBox1.Text = a + c;
            b = a;
            a = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = "";
            richTextBox1.Text = a + c;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string d = "";
            for (int i = 0; i < a.Length - 1; i++)
            {
                d += a[i];
            }
            a = d;
            if (b == "")
                richTextBox1.Text = a;
            else
                richTextBox1.Text = b + a;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string rezultFinal = "";
            switch (c)
            {
                case '+':
                    rezultFinal = RomaCalculate(Translate(a) + Translate(b));
                   // MessageBox.Show("hello world");
                  //  MessageBox.Show(Convert.ToString(Translate(a)));
                    break;
                case '-':
                    rezultFinal = RomaCalculate(Translate(b) - Translate(a));
                   // MessageBox.Show(Convert.ToString(Translate(rezultFinal)));
                    break;
                case '*':
                    rezultFinal = RomaCalculate(Translate(a) * Translate(b));
                    break;
                case '/':
                    rezultFinal = RomaCalculate(Translate(b) / Translate(a));
                    break;
                case '%':
                    rezultFinal = RomaCalculate(Translate(b) % Translate(a));
                    break;
                default:
                   // Console.WriteLine("no such operation has been added yet");
                    break;
            }

            richTextBox1.Text = b + c + a + "=" + rezultFinal;
            b = "";
            c = '=';
            a = rezultFinal;
        }
        private string RomaCalculate(int ArabNumbers)
            {
                string rezult = "";
                var Dict = new Dictionary<int, string>
                {
                    { 1, "I" },
                    { 2, "II" },
                    { 3, "III"},
                    { 4, "IV"},
                    { 5, "V" },
                    { 6, "VI" },
                    { 7, "VII" },
                    { 8, "VIII" },
                    { 9, "IX" },
                    { 10, "X" },
                    { 20, "XX" },
                    { 30, "XXX" },
                    { 40, "XL" },
                    { 50, "L" },
                    { 60, "LX" },
                    { 70, "LXX" },
                    { 80, "LXXX" },
                    { 90, "XC" },
                    { 100, "C" },
                    { 200, "CC" },
                    { 300, "CCC" },
                    { 400, "CD" },
                    { 500, "D" },
                    { 600, "DC" },
                    { 700, "DCC" },
                    { 800, "DCCC" },
                    { 900, "CM" },
                    { 1000, "M" }
                };
               
                foreach (var item in Dict.Keys.Reverse())
                { 
                    while (ArabNumbers / item >= 1)
                    {
                        rezult += Dict[item];
                        ArabNumbers -= item;
                        if (ArabNumbers == 1)
                            break;
                    }
                }
                return rezult;
            }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int Translate(string RomaNumbers)
            {
            if (RomaNumbers == "")
                return -1;
            var Dicti = new Dictionary<char, int>
                {
                    { 'I', 1 },
                    { 'V', 5 },
                    { 'X', 10 },
                    { 'L', 50 },
                    { 'C', 100 },
                    { 'D', 500 },
                    { 'M', 1000 }
                };
                int summ, same = 0;
                int sign = 1;
                foreach (var item in RomaNumbers)
                {
                    if (!Dicti.ContainsKey(item))
                    {
                        Console.WriteLine("eror not roma in [1 - 1000]");
                        return -1;
                    }
                }
                summ = Dicti[RomaNumbers[^1]];
                for (int k = RomaNumbers.Length - 1; k > 0; k--)
                {
                    if (Dicti[RomaNumbers[k - 1]] > Dicti[RomaNumbers[k]])
                    {
                        sign = 1;
                        same = 0;
                    }
                    else if (Dicti[RomaNumbers[k - 1]] == Dicti[RomaNumbers[k]])
                    {
                        same++;
                    }
                    else
                    {
                        sign = -1;
                        same = 0;
                    }
                    if (same != 0)
                        same--;
                    summ += Dicti[RomaNumbers[k - 1]] * sign + same * Dicti[RomaNumbers[k]] * sign;
                }
                return summ;
            }
    }
}
