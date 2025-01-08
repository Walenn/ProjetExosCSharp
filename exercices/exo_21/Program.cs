
Console.WriteLine("--- Accroissement de population ---");

int nbHab = 96809;
double tauxAccr = 0.0089;
int nbAnnee = 0;

while (nbHab < 120000)
{
    nbHab += Convert.ToInt32(Math.Floor((nbHab * tauxAccr)));
    nbAnnee++;
}

Console.WriteLine($"Il faudra {nbAnnee} ans, nous serons en {2025+nbAnnee}");
Console.WriteLine($"Il y aura {nbHab} habitants en {2025+nbAnnee}");