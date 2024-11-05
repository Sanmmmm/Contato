using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(textBox2.Text);
            double altura = Convert.ToDouble(textBox1.Text);
            String valor;

            double imc = peso / (altura * altura);
            if (imc < 16.9)
            {
                textBox3.Text = "Muito abaixo do peso....  ";
                label3.Text =String.Format("Muito abaixo do peso....%0.2f"+imc);

            }
            else if (imc >= 17 && imc <= 18.4)
            {
                textBox3.Text = "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                textBox3.Text = "Peso normal";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                textBox3.Text = "Acima do peso";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                textBox3.Text = "Obesidade grau I";
            }
            else if (imc >= 35 && imc <= 40)
            {
                textBox3.Text = "Obesidade grau II";
            }
            else if (imc > 40)
            {
                textBox3.Text = "Obesidade grau III";
            }

      
        }
    }
}
