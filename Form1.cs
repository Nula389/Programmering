using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gissa_tal_grafisk
{
    public partial class Form1 : Form
    {
        Random slump = new Random();
        int talet;
        int försök = 0;
        int x = 1;
        public Form1()
        {
           talet = slump.Next(1, 100);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(textBox1.Text);
            if (tal > talet)
                label2.Text = "Talet som jag tänker på är mindre än så.";
            else if (tal < talet)
                label2.Text = "Talet som jag tänker på är större än så.";
            else
                label2.Text = "Du gissade rätt!";
            försök++;
            label3.Text = försök.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
