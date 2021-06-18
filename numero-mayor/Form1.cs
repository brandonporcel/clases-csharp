using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numero_mayor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\brand\Imágenes\fox.gif");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            int finalNum;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            num3 = Convert.ToInt32(textBox3.Text);

            if (num1 > num2 && num1 > num3)
            {
                finalNum = num1;

            }
            else if (num2 > num3 && num2 > num1)
            {
                finalNum = num2;
            }
            else if (num3 > num1 && num3 > num2)
            {
                finalNum = num3;
            }
            else
            {
                finalNum = 000000;
            }
            //textBox1.BackColor = Color.Blue;
            //textBox1.ForeColor = Color.White;
            textBox4.Text = finalNum.ToString();
        }
    }
}
