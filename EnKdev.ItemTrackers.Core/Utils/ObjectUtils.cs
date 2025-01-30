using EnKdev.ItemTrackers.Core.Internal.Json;
using EnKdev.ItemTrackers.Core.Internal.Json.OoT;
using EnKdev.ItemTrackers.Core.Internal.Json.OoT.Equips;

namespace EnKdev.ItemTrackers.Core.Utils;

/// <summary>
/// Provides utility methods for retrieving specific objects by their unique identifier
/// from OoTData collections.
/// </summary>
public static class ObjectUtils
{
    /// <summary>
    /// Retrieves an object of type <see cref="Other"/> by its unique identifier from the provided <see cref="OoTData"/>.
    /// </summary>
    /// <param name="id">The unique identifier of the object to retrieve.</param>
    /// <param name="data">The <see cref="OoTData"/> collection to search within.</param>
    /// <returns>The matching <see cref="Other"/> object if found; otherwise, null.</returns>
    public static Other? GetOtherObjectById(string id, OoTData? data)
        => data?.Other?.FirstOrDefault(x => x.Id == id);

    /// <summary>
    /// Retrieves an object of type <see cref="Arrow"/> by its unique identifier from the provided <see cref="OoTData"/>.
    /// </summary>
    /// <param name="id">The unique identifier of the arrow to retrieve.</param>
    /// <param name="data">The <see cref="OoTData"/> collection to search within.</param>
    /// <returns>The matching <see cref="Arrow"/> object if found; otherwise, null.</returns>
    public static Arrow? GetArrowObjectById(string id, OoTData? data)
        => data?.Arrows?.FirstOrDefault(x => x.Id == id);

    /// <summary>
    /// Retrieves a <see cref="Bottle"/> object by its unique identifier from the provided <see cref="OoTData"/>.
    /// </summary>
    /// <param name="id">The unique identifier of the bottle to retrieve.</param>
    /// <param name="data">The <see cref="OoTData"/> collection to search within.</param>
    /// <returns>The matching <see cref="Bottle"/> object if found; otherwise, null.</returns>
    public static Bottle? GetBottleObjectById(string id, OoTData? data)
        => data?.Bottles?.FirstOrDefault(x => x.Id == id);

    /// <summary>
    /// Retrieves an object of type <see cref="Item"/> by its unique identifier from the provided <see cref="OoTData"/>.
    /// </summary>
    /// <param name="id">The unique identifier of the item to retrieve.</param>
    /// <param name="data">The <see cref="OoTData"/> collection to search within.</param>
    /// <returns>The matching <see cref="Item"/> object if found; otherwise, null.</returns>
    public static Item? GetItemObjectById(string id, OoTData? data)
        => data?.Items?.FirstOrDefault(x => x.Id == id);

    /// <summary>
    /// Retrieves an object of type <see cref="MqDungeon"/> by its unique identifier
    /// from the provided <see cref="OoTData"/> collection.
    /// </summary>
    /// <param name="id">The unique identifier of the dungeon to retrieve.</param>
    /// <param name="data">The <see cref="OoTData"/> collection to search within.</param>
    /// <returns>The matching <see cref="MqDungeon"/> object if found; otherwise, null.</returns>
    public static MqDungeon? GetDungeonObjectById(string id, OoTData? data)
        => data?.MqDungeons?.FirstOrDefault(x => x.Id == id);

    /// <summary>
    /// Retrieves a <see cref="Progression"/> object by its unique identifier from the provided <see cref="OoTData"/>.
    /// </summary>
    /// <param name="id">The unique identifier of the progression object to retrieve.</param>
    /// <param name="data">The <see cref="OoTData"/> collection containing <see cref="Progression"/> objects.</param>
    /// <returns>The matching <see cref="Progression"/> object if found; otherwise, null.</returns>
    public static Progression? GetProgressionObjectById(string id, OoTData? data)
        => data?.Progression?.FirstOrDefault(x => x.Id == id);

