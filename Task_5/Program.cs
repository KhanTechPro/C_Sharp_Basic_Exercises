// Task 5: Create a program that calculates the total number of vowels in the text (vowels in the Latin alphabet A,a,B,b,C,c,D,d,E,e)
using System;

class Program
{
    static void Main()
    {
        string text = "Programming my LIFE";
        
        int vowelCount = CountVowels(text);
        
        Console.WriteLine("Total number of vowels: " + vowelCount);
    }

    static int CountVowels(string text)
    {
        int count = 0;
        foreach (char c in text)
        {
            // Convert the character to lowercase for case-insensitive comparison
            char lowercaseChar = char.ToLower(c);
            
            // Check if the character is a vowel
            if (lowercaseChar == 'a' || lowercaseChar == 'e' || lowercaseChar == 'i' || lowercaseChar == 'o' || lowercaseChar == 'u')
            {
                count++;
            }
        }
        return count;
    }
}
