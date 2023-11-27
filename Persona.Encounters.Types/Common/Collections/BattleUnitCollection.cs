namespace Persona.Encounters.Types.Common.Collections;

/// <summary>
/// Collection that checks if an encounter contains a specific battle unit(s).
/// </summary>
internal class BattleUnitCollection<TEncounter, TEnemy> : IEncounterFilter<TEncounter>
    where TEncounter : IEncounter
    where TEnemy : Enum
{
    private readonly ushort[] units;

    public BattleUnitCollection(TEnemy[] units)
    {
        this.units = units.Select(x => (ushort)(object)x).ToArray();
    }

    public BattleUnitCollection(TEnemy unit)
        : this(new TEnemy[] { unit })
    {
    }

    public bool Match(TEncounter encounter) => encounter.BattleUnitsIds.Any(x => units.Contains(x));
}
