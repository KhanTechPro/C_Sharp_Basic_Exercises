// Task 15:

int n = 13;
char[] cards = { 'A', 'L', 'B', 'S', 'O', 'M', 'D', 'A', 'T', 'A', 'S', 'J', 'A' };

string word = "ASSALOM";
bool canFormWord = CanFormWord(word, cards);

if (canFormWord)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}


static bool CanFormWord(string word, char[] cards)
{
    int[] cardCounts = new int[26]; 
    
    foreach (char card in cards)
    {
        int index = card - 'A'; 
        cardCounts[index]++;
    }

    foreach (char letter in word)
    {
        int index = letter - 'A';
        if (cardCounts[index] <= 0)
        {
            return false; 
        }
        cardCounts[index]--;
    }

    return true; // If all letters can be formed, return true
}

