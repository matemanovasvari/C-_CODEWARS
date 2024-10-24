using System.Globalization;
using System.Linq;
using System.Reflection;

static string AlphabetPosition(string text)
{
    return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
}

string textInfo = "aaaa";

Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textInfo.ToLower()));