// Task 4: Create a new text from the words that are part of the sequence of info symbols in the text.

using System;

class Program
{
    static void Main()
    {
        string text = "Informatik Informatsiyalar jarayoni";
        
        string newText = ExtractWordsInInfoSequence(text);
        
        Console.WriteLine("New text: " + newText);
    }

    static string ExtractWordsInInfoSequence(string text)
    {
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string newText = "";

        bool isInInfoSequence = false;

        foreach (string word in words)
        {
            if (word.ToLower() == "info")
            {
                isInInfoSequence = true;
            }
            else if (isInInfoSequence)
            {
                newText += word + " ";
            }
        }

        return newText.Trim();
    }
}
