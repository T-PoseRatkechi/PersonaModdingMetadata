using Persona.Encounters.Types.Common;

namespace Persona.Encounters.Types.P4G;

public class EncounterTbl : BaseEncounterTbl<Encounter>
{
    public EncounterTbl(string file)
        : base(file, 24, new EncounterFactory())
    {
    }

    public EncounterTbl(Stream stream)
        : base(stream, 24, new EncounterFactory())
    {
    }
}
