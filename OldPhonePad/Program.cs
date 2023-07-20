using System.Collections.ObjectModel;

public static class Program
{
    public static IReadOnlyDictionary<char, Collection<char>> Pad => new Dictionary<char, Collection<char>>()
    {
        { '2', new Collection<char> { 'A', 'B', 'C' } },
        { '3', new Collection<char> { 'D', 'E', 'F' } },
        { '4', new Collection<char> { 'G', 'H', 'I' } },
        { '5', new Collection<char> { 'J', 'K', 'L' } },
        { '6', new Collection<char> { 'M', 'N', 'O' } },
        { '7', new Collection<char> { 'P', 'Q', 'R', 'S' } },
        { '8', new Collection<char> { 'T', 'U', 'V' } },
        { '9', new Collection<char> { 'W', 'X', 'Y', 'Z' } },
    };

    private static char Back => '*';
    private static char Space => ' ';

    private static void Main(string[] _)
    {
        OldPhonePad("8 88777444666*664#");
    }

    public static string OldPhonePad(string input)
    {
        string result = string.Empty;
        int index = -1;
        char previousChar = input.First();

        foreach (char character in input)
        {
            if (character == previousChar)
            {
                index += 1;
                continue;
            }

            if (previousChar != Back && previousChar != Space)
            {
                var characters = Pad[previousChar];
                result += characters[index % characters.Count];
            }

            if (character == Back)
            {
                result = result[..^1];
            }

            previousChar = character;
            index = 0;
        }

        return result;
    }
}