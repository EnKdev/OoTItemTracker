using EnKdev.ItemTrackers.Core.Internal.Json.OoT;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.Core.Sprites;

namespace EnKdev.ItemTrackers.Core.Services;

/// <summary>
/// Provides services for managing songs, including toggling their states and handling related operations.
/// </summary>
public class SongService
{
    /// <summary>
    /// Toggles the state of a song based on its current status and corresponding image path.
    /// </summary>
    /// <param name="song">The song to toggle, containing information about its enabled and disabled states.</param>
    /// <param name="imagePath">The file path of the image associated with the song's current state.</param>
    /// <returns>A string representing the new image path corresponding to the toggled state of the song. Returns the original image path if the song is null.</returns>
    public string? ToggleSong(Song? song, string imagePath)
    {
        if (song is not null)
        {
            return SpriteUtils.GetState(imagePath) ? song.SongDisabled : song.SongEnabled;
        }
        
        Logger.LogInformation("Song not found. Returning default image path.");
        return imagePath;
    }
}