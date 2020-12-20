using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 1;
        int[] array = new int[100];
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (i - 1 >= 10) {
                for (int j = 0; j < i; j++)
                {
                    sum += array[j];


                }
                richTextBox1.Text = "";
                richTextBox1.AppendText("Masyvo 10-ies elementų suma: " + sum);

            }
            else
            {
                int skirt = 11;
                skirt -= i;
                MessageBox.Show("Masyve nėra 10 narių. Pridėti reikia dar " + skirt + " narių.");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            if (tikrinti(txt))
            {
                MessageBox.Show("Bloga įvestis. \n Bandykite dar kartą.");


            }
            else {
                array[i - 1] = Convert.ToInt32(textBox1.Text);


                richTextBox1.Text = "";


                for (int j = 0; j < i; j++)
                {
                    richTextBox1.AppendText(j + 1 + " masyvo vieta: " + array[j].ToString() + "\n");

                }
                i++;
            }
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Clear(array, 0, array.Length);
            richTextBox1.Text = "";
            i = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int tarp;
            int zvaigzd;
            string txt1 = textBox1.Text;
            if (tikrinti(txt1))
            {
                MessageBox.Show("Bloga įvestis. \n Bandykite dar kartą.");
            }
            else
            {
                int eglute = Convert.ToInt32(textBox2.Text);
                richTextBox1.Text = "";
                richTextBox1.Text = "Eglė:" + "\n";
                tarp = eglute - 1;
                zvaigzd = 1;
                while (zvaigzd - 1 != eglute)
                {
                    for (int i = 0; i < tarp; i++)
                    {
                        richTextBox1.AppendText(" ");
                    }
                    tarp--;
                    for (int i = 0; i < zvaigzd; i++)
                    {
                        richTextBox1.AppendText("* ");

                    }
                    richTextBox1.AppendText("\n");
                    zvaigzd++;
                }
            }
        }
        bool tikrinti(string txt)
        {
            return String.IsNullOrWhiteSpace(txt);

        }
        
    }
}
