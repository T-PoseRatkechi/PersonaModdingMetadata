namespace Persona.Encounters.Types.Common;

public interface IEncounter
{
    int Id { get; }

    string Name { get; }

    bool IsSpecialBattle { get; }
}