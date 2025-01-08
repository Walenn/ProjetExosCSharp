

Console.WriteLine("--- Calcul de périmètre et de l'aire d'un carré ---");
Console.Write("Entrez en cm la longueur d'un côté du rectangle: ");
Double var_Long = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez en cm la largeur d'un côté du rectangle: ");
Double var_Larg = Convert.ToDouble(Console.ReadLine());

Double var_perim = (var_Long * 2) + (var_Larg * 2);

Double var_aire = var_Long  * var_Larg;


Console.WriteLine($"Le périmètre du rectangle est: {var_perim}.");

Console.WriteLine($"L'aire  du rectangle est: {var_aire}.");