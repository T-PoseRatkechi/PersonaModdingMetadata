using PersonaModdingMetadata.Shared.Games;

namespace Persona.Music.Types.Common;

public class GameSongs
{
    public Game Game { get; set; }

    public int Version { get; set; }

    public List<Song> Songs { get; set; } = new();
}
