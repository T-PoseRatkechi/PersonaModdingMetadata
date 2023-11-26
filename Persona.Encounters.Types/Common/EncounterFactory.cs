namespace Persona.Encounters.Types.Common;

public class EncounterFactory<TEnemy, TMusic>
    where TEnemy : Enum
    where TMusic : Enum
{
    public BaseEncounter<TEnemy, TMusic> Create(ushort[] battleUnitsIds, ushort musicId)
    {
        return new()
        {
            BattleUnits = battleUnitsIds.Select(x => (TEnemy)(object)x).ToArray(),
            Music = (TMusic)(object)musicId,
        };
    }
}
