// Task 3: Determine the number of words ending with NA symbols in the text and create a printing program.
string text = "ANA MANA YANA asd HDFNAS";

int count = CountWordsEndingWithNA(text);
Console.WriteLine("Number of words ending with 'NA': " + count);

Console.WriteLine("Words ending with 'NA':");
PrintWordsEndingWithNA(text);


static int CountWordsEndingWithNA(string text)
{
    string[] words = text.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

    int count = 0;
    foreach (string word in words)
    {
        if (word.EndsWith("NA", StringComparison.OrdinalIgnoreCase))
        {
            count++;
        }
    }
    return count;
}

static void PrintWordsEndingWithNA(string text)
{
    string[] words = text.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

    foreach (string word in words)
    {
        if (word.EndsWith("NA", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine(word);
        }
    }
}

