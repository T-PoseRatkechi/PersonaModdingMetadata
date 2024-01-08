using Persona.Encounters.Types.P5R;

namespace Persona.Encounters.Types.Common.Collections;

public class SpecialBattlesCollection<TEncounter> : IEncounterFilter<TEncounter>
    where TEncounter : IEncounter
{
    private readonly BattleUnitCollection<IEncounter, BattleUnit> emptyBattles
        = new(new BattleUnit[] { BattleUnit.NotUsed, BattleUnit.NotUsed, BattleUnit.NotUsed, BattleUnit.NotUsed, BattleUnit.NotUsed }, true);

    private readonly EncounterIdCollection<TEncounter> unusedBattles = new(new int[] { 734, 735, 746, 838, 780 });

    public bool Match(TEncounter encounter)
    {
        if (encounter.MusicId != 0)
        {
            return true;
        }

        if (this.emptyBattles.Match(encounter))
        {
            return true;
        }

        if (this.unusedBattles.Match(encounter))
        {
            return true;
        }

        return false;
    }
}
