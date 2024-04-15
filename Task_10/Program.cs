string inputText = "Atum Shoh El Baha Mahmud";
string[] words = inputText.Split(' ');

// Assuming i-word is the word at index 1 and j-word is the word at index 2
int iIndex = 1;
int jIndex = 2;

// Replace i-word with j-word
string replacedText = ReplaceWord(words, iIndex, jIndex);

Console.WriteLine("Replaced text: " + replacedText);


static string ReplaceWord(string[] words, int iIndex, int jIndex)
{
    // If iIndex or jIndex is out of bounds, return original text
    if (iIndex < 0 || iIndex >= words.Length || jIndex < 0 || jIndex >= words.Length)
    {
        return string.Join(" ", words);
    }

    string[] replacedWords = new string[words.Length];
    Array.Copy(words, replacedWords, words.Length);

    // Replace i-word with j-word
    replacedWords[iIndex] = words[jIndex];

    return string.Join(" ", replacedWords);
}

