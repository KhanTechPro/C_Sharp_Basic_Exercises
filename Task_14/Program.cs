// Task14: 

string inputText = "tatu UrGanch filial";
string outputText = ConvertCase(inputText);
Console.WriteLine("Output: " + outputText);
    

static string ConvertCase(string text)
{
    char[] charArray = text.ToCharArray();

    for (int i = 0; i < charArray.Length; i++)
    {
 
        if (char.IsUpper(charArray[i]))
        {
            
            charArray[i] = char.ToLower(charArray[i]);
        }
        else if (char.IsLower(charArray[i]))
        {
            
            charArray[i] = char.ToUpper(charArray[i]);
        }
    }

    return new string(charArray);
}
