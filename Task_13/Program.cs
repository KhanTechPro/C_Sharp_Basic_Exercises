// Task 13: You have been given a text of no more than 500 words. Your task is to find the number of words starting with a and ending with b in this text.

string inputText = "abracadabra suf kuf";
int result = CountWordsStartingWithAAndEndingWithB(inputText);
Console.WriteLine("Output: " + result);


static int CountWordsStartingWithAAndEndingWithB(string text)
{
    string[] words = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
    int count = 0;

    foreach (string word in words)
    {
        if (word.Length > 1 && word[0] == 'a' && word[word.Length - 1] == 'b')
        {
            count++;
        }
    }

    return count;
}

