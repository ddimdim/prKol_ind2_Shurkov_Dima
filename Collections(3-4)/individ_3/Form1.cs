using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace prakt15_2
{
    public partial class Form1 : Form
    {
        ArrayList answers = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double real1 = Convert.ToDouble(numericUpDown1.Value);
            double imaginary1 = Convert.ToDouble(numericUpDown2.Value);
            double real2 = Convert.ToDouble(numericUpDown4.Value);
            double imaginary2 = Convert.ToDouble(numericUpDown3.Value);
            if (real1 == 0 || imaginary1 == 0 || real2 == 0 || imaginary2 == 0)
                MessageBox.Show("Введите все необходимые данные", "Ошибка");
            else
            {
                ComplexNumbers complex = new ComplexNumbers(real1, imaginary1, real2, imaginary2);
                MessageBox.Show("Ответ добавлен в список, чтобы список ответов можно вывести список", "Успешно");
                answers.Add(complex.sum());
                label6.Text = $"Ответ: {complex.sum()}";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double real1 = Convert.ToDouble(numericUpDown1.Value);
            double imaginary1 = Convert.ToDouble(numericUpDown2.Value);
            double real2 = Convert.ToDouble(numericUpDown4.Value);
            double imaginary2 = Convert.ToDouble(numericUpDown3.Value);
            if (real1 == 0 || imaginary1 == 0 || real2 == 0 || imaginary2 == 0)
                MessageBox.Show("Введите все необходимые данные", "Ошибка");
            else
            {
                ComplexNumbers complex = new ComplexNumbers(real1, imaginary1, real2, imaginary2);
                MessageBox.Show("Ответ добавлен в список, чтобы список ответов можно вывести список", "Успешно");
                answers.Add(complex.subtraction());
                label6.Text = $"Ответ: {complex.subtraction()}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double real1 = Convert.ToDouble(numericUpDown1.Value);
            double imaginary1 = Convert.ToDouble(numericUpDown2.Value);
            double real2 = Convert.ToDouble(numericUpDown4.Value);
            double imaginary2 = Convert.ToDouble(numericUpDown3.Value);
            if (real1 == 0 || imaginary1 == 0 || real2 == 0 || imaginary2 == 0)
                MessageBox.Show("Введите все необходимые данные", "Ошибка");
            else
            {
                ComplexNumbers complex = new ComplexNumbers(real1, imaginary1, real2, imaginary2);
                MessageBox.Show("Ответ добавлен в список, чтобы список ответов можно вывести список", "Успешно");
                answers.Add(complex.multiplication());
                label6.Text = $"Ответ: {complex.multiplication()}";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = answers.Count-1; i >= 0; i--)
            {
                listBox1.Items.Add(answers[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            answers.Clear();
            listBox1.Items.Clear();
        }
    }
}
