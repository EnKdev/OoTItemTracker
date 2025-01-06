using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT;

/// <summary>
/// Represents a vanilla dungeon in the context of the internal JSON structure for the item trackers system.
/// </summary>
/// <remarks>
/// This class is primarily used for deserialization of JSON data related to dungeons.
/// It supports properties that define the dungeon's unique identifier, its name, the
/// maximum number of keys, and whether it contains a boss key.
/// </remarks>
public class VanillaDungeon
{
    /// <summary>
    /// Gets or sets the unique identifier for the dungeon.
    /// </summary>
    /// <remarks>
    /// This property represents the ID of the dungeon as defined in the JSON structure.
    /// It is typically used to distinguish one dungeon from another within the system.
    /// </remarks>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the dungeon.
    /// </summary>
    /// <remarks>
    /// This property represents the displayable name of the dungeon as defined in the JSON structure.
    /// It is used to provide a human-readable identifier for the dungeon in contexts such as user interfaces or reports.
    /// </remarks>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of keys available in the dungeon.
    /// </summary>
    /// <remarks>
    /// This property defines the total number of small keys that can be found or used within the dungeon.
    /// It is based on the dungeon's data as described in the JSON structure.
    /// </remarks>
    [JsonProperty("maxKeys")]
    public int? MaxKeys { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the dungeon contains a boss key.
    /// </summary>
    /// <remarks>
    /// This property specifies if a boss key is present in the dungeon as defined in the associated JSON data.
    /// It is used to determine whether the dungeon requires a boss key for progression.
    /// </remarks>
    [JsonProperty("hasBossKey")]
    public bool HasBossKey { get; set; }
}