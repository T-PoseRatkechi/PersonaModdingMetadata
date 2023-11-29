namespace Persona.Music.Types.Common;

public enum Category
{
    // Battles.
    Normal_Battle,
    Context__Normal,
    Context__Advantage,
    Context__Disadvantage,
    Victory_Theme,
    Boss_Battle,

    // Common.
    Title_Screen,
    Story,
    Velvet_Room,
    Menu,
    Shop,
    Location,
    Unknown,
    Ending,

    // Daily life.
    Daily_Life,
    Social_Link,
    School,

    // Overworld and weathers.
    Overworld,
    Clear,
    Sunny,
    Cloudy,
    Foggy,
    Night,
    Snow,
    Rainy,

    // Persona 4.
    Dojima_Residence,
    Midnight_Channel,

    // Persona 5.
    Palace,
}

public static class CategoriesExtenions
{
    public static string ToName(this Category category)
        => category.ToString().Replace("__", ": ").Replace('_', ' ');
}
