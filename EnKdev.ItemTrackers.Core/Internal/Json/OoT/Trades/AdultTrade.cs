using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT.Trades;

/// <summary>
/// Represents a trade object in the context of an adult trade, such as those
/// associated with item progression or interactions in trading sequences. This
/// class is typically used for managing and serializing/deserializing JSON data
/// related to various trade items within a specific domain.
/// </summary>
/// <remarks>
/// The `AdultTrade` class defines properties for identifying and managing
/// specific trade items, their relationships within a sequence, and
/// additional states regarding their availability or functionality.
/// </remarks>
public class AdultTrade
{
    /// <summary>
    /// Gets or sets the unique identifier for the trade item.
    /// </summary>
    /// <remarks>
    /// This property is used to uniquely identify a trade item within the context
    /// of adult trade operations. It may represent a specific item in a sequence
    /// or serve as a reference for interaction within the trading system.
    /// </remarks>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name associated with the trade item.
    /// </summary>
    /// <remarks>
    /// This property represents the descriptive or identifiable name of the trade item
    /// within the adult trade context. It may be used for display purposes, internal
    /// reference, or as part of an interaction sequence in the trading system.
    /// </remarks>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the state indicating whether the trade item is disabled.
    /// </summary>
    /// <remarks>
    /// This property determines if the associated item within a trade sequence
    /// is inactive or unavailable for interaction. Its value can be used to
    /// manage or enforce certain restrictions or conditions during the trading process.
    /// </remarks>
    [JsonProperty("itemDisabled")]
    public string? ItemDisabled { get; set; }

    /// <summary>
    /// Gets or sets the property indicating that the trade item is enabled or active.
    /// </summary>
    /// <remarks>
    /// This property determines whether the associated trade item is currently active
    /// or usable within the context of the trade sequence. Its value is typically
    /// set or modified based on the state of trading interactions or external conditions.
    /// </remarks>
    [JsonProperty("itemEnabled")]
    public string? ItemEnabled { get; set; }
    
    /// <summary>
    /// Gets or sets the identifier of the parent trade item in the trade sequence.
    /// </summary>
    /// <remarks>
    /// This property represents the parent trade item's reference or association
    /// within the context of an item trading progression or dependency hierarchy.
    /// It is used to link related trade items and define their relationships.
    /// </remarks>
    [JsonProperty("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Gets or sets the child identifier associated with the trade item.
    /// </summary>
    /// <remarks>
    /// This property represents a reference to a related or subsequent trade item
    /// in the sequence. It is used to establish hierarchical relationships or
    /// dependencies between trade items within the trading system.
    /// </remarks>
    [JsonProperty("child")]
    public string? Child { get; set; }
}