using Persona.Encounters.Types.Common;

namespace Persona.Encounters.Types.P5R;

public class EncounterTbl : BaseEncounterTbl<BattleUnit, Music>
{
    public EncounterTbl(string file)
        : base(file, 44, true)
    {
    }

    public EncounterTbl(Stream stream)
        : base(stream, 44, true)
    {
    }
}
