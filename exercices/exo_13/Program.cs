

Console.WriteLine("--- Quelle est la nature du triangle ABC ? ---");
Console.Write("Entrez la Longueur du segment AB : ");
int coteAB = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez la Longueur du segment BC : ");
int coteBC = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez la Longueur du segment CA : ");
int coteCA = Convert.ToInt32(Console.ReadLine());



if (coteAB == coteBC)
{
    if (coteAB == coteCA)
    {
        Console.WriteLine("Le triangle est équilatéral");
    }
    else
    {
        Console.WriteLine("triangle isocèle en B, et n'est pas équilatéral");
    }
}
else if (coteAB == coteCA)
{
    Console.WriteLine("triangle isocèle en A, et n'est pas équilatéral");

}
else if (coteBC == coteCA)
{
    Console.WriteLine("triangle isocèle en C, et n'est pas équilatéral");
}
else
{
    Console.WriteLine("Triangle assez commun hein, isocèle ni en A, ni en B, ni en C.");
 }