using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT.Trades;

/// <summary>
/// Represents a child trade entity used within the ItemTrackers module.
/// It encapsulates information about the specific trade details, including
/// identifiers and item states associated with a trade.
/// </summary>
public class ChildTrade
{
    /// <summary>
    /// Gets or sets the unique identifier for the child trade entity.
    /// This identifier is used to distinguish different trades within the system.
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name associated with the child trade entity.
    /// This property represents the descriptive identifier or label
    /// for the trade within the system.
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the state indicating whether an item associated with the trade is disabled.
    /// This property reflects the item's availability or usability within the trading system.
    /// </summary>
    [JsonProperty("itemDisabled")]
    public string? ItemDisabled { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the enabled state of the item in a trade.
    /// This property indicates the active or usable state of an item within the trade context.
    /// </summary>
    [JsonProperty("itemEnabled")]
    public string? ItemEnabled { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the parent entity associated with this child trade.
    /// This property establishes a relationship between the current trade and its parent trade entity.
    /// </summary>
    [JsonProperty("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Gets or sets the identifier or reference associated with a child trade entry.
    /// This property is used to establish specific relationships or dependencies
    /// within the trade hierarchy.
    /// </summary>
    [JsonProperty("child")]
    public string? Child { get; set; }
}