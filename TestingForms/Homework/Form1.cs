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

namespace Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string fileName = @"../../../numbers.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            
            StreamWriter sw = new StreamWriter(fileName, false);
            Random random = new Random();
            for (int i = 0; i <= 5; i++)
            {
                 sw.WriteLine(random.Next(1,101));
            }
            sw.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            StreamReader sr = new StreamReader(fileName);
            string line=sr.ReadLine();
            while (line!=null)
            {
                listBox1.Items.Add(line);
                line=sr.ReadLine();
            }
            sr.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum=0;
            foreach (var item in listBox1.Items)
            {

                sum+=int.Parse(item.ToString());
            }

            MessageBox.Show($"{sum}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string odd=string.Empty;
            foreach (var item in listBox1.Items)
            {
                if (int.Parse(item.ToString())%2!=0)
                {
                    odd += item.ToString() + " ";
                }
            }

            MessageBox.Show(odd);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string even = string.Empty;
            foreach (var item in listBox1.Items)
            {
                if (int.Parse(item.ToString()) % 2 == 0)
                {
                    even += item.ToString() + " ";
                }
            }

            MessageBox.Show(even);
        }
    }
}
