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
    public partial class Form2 : Form
    {
        public Form2( string v)
        {
            InitializeComponent();
            textBoxMultitexto.Text = v;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
