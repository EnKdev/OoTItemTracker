namespace EnKdev.ItemTrackers.Core.Utils;

/// <summary>
/// A utility class providing common methods for managing and updating dungeon states.
/// This includes toggling dungeon map and compass visibility, and updating dungeon-specific flags and states.
/// </summary>
public static class DungeonUtils
{
    /// <summary>
    /// Toggles the map state for a specific dungeon, updating its visual representation and internal state.
    /// </summary>
    /// <typeparam name="T">The type of the context object that holds dungeon-related properties and state.</typeparam>
    /// <param name="dungeonId">The unique identifier for the dungeon whose map state is being toggled.</param>
    /// <param name="context">The context object containing dungeon properties and related data.</param>
    /// <param name="getDungeonMap">A function that retrieves the current map state from the context.</param>
    /// <param name="setDungeonMap">An action to update the map state in the context.</param>
    /// <param name="checkSpriteState">A function to determine the current visual state of the map based on the provided value.</param>
    /// <param name="logAction">An action used to log messages during the toggle operation.</param>
    public static void ToggleDungeonMap<T>(
        string dungeonId, T context,
        Func<T, string?> getDungeonMap, Action<T, string?> setDungeonMap,
        Func<string, bool> checkSpriteState, Action<string> logAction)
    {
        logAction($"Toggling dungeon map for {dungeonId}");

        var value = getDungeonMap(context);
        
        var toggledValue = checkSpriteState(value!)
            ? OoTConstants.DungeonMapDisabled
            : OoTConstants.DungeonMapEnabled;
        
        setDungeonMap(context, toggledValue);
    }

    /// <summary>
    /// Toggles the compass state for a specific dungeon, updating its visual representation and internal state.
    /// </summary>
    /// <typeparam name="T">The type of the context object that holds dungeon-related properties and state.</typeparam>
    /// <param name="dungeonId">The unique identifier for the dungeon whose compass state is being toggled.</param>
    /// <param name="context">The context object containing dungeon properties and related data.</param>
    /// <param name="getDungeonCompass">A function that retrieves the current compass state from the context.</param>
    /// <param name="setDungeonCompass">An action to update the compass state in the context.</param>
    /// <param name="checkSpriteState">A function to determine the current visual state of the compass based on the provided value.</param>
    /// <param name="logAction">An action used to log messages during the toggle operation.</param>
    public static void ToggleDungeonCompass<T>(
        string dungeonId, T context,
        Func<T, string?> getDungeonCompass, Action<T, string?> setDungeonCompass,
        Func<string, bool> checkSpriteState, Action<string> logAction)
    {
        logAction($"Toggling dungeon compass for {dungeonId}");

        var value = getDungeonCompass(context);
        
        var toggledValue = checkSpriteState(value!)
            ? OoTConstants.CompassDisabled
            : OoTConstants.CompassEnabled;
        
        setDungeonCompass(context, toggledValue);
    }

    /// <summary>
    /// Updates the state of a dungeon by toggling dungeon flags and determining the appropriate new state.
    /// </summary>
    /// <typeparam name="T">The type of the context object containing dungeon-related properties.</typeparam>
    /// <param name="context">The context object that holds necessary dungeon properties.</param>
    /// <param name="getDungeonState">A function to retrieve the current dungeon state from the context.</param>
    /// <param name="setDungeonState">An action to update the dungeon state in the context.</param>
    /// <param name="getCurrentState">A function to retrieve the current dungeon state representation from the context.</param>
    /// <param name="setCurrentState">An action to update the current dungeon state representation in the context.</param>
    /// <param name="getDungeonFlag">A function to retrieve the current state of a dungeon flag from the context.</param>
    /// <param name="setDungeonFlag">An action to update the dungeon flag in the context.</param>
    /// <param name="getDungeonStateByIndex">A function to retrieve a dungeon state representation by its index.</param>
    /// <param name="maxIndex">The maximum valid index for dungeon states.</param>
    /// <param name="logAction">A logging action used to log messages during the update process.</param>
    /// <param name="invokeOnUi">An action to ensure UI-related operations are executed on the correct thread.</param>
    public static void UpdateDungeonState<T>(
        T context,
        Func<T, int> getDungeonState, Action<T, int> setDungeonState,
        Func<T, string?> getCurrentState, Action<T, string?> setCurrentState,
        Func<T, bool> getDungeonFlag, Action<T, bool> setDungeonFlag,
        Func<int, string?> getDungeonStateByIndex,
        int maxIndex, Action<string> logAction, Action<Action> invokeOnUi)
    {
        logAction("Updating dungeon state");

        var currentState = getDungeonState(context);
        var currentFlag = getDungeonFlag(context);
        setDungeonFlag(context, !currentFlag);

        if (currentState >= maxIndex)
        {
            setDungeonState(context, 0);
        }

        invokeOnUi(() =>
        {
            var newState = getDungeonState(context) + 1;
            setDungeonState(context, newState);

            var dungeonState = newState > maxIndex ? getCurrentState(context) : getDungeonStateByIndex(newState);

            setCurrentState(context, dungeonState);
        });
        
        logAction($"Dungeon state updated to {currentState}");
        logAction($"Dungeon state updated to {getCurrentState(context)}");
        logAction($"Dungeon flag updated to {currentFlag}");
    }

