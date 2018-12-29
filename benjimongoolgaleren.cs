using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Je naam is: " + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox2.Text) <= 18) 
            {
                MessageBox.Show("je bent 18 jaar of jonger");
            }
            else
            {
                MessageBox.Show("je bent ouder dan 18 jaar");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }
    }
}
