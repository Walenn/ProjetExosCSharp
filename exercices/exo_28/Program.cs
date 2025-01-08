

Console.WriteLine("Insertion de valeurs du tableau");

int[] tabEntiers = new int[10];

for (int i = 0; i < tabEntiers.Length; i++)
{
    Console.Write($"Saisir la valeur {i + 1}: ");
    if (!int.TryParse(Console.ReadLine(), out tabEntiers[i]))
    {
        i--;
    }

}

for (int j = 0; j < tabEntiers.Length; j++)
{
    Console.WriteLine(new String('\t', j) + tabEntiers[j]);
}