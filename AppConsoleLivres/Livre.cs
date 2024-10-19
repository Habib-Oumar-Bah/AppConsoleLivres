using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Livre
    {
          //ajoutez les proprietes associees au Livre
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NombrePages { get; set; }

        // ajouter un constructeur a la classe Livres pour initialiser ses proprietes
        public Livre(string titre, string auteur, int nombrepages)
        {

            Titre = titre;
            Auteur = auteur;
            NombrePages =nombrepages;
        }
        //ajouter une methode afficher
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"le Titre du livre est {Titre},son autaur est {Auteur},il a pour nombre de page  {NombrePages}");
        }

    }

}
