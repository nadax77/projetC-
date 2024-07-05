using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net;
using System.Windows.Forms;
namespace Foot
{
    public class Joueur

    {
        MySqlConnection cns = new MySqlConnection("server=localhost;uid=root;database=football");

        private string nom,
        position;
        private int age;
        private bool estExperimente;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public bool EstExperimente
        {
            get { return estExperimente; }
            set { estExperimente = value; }
        }
        public Joueur() { }
        public Joueur(string nom, string position, int age, bool estExperimente)
        {
            this.nom = nom;
            this.position = position;
            this.age = age;
            this.estExperimente = estExperimente;
        }
        public virtual float CalculerPrime(int interne, int externe)
        {
            float prime = 20000 * interne + 30000 * externe;
            return prime = (float)(estExperimente ? 1.5 * prime : prime);
        }
    }

}

