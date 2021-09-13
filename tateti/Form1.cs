using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tateti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool punto1 = true;
        public int[,] tabla = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        bool averiguarSiGano(int jugador)
        {
            for (int i = 0; i <= 2; i++)
            {
                //horizontal
                if (tabla[i, 0] == jugador && tabla[i, 1] == jugador && tabla[i, 2] == jugador)
                {
                    textBox1.Visible = true;
                    textBox1.Text = "gano simpsons team. horizontes";
                }

                //Vertical
                if (tabla[0, i] == jugador && tabla[1, i] == jugador && tabla[2, i] == jugador)
                {
                    textBox1.Visible = true;
                    textBox1.Text = "gano el jugador amarillo.verticalmente";
                }
            }
            
            if (tabla[0, 0] == jugador && tabla[1, 1] == jugador && tabla[2, 2] == jugador)
            {
                textBox1.Visible = true;
                textBox1.Text = "cruzada";    
            }
            if (tabla[2, 2] == jugador && tabla[1, 1] == jugador && tabla[0, 2] == jugador)
            {
                textBox1.Visible = true;
                textBox1.Text = "yellow team win";

            }

            return false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (punto1)
            {
                pictureBox1.BackColor = pictureBox10.BackColor;
                tabla[0, 0] = 1;
            }
            else
            {
                pictureBox1.BackColor = pictureBox11.BackColor;
                tabla[0, 0] = 2;
            }
            pictureBox1.Enabled = false;
            punto1 =!punto1;
            averiguarSiGano(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (punto1)
            {
                pictureBox2.BackColor = pictureBox10.BackColor;
                tabla[0, 1] = 1;
            }
            else
            {
                pictureBox2.BackColor = pictureBox11.BackColor;
                tabla[0, 1] = 2;
            }
            pictureBox2.Enabled = false;
            punto1 = !punto1;
            averiguarSiGano(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (punto1)
            {
                pictureBox3.BackColor = pictureBox10.BackColor;
                tabla[0, 2] = 1;
            }
            else
            {
                pictureBox3.BackColor = pictureBox11.BackColor;
                tabla[0, 2] = 2;
            }
            pictureBox3.Enabled = false;
            punto1 = !punto1;

            averiguarSiGano(1);
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (punto1)
            {
                pictureBox4.BackColor = pictureBox10.BackColor;
                tabla[1, 0] = 1;
            }
            else
            {
                pictureBox4.BackColor = pictureBox11.BackColor;
                tabla[1, 0] = 2;
            }
            pictureBox4.Enabled = false;
            punto1 = !punto1;

            averiguarSiGano(1);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (punto1)
            {
                pictureBox5.BackColor = pictureBox10.BackColor;
                tabla[1, 1] = 1;
            }
            else
            {
                pictureBox5.BackColor = pictureBox11.BackColor;
                tabla[1, 1] = 2;
            }
            pictureBox5.Enabled = false;
            punto1 = !punto1;

            averiguarSiGano(1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (punto1)
            {
                pictureBox6.BackColor = pictureBox10.BackColor;
                tabla[1, 2] = 1;
            }
            else
            {
                pictureBox6.BackColor = pictureBox11.BackColor;
                tabla[1, 2] = 2;
            }
            pictureBox6.Enabled = false;
            punto1 = !punto1;

            averiguarSiGano(1);
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (punto1)
            {
                pictureBox7.BackColor = pictureBox10.BackColor;
                tabla[2, 0] = 1;
            }
            else
            {
                pictureBox7.BackColor = pictureBox11.BackColor;
                tabla[2, 0] = 2;
            }
            pictureBox7.Enabled = false;
            punto1 = !punto1;

            averiguarSiGano(1);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (punto1)
            {
                pictureBox8.BackColor = pictureBox10.BackColor;
                tabla[2, 1] = 1;
            }
            else
            {
                pictureBox8.BackColor = pictureBox11.BackColor;
                tabla[2, 1] = 2;
            }
            pictureBox8.Enabled = false;
            punto1 = !punto1;

            averiguarSiGano(1);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (punto1)
            {
                pictureBox9.BackColor = pictureBox10.BackColor;
                tabla[2, 2] = 1;
            }
            else
            {
                pictureBox9.BackColor = pictureBox11.BackColor;
                tabla[2, 2] = 2;
            }
            pictureBox9.Enabled = false;
            punto1 = !punto1;

            averiguarSiGano(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            punto1 = true;
            pictureBox1.BackColor = Color.LightGreen;
            pictureBox1.Enabled = true;
            pictureBox2.BackColor = Color.LightGreen;
            pictureBox2.Enabled = true;
            pictureBox3.BackColor = Color.LightGreen;
            pictureBox3.Enabled = true;
            pictureBox4.BackColor = Color.LightGreen;
            pictureBox4.Enabled = true;
            pictureBox5.BackColor = Color.LightGreen;
            pictureBox5.Enabled = true;
            pictureBox6.BackColor = Color.LightGreen;
            pictureBox6.Enabled = true;
            pictureBox7.BackColor = Color.LightGreen;
            pictureBox7.Enabled = true;
            pictureBox8.BackColor = Color.LightGreen;
            pictureBox8.Enabled = true;
            pictureBox9.BackColor = Color.LightGreen;
            pictureBox9.Enabled = true;

            textBox1.Visible = false;

            //reiniciar
            int [, ]tabla= { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        }
    }
}
