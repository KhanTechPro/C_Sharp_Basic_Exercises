// Task 11: Create a program to delete the i-word in the text and replace it with the word TATU (the words are separated by spaces)
string inputText = "Xorazmda URDU birinchi";
string[] words = inputText.Split(' ');

// Assuming i-word is the word at index 1
int iIndex = 1;

// Delete i-word and replace it with TATU
string replacedText = DeleteAndReplaceWord(words, iIndex);

Console.WriteLine("Replaced text: " + replacedText);

static string DeleteAndReplaceWord(string[] words, int iIndex)
{
    // If iIndex is out of bounds, return original text
    if (iIndex < 0 || iIndex >= words.Length)
    {
        return string.Join(" ", words);
    }

    // Delete i-word and replace it with TATU
    words[iIndex] = "TATU";

    return string.Join(" ", words);
}

