using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace examan
{
    public partial class joueur : Form
    {
        public joueur()
        {
            InitializeComponent();
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            string xnom, xage, xposition, xexperience, xprime;
            DateTime xDateNaissance;

            xnom = Txt_nom.Text;
            xage = Txt_age.Text;
            xposition = Txt_position.Text;
            xexperience = cmb_experience.Text;
            xprime =Txt_prime.Text;

            if (!string.IsNullOrEmpty(xnom) && xage != "" && xposition != "" && xexperience != "" && xprime !=  "")
            {
                Class2 gesetud = new Class2();
                gesetud.Ajouter(xnom, xage, xposition,  xexperience, xprime);
                MessageBox.Show("Bien Ajouter");
                GetListjoueur();
            }
        }

        private void GetListjoueur()
        {
            throw new NotImplementedException();
        }
    }
}
