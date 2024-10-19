using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Revue: Livre
    {
        // ajout des proprietees de la classe 
        public int Numero { get; set; }
        public int Annee { get; set; }
        // ajout des constructeurs pour initialiser ses proprietés
        public Revue(string titre,string auteur,int  nombrepages,int numero, int annee): base(titre,auteur,nombrepages)    
        {
            Numero = numero;
            Annee = annee;
        }
        // afficher les proprités de la classe
        public override  void AfficherDetails()
        {
            Console.WriteLine($"cette revue a pour titre {Titre},pour Auteur {Auteur},pour nombre de pages {NombrePages},pour numero {Numero}, et pour  {Annee}");

        }
    
    }


}
