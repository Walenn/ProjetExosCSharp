

Console.Write("Veuillez saisir votre nom: ");
string valNom = Console.ReadLine();

Console.Write("Veuillez saisir votre prénom: ");
string valPrenom = Console.ReadLine();

Console.WriteLine($"Bonjour {valPrenom} {valNom}");
// ou bien:
// Console.WriteLine("Bonjour " + valPrenom + " " + valNom);