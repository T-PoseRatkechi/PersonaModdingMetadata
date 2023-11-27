namespace Persona.Encounters.Types.Common;

public interface IEncounterFactory<TEncounter>
{
    TEncounter Create(EncounterData data);
}
