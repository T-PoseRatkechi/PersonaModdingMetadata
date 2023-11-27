namespace Persona.Encounters.Types.Common;

public abstract class BaseEncounter<TEnemy, TMusic>
    where TEnemy : Enum
    where TMusic : Enum
{
    public BaseEncounter(EncounterData data)
    {
        this.Id = data.Id;
        this.BattleUnits = data.BattleUnitsIds.Select(x => (TEnemy)(object)x).ToArray();
        this.Music = (TMusic)(object)data.MusicId;
    }

    public int Id { get; set; }

    public TEnemy[] BattleUnits { get; set; }

    public TMusic Music { get; set; }
}
