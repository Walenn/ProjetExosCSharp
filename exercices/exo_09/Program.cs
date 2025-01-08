

Console.WriteLine("--- Calcul des intérêts ---");
Console.Write("Entrez le capital de départ en Euros: ");
Double var_capital_dep = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez le taux d'intérêts (en %) : ");
// Taux stocké en valeur numérique et non en pourcentage pour faciliter les calculs
Double var_taux_inter = Convert.ToDouble(Console.ReadLine()) / 100;

Console.Write("Entrez la durée d'épargne, en années : ");
Double var_duree = Convert.ToDouble(Console.ReadLine()) ;

// Calculs
Double var_capital_fin = var_capital_dep * Math.Pow(1 + var_taux_inter, var_duree);
Double var_montant_int = var_capital_fin - var_capital_dep;

// Les valeurs sont arrondies pour faciliter l'affichage utilisateur
Console.WriteLine($"Le montant des intérêts sera de {Math.Round(var_montant_int,2)} Euros après {var_duree} ans.");
Console.WriteLine($"Le capital final sera de {Math.Round(var_capital_fin,2)} Euros.");

