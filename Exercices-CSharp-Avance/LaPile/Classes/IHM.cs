using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPile.Classes;

internal static class IHM
{

    private static Pile<String> pileString = new Pile<String>();


    public static void Start()
    {
        while (true)
        {
            AfficherMenu();
            string choix = Console.ReadLine()!;
            switch (choix)

            {
                case "1":
                    Empiler();
                    Console.Clear();
                    break;
                case "2":
                    Depiler();
                    Console.Clear();
                    break;
                case "3":
                    //RecupererX();
                    break;

                case "0":
                    Console.Clear(); // Essentiel de nettoyer derrière soi avant de tout fermer
                    return;

                case "4":
                    Afficher();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Erreur de saisie.");
                    break;
            }
        }
    }


    public static void AfficherMenu()
    {
        
        Console.WriteLine("===== Menu Principal =====\n");
        Console.WriteLine("1-- Empiler");
        Console.WriteLine("2-- Dépiler");
        Console.WriteLine("3-- Récupérer à X");
        Console.WriteLine("4-- Afficher toute la pile");
        Console.WriteLine("0-- Quitter");
        Console.Write("\nVotre choix : ");
    }


    public static void Empiler()
    {
        Afficher();
        Console.WriteLine("\nValeur à empiler: ");
        String choixValeur = Console.ReadLine();

            //if (Decimal.TryParse(Console.ReadLine(), out choixValeur))
            //{
            pileString.Empiler(choixValeur);
        //}
    }
    public static void Depiler()
    {
        Console.WriteLine($"Valeur dépilée: {pileString.Depiler()}");
        
        Afficher();
        Console.ReadLine();

    }
    public static void Afficher()
    {
        Console.WriteLine(pileString);
    }
}
