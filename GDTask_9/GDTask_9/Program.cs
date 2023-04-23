static string ROT13(string t)
{
    string tout = "";
    int j;

    foreach (char c in t)
    {
        if (Char.IsLetter(c))
        {
            if (Char.IsUpper(c))
            {
                tout += (char)(((c - 'A') + 13) % 26 + 'A');
            }
            if (Char.IsLower(c))
            {
                tout += (char)(((c - 'a') + 13) % 26 + 'a');
            }
        }
        else
        {
            tout += c;
        }
    }
    return tout;
}

Console.Write("Введите текст: ");
string text = Console.ReadLine();
string outtext = ROT13(text);

Console.Write($"Зашифрованный текст: {outtext}");
