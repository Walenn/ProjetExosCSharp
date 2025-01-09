String superPhrase = "C'est le B-A BA des mixeurs que cela.";

int compteur_lettre_a(String texte)
{
    int nombreOccurencesA = 0;

    for (int i = 0; i < texte.Length; i++)
    {
        if (texte[i] == 'a' || texte[i] == 'A')
        {
            nombreOccurencesA++;
        }
    }

    return nombreOccurencesA;
}

int compteur_lettre_a_count(String texte)
{
    int nombreOccurencesA = 0;

    nombreOccurencesA = texte.Count(car => car == 'a' || car == 'A');

    return nombreOccurencesA;
}


Console.WriteLine($"Le texte \"{superPhrase}\" contient la lettre 'a' {compteur_lettre_a(superPhrase)} fois.");

Console.WriteLine($"\nMais avec mon autre fonction, le texte \"{superPhrase}\" contient la lettre 'a' {compteur_lettre_a_count(superPhrase)} fois.");
