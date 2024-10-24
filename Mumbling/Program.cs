using System.Globalization;
using System.Xml;

public class Accumul
{
    public static string Accum(string s)
    {
        string output = string.Empty;
        string result = string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            output = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(new string(s[i], i + 1).ToLower());
            result += output + "-";
        }

        return result.TrimEnd('-');
    }
}