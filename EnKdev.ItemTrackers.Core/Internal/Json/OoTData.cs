using EnKdev.ItemTrackers.Core.Internal.Json.OoT;
using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json;

/// <summary>
/// Represents the data structure used to store and manage various properties
/// and configurations related to an OoT (Ocarina of Time) game state.
/// This class facilitates serialization and deserialization of this data structure in JSON format.
/// </summary>
public class OoTData
{
    /// <summary>
    /// Represents a collection of arrow objects, each containing metadata such as
    /// identifier, name, and associated sprites for both enabled and disabled states.
    /// This property is designed to facilitate tracking of arrows within the context
    /// of Ocarina of Time-related data.
    /// </summary>
    [JsonProperty("arrows")]
    public List<Arrow>? Arrows { get; set; }

    /// <summary>
    /// Represents a collection of bottle objects, each containing metadata such as
    /// identifier, name, and associated sprites for active and inactive states.
    /// This property is used to track all collectible bottles within the context
    /// of Ocarina of Time-related data.
    /// </summary>
    [JsonProperty("bottles")]
    public List<Bottle>? Bottles { get; set; }

    /// <summary>
    /// Represents a collection of item objects, each containing attributes such as ID, name,
    /// and associated sprites for both enabled and disabled states. This property is used
    /// to manage and track items within the context of Ocarina of Time-related game data.
    /// </summary>
    [JsonProperty("items")]
    public List<Item>? Items { get; set; }

    /// <summary>
    /// Represents a collection of upgrade objects, each defining metadata such as
    /// identifier, name, icon representation, and relational hierarchy to other upgrades.
    /// This property is utilized for managing and tracking upgrade entities within
    /// the context of Ocarina of Time-related data.
    /// </summary>
    [JsonProperty("upgrades")]
    public List<Upgrade>? Upgrades { get; set; }

    /// <summary>
    /// Represents a collection of progression objects, each containing details
    /// such as identification, name, display properties, and information
    /// regarding discovery. This property is intended to track the progression
    /// elements within the context of Ocarina of Time-related data management.
    /// </summary>
    [JsonProperty("progression")]
    public List<Progression>? Progression { get; set; }

    /// <summary>
    /// Represents the currently equipped items, including categories such as boots,
    /// swords, shields, and tunics, as part of the tracked Ocarina of Time game state.
    /// This property facilitates management and serialization of the player's equipped
    /// items within the game's context.
    /// </summary>
    [JsonProperty("equips")]
    public Equip? Equips { get; set; }

    /// <summary>
    /// Represents a collection of song objects, each containing metadata such as
    /// an identifier, the song's name, and its enabled or disabled states.
    /// This property is utilized for tracking and managing songs within the
    /// Ocarina of Time game context.
    /// </summary>
    [JsonProperty("songs")]
    public List<Song>? Songs { get; set; }

    /// <summary>
    /// Represents a collection of vanilla dungeon objects, each containing metadata such
    /// as unique identifier, name, maximum number of keys, and boss key state. This property
    /// is designed to facilitate tracking and management of dungeons within the Ocarina of Time
    /// game's internal JSON structure.
    /// </summary>
    [JsonProperty("vanillaDungeons")]
    public List<VanillaDungeon>? VanillaDungeons { get; set; }

    /// <summary>
    /// Represents a collection of MQ (Master Quest) dungeon data, where each entry provides details
    /// about a specific MQ dungeon, including its identifier, name, maximum required keys, and whether
    /// it contains a boss key. This property is utilized to manage Master Quest dungeon-related state
    /// for Ocarina of Time-specific data handling.
    /// </summary>
    [JsonProperty("mqDungeons")]
    public List<MqDungeon>? MqDungeons { get; set; }

    /// <summary>
    /// Represents a collection of location identifiers within the context of Ocarina of Time.
    /// These locations may correspond to in-game areas, events, or points of interest
    /// relevant for tracking progression or other gameplay elements.
    /// </summary>
    [JsonProperty("locations")]
    public List<string>? Locations { get; set; }

    /// <summary>
    /// Represents a collection of types, which can be used to store and manage
    /// categorized or grouped data relevant to Ocarina of Time game state.
    /// This property supports serialization and deserialization in JSON format.
    /// </summary>
    [JsonProperty("types")]
    public List<string>? Types { get; set; }

    /// <summary>
    /// Represents a collection of trade-related objects used to track progression items
    /// and events in the context of Ocarina of Time gameplay. This property categorizes
    /// trades into specific child and adult trade sequences, providing structured data
    /// for game state analysis and management.
    /// </summary>
    [JsonProperty("trades")]
    public Trade? Trades { get; set; }

    /// <summary>
    /// Represents a collection of "Other" objects, each containing an identifier,
    /// a name, and corresponding states that define whether an item is enabled or disabled.
    /// This property is used within the context of managing additional miscellaneous states
    /// in an Ocarina of Time-related data structure.
    /// </summary>
    [JsonProperty("other")]
    public List<Other>? Other { get; set; }
}