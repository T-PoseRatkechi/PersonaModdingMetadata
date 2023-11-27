﻿using Persona.Encounters.Types.Common;

namespace Persona.Encounters.Types.P5R;

public class Encounter : BaseEncounter<BattleUnit, Music>
{
    public Encounter(EncounterData data)
        : base(data)
    {
    }

    public override bool IsSpecialBattle => this.Music != Music.LastSurprise;
}