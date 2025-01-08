

// ***********************************
// Variables locales
// ***********************************
Random monRandom = new Random();

String[] tabParticipants = {
        "Matteo" ,
        "Mathieu" ,
        "Leslie" ,
        "Gaelle" ,
        "Léandre" ,
        "Mamadou" ,
        "Valentin" ,
        "Jamel" ,
        "Melvin",
        "Madhi",
        "Rémi:)"
        };

String[] tabGagnants = new string[0];

int nbAAjouter;
int saisieUserMenu = 0;
int numeroTire = 12;

string espace = "";

// *******************************************************
// Main
// *******************************************************



do
{
    Console.WriteLine("==== Le SUPERBE tirage au sort du C# ==== \n");
    Console.WriteLine(@"
1 - Effectuer un tirage
2 - Voir la liste des heureux gagnants
3 - Voir la liste des participants restants
0 - Quitter ");

    Console.Write("\nFaites votre choix dans le menu: ");
    //saisieUserMenu = Convert.ToInt32(Console.ReadLine());
    int.TryParse(Console.ReadLine(), out saisieUserMenu);

    switch (saisieUserMenu)
    {
        case 0:
            Environment.Exit(0);
            break;

        case 1:
            tirerGagnant();
            break;

        case 2:
            listerGagnants();
            break;
        case 3:
            listerParticipants();
            break;

        default:
            Console.Clear();
            break;
    }

}
while (true);



// *******************************************************
// fonctions locales
// *******************************************************

void tirerGagnant()
{
    String gagnant = "";

    numeroTire = monRandom.Next(0, tabParticipants.Length + 1);

    Console.WriteLine(numeroTire);


    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(
$@"***************************************
***** L'heureu.x.se gagnant.e est: {gagnant} *****
**************************************");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\n\n");
}

// *******************************************************
void listerGagnants()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(
@"****************************************
***** Les heureu.x.se gagnant.e.s ! *****
*****************************************");
    Console.ForegroundColor = ConsoleColor.White;

    espace = "";

    foreach (string gagnants in tabGagnants)
    {
        if (gagnants != "")
        {
            Console.WriteLine(espace + gagnants);
            espace += " ";
        }
    }
    Console.WriteLine("\n\n");


}// *******************************************************

void listerParticipants()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(
@"***************************************
***** N'ont pas encore été tirés *****
**************************************");
    Console.ForegroundColor = ConsoleColor.White;

    espace = "";

    foreach (string participant in tabParticipants)
    {
        if (participant != "")
        {
            Console.WriteLine(espace + participant);
            espace += " ";
        }
    }
    Console.WriteLine("\n\n");
}