
Console.WriteLine("--- Quelle catégorie est mon enfant ? ---");


Console.Write("Indiquez l'age de l'enfant: ");
int ageBambin = Convert.ToInt32(Console.ReadLine());

switch (ageBambin)
{
    case < 6 and >= 3:
        Console.WriteLine("Votre enfant est \"Baby\" !");
        break;
    case <= 8:
        Console.WriteLine("Votre enfant est \"Poussin\" !");
        break;
    case <= 10:
        Console.WriteLine("Votre enfant est \"Pupille\" !");
        break;
    case <= 12:
        Console.WriteLine("Votre enfant est \"Minime\" !");
        break;
    case > 13 and < 18:
        Console.WriteLine("Votre enfant est \"Cadet\" !");
        break;
    default:
        Console.WriteLine("Cet enfant n'est pas correct...");
        break;
}

