using Persona.Music.Types.Common;

namespace Persona.Music.Types.P4G;

public class DefaultSongs : GameSongs
{
    public DefaultSongs()
    {
        this.Game = PersonaModdingMetadata.Shared.Games.Game.P4G_PC;
        this.Version = 1;
        this.Songs.Add(new()
        {
            Name = "Reach Out To The Truth",
            Category = Category.Normal_Battle.ToName(),
            Tags = new[] { Category.Context__Normal.ToName() },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/30.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "I'll Face Myself -Battle-",
            Category = Category.Boss_Battle.ToName(),
            Tags = new[] { "Shadow Bosses", "Mini-bosses", "Optional Bosses" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/31.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "A New World Fool",
            Category = Category.Boss_Battle.ToName(),
            Tags = new[] { "Adachi", "Kunino-sagiri" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/32.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "The Almighty",
            Category = Category.Boss_Battle.ToName(),
            Tags = new[] { "Ameno-sagiri" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/33.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "The Fog",
            Category = Category.Boss_Battle.ToName(),
            Tags = new[] { "Izanmi" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/34.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "The Genesis",
            Category = Category.Boss_Battle.ToName(),
            Tags = new[] { "Izanami-no-Okami" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/29.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Period",
            Category = Category.Victory_Theme.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/35.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "New Days",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/36.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "I'll Face Myself",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/37.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Borderline of Madness",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/38.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Who's There?",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/39.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "SMILE",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/40.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Reasoning",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/41.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "The Power of the Heart",
            Category = Category.Social_Link.ToName(),
            Tags = new[] { "Obtained" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/42.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "The Path is Open",
            Category = Category.Social_Link.ToName(),
            Tags = new[] { "Maxed" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/43.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Jika Net Tanaka",
            Category = Category.Menu.ToName(),
            Tags = new[] { Category.Shop.ToName() },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/44.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "youthful lunch",
            Category = Category.School.ToName(),
            Tags = new[] { "Lunchtime" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/45.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "specialist",
            Category = Category.School.ToName(),
            Tags = new[] { "Lessons" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/46.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "A Corner of Memories",
            Category = Category.Menu.ToName(),
            Tags = new[] { Category.Title_Screen.ToName() },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/47.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Poem for Everyone's Souls",
            Category = Category.Velvet_Room.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/48.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "How much?",
            Category = Category.Menu.ToName(),
            Tags = new[] { Category.Shop.ToName() },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/49.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Your Affection",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Category.Clear.ToName(), Category.Sunny.ToName() },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/50.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Heartbeat,Heartbreak",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Category.Cloudy.ToName() },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/51.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Omen",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Category.Foggy.ToName() },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/52.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Signs of Love",
            Category = Category.Dojima_Residence.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/53.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Alone",
            Category = Category.Dojima_Residence.ToName(),
            Tags = new[] { "Story" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/54.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Backside of the TV",
            Category = Category.Midnight_Channel.ToName(),
            Tags = new[] { "Entrance" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/55.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Castle",
            Category = Category.Midnight_Channel.ToName(),
            Tags = new[] { "Yukiko" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/56.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Sauna",
            Category = Category.Midnight_Channel.ToName(),
            Tags = new[] { "Kanji" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/57.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Theater",
            Category = Category.Midnight_Channel.ToName(),
            Tags = new[] { "Rise" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/58.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Game",
            Category = Category.Midnight_Channel.ToName(),
            Tags = new[] { "Mitsuo" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/59.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Secret Base",
            Category = Category.Midnight_Channel.ToName(),
            Tags = new[] { "Naoto" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/60.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Heaven",
            Category = Category.Midnight_Channel.ToName(),
            Tags = new[] { "Nanako" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/61.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Long Way",
            Category = Category.Midnight_Channel.ToName(),
            Tags = new[] { "Adachi" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/62.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Corridor",
            Category = Category.Midnight_Channel.ToName(),
            Tags = new[] { "Izanami" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/63.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Joy (Persona 3)",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/64.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Fearful Experience (Persona 3)",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/65.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Crisis (Persona 3)",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/66.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "P3 fes (Persona 3)",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/67.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Like a dream come true",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/68.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Borderline of Madness (2nd loop)",
            Category = Category.Boss_Battle.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/69.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Borderline of Madness (3rd loop)",
            Category = Category.Boss_Battle.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/70.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "ZONE TIME",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/71.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Reasoning -another version-",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/72.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "I'll Face Myself -another version-",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/73.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Reach Out To The Truth -First Battle-",
            Category = Category.Boss_Battle.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/74.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Traumerei",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/75.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Everyday Sunshine",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/83.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Girl of the Hollow Forest",
            Category = Category.Midnight_Channel.ToName(),
            Tags = new[] { "Marie" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/77.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "A Sky Full Of Stars",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Category.Night.ToName() },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/85.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Let's Hit the Beach!",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/86.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "SNOWFLAKES",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Category.Snow.ToName() },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/76.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Memory",
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/28.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Time To Make History",
            Category = Category.Normal_Battle.ToName(),
            Tags = new[] { Category.Context__Advantage.ToName() },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/77.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "I'll Face Myself -Battle- (Reincarnation) Phase 1",
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/78.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "I'll Face Myself -Battle- (Reincarnation) Phase 2",
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/79.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Shin Mitsuo Tensei",
            Category = Category.Boss_Battle.ToName(),
            Tags = new[] { "Shadow Mitsuo" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/81.hca",
            Encoder = "HCA",
        });
    }
}
