using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Internal.Json.OoT;

/// <summary>
/// Represents a song in the system with properties for its ID, name, and states indicating whether the song is enabled or disabled.
/// </summary>
public class Song
{
    /// <summary>
    /// Gets or sets the unique identifier of the song.
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the song.
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the song is disabled.
    /// </summary>
    [JsonProperty("songDisabled")]
    public string? SongDisabled { get; set; }

    /// <summary>
    /// Gets or sets the state indicating whether the song is enabled.
    /// </summary>
    [JsonProperty("songEnabled")]
    public string? SongEnabled { get; set; }
}