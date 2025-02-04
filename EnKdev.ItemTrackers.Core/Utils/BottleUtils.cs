using EnKdev.ItemTrackers.Core.Internal.Json.OoT;

namespace EnKdev.ItemTrackers.Core.Utils;

public static class BottleUtils
{
    /// <summary>
    /// Toggles the state of a bottle by updating its associated sprite
    /// based on its current state and internal logic.
    /// </summary>
    /// <typeparam name="T">The context type containing the state to be toggled.</typeparam>
    /// <param name="bottleId">The identifier of the bottle to be toggled.</param>
    /// <param name="context">The context object containing the state to toggle.</param>
    /// <param name="getSprite">A function that retrieves the current sprite from the context.</param>
    /// <param name="setSprite">An action to update the sprite in the context.</param>
    /// <param name="getBottleObjById">A function to retrieve the bottle object by its identifier.</param>
    /// <param name="checkSpriteState">A function that checks the state of the sprite.</param>
    /// <param name="logAction">An action to log the operation details.</param>
    public static void ToggleBottle<T>(
        string bottleId, T context,
        Func<T, string?> getSprite, Action<T, string?> setSprite,
        Func<string, Bottle?> getBottleObjById, Func<string, bool> checkSpriteState,
        Action<string> logAction)
    {
        logAction($"Toggle bottle: {bottleId}");

        var bottleObj = getBottleObjById(bottleId);
        
        if (bottleObj == null)
        {
            logAction($"Bottle {bottleId} not found");
            return;
        }
        
        var value = getSprite(context);
        var toggledValue = checkSpriteState(value!)
            ? bottleObj.DisabledSprite!
            : bottleObj.EnabledSprite!;
        
        setSprite(context, toggledValue);
        logAction($"Bottle {bottleId} set to {toggledValue}");
    }
}