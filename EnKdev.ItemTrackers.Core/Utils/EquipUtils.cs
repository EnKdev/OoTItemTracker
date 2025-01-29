using EnKdev.ItemTrackers.Core.Internal.Json.OoT.Equips;

namespace EnKdev.ItemTrackers.Core.Utils;

/// <summary>
/// Provides utility methods to toggle various equipment such as swords, shields, tunics, and boots.
/// This class is designed to handle context-based toggling operations by interacting
/// with property getters/setters, state checkers, and logging mechanisms.
/// </summary>
public static class EquipUtils
{
    /// <summary>
    /// Toggles the state of a sword between enabled and disabled based on the provided context and state check.
    /// </summary>
    /// <typeparam name="T">The type of the context that stores the sword state.</typeparam>
    /// <param name="swordId">The unique identifier for the sword being toggled.</param>
    /// <param name="context">The context object containing the state property of the sword.</param>
    /// <param name="getProperty">A function to retrieve the current sword state from the context.</param>
    /// <param name="setProperty">A function to update the sword state in the context.</param>
    /// <param name="getSwordObjById">A function to retrieve the Sword object by its identifier.</param>
    /// <param name="checkSpriteState">A function to determine whether the sprite state is enabled or disabled.</param>
    /// <param name="logAction">An action to log messages or actions performed during the toggle process.</param>
    public static void ToggleSword<T>(
        string swordId, T context,
        Func<T, string?> getProperty, Action<T, string?> setProperty,
        Func<string, Sword?> getSwordObjById,
        Func<string, bool> checkSpriteState,
        Action<string> logAction)
    {
        logAction($"Toggle sword: {swordId}");

        var swordObj = getSwordObjById(swordId);
        
        if (swordObj == null)
        {
            logAction($"Sword {swordId} not found");
            return;
        }
        
        var value = getProperty(context);
        var toggledValue = checkSpriteState(value!)
            ? swordObj.DisabledSprite
            : swordObj.EnabledSprite;
        
        setProperty(context, toggledValue);
        logAction($"Sword {swordId} set to {toggledValue}");
    }

    /// <summary>
    /// Toggles the state of a shield between enabled and disabled based on the provided context and state check.
    /// </summary>
    /// <typeparam name="T">The type of the context that stores the shield state.</typeparam>
    /// <param name="shieldId">The unique identifier for the shield being toggled.</param>
    /// <param name="context">The context object containing the state property of the shield.</param>
    /// <param name="getProperty">A function to retrieve the current shield state from the context.</param>
    /// <param name="setProperty">A function to update the shield state in the context.</param>
    /// <param name="getShieldObjById">A function to retrieve the Shield object by its identifier.</param>
    /// <param name="checkSpriteState">A function to determine whether the sprite state is enabled or disabled.</param>
    /// <param name="logAction">An action to log messages or actions performed during the toggle process.</param>
    public static void ToggleShield<T>(
        string shieldId, T context,
        Func<T, string?> getProperty, Action<T, string?> setProperty,
        Func<string, Shield?> getShieldObjById,
        Func<string, bool> checkSpriteState,
        Action<string> logAction)
    {
        logAction($"Toggle shield: {shieldId}");

        var shieldObj = getShieldObjById(shieldId);
        
        if (shieldObj == null)
        {
            logAction($"Shield {shieldId} not found");
            return;
        }
        
        var value = getProperty(context);
        var toggledValue = checkSpriteState(value!)
            ? shieldObj.DisabledSprite
            : shieldObj.EnabledSprite;
        
        setProperty(context, toggledValue);
        logAction($"Shield {shieldId} set to {toggledValue}");
    }

    /// <summary>
    /// Toggles the state of a tunic between enabled and disabled based on the provided context and state check.
    /// </summary>
    /// <typeparam name="T">The type of the context that stores the tunic state.</typeparam>
    /// <param name="tunicId">The unique identifier for the tunic being toggled.</param>
    /// <param name="context">The context object containing the state property of the tunic.</param>
    /// <param name="getProperty">A function to retrieve the current tunic state from the context.</param>
    /// <param name="setProperty">A function to update the tunic state in the context.</param>
    /// <param name="getTunicObjById">A function to retrieve the Tunic object by its identifier.</param>
    /// <param name="checkSpriteState">A function to determine whether the sprite state is enabled or disabled.</param>
    /// <param name="logAction">An action to log messages or actions performed during the toggle process.</param>
    public static void ToggleTunic<T>(
        string tunicId, T context,
        Func<T, string?> getProperty, Action<T, string?> setProperty,
        Func<string, Tunic?> getTunicObjById,
        Func<string, bool> checkSpriteState,
        Action<string> logAction)
    {
        logAction($"Toggle tunic: {tunicId}");

        var tunicObj = getTunicObjById(tunicId);
        
        if (tunicObj == null)
        {
            logAction($"Tunic {tunicId} not found");
            return;
        }
        
        var value = getProperty(context);
        var toggledValue = checkSpriteState(value!)
            ? tunicObj.DisabledSprite
            : tunicObj.EnabledSprite;
        
        setProperty(context, toggledValue);
        logAction($"Tunic {tunicId} set to {toggledValue}");
    }

    /// <summary>
    /// Toggles the state of boots between enabled and disabled based on the provided context and state check.
    /// </summary>
    /// <typeparam name="T">The type of the context that stores the boots state.</typeparam>
    /// <param name="bootsId">The unique identifier for the boots being toggled.</param>
    /// <param name="context">The context object containing the state property of the boots.</param>
    /// <param name="getProperty">A function to retrieve the current boots state from the context.</param>
    /// <param name="setProperty">A function to update the boots state in the context.</param>
    /// <param name="getBootsObjById">A function to retrieve the Boot object by its identifier.</param>
    /// <param name="checkSpriteState">A function to determine whether the sprite state is enabled or disabled.</param>
    /// <param name="logAction">An action to log messages or actions performed during the toggle process.</param>
    public static void ToggleBoots<T>(
        string bootsId, T context,
        Func<T, string?> getProperty, Action<T, string?> setProperty,
        Func<string, Boot?> getBootsObjById,
        Func<string, bool> checkSpriteState,
        Action<string> logAction)
    {
        logAction($"Toggle boots: {bootsId}");

        var bootsObj = getBootsObjById(bootsId);
        
        if (bootsObj == null)
        {
            logAction($"Boots {bootsId} not found");
            return;
        }
        
        var value = getProperty(context);
        var toggledValue = checkSpriteState(value!)
            ? bootsObj.DisabledSprite
            : bootsObj.EnabledSprite;
        
        setProperty(context, toggledValue);
        logAction($"Boots {bootsId} set to {toggledValue}");
    }
}