using EnKdev.ItemTrackers.Core.Interfaces;
using EnKdev.ItemTrackers.Core.Sprites;

namespace EnKdev.ItemTrackers.Core.Services;

/// <inheritdoc cref="ISongService"/>
public class SongService : ISongService
{
    /// <inheritdoc/>
    public string ToggleSong(string? imagePath, string songName)
    {
        return imagePath = songName switch
        {
            "lullaby" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledSongs[0] : OoTConstants.EnabledSongs[0],
            "epona" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledSongs[1] : OoTConstants.EnabledSongs[1],
            "saria" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledSongs[2] : OoTConstants.EnabledSongs[2],
            "storm" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledSongs[3] : OoTConstants.EnabledSongs[3],
            "sun" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledSongs[4] : OoTConstants.EnabledSongs[4],
            "time" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledSongs[5] : OoTConstants.EnabledSongs[5],
            "minuet" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledSongs[6] : OoTConstants.EnabledSongs[6],
            "bolero" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledSongs[7] : OoTConstants.EnabledSongs[7],
            "serenade" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledSongs[8] : OoTConstants.EnabledSongs[8],
            "requiem" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledSongs[9] : OoTConstants.EnabledSongs[9],
            "nocturne" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledSongs[10] : OoTConstants.EnabledSongs[10],
            "prelude" => SpriteUtils.GetState(imagePath) ? OoTConstants.DisabledSongs[11] : OoTConstants.EnabledSongs[11],
            _ => imagePath
        };
    }
}