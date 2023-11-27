using Persona.Encounters.Types.Common;

namespace Persona.Encounters.Types.P4G;

public class Encounter : BaseEncounter<BattleUnit, Music>
{
    public Encounter(EncounterData data)
        : base(data)
    {
    }

    public override bool IsSpecialBattle => this.Music != Music.TimeToMakeHistory;
}
