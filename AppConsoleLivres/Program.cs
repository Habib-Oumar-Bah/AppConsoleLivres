using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        // les instances de la classe Revue
        Revue revue1 = new Revue("Science et Vie", "Brrraou", 202, 85, 2009);
        Revue revue2 = new Revue("National Geographic", "Roger", 400, 25, 2012);
        Revue revue3 = new Revue("Election presidentielle", "Cellou Dalein", 108, 5, 2010);
        // la création d'une liste et l'ajout des élèments dans la liste
        List<Revue> Revues = new List<Revue> { revue1, revue2, revue3 };
        Console.WriteLine("les revues a notre dispositions sont  :");
        foreach (var revue in Revues)
        {
            revue.AfficherDetails();
        }
        Console.WriteLine();


        // les instances de la classe Roman
        Roman roman1 = new Roman("l'etrande destin de wangrin", "Amadou Hampâté Bâ",400,"Hisoire");
        Roman roman2 = new Roman("pere riche pere pauvre", " Robert T. Kiyosaki et Sharon Lechter ", 251, "Education financiere");
        Roman roman3 = new Roman("One piece ", "Eichiro Oda", 1036, "Aventure");
        // la création d'une liste et l'ajout des élèments dans la liste
        List<Roman> Romans = new List<Roman> { roman1, roman2, roman3 };
        Console.WriteLine("les romans a notre dispositions sont :");
        foreach (var Roman in Romans)
        {
            Roman.AfficherDetails();
        }
        Console.WriteLine();


        //Une liste generique de livre 
        List<Livre> livres = new List<Livre> { revue1, revue2, revue3, roman1, roman2, roman3 };

        Console.WriteLine("les Livres a notre dispositions sont :");
        foreach (var Livre in livres)
        {
            Livre.AfficherDetails();
        }
    }
}