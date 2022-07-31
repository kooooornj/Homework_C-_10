/* Zadacha 1 
int Stroki(string[] words)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
    int count = 0;
    for (int i = 0; i < words.Length; i++)
        for (int j = 0; j < vowels.Length; j++)
        {
            if (words[i].ToLower()[0] == Char.ToLower(vowels[j])) count++;
        }
    return count;
}
string[] array = { "dbc", "det", "ert", "isa", "sss", "dsa" };
Console.Write("Кол-во слов в массиве, начинающихся на гласную букву: " + Stroki(array));
*/
/* Zadacha 2 
string[] array = { "га", "чи", "му", "чи", "ка", "йф", "пой", "мала" };

string[] Obedinenie(string[] a)
{
    int c = 0;
    string[] b = new string[a.Length / 2];
    for (int i = 0; i < a.Length / 2; i++)
    {
        b[i] = a[c] + a[c + 1];
        c += 2;
    }
    return b;
}

void Vyvod(string[] str)
{
    for (int i = 0; i < str.Length; i++)
        Console.Write(str[i] + ", ");
}

Vyvod(Obedinenie(array));
*/