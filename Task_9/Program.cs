
string input = "Someone said www ALGO uz";
int count = CountWordsStartingWithCapital(input);
Console.WriteLine("Number of words starting with capital letters: " + count);


static int CountWordsStartingWithCapital(string text)
{
    string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    int count = 0;

    foreach (string word in words)
    {
        if (!string.IsNullOrEmpty(word) && char.IsUpper(word[0]))
        {
            count++;
        }
    }

    return count;
}

