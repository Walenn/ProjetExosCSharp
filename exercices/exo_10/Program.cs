


Console.WriteLine("--- Est-ce une voyelle ?! ---");
Console.Write("Entrez une lettre: ");
char maLettre = char.ToUpper(Console.ReadLine()[0]);


if (maLettre == 'A'
    || maLettre == 'E'
    || maLettre == 'I'
    || maLettre == 'O'
    || maLettre == 'U'
    || maLettre == 'Y')

    Console.WriteLine("C'est une voyelle, félicitations.");
else
    Console.WriteLine("C'est une consonne, toutes mes excuses...");
