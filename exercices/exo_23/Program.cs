Console.OutputEncoding = System.Text.Encoding.UTF8;


// ---------------------------------------------------------------
//   Version colorée et festive bien qu'inefficace
// ---------------------------------------------------------------

Console.WriteLine("--- Super sapin 🎄(✿ ◡‿◡) ---");

Console.Write($"Saisir la hauteur du triangle: ");
int nbUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");


// Random à boules
Random myObject = new Random();


Console.ForegroundColor = ConsoleColor.Green;

for (int i = 0; i < nbUser; i++)
{
    for (int j = 0; j < nbUser - 1 - i; j++)
    {
        Console.Write(" ");
    }

    Console.Write("*");
    for (int k = 0; k < i; k++)
    {
        // Version avec des boules
        if (myObject.Next(10) <= 5 && i > 1)
        {
            Console.Write("*");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.Write("**");
        }

    }

    Console.WriteLine("");


    // ------------------------------------------------------------
    // Version classique
    /*

    Console.WriteLine("--- Super sapin ---");

    Console.Write($"Saisir la hauteur du triangle: ");
    int nbUser = Convert.ToInt32(Console.ReadLine());
    //int nbUser = 4;
    Console.WriteLine("\n");

    String etage = "";

    // Random à boules
    Random myObject = new Random();


    Console.ForegroundColor = ConsoleColor.Green;

    for (int i = 0; i < nbUser; i++)
    {
        for (int j = 0; j < nbUser-1-i; j++)
        {
            etage += " ";
        }

        etage += "*";
        for (int k = 0; k < i; k++)
        {
            //etage += "**";

            // Version avec des boules
            if (myObject.Next(2) == 0 && i > 1)
            {
                etage += "*o";
            }
            else
            {
                etage += "**";
            }

        }

        Console.WriteLine(etage);
        etage = "";
    }
    */
}