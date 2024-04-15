// Task 7: Create a program that determines the length of the words in the text and prints the word and its length (the words are separated by commas)

string input = "ALGORITM TUIT UZ";
PrintWordLengths(input);


static void PrintWordLengths(string text)
{
    string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    
    Console.WriteLine("Word Lengths:");
    foreach (string word in words)
    {
        Console.WriteLine($"{word}: {word.Length}");
    }
}
