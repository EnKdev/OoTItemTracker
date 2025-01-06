using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT.Equips;

/// <summary>
/// Represents a shield with properties for ID, name, and associated sprites for equipped states.
/// </summary>
public class Shield
{
    /// <summary>
    /// Gets or sets the unique identifier for the shield.
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the shield.
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the sprite representation of the shield when it is in a disabled state.
    /// </summary>
    [JsonProperty("equipDisabled")]
    public string? DisabledSprite { get; set; }

    /// <summary>
    /// Gets or sets the sprite displayed when the shield is in its enabled or equipped state.
    /// </summary>
    [JsonProperty("equipEnabled")]
    public string? EnabledSprite { get; set; }
}