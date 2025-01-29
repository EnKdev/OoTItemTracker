using EnKdev.ItemTrackers.Core.Internal.Json.OoT;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.Core.Sprites;

namespace EnKdev.ItemTrackers.Core.Services;

public class OtherService
{
    public string ToggleOtherItem(Other? otherItem, string imagePath)
    {
        if (otherItem is not null)
        {
            return SpriteUtils.GetState(imagePath) ? otherItem.ItemDisabled! : otherItem.ItemEnabled!;
        }
        
        Logger.LogInformation("Other item not found. Returning default image path.");
        return imagePath;
    }
}