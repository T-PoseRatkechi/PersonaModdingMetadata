namespace Persona.Encounters.Types.Common;

public class BaseEncounter<TEnemy, TMusic>
    where TEnemy : Enum
    where TMusic : Enum
{
    public TEnemy[] BattleUnits { get; set; } = Array.Empty<TEnemy>();

    public TMusic? Music { get; set; }
}
