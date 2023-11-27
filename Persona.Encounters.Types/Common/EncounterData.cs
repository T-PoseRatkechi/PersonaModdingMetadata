namespace Persona.Encounters.Types.Common;

public class EncounterData
{
    public required int Id { get; set; }

    public required IEnumerable<ushort> BattleUnitsIds { get; set; }

    public required ushort MusicId { get; set; }
}
