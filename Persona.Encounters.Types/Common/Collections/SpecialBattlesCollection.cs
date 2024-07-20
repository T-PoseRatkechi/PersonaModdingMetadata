using Persona.Encounters.Types.P5R;
using PersonaModdingMetadata.Shared.Games;

namespace Persona.Encounters.Types.Common.Collections;

public class SpecialBattlesCollection<TEncounter> : IEncounterFilter<TEncounter>
    where TEncounter : IEncounter
{
    private readonly BattleUnitCollection<IEncounter, BattleUnit> emptyBattles
        = new(new BattleUnit[] { BattleUnit.NotUsed, BattleUnit.NotUsed, BattleUnit.NotUsed, BattleUnit.NotUsed, BattleUnit.NotUsed }, true);

    private readonly int[] ignoredBattles = Array.Empty<int>();

    public SpecialBattlesCollection(Game game)
    {
        if (game == Game.P3R_PC)
        {
            this.ignoredBattles = new[] { 700 };
        }
    }

    public bool Match(TEncounter encounter)
    {
        if (this.ignoredBattles.Contains(encounter.Id))
        {
            return false;
        }

        if (encounter.MusicId != 0)
        {
            return true;
        }

        if (this.emptyBattles.Match(encounter))
        {
            return true;
        }

        return false;
    }
}
