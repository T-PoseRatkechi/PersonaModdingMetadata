using Persona.Encounters.Types.Common;

namespace Persona.Encounters.Types.P5R;

public class EncounterTbl : BaseEncounterTbl<Encounter>
{
    public EncounterTbl(string file)
        : base(file, 44, new EncounterFactory(), true)
    {
    }

    public EncounterTbl(Stream stream)
        : base(stream, 44, new EncounterFactory(), true)
    {
    }
}
