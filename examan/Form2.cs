using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selectionnational gesetud = new Selectionnational();
            gesetud.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new joueur().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entraineur gesetud = new entraineur();
            gesetud.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            international gesetud = new international();
            gesetud.Show();
        }
    }
}
