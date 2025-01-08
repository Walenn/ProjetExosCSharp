

Console.WriteLine("--- Menu et sous-menu ---");

Console.WriteLine("Table des matières:");

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($@"   Chapitre {i}:");

    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine($@"       - Partie {i}.{j}:");
        
    }
}