    /// <summary>
    /// Handles the key count and updates associated visual and state
    /// elements based on the current count and maximum allowable keys.
    /// </summary>
    /// <typeparam name="T">The type representing the color state for the keys.</typeparam>
    /// <param name="isMq">Indicates whether the dungeon is in its Master Quest variant, affecting maximum key count.</param>
    /// <param name="getKeyCount">A function to retrieve the current key count.</param>
    /// <param name="setKeyCount">An action to update the current key count.</param>
    /// <param name="setKeyColor">An action to update the key color state.</param>
    /// <param name="setKeyImage">An action to update the key image representation.</param>
    /// <param name="maxKeysVanilla">The maximum key count allowed for the standard dungeon variant.</param>
    /// <param name="maxKeysMq">The maximum key count allowed for the Master Quest dungeon variant.</param>
    /// <param name="enabledImage">The image to be set when the key count is at or above the maximum allowable keys.</param>
    /// <param name="hasKeyColor">The color state to set when at least one key is available.</param>
    /// <param name="allKeyColor">The color state to set when the key count reaches the maximum allowable keys.</param>
    /// <param name="noKeyColor">The optional color state to set when no keys are available.</param>
    public static void HandleKeys<T>(
        bool isMq, Func<int> getKeyCount, Action<int> setKeyCount,Action<T> setKeyColor,
        Action<string> setKeyImage, int maxKeysVanilla, int maxKeysMq,
        string enabledImage, T hasKeyColor, T allKeyColor,
        T? noKeyColor = default)
    {
        var maxKeys = isMq ? maxKeysVanilla : maxKeysMq;
        var currentKeyCount = getKeyCount();

        if (currentKeyCount < maxKeys)
        {
            setKeyImage(enabledImage);
            setKeyColor(hasKeyColor);
        }

        currentKeyCount++;

        if (currentKeyCount >= maxKeys)
        {
            currentKeyCount = maxKeys;
            setKeyColor(allKeyColor);
        }
        
        setKeyCount(currentKeyCount);
        
        if (noKeyColor != null && currentKeyCount == 0)
        {
            setKeyColor(noKeyColor);
        }
    }

    /// <summary>
    /// Toggles the boss key state for a specific dungeon, updating its visual representation and internal state.
    /// </summary>
    /// <typeparam name="T">The type of the context object that holds dungeon-related properties and state.</typeparam>
    /// <param name="dungeonId">The unique identifier for the dungeon whose boss key state is being toggled.</param>
    /// <param name="context">The context object containing dungeon properties and related data.</param>
    /// <param name="getBossKey">A function that retrieves the current boss key state from the context.</param>
    /// <param name="setBossKey">An action to update the boss key state in the context.</param>
    /// <param name="checkSpriteState">A function to determine whether the current visual state of the boss key is enabled or disabled.</param>
    /// <param name="logAction">An action used to log messages related to the toggle operation.</param>
    public static void ToggleBossKey<T>(
        string dungeonId, T context,
        Func<T, string?> getBossKey, Action<T, string?> setBossKey,
        Func<string, bool> checkSpriteState, Action<string> logAction)
    {
        logAction($"Toggling dungeon compass for {dungeonId}");

        var value = getBossKey(context);

        var toggledValue = checkSpriteState(value!)
            ? OoTConstants.BossKeyDisabled
            : OoTConstants.BossKeyEnabled;
        
        setBossKey(context, toggledValue);
    }
}