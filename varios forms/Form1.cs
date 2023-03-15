using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace varios_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxNome.Text == "")
            {
                MessageBox.Show("Por favor insira u nome no campo!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information );
                textBoxNome.Focus();
                return;
            }
            textBoxMultiTexto.Text = textBoxNome.Text + ",";
            textBoxNome.Clear();
            textBoxNome.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            textBoxMultiTexto.Clear();
            textBoxNome.Focus();
        }
    }
}
