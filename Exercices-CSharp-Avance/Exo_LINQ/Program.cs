
using System.Net.Cache;
using Exo8_LINQ;



List<Personne> people = new()
{
    new() { Id = 1, Name = "Alice", Age = 25, City = "Paris" },

    new() { Id = 2, Name = "Bob", Age = 30, City = "Lyon" },
    new() { Id = 3, Name = "Charlie", Age = 35, City = "Marseille" },
    new() { Id = 4, Name = "Diana", Age = 40, City = "Paris" },
    new() { Id = 5, Name = "Eve", Age = 28, City = "Lyon" },
    new() { Id = 6, Name = "Frank", Age = 33, City = "Paris" },

};

IEnumerable<Personne> peopleTries;

// 1  Trouver toutes les personnes de Paris
Console.WriteLine("- 1 ------------------------");
peopleTries = people.Where(x => x.City == "Paris");
peopleTries.ToList().ForEach(Console.WriteLine);


// 
//2. **Trouver les noms des personnes ayant plus de 30 ans.**
Console.WriteLine("- 2 ------------------------");
people.Where(p => p.Age >= 30)
      .Select(p => p.Name)
      .ToList()
      .ForEach(Console.WriteLine);


// 
//3. **Trier les personnes par âge croissant.**
Console.WriteLine("- 3 ------------------------");
peopleTries = people.OrderBy(p => p.Age);
peopleTries.ToList().ForEach(Console.WriteLine);

// 
//4. **Compter le nombre de personnes vivant à Lyon.**
Console.WriteLine("- 4 ------------------------");
Console.WriteLine($"Vivent à Lyon: "
                + people.Where(p => p.City == "Lyon").Count()
                + " personnes.");

// 
//5. **Trouver la personne la plus âgée.**
Console.WriteLine("- 5 ------------------------");
Console.WriteLine(people.OrderByDescending(p => p.Age)
                     .FirstOrDefault());


// 
//6. **Obtenir une liste des villes distinctes.**
Console.WriteLine("- 6 ------------------------");
people.Select(p => p.City)
      .Distinct()
      .ToList()
      .ForEach(Console.WriteLine);

// 
//7. **Vérifier si toutes les personnes ont plus de 20 ans.**
Console.WriteLine("- 7 ------------------------");
if (people.All(x => x.Age <= 20))
{
    Console.WriteLine("Tout le monde a plus de 20ans");
}
else
{
    Console.WriteLine("Intrus de moins de 20ans !");
}



// 
//8. **Projeter une nouvelle liste contenant uniquement les noms et âges.**
Console.WriteLine("- 8 ------------------------");
people.Select(p => new { p.Name, p.Age })
      .ToList()
      .ForEach(Console.WriteLine);


//9. **Trouver le nom de la personne la plus jeune vivant à Paris.**
Console.WriteLine("- 9 ------------------------");
Console.WriteLine(people.Where(p => p.City == "Paris")
                    .OrderBy(p => p.Age)
                    .Select(p => p.Name)
                    .FirstOrDefault());



//10. **Grouper les personnes par ville et afficher le nombre de personnes dans chaque ville.**
Console.WriteLine("- 10 ------------------------");

var peopleByCity = people.GroupBy(p => p.City)
                         .ToList();

foreach (var p in peopleByCity)
{
    Console.WriteLine(p.GetType());
}




//11. **Créer une séquence infinie de nombres pairs et récupérer les 10 premiers.**  
Enumerable.Range(0, 10);
//12. **Paginer une liste de nombres de 1 à 100 pour obtenir le 3ème bloc de 10 nombres (21 à 30).**

// faire app constantes / var 


//13. **Trouver le nombre maximum dans une liste d'entiers.** `[4, 8, 15, 16, 23, 42]`
//14. **Filtrer les mots d'une liste contenant plus de 5 lettres.** `["chat", "ordinateur", "table", "lampe", "programme"]`
