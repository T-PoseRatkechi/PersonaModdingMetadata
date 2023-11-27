﻿using Persona.Encounters.Types.Common;

namespace Persona.Encounters.Types.P4G;

public class Encounter : BaseEncounter<BattleUnit, Music>
{
    public Encounter(EncounterData data)
        : base(data)
    {
    }
}
