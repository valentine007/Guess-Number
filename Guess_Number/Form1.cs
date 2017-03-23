using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_Number
{
    public partial class Form1 : Form
    {
        int number = 0; /// <summary>
                        /// Переменная для хранения числа заданного пользователем
                        /// </summary>
        int level = 0;  // переменная для цикла
        int randNumber = 0; // переменная для хранения числа заданного компьютером
        int counter = 0;    // переменная - счетчик позиционных совпадений
        static int tryes = 0;   // переменная - счетчик для хранения общего количества попыток

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тепер не ображайтесь :)");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Random r1 = new Random();
                level = 3;
                randNumber = r1.Next(100, 999);
                MessageBox.Show(randNumber.ToString());
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Random r2 = new Random();
                level = 5;
                randNumber = r2.Next(10000, 99999);
                MessageBox.Show(randNumber.ToString());
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Random r3 = new Random();
                level = 7;
                randNumber = r3.Next(1000000, 9999999);
                MessageBox.Show(randNumber.ToString());
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberField_TextChanged(object sender, EventArgs e)
        {
            number = Convert.ToInt32(numberField.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tryes++;
            label6.Text = tryes.ToString();
            MessageBox.Show(number.ToString());
            textBox3.Text = number.ToString();
            if (number == randNumber)
            {
                MessageBox.Show("Вітаю! Ви перемогли! :)");
            }
            else
            {
                int temp1 = 0;
                int temp2 = 0;
                for (int i = 0; i < level; ++i)
                {
                    temp1 = number % 10;
                    temp2 = randNumber % 10;
                    if (temp1 == temp2)
                        counter++;
                    number /= 10;
                    randNumber /= 10;
                }
                MessageBox.Show(counter.ToString());
                textBox5.Text = counter.ToString();
                counter = 0;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
