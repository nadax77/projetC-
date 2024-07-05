using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace examan
{
    internal class Class1
    {
        MySqlConnection cns = new MySqlConnection("server=localhost;uid=root;database=examen");

        public MySqlDataReader Lister()
        {
            try
            {
                string Query = "SELECT * FROM joueur";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                MySqlDataReader Rs = cmd.ExecuteReader();
                return Rs;
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Lister", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
        public bool Authentification(string id, string password)
        {
            try
            {
                bool Result = false;
                string Query = "SELECT * FROM tblogin WHERE Login='" + id + "' AND Pwd='" + password + "'";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                MySqlDataReader Rs = cmd.ExecuteReader();
                if (Rs.HasRows) Result = true;
                cns.Close();
                return Result;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        

        public MySqlDataReader Consulter()
        {
            try
            {
                string Query = "SELECT * FROM joueur ORDER BY nom";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                MySqlDataReader Rs = cmd.ExecuteReader();
                return Rs;
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Consulter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
        public void Ajouter(string Nom, string Position, string Age, string Experiment)
        {
            try
            {
                string Query = "INSERT INTO joueur (nom, position, age, experiment) VALUES ('" + Nom + "','" + Position + "','" + Age + "','" + Experiment + ")";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();

                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Modifier(string nom, string position, string age, string experiment)
        {
            try
            {
                string Query = "UPDATE joueur SET nom='" + nom + "' where position='" + position + "'";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Suppression(string nom)
        {
            try
            {
                string Query = "DELETE FROM joueur where nom='" + nom + "'";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      

    }
}