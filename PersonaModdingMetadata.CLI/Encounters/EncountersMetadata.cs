using Persona.Encounters.Types.Common;
using PersonaModdingMetadata.Shared.Games;
using PersonaModdingMetadata.Shared.Serializers;

namespace PersonaModdingMetadata.CLI.Encounters;

internal class EncountersMetadata
{
    private readonly string baseDir;

    public EncountersMetadata(string baseDir)
    {
        this.baseDir = baseDir;
    }

    public void Generate()
    {
        this.GenerateGame(Game.P4G_PC);
        this.GenerateGame(Game.P5R_PC);
        this.GenerateGame(Game.P3P_PC);
    }

    private void GenerateGame(Game game)
    {
        var originalDir = game.OriginalFilesDir(this.baseDir);
        Directory.CreateDirectory(originalDir);

        var encountFile = Path.Join(originalDir, "ENCOUNT.TBL");
        if (!File.Exists(encountFile))
        {
            Console.WriteLine($"Missing: {encountFile}");
            return;
        }

        switch (game)
        {
            case Game.P4G_PC:
                this.Generate_P4G(encountFile);
                break;
            case Game.P5R_PC:
                this.Generate_P5R(encountFile);
                break;
            case Game.P3P_PC:
                this.Generate_P3P(encountFile);
                break;
            default:
                break;
        }
    }

    private void Generate_P4G(string file)
    {
        var encounterTbl = new Persona.Encounters.Types.P4G.EncounterTbl(file);
        this.GenerateSpecialBattles(Game.P4G_PC, encounterTbl.Encounters);
    }

    private void Generate_P5R(string file)
    {
        var encounterTbl = new Persona.Encounters.Types.P5R.EncounterTbl(file);
        this.GenerateSpecialBattles(Game.P5R_PC, encounterTbl.Encounters);
    }

    private void Generate_P3P(string file)
    {
        var encounterTbl = new Persona.Encounters.Types.P3P.EncounterTbl(file);
        this.GenerateSpecialBattles(Game.P3P_PC, encounterTbl.Encounters);
    }

    private void GenerateSpecialBattles(Game game, IEncounter[] encounters)
    {
        var collectionsDir = Path.Join(game.GameFolder(this.baseDir), "collections");
        Directory.CreateDirectory(collectionsDir);

        var specialBattlesFile = Path.Join(collectionsDir, "Special Battles.enc");
        NewLineSerializer.Serialize(specialBattlesFile, encounters.Where(x => x.IsSpecialBattle).Select(x => x.Id));
        Console.WriteLine(specialBattlesFile);
    }
}
