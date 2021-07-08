using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace porcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {   
            axWindowsMediaPlayer1.Visible = true;
            pictureBox1.Visible = true;
        }

        private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            pictureBox1.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            button1.Text = "que te dije flaco 🤬😡😡🤬";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {            
            pictureBox1.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            button1.Text = "que te dije flaco 🤬😡😡🤬";
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}    
