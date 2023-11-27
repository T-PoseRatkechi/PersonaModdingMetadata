namespace Persona.Encounters.Types.Common.Collections;

public class SpecialBattlesCollection<TEncounter> : IEncounterFilter<TEncounter>
    where TEncounter : IEncounter
{
    public bool Match(TEncounter encounter)
        => encounter.MusicId != 0;
}
