
Console.WriteLine("B A - BA de l'Alphabet en MAJUSCULE\n");

char[] tabChar = new char[26];

for (int i = 0; i < tabChar.Length; i++)
{
    tabChar[i] = Convert.ToChar(65 + i);

}

for (int j = 0; j < tabChar.Length; j++)
{
    Console.WriteLine(new String(' ', j *2) + tabChar[j]);
}