using EnKdev.ItemTrackers.Core.Internal.Json.OoT;

namespace EnKdev.ItemTrackers.Core.Utils;

/// <summary>
/// Provides utility methods for managing and toggling song states in the application.
/// </summary>
public static class SongUtils
{
    /// <summary>
    /// Toggles the state of a song based on its current configured state and updates the relevant properties.
    /// </summary>
    /// <typeparam name="T">The type of the context object that contains the song property to be toggled.</typeparam>
    /// <param name="songId">The unique identifier of the song to be toggled.</param>
    /// <param name="context">The context object that encapsulates the state to be updated.</param>
    /// <param name="getProperty">A function that retrieves the current property value from the context.</param>
    /// <param name="setProperty">A function that updates the property value in the context.</param>
    /// <param name="getSongObjById">A function used to retrieve the song object by its identifier.</param>
    /// <param name="checkSpriteState">A function to evaluate the current state of the song (enabled or disabled).</param>
    /// <param name="logAction">A function to log actions performed during the method execution.</param>
    public static void ToggleSong<T>(
        string songId, T context,
        Func<T, string?> getProperty, Action<T, string?> setProperty,
        Func<string, Song?> getSongObjById,
        Func<string, bool> checkSpriteState,
        Action<string> logAction)
    {
        logAction($"Toggle song: {songId}");

        var songObj = getSongObjById(songId);

        if (songObj == null)
        {
            logAction($"Song {songId} not found");
            return;
        }
        
        var value = getProperty(context);
        var toggledValue = checkSpriteState(value!)
            ? songObj.SongDisabled
            : songObj.SongEnabled;
        
        setProperty(context, toggledValue);
        logAction($"Song {songId} set to {toggledValue}");
    }
}