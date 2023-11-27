using Persona.Encounters.Types.Common;

namespace Persona.Encounters.Types.P3P;

internal class EncounterFactory : IEncounterFactory<Encounter>
{
    public Encounter Create(EncounterData data) => new(data);
}
