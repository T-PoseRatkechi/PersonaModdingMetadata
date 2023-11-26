namespace PersonaModdingMetadata.Shared.Games;

public static class GameFolder
{
    public static string OriginalFilesDir(this Game game) => Path.Join(game.ToString(), "files", "original");
}
