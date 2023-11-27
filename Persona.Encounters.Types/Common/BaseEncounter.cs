namespace Persona.Encounters.Types.Common;

public abstract class BaseEncounter<TEnemy, TMusic> : IEncounter
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

    public string Name
    {
        get
        {
            return string.Join(", ", this.BattleUnits.Where(x => (ushort)(object)x != 0).Select(x => x.ToString()));
        }
    }

    public ushort[] BattleUnitsIds => this.BattleUnits.Select(x => (ushort)(object)x).ToArray();

    public ushort MusicId => (ushort)(object)this.Music;
}
