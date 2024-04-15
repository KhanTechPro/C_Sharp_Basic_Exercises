// Task 2: Create a program that prints words starting with A in the text.

string text = "ARTDJ Algoritm tuit uz dizayneri";

PrintWordsStartingWithA(text);


static void PrintWordsStartingWithA(string text)
{
    string[] words = text.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

    foreach (string word in words)
    {
        if (word.StartsWith("A", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine(word);
        }
    }
}
