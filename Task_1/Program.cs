// Task 1: Determine letters A and Y

string text1 = "ALGORITAMTUITUZ";
string text2 = "Astrum School";

int countA1 = CountLetter(text1, 'A');
int countY1 = CountLetter(text1, 'Y');

int countA2 = CountLetter(text2, 'A');
int countY2 = CountLetter(text2, 'Y');

Console.WriteLine("Count of 'A' in text1: " + countA1);
Console.WriteLine("Count of 'Y' in text1: " + countY1);
Console.WriteLine("Count of 'A' in text2: " + countA2);
Console.WriteLine("Count of 'Y' in text2: " + countY2);
    
static int CountLetter(string text, char letter)
{
      int count = 0;
      foreach (char c in text)
      {
      if (c == letter)
      {
            count++;
      }
      }
      return count;
}

