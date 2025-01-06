using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT.Equips;

/// <summary>
/// Represents a tunic in the context of equipment tracking.
/// </summary>
/// <remarks>
/// The class is utilized for mapping JSON data related to tunics.
/// It contains properties such as the tunic's ID, name, and associated sprites.
/// </remarks>
public class Tunic
{
    /// <summary>
    /// Gets or sets the unique identifier of the tunic.
    /// </summary>
    /// <remarks>
    /// This property is used for mapping the "id" field in the JSON representation of a tunic.
    /// It serves as an identifier for distinguishing between different tunics.
    /// </remarks>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the tunic.
    /// </summary>
    /// <remarks>
    /// This property is used for mapping the "name" field in the JSON representation of a tunic.
    /// It represents the display name or identifier that describes the tunic.
    /// </remarks>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the sprite representation of the tunic when it is in a disabled state.
    /// </summary>
    /// <remarks>
    /// This property is used for mapping the "equipDisabled" field in the JSON representation of a tunic.
    /// It typically refers to the graphical asset displayed when the tunic cannot be equipped.
    /// </remarks>
    [JsonProperty("equipDisabled")]
    public string? DisabledSprite { get; set; }

    /// <summary>
    /// Gets or sets the sprite representation of the tunic in its enabled state.
    /// </summary>
    /// <remarks>
    /// This property is used for mapping the "equipEnabled" field in the JSON representation of a tunic.
    /// It represents the visual appearance of the tunic when it is available or equipped.
    /// </remarks>
    [JsonProperty("equipEnabled")]
    public string? EnabledSprite { get; set; }
}