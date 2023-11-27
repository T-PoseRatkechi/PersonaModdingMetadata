using PersonaModdingMetadata.Shared;

namespace Persona.Encounters.Types.Common;

public abstract class BaseEncounterTbl<TEncounter>
    where TEncounter : IEncounter
{
    public BaseEncounterTbl(
        string file,
        int entrySize,
        IEncounterFactory<TEncounter> factory,
        bool isBigEndian = false)
    {
        var stream = new FileStream(file, FileMode.Open, FileAccess.Read);
        this.Encounters = GetEncounters(stream, entrySize, factory, isBigEndian);
    }

    public BaseEncounterTbl(
        Stream stream,
        int entrySize,
        IEncounterFactory<TEncounter> factory,
        bool isBigEndian = false)
    {
        this.Encounters = GetEncounters(stream, entrySize, factory, isBigEndian);
    }

    public TEncounter[] Encounters { get; }

    private static TEncounter[] GetEncounters(
        Stream stream,
        int entrySize,
        IEncounterFactory<TEncounter> factory,
        bool isBigEndian)
    {
        using var br = new BinaryReader(stream);
        var totalSize = isBigEndian ? br.ReadInt32().ToBigEndian() : br.ReadInt32();

        var totalEncounters = totalSize / entrySize;
        var encounters = new TEncounter[totalEncounters];

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

            encounters[i] = factory.Create(new()
            {
                Id = i,
                BattleUnitsIds = battleUnits,
                MusicId = musicId,
            });
        }

        return encounters;
    }
}
