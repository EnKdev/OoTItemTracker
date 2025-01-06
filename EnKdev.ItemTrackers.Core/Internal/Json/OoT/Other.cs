using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT;

/// <summary>
/// Represents an object with id, name, and states for an item being enabled or disabled.
/// </summary>
public class Other
{
    /// <summary>
    /// Gets or sets the unique identifier for the object.
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the state indicating whether the item is disabled.
    /// </summary>
    [JsonProperty("itemDisabled")]
    public string? ItemDisabled { get; set; }

    /// <summary>
    /// Gets or sets the value indicating whether the item is enabled.
    /// </summary>
    [JsonProperty("itemEnabled")]
    public string? ItemEnabled { get; set; }
}