

Console.WriteLine("--- Quel sera le montant de l'indemnité de licenciement ? ---");

Console.Write("Saisissez votre dernier salaire (en Euros): ");
int varSalaire = Convert.ToInt32(Console.ReadLine());

Console.Write("Saisissez votre age: ");
int varAge = Convert.ToInt32(Console.ReadLine());

Console.Write("Saisissez votre nombre d'années d'ancienneté: ");
int varAnciennete = Convert.ToInt32(Console.ReadLine());
int varMontantIndm = 0;


// Indemnité par ancienneté
switch (varAnciennete)
{
    case > 0 when (varAnciennete < 10):
        varMontantIndm = varAnciennete * (varSalaire / 2);
        break;

    case >= 10:
        varMontantIndm = varAnciennete * varSalaire;
        break;

    default:
        break;
}
// Indemnité par age > 45 ans
switch (varAge)
{
    case >= 45 when (varAge < 50):
        varMontantIndm += varSalaire * 2;
        break;

    case >= 50:
        varMontantIndm += varSalaire * 5;
        break;

    default:
        break;
}

Console.WriteLine($"Votre indemnité est de: {varMontantIndm}euros. Au revoir.");