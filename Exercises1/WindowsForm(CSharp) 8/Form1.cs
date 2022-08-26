using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_CSharp__8
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int attemps = 1;
        public int password0 = 654;
        private void button1_Click(object sender, EventArgs e)
        {
            int passwordN = int.Parse(textBox1.Text);
            if (password0 == passwordN)
            {
                label3.Text = "Acceso permitido.";
                button1.Enabled = false;
            }

            else
            {
                if (attemps < 3)
                {
                    label3.Text = "Acceso denegado.";
                    attemps = attemps + 1;
                    label2.Text = attemps.ToString();
                    textBox1.Text = "";
                }
                else 
                {
                    label3.Text = "Clave bloqueada.";
                    textBox1.Text = "";
                    button1.Enabled = false;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
