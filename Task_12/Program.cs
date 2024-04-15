// Task: You have been given a text. Your task is to find the number of odd-length words multiplied by the number of even-length words.

string inputText = "Acm icpc contest tatu";
int result = CountOddEvenWords(inputText);
Console.WriteLine("Output: " + result);


static int CountOddEvenWords(string text)
{
    string[] words = text.Split(' ');
    int oddLengthCount = 0;
    int evenLengthCount = 0;

    foreach (string word in words)
    {
        if (word.Length % 2 == 0)
        {
            evenLengthCount++;
        }
        else
        {
            oddLengthCount++;
        }
    }

    return oddLengthCount * evenLengthCount;
}

