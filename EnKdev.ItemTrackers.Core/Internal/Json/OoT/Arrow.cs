using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT;

/// <summary>
/// Represents an arrow with a set of properties including identifier, name,
/// and sprites for enabled and disabled states.
/// </summary>
public class Arrow
{
    /// <summary>
    /// Gets or sets the unique identifier of the arrow object in the Item Tracker system.
    /// </summary>
    /// <remarks>
    /// This property is represented as a nullable string and uniquely identifies an arrow instance.
    /// It is mapped from a JSON property with the name "id".
    /// </remarks>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the descriptive name of the arrow object in the Item Tracker system.
    /// </summary>
    /// <remarks>
    /// This property is represented as a string and provides a human-readable identifier for the arrow instance.
    /// It is mapped from a JSON property with the name "name".
    /// </remarks>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the sprite used to represent the enabled state of an arrow object in the Item Tracker system.
    /// </summary>
    /// <remarks>
    /// This property is represented as a string that maps to a visual asset for the enabled state.
    /// It is mapped from a JSON property with the name "enabled".
    /// </remarks>
    [JsonProperty("enabled")]
    public string? EnabledSprite { get; set; }

    /// <summary>
    /// Gets or sets the sprite associated with the disabled state of the arrow object in the Item Tracker system.
    /// </summary>
    /// <remarks>
    /// This property is represented as a string and is used to visually indicate the arrow's disabled state.
    /// It is mapped from a JSON property with the name "disabled".
    /// </remarks>
    [JsonProperty("disabled")]
    public string? DisabledSprite { get; set; }
}