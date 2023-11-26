namespace PersonaModdingMetadata.Shared.Serializers;

public static class NewLineSerializer
{
    public static void Serialize(string file, IEnumerable<int> items)
    {
        File.WriteAllText(file, string.Join('\n', items.Select(x => x.ToString())));
    }

    public static int[] Deserialize(string file)
    {
        var items = File.ReadAllLines(file)
            .Where(x => !x.StartsWith("//") && !string.IsNullOrEmpty(x))
            .Select(int.Parse)
            .ToArray();

        return items;
    }
}
