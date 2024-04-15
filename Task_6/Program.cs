// Task 6: Create a program that reverses the given text.

string input = "ALGORITM TUIT UZ";
Console.WriteLine("Given text: " + input);
string reversedText = ReverseText(input);
Console.WriteLine("Reversed text: " + reversedText);

static string ReverseText(string text)
{
    char[] charArray = text.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

