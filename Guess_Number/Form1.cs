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
        int randNumber = 0; // переменная для хранения числа заданного компьютером
        int counter = 0;    // переменная - счетчик позиционных совпадений

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
                randNumber = r1.Next(001, 999);
                MessageBox.Show(randNumber.ToString());
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Random r2 = new Random();
                randNumber = r2.Next(00001, 99999);
                MessageBox.Show(randNumber.ToString());
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Random r3 = new Random();
            randNumber = r3.Next(0000001, 9999999);
            MessageBox.Show(randNumber.ToString());
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
            MessageBox.Show(number.ToString());
            if (number == randNumber)
            {
                MessageBox.Show("Вітаю! Ви перемогли! :)");
            }
            else
            {
                //for (int i = number; i > 0; i /= 10)
                //{
                //    int temp = i % 10;
                //    for (int j = randNumber; j > 0; j /= 10)
                //    {
                //        int temp1 = j % 10;
                //        if (temp == temp1)
                //            counter++;
                //    }
                //}
                MessageBox.Show(counter.ToString());
            }
        }
    }
}
