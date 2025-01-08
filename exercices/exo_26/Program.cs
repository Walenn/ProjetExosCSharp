Console.OutputEncoding = System.Text.Encoding.UTF8;
// ---------------------------------------------------------------
Random myRandom = new Random();

int reponseNbUser;
int nbMystere = myRandom.Next(1, 51);

int nbEssais = 0;

String plusGrandOuPetit = "";

Console.WriteLine("--- Trouver le nombre mystère (❁´◡`❁) ---");
//Console.WriteLine("nb myst:" + nbMystere + ".");

Console.Write("Veuillez saisir un nombre: ");
reponseNbUser = Convert.ToInt32(Console.ReadLine());
nbEssais++;

while (reponseNbUser != nbMystere)
{
    if (reponseNbUser < nbMystere)
    {
        plusGrandOuPetit = "grand";
    }
    else
    {
        plusGrandOuPetit = "petit";
    }

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Raté, le nombre mystère est plus {plusGrandOuPetit} !");
    Console.ForegroundColor = ConsoleColor.White;

    Console.Write("Veuillez saisir un nombre: ");
    reponseNbUser = Convert.ToInt32(Console.ReadLine());
    nbEssais++;
}

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nBravo, vous avez trouvé en {nbEssais} coup{(nbEssais > 1 ? "s" : "")} !!");
Console.ForegroundColor = ConsoleColor.White;