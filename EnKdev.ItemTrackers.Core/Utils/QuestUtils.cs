using EnKdev.ItemTrackers.Core.Internal.Json.OoT;

namespace EnKdev.ItemTrackers.Core.Utils;

/// <summary>
/// A collection of utility methods for handling quest progression and location updates within the system.
/// </summary>
public static class QuestUtils
{
    /// <summary>
    /// Toggles the progression state of a quest based on the specified progression ID.
    /// This method updates the quest's sprite to either its enabled or disabled state.
    /// </summary>
    /// <typeparam name="T">The type of the context object that contains quest-related properties.</typeparam>
    /// <param name="progId">The identifier of the quest progression to be toggled.</param>
    /// <param name="context">The context object that holds the state and properties of the quest.</param>
    /// <param name="getProperty">A function to retrieve the quest-related property value from the context.</param>
    /// <param name="setProperty">A function to update the quest-related property value in the context.</param>
    /// <param name="getProgObjById">A function to retrieve the quest progression object by its identifier.</param>
    /// <param name="checkSpriteState">A function to check the current sprite state of the quest progression.</param>
    /// <param name="logAction">A logging action to record information about the toggle operation.</param>
    public static void ToggleQuestProgression<T>(
        string progId, T context,
        Func<T, string?> getProperty, Action<T, string?> setProperty,
        Func<string, Progression?> getProgObjById,
        Func<string, bool> checkSpriteState,
        Action<string> logAction)
    {
        logAction($"Toggle quest progression: {progId}");

        var progObj = getProgObjById(progId);
        
        if (progObj == null)
        {
            logAction($"Quest progression {progId} not found");
            return;
        }
        
        var value = getProperty(context);
        var toggledValue = checkSpriteState(value!)
            ? progObj.DisabledSprite
            : progObj.EnabledSprite;
        
        setProperty(context, toggledValue);
        logAction($"Quest progression {progId} set to {toggledValue}");
    }

    /// <summary>
    /// Updates the location index and the current location in the context, cycling the index if it surpasses the maximum allowed value.
    /// This method performs updates on the UI thread and logs the changes.
    /// </summary>
    /// <typeparam name="T">The type of the context object that contains location-related properties.</typeparam>
    /// <param name="context">The context object that holds the state and properties of the location.</param>
    /// <param name="getCurrentIdx">A function to retrieve the current location index from the context.</param>
    /// <param name="setCurrentIdx">A function to update the current location index in the context.</param>
    /// <param name="getCurrentLocation">A function to retrieve the current location value from the context.</param>
    /// <param name="setCurrentLocation">A function to update the current location value in the context.</param>
    /// <param name="getLocationByIndex">A function to retrieve a location value based on the given index.</param>
    /// <param name="maxIndex">The maximum allowed value for the location index.</param>
    /// <param name="logAction">A logging action to record information about the update operation.</param>
    /// <param name="invokeOnUi">A function to execute actions on the UI thread.</param>
    public static void UpdateLocationIndex<T>(
        T context,
        Func<T, int> getCurrentIdx, Action<T, int> setCurrentIdx,
        Func<T, string?> getCurrentLocation, Action<T, string?> setCurrentLocation,
        Func<int, string?> getLocationByIndex,
        int maxIndex,
        Action<string> logAction, Action<Action> invokeOnUi)
    {
        logAction("Updating location index");

        // Check and cycle the index
        var currentIdx = getCurrentIdx(context);

        if (currentIdx >= maxIndex)
        {
            // Cycle back on 0
            setCurrentIdx(context, 0);
        }

        invokeOnUi(() =>
        {
            var newIdx = getCurrentIdx(context) + 1; // Increment the index
            setCurrentIdx(context, newIdx);

            // Update location based on the index
            var newLocation = newIdx > maxIndex
                ? getCurrentLocation(context)
                : getLocationByIndex(newIdx);

            setCurrentLocation(context, newLocation);
        });
        
        logAction($"Location index updated to {currentIdx}");
        logAction($"Location updated to {getCurrentLocation(context)}");
    }
}