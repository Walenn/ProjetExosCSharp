
using Citernes.Classes;

Citerne Citerne1 = new Citerne(niveauRemplissage: 10, capaciteTotale: 20, poidsVide: 10);
Citerne Citerne2 = new Citerne(niveauRemplissage: 10, capaciteTotale: 10, poidsVide: 5);
Citerne Citerne3 = new Citerne(niveauRemplissage: 6, capaciteTotale: 10, poidsVide: 5);

Console.WriteLine($"Poids total de la citerne 1 : {Citerne1.TotalWeight}");
Console.WriteLine($"Poids total de la citerne 2 : {Citerne2.TotalWeight}");

Console.WriteLine("----------------------");

Console.WriteLine($"Quantité d'eau dans la citerne 1 : {Citerne1.NiveauRemplissage}");
//Citerne1.AffichageCiterne();
Console.WriteLine($"Quantité d'eau dans la citerne 2 : {Citerne2.NiveauRemplissage}");
//Citerne2.AffichageCiterne();
Console.WriteLine($"Quantité d'eau dans la citerne 3 : {Citerne3.NiveauRemplissage}");

Console.WriteLine($"Quantité d'eau dans toutes les Citerne : {Citerne.VolumeTotal}");

Console.WriteLine("----------------------");

int excessWater = Citerne1.remplir(11);
Console.WriteLine($"Quantité d'eau dans la citerne 1 après ajout de 11 litres: {Citerne1.NiveauRemplissage}/{Citerne1.CapaciteTotale}");
Console.WriteLine($"Excès d'eau récupéré : {excessWater}");
Console.WriteLine($"Quantité d'eau dans toutes les Citerne : {Citerne.VolumeTotal}");

Console.WriteLine("----------------------");
int waterTaken = Citerne2.vider(8);
Console.WriteLine($"Quantité d'eau dans la citerne 2 après tentative de retrait de 11 litres: {Citerne2.NiveauRemplissage}/{Citerne2.CapaciteTotale}");
Console.WriteLine($"Quantité d'eau récupérée : {waterTaken}");
Console.WriteLine($"Quantité d'eau dans toutes les Citerne : {Citerne.VolumeTotal}");

Console.WriteLine("----------------------");

Console.WriteLine($"Quantité d'eau dans la citerne 1 : {Citerne1.NiveauRemplissage}");
//Citerne1.AffichageCiterne();
Console.WriteLine($"Quantité d'eau dans la citerne 2 : {Citerne2.NiveauRemplissage}");  
//Citerne2.AffichageCiterne();
Console.WriteLine($"Quantité d'eau dans toutes les Citerne : {Citerne.VolumeTotal}");