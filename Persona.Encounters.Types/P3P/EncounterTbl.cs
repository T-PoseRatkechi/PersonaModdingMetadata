using Persona.Encounters.Types.Common;

namespace Persona.Encounters.Types.P3P;

public class EncounterTbl : BaseEncounterTbl<Encounter>
{
    public EncounterTbl(string file)
        : base(file, 28, new EncounterFactory())
    {
    }

    public EncounterTbl(Stream stream)
        : base(stream, 28, new EncounterFactory())
    {
    }
}
