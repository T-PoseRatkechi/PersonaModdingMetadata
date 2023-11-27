using Persona.Encounters.Types.Common;

namespace Persona.Encounters.Types.P4G;

internal class EncounterFactory : IEncounterFactory<Encounter>
{
    public Encounter Create(EncounterData data) => new(data);
}