

Console.WriteLine("--- Calcul de la longueur de l'hypothénuse ---");
Console.Write("Entrez en cm la longueur du premier côté: ");
Double var_cote1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez en cm la longueur du second côté: ");
Double var_cote2 = Convert.ToDouble(Console.ReadLine());

Double var_hypo = Math.Sqrt(Math.Pow(var_cote1,2) + Math.Pow(var_cote2,2));


Console.WriteLine($"La longueur de l'hypothénuse est: {var_hypo}.");