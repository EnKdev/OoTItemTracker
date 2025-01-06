using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT;

/// <summary>
/// Represents a bottle with a set of properties including an identifier,
/// name, and sprites for enabled and disabled states.
/// </summary>
public class Bottle
{
    /// <summary>
    /// Gets or sets the identifier for the bottle.
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the bottle.
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the sprite that represents the enabled state of the bottle.
    /// </summary>
    [JsonProperty("enabled")]
    public string? EnabledSprite { get; set; }

    /// <summary>
    /// Gets or sets the sprite image representing the bottle in its disabled state.
    /// </summary>
    [JsonProperty("disabled")]
    public string? DisabledSprite { get; set; }
}