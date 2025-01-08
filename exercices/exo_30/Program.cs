Random monRandom = new Random();
String[] paireOuImpair = {"pair", "impair"};

Console.WriteLine("--- Est-il pair ...? Est-il impaire ??? ---");

Console.Write("Combien de nombre contiendra le tableau ? : ");
int.TryParse(Console.ReadLine(), out int longueurTab);

int[]tabEntiers = new int[longueurTab];

for (int i = 0; i < tabEntiers.Length; i++)
{
    tabEntiers[i] = monRandom.Next(1, 51);
}

for (int i = 0; i < tabEntiers.Length; i++)
{
    Console.WriteLine($"Le nombre {tabEntiers[i]} est {paireOuImpair[tabEntiers[i] % 2]}.");
}

