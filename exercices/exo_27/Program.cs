String ligne = "";

for (int i = 1; i <= 100; i++)
{

    if ((i % 3) == 0)
           ligne += "Fizz";
    if ((i % 5) == 0)
           ligne += "Buzz";
    
    if (ligne == "")
        ligne = i+"" ;

    Console.WriteLine(ligne);
    ligne = "";
}