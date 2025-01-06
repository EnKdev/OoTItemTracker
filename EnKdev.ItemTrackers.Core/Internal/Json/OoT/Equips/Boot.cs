using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT.Equips;

/// <summary>
/// Represents a boot item with properties for its id, name, and associated sprites
/// for enabled and disabled states. This class is utilized for JSON serialization/deserialization.
/// </summary>
public class Boot
{
    /// <summary>
    /// Gets or sets the unique identifier for the boot item. This property is used
    /// in JSON serialization/deserialization to represent the boot's id.
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the boot item. This property is used in JSON
    /// serialization/deserialization to represent the boot's name.
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the sprite representation of the boot item in its disabled state.
    /// This property is used in JSON serialization/deserialization to represent the appearance
    /// of the boot when it is not equipped or unavailable.
    /// </summary>
    [JsonProperty("equipDisabled")]
    public string? DisabledSprite { get; set; }

    /// <summary>
    /// Gets or sets the sprite used to visually represent the enabled state of the boot item.
    /// This property is utilized during JSON serialization/deserialization.
    /// </summary>
    [JsonProperty("equipEnabled")]
    public string? EnabledSprite { get; set; }
}