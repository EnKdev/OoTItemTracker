using EnKdev.ItemTrackers.Core.Internal.Json.OoT;

namespace EnKdev.ItemTrackers.Core.Utils;

/// <summary>
/// Provides utility functions for managing and performing operations on "Other" items.
/// </summary>
public static class OtherUtils
{
    /// <summary>
    /// Toggles the state of an "Other" item based on its current sprite state and updates the associated context.
    /// </summary>
    /// <typeparam name="T">The type of the context containing the property to be toggled.</typeparam>
    /// <param name="otherId">The identifier of the "Other" item to be toggled.</param>
    /// <param name="context">The context object containing the property to be updated.</param>
    /// <param name="getProperty">A function to retrieve the current property value from the context.</param>
    /// <param name="setProperty">An action to set the new property value in the context.</param>
    /// <param name="getOtherObjById">A function to retrieve the "Other" object by its identifier.</param>
    /// <param name="checkSpriteState">A function to check the state of a sprite based on its name.</param>
    /// <param name="logAction">An action to log the operation performed.</param>
    public static void ToggleOtherItem<T>(
        string otherId, T context,
        Func<T, string?> getProperty, Action<T, string?> setProperty,
        Func<string, Other?> getOtherObjById,
        Func<string, bool> checkSpriteState,
        Action<string> logAction)
    {
        logAction($"Toggle other item: {otherId}");

        var otherObj = getOtherObjById(otherId);
        
        if (otherObj == null)
        {
            logAction($"Other item {otherId} not found");
            return;
        }
        
        var value = getProperty(context);
        var toggledValue = checkSpriteState(value!)
            ? otherObj.ItemDisabled!
            : otherObj.ItemEnabled!;
        
        setProperty(context, toggledValue);
        logAction($"Other item {otherId} set to {toggledValue}");
    }
}