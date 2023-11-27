namespace Persona.Encounters.Types.Common;

public static class EncounterExtensions
{
    public static bool IsSpecialBattle(this P4G.Encounter encounter)
        => encounter.Music != P4G.Music.TimeToMakeHistory;

    public static bool IsSpecialBattle(this P5R.Encounter encounter)
        => encounter.Music != P5R.Music.LastSurprise;

    public static bool IsSpecialBattle(this P3P.Encounter encounter)
        => encounter.Music != P3P.Music.MassDestruction;
}