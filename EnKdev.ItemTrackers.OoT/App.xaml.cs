using System.Windows;
using EnKdev.ItemTrackers.Core.Data;
using EnKdev.ItemTrackers.Core.Internal.Json;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.OoT.Internal;

namespace EnKdev.ItemTrackers.OoT;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private void App_OnStartup(object sender, StartupEventArgs e)
    {
        Logger.SetupLogger();
        Logger.LogInformation("[Startup] App started. Reading data file.");
        Globals.InstanceData = JsonReader.ReadDataFile<OoTData>();
        Logger.LogInformation("[Startup] Data file read.");
        Logger.LogInformation("[Startup] Instantiating main window.");
    }
}