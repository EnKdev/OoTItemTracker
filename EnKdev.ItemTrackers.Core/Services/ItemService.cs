using EnKdev.ItemTrackers.Core.Internal.Json.OoT;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.Core.Sprites;

namespace EnKdev.ItemTrackers.Core.Services;

/// <summary>
/// Service class that provides operations for managing and interacting with items.
/// </summary>
public class ItemService
{

    /// <summary>
    /// Toggles the state of an item and returns the appropriate image path based on its state.
    /// </summary>
    /// <param name="name">The name of the item to toggle.</param>
    /// <param name="imagePath">The default image path to use if the item is not found.</param>
    /// <returns>
    /// Returns the enabled image path if the item's current state is disabled, otherwise returns the disabled image path.
    /// If the item is not found, returns the default image path.
    /// </returns>
    public string? ToggleItem(Item? item, string? imagePath)
    {
        if (item is not null)
        {
            return SpriteUtils.GetState(imagePath) ? item.DisabledSprite : item.EnabledSprite;
        }
        
        Logger.LogInformation("Item not found. Returning default image path.");
        return imagePath;
    }

    /// <summary>
    /// Advances the given item's upgrade to the next stage if available.
    /// </summary>
    /// <param name="upgrades">The list of available upgrades to search through.</param>
    /// <param name="id">The unique identifier of the current upgrade item.</param>
    /// <returns>
    /// Returns the next upgrade object if it exists. If no next upgrade is available or the current upgrade cannot be found, returns null.
    /// </returns>
    public Upgrade? AdvanceUpgrade(List<Upgrade> upgrades, string? id)
    {
        // Get the current upgrade instance (e.g. Bomb Bag)
        var currentUpgrade = GetUpgradeItem(upgrades, id);
        
        // Get the next upgrade instance (e.g. Big Bomb Bag)
        var nextUpgrade = GetUpgradeItem(upgrades, currentUpgrade?.Child);

        // If the upgrade could be found, return the next stage.
        if (nextUpgrade is not null)
        {
            return nextUpgrade;
        }

        // If not, log that the upgrade couldn't be found and return null.
        Logger.LogInformation("Upgrade not found. Returning null.");
        return null;
    }

    /// <summary>
    /// Retrieves the first upgrade item from a list of upgrades that matches the provided ID and has no parent.
    /// </summary>
    /// <param name="upgrades">The list of available upgrades to search through.</param>
    /// <param name="id">The identifier of the upgrade to find.</param>
    /// <returns>
    /// Returns the first matching upgrade with the specified ID and no parent.
    /// If no such upgrade is found, returns null.
    /// </returns>
    public Upgrade? GetFirstUpgradeItem(List<Upgrade> upgrades, string? id)
    {
        var wantedUpgrade = upgrades.FirstOrDefault(x => x.Id == id && x.Parent is null);
        
        if (wantedUpgrade is not null)
        {
            return wantedUpgrade;
        }
        
        Logger.LogInformation("Upgrade not found. Returning null.");
        return null;
    }

    private Upgrade? GetUpgradeItem(List<Upgrade> upgrades, string? id)
    {
        var wantedUpgrade = upgrades.FirstOrDefault(x => x.Id == id);

        if (wantedUpgrade is not null)
        {
            return wantedUpgrade;
        }
        
        Logger.LogInformation("Upgrade not found. Returning null.");
        return null;
    }
}