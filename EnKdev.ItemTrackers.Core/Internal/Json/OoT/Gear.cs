using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT;

/// <summary>
/// Represents a gear item with attributes defining its id, name,
/// and states for enabled and disabled gear.
/// </summary>
public class Gear
{
    /// <summary>
    /// Gets or sets the unique identifier for the gear item.
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the gear item.
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the state representing when the gear is disabled.
    /// </summary>
    [JsonProperty("gearDisabled")]
    public string? GearDisabled { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the enabled state of the gear.
    /// </summary>
    [JsonProperty("gearEnabled")]
    public string? GearEnabled { get; set; }
}