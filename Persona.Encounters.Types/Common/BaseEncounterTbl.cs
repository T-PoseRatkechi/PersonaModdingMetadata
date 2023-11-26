using PersonaModdingMetadata.Shared;

namespace Persona.Encounters.Types.Common;

public abstract class BaseEncounterTbl<TEnemy, TMusic>
    where TEnemy : Enum
    where TMusic : Enum
{
    public BaseEncounterTbl(
        string file,
        int entrySize,
        bool isBigEndian = false)
    {
        var stream = new FileStream(file, FileMode.Open, FileAccess.Read);
        this.Encounters = GetEncounters(stream, entrySize, isBigEndian);
    }

    public BaseEncounterTbl(
        Stream stream,
        int entrySize,
        bool isBigEndian = false)
    {
        this.Encounters = GetEncounters(stream, entrySize, isBigEndian);
    }

    public BaseEncounter<TEnemy, TMusic>[] Encounters { get; }

    private static BaseEncounter<TEnemy, TMusic>[] GetEncounters(
        Stream stream,
        int entrySize,
        bool isBigEndian)
    {
        var factory = new EncounterFactory<TEnemy, TMusic>();
        using var br = new BinaryReader(stream);
        var totalSize = isBigEndian ? br.ReadInt32().ToBigEndian() : br.ReadInt32();

        var totalEncounters = totalSize / entrySize;
        var encounters = new BaseEncounter<TEnemy, TMusic>[totalEncounters];

        for (int i = 0; i < totalEncounters; i++)
        {
            var offset = (i * entrySize) + 4;
            br.BaseStream.Seek(offset, SeekOrigin.Begin);

            // Skip flags and field04/06
            br.BaseStream.Position += 6;
            var battleUnits = new ushort[]
            {
                isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16(),
                isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16(),
                isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16(),
                isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16(),
                isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16(),
            };

            // Skip field/room ids.
            br.BaseStream.Position += 4;
            var musicId = isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16();

            encounters[i] = factory.Create(battleUnits, musicId);
        }

        return encounters;
    }
}
