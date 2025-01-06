using EnKdev.ItemTrackers.Core.Internal;
using EnKdev.ItemTrackers.Core.Internal.Json.OoT;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.Core.Sprites;

namespace EnKdev.ItemTrackers.Core.Services;

/// <summary>
/// 
/// </summary>
public class ItemService
{
    private readonly List<Item> _items = [];

    /// <summary>
    /// Registers an item by adding it to the internal item list.
    /// </summary>
    /// <param name="item">The item to be registered.</param>
    public void RegisterItem(Item item)
    {
        _items.Add(item);
    }

    /// <summary>
    /// Toggles the state of an item and returns the appropriate image path based on its state.
    /// </summary>
    /// <param name="name">The name of the item to toggle.</param>
    /// <param name="imagePath">The default image path to use if the item is not found.</param>
    /// <returns>
    /// Returns the enabled image path if the item's current state is disabled, otherwise returns the disabled image path.
    /// If the item is not found, returns the default image path.
    /// </returns>
    public string? ToggleItem(string name, string? imagePath)
    {
        var item = _items.FirstOrDefault(x => x.Name == name);

        if (item is not null)
        {
            return SpriteUtils.GetState(imagePath) ? item.DisabledSprite : item.EnabledSprite;
        }
        
        Logger.LogInformation($"Item '{name}' not found. Returning default image path.");
        return imagePath;
    }
}