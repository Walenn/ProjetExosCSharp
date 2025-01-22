using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo7_CompteEnBanque.Classes
{
    internal class Client
    {
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public int Identifiant { get; set; }
        public int Telephone {  get; set; }  
        public List<CompteBancaire> Comptes { get; set; }

        /// <summary>
        /// Constructeur de Client sans compte bancaire
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="identifiant"></param>
        /// <param name="telephone"></param>
        public Client(string nom, String prenom, int identifiant, int telephone)
        {
            Nom = nom;
            Prenom = prenom;
            Identifiant = identifiant;
            Telephone = telephone;
            Comptes = new List<CompteBancaire>();
        }  
    }
}
