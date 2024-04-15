// Task 17: Find the longest of the words in the given line.


string input = "Bugun birinchi kurslar uchun olimpiada bo’lib o’tadi";
string longestWord = FindLongestWord(input);
Console.WriteLine("Output: " + longestWord);


static string FindLongestWord(string line)
{
    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    string longestWord = "";
    foreach (string word in words)
    {
        if (word.Length > longestWord.Length)
        {
            longestWord = word;
        }
    }

    return longestWord;
}

