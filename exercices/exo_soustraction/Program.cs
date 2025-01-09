
int soustraite(int nombreA , int nombreB)
{
    int result = nombreA - nombreB;

    Console.WriteLine($"Je soustrait {nombreA} et {nombreB}");

    return result;
}

Console.WriteLine($"Résultat de ma soustraction: {soustraite(12,15)}.");