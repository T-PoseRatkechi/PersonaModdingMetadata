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
        Log.Information("Persona 4 Golden");
        var encounterTbl = new Persona.Encounters.Types.P4G.EncounterTbl(file);
        this.FixLocationCollections(encounterTbl);
        this.GenerateSpecialBattles(encounterTbl);
    }

    private void Generate_P5R(string file)
    {
        Log.Information("Persona 5 Royal");
        var encounterTbl = new Persona.Encounters.Types.P5R.EncounterTbl(file);
        this.FixLocationCollections(encounterTbl);
        this.GenerateSpecialBattles(encounterTbl);
    }

    private void Generate_P3P(string file)
    {
        Log.Information("Persona 3 Portable");
        var encounterTbl = new Persona.Encounters.Types.P3P.EncounterTbl(file);
        this.GenerateSpecialBattles(encounterTbl);
    }

    private void FixLocationCollections<TEncounter>(BaseEncounterTbl<TEncounter> encounterTbl)
        where TEncounter : IEncounter
    {
        var locationsDir = Path.Join(encounterTbl.Game.OriginalFilesDir(this.baseDir), "collections", "locations");
        if (!Directory.Exists(locationsDir))
        {
            Log.Debug("Missing: {dir}", locationsDir);
            return;
        }

        foreach (var file in Directory.EnumerateFiles(locationsDir, "*.enc", SearchOption.AllDirectories))
        {
            var relativePath = Path.GetRelativePath(encounterTbl.Game.OriginalFilesDir(this.baseDir), file);
            var outputFile = Path.Join(encounterTbl.Game.GameFolder(this.baseDir), relativePath);
            if (File.Exists(outputFile))
            {
                Log.Debug("Location collection already exists. Delete existing collection to regenerate.");
                continue;
            }

            Log.Information("Fixing Location Collection: {name}", Path.GetFileNameWithoutExtension(file));

            var collection = CollectionSerializer.DeserializeFile(file);
            var fixedEncounters = collection
                .Select(x => encounterTbl.Encounters[x])
                .Where(x =>
                {
                    if (x.IsSpecialBattle)
                    {
                        Log.Debug("Removed Encounter: {id}", x.Id);
                        return false;
                    }

                    return true;
                })
                .ToArray();

            CollectionSerializer.Serialize(outputFile, FormatEncounters(fixedEncounters.OfType<IEncounter>()));

            Log.Information("Fixed Location Collection: {file}", outputFile);
        }
    }

    private void GenerateSpecialBattles<TEncounter>(BaseEncounterTbl<TEncounter> encounterTbl)
        where TEncounter : IEncounter
    {
        var collectionsDir = Path.Join(encounterTbl.Game.GameFolder(this.baseDir), "collections");
        Directory.CreateDirectory(collectionsDir);

        var specialBattlesFile = Path.Join(collectionsDir, "Special Battles.enc");
        CollectionSerializer.Serialize(specialBattlesFile, FormatEncounters(encounterTbl.Encounters.Where(x => x.IsSpecialBattle).OfType<IEncounter>()));
        Console.WriteLine(specialBattlesFile);
    }

    private static string[] FormatEncounters(IEnumerable<IEncounter> encounters)
        => encounters.Select(x => $"// {x.Name}\n{x.Id}\n").ToArray();
}
