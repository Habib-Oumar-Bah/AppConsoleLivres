using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Roman:Livre
    {
        // ajout des proprietees de la Roman    
        public string Genre { get; set; }
        // ajout des constructeurs pour initialiser ses proprietés
        public Roman(string titre, string auteur, int nombrepages, string genre):base(titre,auteur,nombrepages)
        {
            Genre =genre;
          
        }
        // afficher les proprités de la classe
        public override void AfficherDetails()
        {
            Console.WriteLine($"ce Roman a pour titre {Titre},pour Auteur {Auteur},pour nombre de pages {NombrePages}, et pour genre {Genre}");

        }
    }
}
