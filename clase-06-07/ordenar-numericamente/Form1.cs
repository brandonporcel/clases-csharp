using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenar_numericamente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] a = listBox1.Items.Cast<string>().ToArray();


            listBox1.Items.Clear();


            var ret = a.OrderBy(p => int.Parse(p));


            foreach (var item in ret)
            {
                listBox1.Items.Add(item.ToString());
            }


            //es por aca pero no funca XD----------------------------------------------------------
            //int[] arr = new int[listBox1.Items.Count - 1];
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    arr.OrderBy(x =>x);
            //    arr[i] = int.Parse(listBox1.Items[i].ToString());
            //}

            //cartListBox.Items.Clear();
            //cartListBox.Items.AddRange(items);



        }
    }
}
