using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT;

/// <summary>
/// Represents an upgrade entity used in the tracking system.
/// </summary>
/// <remarks>
/// An Upgrade contains unique identification, name, associated icons,
/// and hierarchical relationships with parent and child upgrades.
/// </remarks>
public class Upgrade
{
    /// <summary>
    /// Gets or sets the unique identifier for the upgrade.
    /// </summary>
    /// <remarks>
    /// This property represents the unique ID associated with a specific upgrade item
    /// within the tracking system. It can be utilized to ensure proper identification
    /// and linkage between upgrades.
    /// </remarks>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the upgrade.
    /// </summary>
    /// <remarks>
    /// This property represents the displayed or referenced name for an upgrade item
    /// in the tracking system. It is used to provide clear identification and readability
    /// for users interacting with or managing upgrades.
    /// </remarks>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the collection of icons associated with the upgrade item.
    /// </summary>
    /// <remarks>
    /// This property represents visual representations in both enabled and disabled states,
    /// categorized based on their association with gear or items.
    /// </remarks>
    [JsonProperty("icons")]
    public Icons? Icons { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the parent upgrade in the hierarchy.
    /// </summary>
    /// <remarks>
    /// This property represents the parent relationship in the hierarchical structure
    /// of upgrades. It allows for establishing a connection to the parent item,
    /// enabling the representation of upgrade dependencies or progression paths.
    /// </remarks>
    [JsonProperty("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Gets or sets the identifier of a child upgrade related to this upgrade.
    /// </summary>
    /// <remarks>
    /// This property denotes the ID of the child upgrade associated with this entity.
    /// It helps to establish hierarchical relationships between upgrades, allowing for structured organization
    /// and navigation through dependencies or subsequent levels of upgrades.
    /// </remarks>
    [JsonProperty("child")]
    public string? Child { get; set; }
}