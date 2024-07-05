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
                string Query = "SELECT * FROM selectionnational ORDER BY sunom";
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
        public void Ajouter(string surnom, string nombrematchinterieur, string nombrematchexterieur, string nom)
        {
            try
            {
                string Query = "INSERT INTO selectionnational (nom,surnom,nombrematchinterieur,nombrematchexterieur) VALUES ('" + nom + "','" + surnom + "','" + nombrematchinterieur + "','" + nombrematchexterieur + ")";
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
        public void Modifier(string Login, string Pwd)
        {
            try
            {
                string Query = "UPDATE tblclogin SET username='" + Login + "' where password='" + Pwd + "'";
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

    }
}