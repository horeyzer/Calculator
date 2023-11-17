using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CalculatorClass cc = new CalculatorClass();

        void Asign()
        {
            cc.number1 = Convert.ToInt32(textBox1.Text);
            cc.number2 = Convert.ToInt32(textBox2.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Asign();
            textBox3.Text = Convert.ToString(cc.Sum());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Asign();
            textBox3.Text = Convert.ToString(cc.Subtract());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Asign();
            textBox3.Text = Convert.ToString(cc.Multiply());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Asign();
            textBox3.Text = Convert.ToString(cc.Divide());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Asign();
            textBox3.Text = Convert.ToString(cc.Modulus()); 
        }
        private void button15_Click(object sender, EventArgs e)
        {
            Asign();
            textBox3.Text = Convert.ToString(cc.Power());
        }
        private void button20_Click(object sender, EventArgs e)
        {
            Asign();
            textBox3.Text = Convert.ToString(cc.Factoctoriel());
        }
    }
    }

