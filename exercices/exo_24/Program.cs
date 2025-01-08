Console.OutputEncoding = System.Text.Encoding.UTF8;
// ---------------------------------------------------------------
String reponseUser = "";
String reponseNouvelEssai = "";
String bonneReponse = "C";
int nbEssaisRestants = 2;


Console.WriteLine("--- Question à choix multiple (❁´◡`❁) ---");

Console.WriteLine(@"Quelle instruction permet de sortir d'un boucle en C# ?
    a) quit
    b) continue
    c) break
    d) exit
");


do
{
    Console.Write($"Saisir votre réponse: ");
    reponseUser = Console.ReadLine().ToUpper();
    // !int.TryParse(Console.ReadLine(), out choix) 

    if ( reponseUser != bonneReponse)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Réponse incorrecte !");
        Console.ForegroundColor = ConsoleColor.White;
        nbEssaisRestants--;

        if (nbEssaisRestants >= 1)
        {
            Console.Write("Un nouvel essai ? Oui/Non: ");
            reponseNouvelEssai = Console.ReadLine().ToUpper();

            if (reponseNouvelEssai == "OUI") {
                continue ;
            }
            else
            {
                Console.WriteLine("Tant pis... ciao");
                break;
            }
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bravo, c'est la bonne réponse !!");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
while (nbEssaisRestants > 0 && reponseUser != bonneReponse);


