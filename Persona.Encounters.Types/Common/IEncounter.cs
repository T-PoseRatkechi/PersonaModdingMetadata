namespace Persona.Encounters.Types.Common;

public interface IEncounter
{
    int Id { get; }

    string Name { get; }

    public ushort[] BattleUnitsIds { get; }

    public ushort MusicId { get; }
}