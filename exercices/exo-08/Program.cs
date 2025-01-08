

Console.WriteLine("--- Calcul de TVA ---");
Console.Write("Entrez le prix de l'objet en Euros, HT: ");
Double var_prix_ht = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez le taux de TVA (en %) : ");
Double var_tva = Convert.ToDouble(Console.ReadLine()) / 100;
// TVA stockée en valeur numérique et non en pourcentage pour faciliter les calculs

Double var_montant_tva = var_prix_ht * var_tva;
Double var_prix_ttc = var_prix_ht + var_montant_tva;

Console.WriteLine($"Le montant de la T.V.A. est de {var_montant_tva} Euros.");
Console.WriteLine($"Le prix TTC est de {var_prix_ttc} Euros.");