using System.Windows.Media;
using EnKdev.ItemTrackers.Core.Version;

namespace EnKdev.ItemTrackers.OoT;

public static class AppConstants
{
    public static readonly SolidColorBrush NoKeyColor = new(Color.FromRgb(0, 0, 0));
    public static readonly SolidColorBrush HasKeyColor = new(Color.FromRgb(255, 255, 255));
    public static readonly SolidColorBrush AllKeyColor = new(Color.FromRgb(0, 255, 0));
    
    public static readonly string AppTitle = Versioner.VersionString("EnKdevs Ocarina of Time Item Tracker", 3, 0, 0, "build.6", "1bab039");

    public const string KokiriTunicImage = "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Tunic_Icon.png";
    public const string KokiriBootsImage = "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Boots_Icon.png";
    
    public const int MaxForestKeysVanilla = 5;
    public const int MaxForestKeysMq = 6;

    public const int MaxFireKeysVanilla = 8;
    public const int MaxFireKeysMq = 5;

    public const int MaxWaterKeysVanilla = 6;
    public const int MaxWaterKeysMq = 2;

    public const int MaxShadowKeysVanilla = 5;
    public const int MaxShadowKeysMq = 6;

    public const int MaxSpiritKeysVanilla = 5;
    public const int MaxSpiritKeysMq = 7;

    public const int MaxBottomKeysVanilla = 3;
    public const int MaxBottomKeysMq = 2;

    public const int MaxGanonKeysVanilla = 2;
    public const int MaxGanonKeysMq = 3;

    public const int MaxGtgKeysVanilla = 9;
    public const int MaxGtgKeysMq = 3;
}