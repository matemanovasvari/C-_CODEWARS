int[] Parse(string commands)
{
    List<int> results = new List<int>();

    int value = 1;

    foreach (char command in commands)
    {
        switch (command)
        {
            case 'i':
                value++;
                break;
            case 'd':
                value--;
                break;
            case 's':
                value *= value;
                break;
            case 'o':
                results.Add(value);
                break;
        }
    }

    return results.ToArray();
}

Console.WriteLine($"[{string.Join(", ", Parse("iiisdoso"))}]");