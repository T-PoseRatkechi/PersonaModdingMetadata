using Persona.Music.Types.Common;
using PersonaModdingMetadata.Shared.Games;

namespace Persona.Music.Types.Tests;

public class DefaultMusicTests
{
    [Fact]
    public void DefaultMusic_NoDuplicate_Names()
    {
        foreach (var game in Enum.GetValues<Game>())
        {
            var defaultMusic = DefaultGameMusic.For(game);
            var currentSong = string.Empty;

            Assert.True(defaultMusic.Songs
                .GroupBy(x => x.Name)
                .All(x =>
                {
                    currentSong = x.Key;
                    return x.Count() == 1;
                }), $"{game}: {currentSong}");
        }
    }

    [Fact]
    public void DefaultMusic_NoDuplicate_ReplacementPaths()
    {
        foreach (var game in Enum.GetValues<Game>())
        {
            var defaultMusic = DefaultGameMusic.For(game);
            var currentSong = string.Empty;

            Assert.True(defaultMusic.Songs
                .GroupBy(x => x.ReplacementPath)
                .All(x =>
                {
                    currentSong = x.Key;
                    return x.Count() == 1;
                }), $"{game}: {currentSong}");
        }
    }
}
