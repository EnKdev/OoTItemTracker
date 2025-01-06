using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT;

/// <summary>
/// Represents a collection of icons associated with items or gear in enabled or disabled states.
/// </summary>
/// <remarks>
/// The Icons class is used to store information about visual representations of items or gear,
/// separated into enabled and disabled states for each type.
/// </remarks>
public class Icons
{
    /// <summary>
    /// Gets or sets the representation of the gear icon in a disabled state.
    /// </summary>
    /// <remarks>
    /// This property holds the visual representation for gear that is in a disabled state,
    /// typically used to differentiate unavailable or inactive gear visually.
    /// </remarks>
    [JsonProperty("gearDisabled")]
    public string? GearDisabled { get; set; }

    /// <summary>
    /// Gets or sets the representation of the gear icon in an enabled state.
    /// </summary>
    /// <remarks>
    /// This property holds the visual representation for gear that is in an active or available state,
    /// typically used to indicate functionality or readiness visually.
    /// </remarks>
    [JsonProperty("gearEnabled")]
    public string? GearEnabled { get; set; }

    /// <summary>
    /// Gets or sets the representation of an item in a disabled state.
    /// </summary>
    /// <remarks>
    /// This property holds the visual representation for an item that is unavailable or inactive,
    /// typically used to indicate its disabled status within the user interface.
    /// </remarks>
    [JsonProperty("itemDisabled")]
    public string? ItemDisabled { get; set; }

    /// <summary>
    /// Gets or sets the representation of the item icon in an enabled state.
    /// </summary>
    /// <remarks>
    /// This property holds the visual representation for items that are active or available,
    /// typically used to indicate the item can be interacted with or is in a functional state.
    /// </remarks>
    [JsonProperty("itemEnabled")]
    public string? ItemEnabled { get; set; }
}