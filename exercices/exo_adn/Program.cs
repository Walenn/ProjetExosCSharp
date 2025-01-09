
//3.
//Écrire une fonction
//proportion
//qui reçoit deux paramètres : une chaine d’ADN et une
//séquence d’ADN. Elle renverra le % d’occurrences de la séquence dans la chaîne
//4.
//Créer des instructions pour pouvoir tester le programme

using System.Collections.Concurrent;
using System.Threading.Channels;

String chaineAdn = "tcatcatcatcagtatgcatta";


// **************************************************
bool verification_adn(String paramChaineAdn)
{
    bool estCorrect = true;

    foreach (char lettre in paramChaineAdn)
    {
        if(lettre != 'a' &&  lettre != 't' && lettre != 'c' && lettre != 'g')
        {
            //Console.WriteLine("DEBUG Premiere lettre non correct: " + lettre);
            estCorrect = false; 
            break;
        }
    }

    return estCorrect;
}

// **************************************************

String saisie_adn()
{
    String adnSaisi = "";

    Console.Write("\nSaisissez votre chaine ADN : ");
    adnSaisi = Console.ReadLine();

    while( ! verification_adn(adnSaisi))
    {
        Console.Write("Votre chaine est incorrecte, veuillez resaisir : ");
        adnSaisi = Console.ReadLine();
    } 

    return adnSaisi;
}
// **************************************************

double proportion (String paramChaineAdn , String sequenceAdn) {
    int qteApparitionSequence = 0;

    
    for (int i = 0; i < paramChaineAdn.Length; i++) 
    {
        if (paramChaineAdn[i] == sequenceAdn[0])
        {
            // Premier char de ma séquence trouvée en chaine, je recherche spécifiquement la suite
            for (int j = 1; j < sequenceAdn.Length; j++)
            {

                // Le maillon j de ma séquence ne correspond plus à ma chaine: fin de reconnaissance de séquence
                if (sequenceAdn[j] != paramChaineAdn[i + j])                
                    break;
                
                // Dernier maillon de ma séquence atteint et correspondance parfaite: séquence trouvée en chaine
                if (j == sequenceAdn.Length - 1)
                {
                    qteApparitionSequence++;
                    // Choix arbitraire de ne compter chaque maillon de ma chaine que pour une unique séquence,
                    // donc avance le curseur de lecture de ma chaine 
                    i += sequenceAdn.Length -1;
                }
            }
        }
    }

    Console.WriteLine($"Sequence longue de {sequenceAdn.Length} lettres, trouvée {qteApparitionSequence}" +
        $"fois pour {chaineAdn.Length} de long.");

    // Calcul du % d'apparition de la séquence par rapport à la chaine en entier
    return Math.Round(((double)(sequenceAdn.Length * qteApparitionSequence) / chaineAdn.Length * 100), 2);
}

// **************************************************
// Main

Console.WriteLine("Ma chaine ADN: " + chaineAdn);
Console.WriteLine("Ma chaine est correcte ?! Réponse: " + verification_adn(chaineAdn));

chaineAdn = saisie_adn();
Console.WriteLine("\nMa chaine saisie et vérifiée: " + chaineAdn + "\n\n\n");


chaineAdn = "tatagagafaafgaggttatagagafaftgafgtatgfgtaftgatgftgatatagagafa";

String maSequence = "tatagagafa";  

Console.WriteLine($"- Taux d'apparition dans ma chaine: {proportion(chaineAdn, maSequence)}%");