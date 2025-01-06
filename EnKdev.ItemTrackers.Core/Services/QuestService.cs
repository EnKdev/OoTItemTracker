using EnKdev.ItemTrackers.Core.Interfaces;
using EnKdev.ItemTrackers.Core.Sprites;

namespace EnKdev.ItemTrackers.Core.Services;

/// <inheritdoc cref="IQuestService"/>
public class QuestService : IQuestService
{
    /// <inheritdoc />
    public string ToggleQuestItem(string? imagePath, string questItem)
    {
        return imagePath = questItem switch
        {
            // Stones
            "emerald" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledStones[0] : OoTConstants.EnabledStones[1],
            "ruby" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledStones[1] : OoTConstants.EnabledStones[1],
            "sapphire" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledStones[2] : OoTConstants.EnabledStones[2],

            // Medallions
            "light" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledMeds[0] : OoTConstants.EnabledMeds[0],
            "forest" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledMeds[1] : OoTConstants.EnabledMeds[1],
            "fire" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledMeds[2] : OoTConstants.EnabledMeds[2],
            "water" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledMeds[3] : OoTConstants.EnabledMeds[3],
            "shadow" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledMeds[4] : OoTConstants.EnabledMeds[4],
            "spirit" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledMeds[5] : OoTConstants.EnabledMeds[5],

            // Default
            _ => imagePath
        };
    }
}