using EnKdev.ItemTrackers.Core.Internal.Json.OoT.Trades;
using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT;

/// <summary>
/// Represents a trade entity for tracking item trades in the context of the
/// Ocarina of Time (OoT) item tracking system. This class organizes trade
/// sequences into two categories: child trades and adult trades, which
/// correspond to game states or progressions.
/// </summary>
/// <remarks>
/// The `Trade` class is primarily used for managing and serializing/deserializing
/// JSON data that describes trade sequences for both child and adult game states.
/// It serves as a container for the `ChildTrade` and `AdultTrade` objects, which
/// represent detailed trade information for each respective category.
/// </remarks>
public class Trade
{
    /// <summary>
    /// Gets or sets the list of child trades associated with the trade entity.
    /// This property is used to manage child-specific trade sequences in the
    /// Ocarina of Time item tracking system.
    /// </summary>
    /// <remarks>
    /// Each child trade in the list is represented by an instance of the
    /// <see cref="ChildTrade"/> class, which encapsulates details such as
    /// trade identifiers, associated items, and parent-child relationships.
    /// </remarks>
    [JsonProperty("child")]
    public List<ChildTrade>? Child { get; set; }

    /// <summary>
    /// Gets or sets the list of adult trades associated with the trade entity.
    /// This property is used to manage adult-specific trade sequences within
    /// the Ocarina of Time item tracking system.
    /// </summary>
    /// <remarks>
    /// Each adult trade in the list is represented by an instance of the
    /// <see cref="AdultTrade"/> class, which contains details such as trade
    /// identifiers, associated items, and hierarchical relationships with
    /// child trades or other game states.
    /// </remarks>
    [JsonProperty("adult")]
    public List<AdultTrade>? Adult { get; set; }
}