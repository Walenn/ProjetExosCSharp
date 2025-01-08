

Console.Write("Veuillez saisir votre nom: ");
string valNom = Console.ReadLine();

Console.Write("Veuillez saisir votre prénom: ");
string valPrenom = Console.ReadLine();

Console.Write("Veuillez saisir votre age: ");
int valAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Bonjour {valPrenom} {valNom}, tu as {valAge}ans");

