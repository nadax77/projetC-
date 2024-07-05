using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace examan
{
    public partial class Selectionnational : Form

    {
        private MySqlConnection cns;

        public Selectionnational()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Selectionnational gesetud = new Selectionnational();
            MySqlDataReader Rs;
            Rs = gesetud.Consulter();
            DataTable dt = new DataTable();
            dt.Load(Rs);
            Getlistselectionnational.DataSource = dt;
        }

        private MySqlDataReader Consulter()
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string xnom, xsurnom, xnombrematchinterieur, xnombrematchexterieur;

            xnom = Txt_nom.Text;
            xsurnom = Txt_surnom.Text;
            xnombrematchinterieur = Txt_nombrematchinterieur.Text;
            xnombrematchexterieur = Txt_nombrematchexterieur.Text;

            if (!string.IsNullOrEmpty(xnom) && xsurnom != "" && xnombrematchinterieur != "" && xnombrematchexterieur != "" )
            {
                Class1 gesetud = new Class1();
                gesetud.Ajouter(xsurnom, xnombrematchinterieur, xnombrematchexterieur, xnom);
                MessageBox.Show("Bien Ajouter");
                
            }
        }
    }
    }

