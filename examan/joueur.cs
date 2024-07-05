using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace examan
{
    public partial class joueur : Form
    {
        public void GetListJoueur()
        {
            Class1 Etudiant = new Class1();
            MySqlDataReader Rs;
            Rs = Etudiant.Lister();
            DataTable dt = new DataTable();
            dt.Load(Rs);
            dataGridView1.DataSource = dt;

        }
        public joueur()
        {
            InitializeComponent();
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ajouter_Click(object sender, EventArgs e) {
          string xNom, xPosition, xAge, xExprimente ;
        xNom = Txt_nom.Text;
        xPosition = Txt_position.Text;
        xAge = Txt_age.Text;
        xExprimente = txt_experimente.Text;

            if (!string.IsNullOrEmpty(xNom) && xPosition != "" && xAge != "" && xExprimente != "")
            {
                Class1 Spt = new Class1();
                Spt.Ajouter(xNom, xPosition , xAge , xExprimente);
                MessageBox.Show("Bien Ajouter");
                GetListJoueur();

            }
    }

        private void bt_afficher_Click(object sender, EventArgs e)
        {
            GetListJoueur();
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            String xnom;
            xnom = Txt_nom.Text;

            Class1 Spt = new Class1();
            Spt.Suppression(xnom);
            GetListJoueur();
        }

        private void joueur_Load(object sender, EventArgs e)
        {
            GetListJoueur();

        }
    }

    
    }

