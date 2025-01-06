using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT.Equips;

/// <summary>
/// Represents a sword in the item tracking system.
/// </summary>
/// <remarks>
/// This class is used to define the properties of a sword, including its unique identifier, name,
/// and its visual state representation (enabled or disabled).
/// </remarks>
public class Sword
{
    /// <summary>
    /// Gets or sets the unique identifier of the sword.
    /// </summary>
    /// <remarks>
    /// The identifier is used to uniquely distinguish the sword in the item tracking system.
    /// </remarks>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the sword.
    /// </summary>
    /// <remarks>
    /// The name is used to identify the sword in a human-readable format within the item tracking system.
    /// </remarks>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the visual representation of the sword when it is unavailable or unequipped.
    /// </summary>
    /// <remarks>
    /// This property holds the sprite data or reference for the visually disabled state of the sword in the item tracking system.
    /// </remarks>
    [JsonProperty("equipDisabled")]
    public string? DisabledSprite { get; set; }

    /// <summary>
    /// Gets or sets the visual representation of the sword when it is in an enabled state.
    /// </summary>
    /// <remarks>
    /// This property represents the sprite or image used to display the sword in its enabled or active state,
    /// used in the user interface or item tracking visuals.
    /// </remarks>
    [JsonProperty("equipEnabled")]
    public string? EnabledSprite { get; set; }
}