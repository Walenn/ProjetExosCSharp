using System.Runtime.InteropServices;

Console.WriteLine("--- Gestion des notes ---");

int noteBasse = 1000;
int noteHaute = 0;
double noteTotal = 0;
int noteTampon = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write($@"- Merci de saisir la note {i} (sur 20): ");
    noteTampon = Convert.ToInt32(Console.ReadLine());

    noteTotal += noteTampon;

    if (noteHaute < noteTampon)
        noteHaute = noteTampon;

    if (noteBasse > noteTampon)
        noteBasse = noteTampon;
}



Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n\nLa meilleure note est {noteHaute}/20");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La moins bonne note est {noteBasse}/20");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"La moyenne des notes est {noteTotal/5}/20");