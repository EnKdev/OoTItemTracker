using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT;

/// <summary>
/// Represents an item with an optional ID, name, and sprite information for both enabled and disabled states.
/// </summary>
public class Item
{
    /// <summary>
    /// Gets or sets the unique identifier for the item.
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the item.
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the sprite representation for the enabled state of the item.
    /// </summary>
    [JsonProperty("enabled")]
    public string? EnabledSprite { get; set; }

    /// <summary>
    /// Gets or sets the sprite representation of the item in its disabled state.
    /// </summary>
    [JsonProperty("disabled")]
    public string? DisabledSprite { get; set; }
}