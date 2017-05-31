using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_de_prestamos
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label02_Click(object sender, EventArgs e)
        {

        }
        
        private void label05_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "")
            {

                double iMensual;
                iMensual = double.Parse(textBox2.Text) / 100;

                decimal tY = numericUpDown1.Value;

                decimal tM = numericUpDown2.Value;

                int tiempoY = Convert.ToInt16(tY);

                int tiempoM = Convert.ToInt16(tM);

                int totalT = (tiempoY * 12) + tiempoM;


                int prestado;
                prestado = int.Parse(textBox1.Text);

                double intereses = prestado * iMensual;
                label06.Text = Convert.ToString(intereses);

                double pagos = intereses * totalT;
                label03.Text = Convert.ToString(pagos);

                double plus = pagos + prestado;
                label04.Text = Convert.ToString(plus);

                label01.Text = Convert.ToString(plus / totalT);

                /*double result;
                result = Math.Pow((iMensual * prestado) / 1 - (1 + iMensual), -totalT);*/

                label02.Text = Convert.ToString(totalT);

                label05.Text = Convert.ToString(iMensual + "%");




            }else {
                double iAnual;
                iAnual = double.Parse(textBox3.Text) / 100;

                decimal tY = numericUpDown1.Value;

                decimal tM = numericUpDown2.Value;

                int tiempoY = Convert.ToInt16(tY);

                int tiempoM = Convert.ToInt16(tM);

                int totalT = (tiempoY * 12) + tiempoM;


                int prestado;
                prestado = int.Parse(textBox1.Text);

                double intereses = prestado * iAnual;
                label06.Text = Convert.ToString(intereses);

                double pagos = intereses * totalT;
                label03.Text = Convert.ToString(pagos);

                double plus = pagos + prestado;
                label04.Text = Convert.ToString(plus);

                label01.Text = Convert.ToString(plus / totalT);

                /*double result;
                result = Math.Pow((iMensual * prestado) / 1 - (1 + iMensual), -totalT);*/

                label02.Text = Convert.ToString(totalT);

                label05.Text = Convert.ToString(iAnual + "%");
            
            }
        }
        



    
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            label01.Text = "0";
            label02.Text = "0";
            label03.Text = "0";
            label04.Text = "0";
            label05.Text = "0";
            label06.Text = "0";

        }
    }
}