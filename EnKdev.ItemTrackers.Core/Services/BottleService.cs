using EnKdev.ItemTrackers.Core.Internal.Json.OoT;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.Core.Sprites;

namespace EnKdev.ItemTrackers.Core.Services;

/// <summary>
/// Provides services related to the management of bottles, including toggling
/// their visual states based on enabled or disabled conditions.
/// </summary>
public class BottleService
{
    /// <summary>
    /// Toggles the visual state of a bottle between enabled and disabled based on its current state.
    /// If the bottle is null, logs an informational message and returns the default image path.
    /// </summary>
    /// <param name="bottle">The bottle object containing information about enabled and disabled states.</param>
    /// <param name="imagePath">The default path to the bottle image.</param>
    /// <returns>
    /// A string representing the updated sprite path for the bottle. If the bottle is null,
    /// returns the provided default image path.
    /// </returns>
    public string? ToggleBottle(Bottle? bottle, string imagePath)
    {
        if (bottle is not null)
        {
            return SpriteUtils.GetState(imagePath) ? bottle.DisabledSprite : bottle.EnabledSprite;
        }

        Logger.LogInformation("Bottle not found. Returning default image path.");
        return imagePath;
    }
}