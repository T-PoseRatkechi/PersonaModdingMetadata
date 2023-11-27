using Persona.Encounters.Types.Common;
using Persona.Encounters.Types.Common.Collections;

namespace Persona.Encounters.Types.P4G;

public class Collections : Dictionary<string, IEncounterFilter<Encounter>>
{
    private readonly BattleUnit[] shadowBosses = new BattleUnit[]
    {
        BattleUnit.ShadowYosuke,
        BattleUnit.ShadowChie,
        BattleUnit.ShadowYukiko,
        BattleUnit.ShadowKanji,
        BattleUnit.ShadowRise,
        BattleUnit.ShadowTeddie,
        BattleUnit.ShadowNaoto,
        BattleUnit.ShadowMitsuo
    };

    private readonly BattleUnit[] goldenHands = new BattleUnit[]
    {
        BattleUnit.OpulentHand,
        BattleUnit.LuxuryHand,
        BattleUnit.HappinessHand,
        BattleUnit.WealthHand,
        BattleUnit.SupremeHand,
        BattleUnit.GloriousHand,
        BattleUnit.IsolatedHand,
    };


    private readonly BattleUnit[] reapers = new BattleUnit[]
    {
        BattleUnit.TheReaper288,
        BattleUnit.TheReaper289,
        BattleUnit.TheReaper290,
        BattleUnit.TheReaper291,
        BattleUnit.TheReaper292,
        BattleUnit.TheReaper293,
        BattleUnit.TheReaper294,
        BattleUnit.TheReaper295,
        BattleUnit.TheReaper296,
        BattleUnit.TheReaper297,
    };

    private readonly int[] miniBossesIds = new int[]
    {
        811,
        812,
        813,
        814,
        815,
        816,
        817,
        818,
        819,
        820,
        938,
        939,
    };

    private readonly int[] optionalBossesIds = new int[]
    {
        526,
        527,
        528,
        529,
        530,
        531,
    };

    public Collections()
    {
        this["bosses/Shadow Yosuke"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.ShadowYosuke);
        this["bosses/Shadow Chie"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.ShadowChie);
        this["bosses/Shadow Yukiko"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.ShadowYukiko);
        this["bosses/Shadow Kanji"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.ShadowKanji);
        this["bosses/Shadow Rise"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.ShadowRise);
        this["bosses/Shadow Teddie"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.ShadowTeddie);
        this["bosses/Shadow Mitsuo"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.ShadowMitsuo);
        this["bosses/Shadow Naoto"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.ShadowNaoto);
        this["bosses/Kunino-Sagiri"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.Kuninosagiri);
        this["bosses/Adachi"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.Adachi);
        this["bosses/Ameno-sagiri"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.Amenosagiri);
        this["bosses/Izanami"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.Izanami);
        this["bosses/Izanami-no-Okami"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.IzanaminoOkami);
        this["bosses/Marie"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.Marie);
        this["bosses/Kusumi-no-Okami"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.KusuminoOkami);
        this["bosses/Margaret"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.Margaret);
        this["bosses/Spooky Fog Man"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.QuestionMark275);
        this["bosses/The Reaper"] = new BattleUnitCollection<Encounter, BattleUnit>(this.reapers);
        this["Shadow Bosses"] = new BattleUnitCollection<Encounter, BattleUnit>(this.shadowBosses);
        this["Golden Hands"] = new BattleUnitCollection<Encounter, BattleUnit>(this.goldenHands);
        this["Optional Bosses"] = new EncounterIdCollection<Encounter>(this.optionalBossesIds);
        this["Minibosses"] = new EncounterIdCollection<Encounter>(this.miniBossesIds);
        this["Special Battles"] = new SpecialBattlesCollection<Encounter>();

        // Backwards compatability.
        this["bosses/Namatame"] = new BattleUnitCollection<Encounter, BattleUnit>(BattleUnit.Kuninosagiri);
        this["Reapers"] = new BattleUnitCollection<Encounter, BattleUnit>(this.reapers);
    }
}
