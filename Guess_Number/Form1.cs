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
        // ========================= //
           /* Questionarie:
           1. Кнопка "Не чіпати" - очистить все поля + остановить таймер
           2. Кнопка "Підтверджую" - после каждого нажатия очищать numberField и запускать таймер
           3. 

           */
        // ========================= //

        int number = 0; /// Переменная для хранения числа заданного пользователем
        int randNumber = 0; // переменная для хранения числа заданного компьютером
        int counter = 0;    // переменная - счетчик позиционных совпадений
        int counter2 = 0;   // переменная - счетчик совпадений цифр
        static int tryes = 0;   // переменная - счетчик для хранения общего количества попыток
        int level = 0;  // переменная для цикла

        int arg1 = 0;   // переменныая для вывода в историю
        int arg2 = 0;   // переменныая для вывода в историю
        string outString = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тепер не ображайтесь :)");
            numberField.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            label6.ResetText();
            label7.ResetText();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Random r1 = new Random();
                level = 3;
                randNumber = r1.Next(100, 999);
#if DEBUG
                MessageBox.Show(randNumber.ToString()); // Debug
#endif
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Random r2 = new Random();
                level = 5;
                randNumber = r2.Next(10000, 99999);
#if DEBUG
                MessageBox.Show(randNumber.ToString()); // Debug
                Console.WriteLine(randNumber.ToString());
#endif
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Random r3 = new Random();
                level = 7;
                randNumber = r3.Next(1000000, 9999999);
                MessageBox.Show(randNumber.ToString()); // Debug
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
            if (numberField.Text !=String.Empty)
                number = Convert.ToInt32(numberField.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tryes++;
            label6.Text = tryes.ToString();
            MessageBox.Show(number.ToString()); // Debug
            textBox3.Text = number.ToString();
            if (number == randNumber)
            {
                MessageBox.Show("Вітаю! Ви перемогли! :)");
            }
            else
            {
                int temp1 = 0;
                int temp2 = 0;
                int temp3 = 0;
                int temp4 = 0;
                int tempNumb = 0;
                int tempRandNumb = 0;

                tempNumb = number;
                tempRandNumb = randNumber;

                for (int i = 0; i < level; ++i)
                {
                    temp1 = tempNumb % 10;
                    temp2 = tempRandNumb % 10;
                    if (temp1 == temp2)
                        counter++;
                    tempNumb /= 10;
                    tempRandNumb /= 10;
                }
                MessageBox.Show(counter.ToString());    // Debug
                textBox5.Text = counter.ToString();
                arg2 = counter;
                counter = 0;

                // ========================== //

                for (int k = number; k > 0; k /= 10)
                {
                    temp3 = k % 10;
                    for (int l = randNumber; l > 0; l /= 10)
                    {
                        temp4 = l % 10;
                        if (temp3 == temp4)
                            counter2++;
                    }
                }
                MessageBox.Show(counter2.ToString());   // Debug
                textBox4.Text = counter2.ToString();
                arg1 = counter2;
                counter2 = 0;

                // ===Переделать на $)))=== //
                outString = "\n" + number.ToString() + " " + arg1.ToString() + " " + arg2.ToString() + "\r\n";
                textBox2.Text += outString;


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
