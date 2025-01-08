

using System.Diagnostics;
using System.Linq.Expressions;

Console.WriteLine("--- Dans quelle catégorie est mon enfant ? ---");
Console.Write("Entrez l'âge devotre enfant: ");
int ageRenseigne = Convert.ToInt32(Console.ReadLine());

// Tentative de Switch case pour m'exercer
switch (ageRenseigne) {
case int ageMarmot when ageMarmot >= 3 && ageMarmot <= 6 :
    Console.WriteLine("c 3");
    break;

case int ageMarmot when ageMarmot >= 7 && ageMarmot <= 8:
    Console.WriteLine("Enfant de type: Poussin");
    break;

case int ageMarmot when ageMarmot >= 9 && ageMarmot <= 10:
    Console.WriteLine("Enfant de type: pupille");
      break;
case int ageMarmot when ageMarmot >= 11 && ageMarmot <= 12:
    Console.WriteLine("Enfant de type: minime");
    break;
case int ageMarmot when ageMarmot > 12:
    Console.WriteLine("Enfant de type: cadet");
    break;
case int ageMarmot when ageMarmot > 18:
    Console.WriteLine("Ce n'est plus un enfant...");
     break;

default:
     Console.WriteLine("Enfant nul et non accepté.");
     break;
}