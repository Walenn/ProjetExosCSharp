// ***********************************
// Variables locales
// ***********************************

String[] tabContacts = new string[0];
String[] tabContactsTampon = new string[0];

int nbAAjouter;
int saisieUserMenu = 0;

// *******************************************************
// Main
// *******************************************************

do
{
    Console.WriteLine("==== Gestion des contacts \n");
    Console.WriteLine(@"
1 - Saisir les contact
2 - Afficher les contats
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
            saisirContacts();
            Console.Clear();
            break;

        case 2:
            listerContacts();
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
//
//   Saisie Contact 2.0  : Gère l'ajout à la liste à chaque ajout et resize, et non réécriture simple
// 
void saisirContacts()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"--- Saisir des contacts ---\n ");
    Console.ForegroundColor = ConsoleColor.White;

    tabContactsTampon = (String[]) tabContacts.Clone();


    Console.Write($"\nMerci de saisir le nombre de contacts à ajouter : ");
    nbAAjouter = Convert.ToInt32(Console.ReadLine());
    tabContacts = new string[ nbAAjouter + tabContacts.Length ];

    if (tabContacts.Length > 0)
    {
        tabContactsTampon.CopyTo(tabContacts, 0 );

        for (int i = 0; i < nbAAjouter; i++)
        {
            Console.Write($"Nom et prénom du contact n°{tabContacts.Length - nbAAjouter + i+1} : ");
            tabContacts[tabContacts.Length - nbAAjouter  + i] = Console.ReadLine();
        }
    }
}

// *******************************************************

void listerContacts()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("------ Affichage des contacts ------");
    Console.ForegroundColor = ConsoleColor.White;

    for (int i = 0; i < tabContacts.Length; i++)
    {
        Console.WriteLine($"\t- Contact n°{i+1} : {tabContacts[i]}");
    }
}