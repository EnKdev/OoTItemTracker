using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT;

/// <summary>
/// Represents the progression details in the tracking system.
/// This class contains properties that describe a progression element, including
/// its identification, name, display properties, and discovery details.
/// </summary>
public class Progression
{
    /// <summary>
    /// Gets or sets the unique identifier for the progression element.
    /// This property is used to uniquely identify a progression element in the tracking system.
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the progression element.
    /// This property represents the user-friendly name used for display purposes
    /// within the tracking system.
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the sprite representation used when the progression element is in a disabled state.
    /// This property defines the visual appearance of the progression element when its associated condition is not active.
    /// </summary>
    [JsonProperty("questDisabled")]
    public string? DisabledSprite { get; set; }

    /// <summary>
    /// Gets or sets the sprite associated with the enabled state of the progression element.
    /// This property determines the appearance of the progression element when it is active or completed.
    /// </summary>
    [JsonProperty("questEnabled")]
    public string? EnabledSprite { get; set; }

    /// <summary>
    /// Gets or sets the location or context in which the progression element
    /// was found or discovered during tracking. This property provides details
    /// about where the element was obtained or identified.
    /// </summary>
    [JsonProperty("foundAt")]
    public string? FoundAt { get; set; }
}