namespace Persona.Encounters.Types.Common;

public interface IEncounter
{
    int Id { get; }

    bool IsSpecialBattle { get; }
}