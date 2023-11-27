namespace PersonaModdingMetadata.Shared.Serializers;

public static class CollectionSerializer
{
    public static string Serialize<T>(IEnumerable<T> items)
        where T : notnull
        => string.Join('\n', items.Select(x => x.ToString()));

    public static int[] Deserialize(string text)
    {
        var items = text.Split('\n')
            .Where(x => !x.StartsWith("//") && !string.IsNullOrEmpty(x))
            .Select(int.Parse)
            .ToArray();

        return items;
    }

    public static void Serialize<T>(string file, IEnumerable<T> items)
        where T : notnull
        => File.WriteAllText(file, Serialize(items));

    public static int[] DeserializeFile(string file) => Deserialize(File.ReadAllText(file));
}
