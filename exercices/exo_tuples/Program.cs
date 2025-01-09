//Tuple d'operations
//Écrire un programme se servant d'une fonction nommée
//operation
//retournant, à partir dedeux nombres lui étant envoyés en paramètres :
//La somme
//La difference
//Le quotient
//Le produit
//
//Vous testerez cette fonction dans le cadre d'un programme console demandant à l'utilisateur deux
//valeurs et lui permettant d'obtenir les 4 résultats en même temps


(int, int, double, int) operation(int nombreA , int nombreB)
{
    return (nombreA + nombreB,
        nombreA - nombreB,
        nombreA / nombreB,
        nombreA* nombreB);
}

Console.Write("Entrez le nombre 1 : ");
int nombreUn = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez le nombre 2 : ");
int nombreDeux = Convert.ToInt32(Console.ReadLine());

(int, int, double, int) result = operation(nombreUn, nombreDeux);

Console.WriteLine("La somme =" + result.Item1);
Console.WriteLine("La différence =" + result.Item2);
Console.WriteLine("Le quotient =" + result.Item3);
Console.WriteLine("Le produit =" + result.Item4);  