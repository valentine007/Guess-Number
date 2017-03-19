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
                int easyNumber = r1.Next(001, 999);
                MessageBox.Show(easyNumber.ToString());
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Random r2 = new Random();
                int mediumNumber = r2.Next(00001, 99999);
                MessageBox.Show(mediumNumber.ToString());
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Random r3 = new Random();
            int hardNumber = r3.Next(0000001, 9999999);
            MessageBox.Show(hardNumber.ToString());
        }
    }
}
