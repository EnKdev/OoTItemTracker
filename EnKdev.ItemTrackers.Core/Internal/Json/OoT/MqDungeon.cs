using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT;

/// <summary>
/// Represents a specific dungeon with properties related to its identifiers, name, key requirements,
/// and whether it contains a boss key.
/// </summary>
public class MqDungeon
{
    /// <summary>
    /// Gets or sets the unique identifier for the dungeon.
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the dungeon.
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of keys required for the dungeon.
    /// </summary>
    [JsonProperty("maxKeys")]
    public int? MaxKeys { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the dungeon contains a boss key.
    /// </summary>
    [JsonProperty("hasBossKey")]
    public bool HasBossKey { get; set; }
}