    /// <summary>
    /// Retrieves a song object of type <see cref="Song"/> by its unique identifier from the provided <see cref="OoTData"/>.
    /// </summary>
    /// <param name="id">The unique identifier of the song to retrieve.</param>
    /// <param name="data">The <see cref="OoTData"/> collection to search within.</param>
    /// <returns>The matching <see cref="Song"/> object if found; otherwise, null.</returns>
    public static Song? GetSongObjectById(string id, OoTData? data)
        => data?.Songs?.FirstOrDefault(x => x.Id == id);

    /// <summary>
    /// Retrieves an object of type <see cref="Gear"/> by its unique identifier from the provided <see cref="OoTData"/>.
    /// </summary>
    /// <param name="id">The unique identifier of the gear object to retrieve.</param>
    /// <param name="data">The <see cref="OoTData"/> collection to search within.</param>
    /// <returns>The matching <see cref="Gear"/> object if found; otherwise, null.</returns>
    public static Gear? GetGearObjectById(string id, OoTData? data)
        => data?.Gear?.FirstOrDefault(x => x.Id == id);

    /// <summary>
    /// Retrieves a <see cref="VanillaDungeon"/> object by its unique identifier from the provided <see cref="OoTData"/>.
    /// </summary>
    /// <param name="id">The unique identifier of the dungeon to retrieve.</param>
    /// <param name="data">The <see cref="OoTData"/> collection to search within.</param>
    /// <returns>The matching <see cref="VanillaDungeon"/> object if found; otherwise, null.</returns>
    public static VanillaDungeon? GetVanillaDungeonObjectById(string id, OoTData? data)
        => data?.VanillaDungeons?.FirstOrDefault(x => x.Id == id);

    /// <summary>
    /// Retrieves an object of type <see cref="Sword"/> by its unique identifier from the provided <see cref="OoTData"/>.
    /// </summary>
    /// <param name="id">The unique identifier of the sword to retrieve.</param>
    /// <param name="data">The <see cref="OoTData"/> collection to search within.</param>
    /// <returns>The matching <see cref="Sword"/> object if found; otherwise, null.</returns>
    public static Sword? GetSwordObjectById(string id, OoTData? data)
        => data?.Equips?.Swords?.FirstOrDefault(x => x.Id == id);

    /// <summary>
    /// Retrieves a <see cref="Shield"/> object by its unique identifier from the provided <see cref="OoTData"/>.
    /// </summary>
    /// <param name="id">The unique identifier of the shield to retrieve.</param>
    /// <param name="data">The <see cref="OoTData"/> collection to search within.</param>
    /// <returns>The matching <see cref="Shield"/> object if found; otherwise, null.</returns>
    public static Shield? GetShieldObjectById(string id, OoTData? data)
        => data?.Equips?.Shields?.FirstOrDefault(x => x.Id == id);

    /// <summary>
    /// Retrieves an object of type <see cref="Tunic"/> by its unique identifier from the provided <see cref="OoTData"/>.
    /// </summary>
    /// <param name="id">The unique identifier of the tunic object to retrieve.</param>
    /// <param name="data">The <see cref="OoTData"/> collection to search within.</param>
    /// <returns>The matching <see cref="Tunic"/> object if found; otherwise, null.</returns>
    public static Tunic? GetTunicObjectById(string id, OoTData? data)
        => data?.Equips?.Tunics?.FirstOrDefault(x => x.Id == id);

    /// <summary>
    /// Retrieves a boot object of type <see cref="Boot"/> by its unique identifier from the provided <see cref="OoTData"/>.
    /// </summary>
    /// <param name="id">The unique identifier of the boot object to retrieve.</param>
    /// <param name="data">The <see cref="OoTData"/> collection to search within.</param>
    /// <returns>The matching <see cref="Boot"/> object if found; otherwise, null.</returns>
    public static Boot? GetBootObjectById(string id, OoTData? data)
        => data?.Equips?.Boots?.FirstOrDefault(x => x.Id == id);
}