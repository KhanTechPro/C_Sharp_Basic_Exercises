using System;

class Program
{
    static void Main()
    {
        int n = 1;
        string text = "Bu$";

        string result = RemoveDollarSigns(text);
        Console.WriteLine("Output: " + result);
    }

    static string RemoveDollarSigns(string text)
    {
        // Convert the string to a character array
        char[] charArray = text.ToCharArray();

        // Iterate through each character
        for (int i = 0; i < charArray.Length; i++)
        {
            // Check if the character is '$', if so, remove it by shifting the characters
            if (charArray[i] == '$')
            {
                for (int j = i; j < charArray.Length - 1; j++)
                {
                    charArray[j] = charArray[j + 1];
                }
                // Decrement the length of the character array since we removed a character
                Array.Resize(ref charArray, charArray.Length - 1);

                // Decrement the index to revisit the current position
                i--;
            }
        }

        // Convert the character array back to a string and return it
        return new string(charArray);
    }
}
