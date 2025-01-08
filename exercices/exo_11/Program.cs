

Console.WriteLine("--- Le nombre est-il divisible par..?!? ---");
Console.Write("Entrez un chiffre/nombre entier: ");
int chiffre1 = Convert.ToInt32(Console.ReadLine()) ; 

Console.Write("Entrez un chiffre/nombre diviseur: ");
int chiffre2 = Convert.ToInt32(Console.ReadLine()) ; 



if ( (chiffre1 % chiffre2)  == 0)
{
    if (chiffre1 >= 10)
    {
        Console.Write($"Le nombre {chiffre1} est divisible par {chiffre2}.");
    }
    else
    {
        Console.Write($"Le chiffre {chiffre1} est divisible par {chiffre2}.");
    }

}
else
{
    if (chiffre1 >= 10)
    {
        Console.Write($"Le nombre {chiffre1} n'est pas divisible par {chiffre2}.");
    }
    else
    {
        Console.Write($"Le chiffre {chiffre1} n'est pas divisible par {chiffre2}.");
    }
}