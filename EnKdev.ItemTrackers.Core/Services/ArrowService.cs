using EnKdev.ItemTrackers.Core.Internal.Json.OoT;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.Core.Sprites;

namespace EnKdev.ItemTrackers.Core.Services;

/// <summary>
/// Provides services for managing and toggling arrow-related sprites for different states,
/// such as enabled and disabled. This service interacts with arrow objects, sprite utilities,
/// and logging mechanisms to ensure consistent handling of arrow sprites.
/// </summary>
public class ArrowService
{
    /// <summary>
    /// Toggles the state of an arrow sprite between enabled and disabled.
    /// If the input arrow is not null, it checks the state of the sprite and
    /// returns the appropriate enabled or disabled sprite path. If the input arrow is null,
    /// it logs an informational message and returns the provided image path.
    /// </summary>
    /// <param name="arrow">The arrow object containing sprite path information. Can be null.</param>
    /// <param name="imagePath">The current image path to evaluate or return if the arrow is null.</param>
    /// <returns>A string representing the updated sprite path if the arrow is not null,
    /// or the provided image path if the arrow is null.</returns>
    public string? ToggleArrow(Arrow? arrow, string? imagePath)
    {
        if (arrow is not null)
        {
            return SpriteUtils.GetState(imagePath) ? arrow.DisabledSprite : arrow.EnabledSprite;
        }

        Logger.LogInformation($"Arrow not found. Returning default image path.");
        return imagePath;
    }
}