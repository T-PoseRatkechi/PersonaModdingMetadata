using Persona.Encounters.Types.Common;

namespace Persona.Encounters.Types.P5R;

internal class EncounterFactory : IEncounterFactory<Encounter>
{
    public Encounter Create(EncounterData data) => new(data);
}
