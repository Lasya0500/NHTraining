using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddNumbers_Desktop_App_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNumber, secondNumber, sum = 0;

            firstNumber   = Convert.ToInt32(textBox1.Text);
            secondNumber  = Convert.ToInt32(textBox2.Text);

            sum           = firstNumber + secondNumber;

            textBox3.Text = sum.ToString();

            Console.ReadLine();
        }
    }
}
