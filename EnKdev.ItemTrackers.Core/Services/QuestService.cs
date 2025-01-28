using EnKdev.ItemTrackers.Core.Internal.Json.OoT;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.Core.Sprites;

namespace EnKdev.ItemTrackers.Core.Services;

/// <summary>
/// The QuestService class provides functionality for managing quest-related items within the application.
/// It interacts with progression data, logging utilities, and sprite utilities to handle the state and
/// visual representation of quest items.
/// </summary>
public class QuestService
{
    /// <summary>
    /// Toggles the state of a quest item, updating its associated sprite image based on current state.
    /// If the quest item is null, it logs an informational message and returns the default image path.
    /// </summary>
    /// <param name="questItem">The quest item whose sprite image state is being toggled. Can be null.</param>
    /// <param name="imagePath">The file path of the default image.</param>
    /// <returns>
    /// Returns the updated sprite image path based on the toggled state of the quest item.
    /// If the quest item is null, it will return the provided default image path.
    /// </returns>
    public string? ToggleQuestItem(Progression? questItem, string imagePath)
    {
        if (questItem is not null)
        {
            return SpriteUtils.GetState(imagePath) ? questItem.DisabledSprite : questItem.EnabledSprite;
        }
        
        Logger.LogInformation("Quest item not found. Returning default image path.");
        return imagePath;
    }
}