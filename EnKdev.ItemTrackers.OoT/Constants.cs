using System.Windows.Media;
using EnKdev.ItemTrackers.Core.Version;

namespace EnKdev.ItemTrackers.OoT;

public static class Constants
{
    public static readonly SolidColorBrush NoKeyColor = new(Color.FromRgb(0, 0, 0));
    public static readonly SolidColorBrush HasKeyColor = new(Color.FromRgb(255, 255, 255));
    public static readonly SolidColorBrush AllKeyColor = new(Color.FromRgb(0, 255, 0));
    
    public static readonly string AppTitle = Versioner.VersionString("EnKdevs Ocarina of Time Item Tracker", 3, 0, 0, "build.6", "1bab039");

    public const string KokiriTunicImage = "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Tunic_Icon.png";
    public const string KokiriBootsImage = "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Boots_Icon.png";
}