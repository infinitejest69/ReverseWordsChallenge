Console.WriteLine("Enter a string to reverse the words in it: ");
string? inputString = Console.ReadLine();
if (inputString != null)
{
    var outputString = WordReverser(inputString);

    Console.WriteLine(outputString);
}
else
{
    throw new Exception("Input string is null");
}

static string WordReverser(string inputString)
{
    var words = inputString.Split(' ').ToList();
    var reversedWords = new List<string>();
    for (int i = words.Count - 1; i != -1; i--)
    {
        reversedWords.Add(words[i]);
    }
    var charArray = reversedWords[0].ToCharArray();

    reversedWords[0] = UpperFirstLetter(reversedWords[0]);

    return string.Join(" ", reversedWords);
}

static string UpperFirstLetter(string inputString)
{
    var charArray = inputString.ToCharArray();
    charArray[0] = char.ToUpper(charArray[0]);
    return new string(charArray);
}
