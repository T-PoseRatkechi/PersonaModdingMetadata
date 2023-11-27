using Persona.Encounters.Types.Common;
using PersonaModdingMetadata.Shared.Games;
using PersonaModdingMetadata.Shared.Serializers;
using Serilog;

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
            Log.Warning("Missing: {file}", encountFile);
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
        this.GenerateSpecialBattles(encounterTbl);
    }

    private void Generate_P5R(string file)
    {
        var encounterTbl = new Persona.Encounters.Types.P5R.EncounterTbl(file);
        this.GenerateSpecialBattles(encounterTbl);
    }

    private void Generate_P3P(string file)
    {
        var encounterTbl = new Persona.Encounters.Types.P3P.EncounterTbl(file);
        this.GenerateSpecialBattles(encounterTbl);
    }

    private void GenerateSpecialBattles<TEncounter>(BaseEncounterTbl<TEncounter> encounterTbl)
        where TEncounter : IEncounter
    {
        var collectionsDir = Path.Join(encounterTbl.Game.GameFolder(this.baseDir), "collections");
        Directory.CreateDirectory(collectionsDir);

        var specialBattlesFile = Path.Join(collectionsDir, "Special Battles.enc");
        CollectionSerializer.Serialize(specialBattlesFile, encounterTbl.Encounters.Where(x => x.IsSpecialBattle).Select(x => $"// {x.Name}\n{x.Id}\n"));
        Console.WriteLine(specialBattlesFile);
    }
}
