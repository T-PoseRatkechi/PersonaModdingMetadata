using Persona.Encounters.Types.Common;

namespace Persona.Encounters.Types.P4G;

public class EncounterTbl : BaseEncounterTbl<BattleUnit, Music>
{
    public EncounterTbl(string file)
        : base(file, 24)
    {
    }

    public EncounterTbl(Stream stream)
        : base(stream, 24)
    {
    }
}
