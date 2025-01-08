// ***********************************
// Variables locales
// ***********************************

int nbNotes = 0;
int sommeNotes = 0;
int noteMin = 20;
int noteMax = 0;

int saisieUserMenu = 0;

int saisieUserNote = 0;

// ***********************************
// fonctions locales

// *******************************************************
void afficherMenu()
{

    do
    {
        Console.WriteLine(@"1 - Saisir les notes
2 - Afficher la plus grande note
3 - Afficher la plus petite note
4 - Afficher la moyenne des notes
0 - Quitter ");

        Console.Write("\nFaites votre choix dans le menu: ");
        saisieUserMenu = Convert.ToInt32(Console.ReadLine());
        
        switch (saisieUserMenu)
        {
            case 0:
                Environment.Exit(0);
                break;

            case 1:
                saisirNotes();
                Console.Clear();
                break;

            case 2:
                laPlusGrandeNote();
                break;
            case 3:
                laPlusPetiteNote();
                break;
            case 4:
                laNoteMoyenne();
                break;
            default:
                Console.Clear();
                break;
        }
        
    }
    while (true);

}

// *******************************************************
void saisirNotes()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"--- Saisir des notes ---\n (Entrez 999 pour stopper ici la saisie)");
    Console.ForegroundColor = ConsoleColor.White;

    do
    {
        Console.Write($"\nMerci de saisir la note {nbNotes+1} (/20) : ");
        int.TryParse(Console.ReadLine(), out saisieUserNote);
        
        if (saisieUserNote >= 0 && saisieUserNote <= 20)
        {
            nbNotes++;
            sommeNotes += saisieUserNote;

            if (saisieUserNote > noteMax)
                noteMax = saisieUserNote;
            if (saisieUserNote < noteMin)
                noteMin = saisieUserNote;
        }
        else if (saisieUserNote != 999)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("             Erreyr de saisie, la note est sur 20 !");
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
    while (saisieUserNote != 999);

}
// *******************************************************
void laPlusGrandeNote()
{
    Console.Clear ();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("--- La plus grande note ---");
    Console.WriteLine($"\nLa note la plus grande est : {noteMax}/20.\n\n");

    Console.ForegroundColor = ConsoleColor.White;
}
// *******************************************************
void laPlusPetiteNote()
{
    Console.Clear ();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("--- La plus petite note ---");
    Console.WriteLine($"\nLa note la plus grande est : {noteMin}/20.\n\n");

    Console.ForegroundColor = ConsoleColor.White;

}
// *******************************************************
void laNoteMoyenne()
{
    Console.Clear ();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("--- La note moyenne ---");
    Console.WriteLine($"\nLa note moyenne est : { sommeNotes/nbNotes }/20.\n\n");

    Console.ForegroundColor = ConsoleColor.White;

}

// *******************************************************
// Main (inutile)
// *******************************************************
Console.WriteLine("--- Gestion des notes avec menu ---\n");

afficherMenu();