using EnKdev.ItemTrackers.Core.Internal.Json.OoT.Equips;
using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT;

/// <summary>
/// Represents the collection of equipment items available in the item tracking system.
/// </summary>
/// <remarks>
/// The Equip class defines lists of various types of equipment, including boots, swords, shields, and tunics.
/// Each type of equipment is represented by its respective class, which defines detailed properties.
/// This class is used for serialization and deserialization of equipment data in JSON format.
/// </remarks>
public class Equip
{
    /// <summary>
    /// Represents the collection of boots available as equipment items in the item tracking system.
    /// </summary>
    /// <remarks>
    /// The <c>Boots</c> property contains a list of <c>Boot</c> objects, where each object
    /// defines attributes such as id, name, and sprite paths for both enabled and disabled states.
    /// This property is used to manage and serialize/deserialize boot data in JSON format.
    /// </remarks>
    [JsonProperty("boots")]
    public List<Boot>? Boots { get; set; }

    /// <summary>
    /// Represents the collection of swords available as equipment items in the item tracking system.
    /// </summary>
    /// <remarks>
    /// The <c>Swords</c> property contains a list of <c>Sword</c> objects, where each object
    /// defines attributes such as id, name, and sprite paths for both enabled and disabled states.
    /// This property is used to manage and serialize/deserialize sword data in JSON format.
    /// </remarks>
    [JsonProperty("swords")]
    public List<Sword>? Swords { get; set; }

    /// <summary>
    /// Represents the collection of shields available as equipment items in the item tracking system.
    /// </summary>
    /// <remarks>
    /// The <c>Shields</c> property contains a list of <c>Shield</c> objects, where each object
    /// defines attributes such as id, name, and sprite paths for both enabled and disabled states.
    /// This property is used to manage and serialize/deserialize shield data in JSON format.
    /// </remarks>
    [JsonProperty("shields")]
    public List<Shield>? Shields { get; set; }

    /// <summary>
    /// Represents the collection of tunics available as equipment items in the item tracking system.
    /// </summary>
    /// <remarks>
    /// The <c>Tunics</c> property contains a list of <c>Tunic</c> objects, where each object
    /// defines attributes such as id, name, and sprite paths for both enabled and disabled states.
    /// This property is used to manage and serialize/deserialize tunic data in JSON format.
    /// </remarks>
    [JsonProperty("tunics")]
    public List<Tunic>? Tunics { get; set; }
}