using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        int[] arr = new int[10];
        int n, n1;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = arr.Count();
            for(int i = 0; i < n; i++)
            {
                n1 = rnd.Next(1, 5);
                textBox1.Text += n1.ToString() + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arr = new int[0];
            textBox1.Text = null;
        }
    }
}
