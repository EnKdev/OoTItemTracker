using EnKdev.ItemTrackers.Core.Internal.Json.OoT;

namespace EnKdev.ItemTrackers.Core.Utils;

public static class UpgradeUtils
{
    /// <summary>
    /// Upgrades the gear associated with a given gear ID in context, updating its state and corresponding image.
    /// </summary>
    /// <typeparam name="T">The type of the context object that holds the gear properties to be upgraded.</typeparam>
    /// <param name="gearId">The unique identifier for the gear to be upgraded.</param>
    /// <param name="context">The object containing properties related to the state and image of the gear being upgraded.</param>
    /// <param name="getStateProperty">A function to retrieve the current state property of the gear from the context.</param>
    /// <param name="setStateProperty">An action to set the updated state property of the gear in the context.</param>
    /// <param name="getImageProperty">A function to retrieve the current image property of the gear from the context.</param>
    /// <param name="setImageProperty">An action to set the updated image property of the gear in the context.</param>
    /// <param name="getGearObjById">A function that retrieves the corresponding Gear object based on the given gear ID.</param>
    /// <param name="logAction">An action for logging operational details about the upgrade process.</param>
    public static void UpgradeGear<T>(
        string gearId, T context,
        Func<T, int> getStateProperty, Action<T, int> setStateProperty,
        Func<T, string?> getImageProperty, Action<T, string?> setImageProperty,
        Func<string, Gear?> getGearObjById,
        Action<string> logAction)
    {
        logAction($"Upgrading: {gearId}");

        var upgradeObj = getGearObjById(gearId);

        if (upgradeObj == null)
        {
            logAction($"Upgrade {gearId} not found");
            return;
        }

        var currentState = getStateProperty(context);

        if (currentState == -1)
        {
            logAction($"Upgrade {gearId} not yet unlocked. Setting base level (0)");
            
            setStateProperty(context, 0);
            setImageProperty(context, upgradeObj.GearEnabled);
            
            logAction($"Upgrade {gearId} set to level 0");
            return;
        }
        
        var nextState = currentState + 1;
        
        setStateProperty(context, nextState);
        setImageProperty(context, upgradeObj.GearEnabled);
        
        logAction($"Gear {gearId} set to level {nextState}");
    }

    /// <summary>
    /// Downgrades the gear associated with a given gear ID in context, updating its state and corresponding image to the previous level.
    /// </summary>
    /// <typeparam name="T">The type of the context object that holds the gear properties to be downgraded.</typeparam>
    /// <param name="gearId">The unique identifier for the gear to be downgraded.</param>
    /// <param name="context">The object containing properties related to the state and image of the gear being downgraded.</param>
    /// <param name="getStateProperty">A function to retrieve the current state property of the gear from the context.</param>
    /// <param name="setStateProperty">An action to set the updated state property of the gear in the context.</param>
    /// <param name="getImageProperty">A function to retrieve the current image property of the gear from the context.</param>
    /// <param name="setImageProperty">An action to set the updated image property of the gear in the context.</param>
    /// <param name="getGearObjById">A function that retrieves the corresponding Gear object based on the given gear ID.</param>
    /// <param name="logAction">An action for logging operational details about the downgrade process.</param>
    public static void DowngradeGear<T>(
        string gearId, T context,
        Func<T, int> getStateProperty, Action<T, int> setStateProperty,
        Func<T, string?> getImageProperty, Action<T, string?> setImageProperty,
        Func<string, Gear?> getGearObjById,
        Action<string> logAction)
    {
        logAction($"Downgrading: {gearId}");

        var gearObj = getGearObjById(gearId);

        if (gearObj == null)
        {
            logAction($"Upgrade {gearId} not found");
            return;
        }
        
        var currentState = getStateProperty(context);

        switch (currentState)
        {
            case 0:
                logAction($"Upgrade {gearId} already at base level. Disabling (-1).");
            
                setStateProperty(context, -1);
                setImageProperty(context, gearObj.GearDisabled);
                return;
            case <= -1:
                logAction($"Upgrade {gearId} already at min level");
                return;
        }

        var previousState = currentState - 1;
        setStateProperty(context, previousState);
        setImageProperty(context, gearObj.GearEnabled);

        logAction($"Gear {gearId} set to level {previousState}");
    }
}