using EnKdev.ItemTrackers.Core.Internal.Json.OoT;

namespace EnKdev.ItemTrackers.Core.Utils;

/// <summary>
/// Provides utility methods for managing and manipulating item states within a specified context.
/// </summary>
public static class ItemUtils
{
    /// <summary>
    /// Toggles the visual state (enabled or disabled sprite) of an item based on its current state
    /// in the given context.
    /// </summary>
    /// <typeparam name="T">The type of the context object.</typeparam>
    /// <param name="itemId">The unique identifier of the item to toggle.</param>
    /// <param name="context">The context object holding the item's current state.</param>
    /// <param name="getProperty">A function to retrieve the current property value from the context object.</param>
    /// <param name="setProperty">An action to update the property value in the context object.</param>
    /// <param name="getItemObjById">A function to retrieve the item object by its unique identifier.</param>
    /// <param name="checkSpriteState">A function to check if the current sprite indicates the enabled or disabled state.</param>
    /// <param name="logAction">An action to log messages during the toggling process.</param>
    public static void ToggleItem<T>(
        string itemId, T context,
        Func<T, string?> getProperty, Action<T, string?> setProperty,
        Func<string, Item?> getItemObjById, Func<string, bool> checkSpriteState,
        Action<string> logAction)
    {
        logAction($"Toggle item: {itemId}");

        var itemObj = getItemObjById(itemId);

        if (itemObj == null)
        {
            logAction($"Item {itemId} not found");
            return;
        }
        
        var value = getProperty(context);
        var toggledValue = checkSpriteState(value!)
            ? itemObj.DisabledSprite!
            : itemObj.EnabledSprite!;
        
        setProperty(context, toggledValue);
        logAction($"Item {itemId} set to {toggledValue}");
    }
}