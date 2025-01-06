namespace EnKdev.ItemTrackers.Core.Sprites;

/// <summary>
/// Provides utility methods for working with sprites.
/// </summary>
public static class SpriteUtils
{
    /// <summary>
    /// Returns the state of a sprite.
    /// </summary>
    /// <param name="spriteName">The name of the sprite.</param>
    /// <returns>
    /// A boolean value indicating whether the sprite is enabled or disabled.
    /// </returns>
    public static bool GetState(string? spriteName)
    {
        return !spriteName.Contains("_Disabled");
    }
}