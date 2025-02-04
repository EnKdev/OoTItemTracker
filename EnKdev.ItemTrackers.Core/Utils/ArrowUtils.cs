using EnKdev.ItemTrackers.Core.Internal.Json.OoT;

namespace EnKdev.ItemTrackers.Core.Utils;

/// <summary>
/// Utility class for handling operations related to arrows and their visual representation.
/// </summary>
public static class ArrowUtils
{
    /// <summary>
    /// Toggles the state of an arrow's sprite between enabled and disabled based on its current state.
    /// </summary>
    /// <typeparam name="T">The type of the context object used in the operation.</typeparam>
    /// <param name="arrowId">The identifier of the arrow to toggle.</param>
    /// <param name="context">The context object containing sprite-related information.</param>
    /// <param name="getSprite">A function that retrieves the current sprite associated with the context.</param>
    /// <param name="setSprite">An action that sets the specified sprite to the context.</param>
    /// <param name="getArrowObjById">A function that retrieves an Arrow object by its identifier.</param>
    /// <param name="checkSpriteState">A function that checks whether a given sprite represents an enabled state.</param>
    /// <param name="logAction">An action that logs messages during the toggle operation.</param>
    public static void ToggleArrow<T>(
        string arrowId, T context,
        Func<T, string?> getSprite, Action<T, string?> setSprite,
        Func<string, Arrow?> getArrowObjById, Func<string, bool> checkSpriteState,
        Action<string> logAction)
    {
        logAction($"Toggle arrow: {arrowId}");

        var arrowObj = getArrowObjById(arrowId);

        if (arrowObj == null)
        {
            logAction($"Arrow {arrowId} not found");
            return;
        }

        var value = getSprite(context);
        var toggledValue = checkSpriteState(value!)
            ? arrowObj.DisabledSprite!
            : arrowObj.EnabledSprite!;

        setSprite(context, toggledValue);
        logAction($"Arrow {arrowId} set to {toggledValue}");
    }
}