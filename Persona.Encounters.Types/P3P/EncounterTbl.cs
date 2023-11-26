using Persona.Encounters.Types.Common;

namespace Persona.Encounters.Types.P3P;

public class EncounterTbl : BaseEncounterTbl<BattleUnits, Music>
{
    public EncounterTbl(string file)
        : base(file, 28)
    {
    }

    public EncounterTbl(Stream stream)
        : base(stream, 28)
    {
    }
}
