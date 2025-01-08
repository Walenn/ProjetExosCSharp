

using System.Linq.Expressions;

Console.WriteLine("--- Quelle boisson souhaitez-vous ? ---");


Console.Write("Selection de la boisson (1euro): " +
              "\n\t1) Eau plate" +
              "\n\t2) Eau gazeuse" +
              "\n\t3) Breizh Cola" +
              "\n\t4) Club Maté" +
              "\n\t5) Limonade" +
              "\n\t6) Jus d'orange" +
              "\n\t7) Ginger Beer\n");
Console.Write("Faites votre choix (1 à 7): ");
int choixBoiss = Convert.ToInt32(Console.ReadLine());

switch (choixBoiss)
{
    case 1:
        Console.WriteLine("Votre Eau plate est servi.");
        break;
    case 2: Console.WriteLine("Votre Eau gazeuse est servi."); 
        break; 
    case 3: Console.WriteLine("Votre Breizh Cola est servi.");
        break;
    case 4: Console.WriteLine("Votre Club Maté est servi.");
        break;
    case 5: Console.WriteLine("Votre Limonade est servi.");
        break;
    case 6: Console.WriteLine("Votre Jus d'orange est servi.");
        break;
    case 7: Console.WriteLine("Votre Ginger Beer est servi.");
        break;
    default:
        Console.WriteLine("Mauvais code. Nous ne rendons pas la monnaie");
        break;
}