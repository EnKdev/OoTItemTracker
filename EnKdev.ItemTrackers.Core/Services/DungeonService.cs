using EnKdev.ItemTrackers.Core.Sprites;

namespace EnKdev.ItemTrackers.Core.Services;

public class DungeonService
{
    public string ToggleDungeonMap(string imagePath)
    {
        return SpriteUtils.GetState(imagePath) ? OoTConstants.DungeonMapDisabled : OoTConstants.DungeonMapEnabled;
    }

    public string ToggleDungeonCompass(string imagePath)
    {
        return SpriteUtils.GetState(imagePath) ? OoTConstants.CompassDisabled : OoTConstants.CompassEnabled;
    }
}