

Console.WriteLine("--- Tables de multiplication ---");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($@"Table de {i}:");

    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($@"       - {i} x {j} = {i*j}");

    }
}