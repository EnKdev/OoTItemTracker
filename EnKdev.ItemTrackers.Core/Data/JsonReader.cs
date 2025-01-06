using EnKdev.ItemTrackers.Core.Logging;
using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.Core.Data;

/// <summary>
/// Provides methods to read the data file of an item tracker.
/// </summary>
public static class JsonReader
{
    /// <summary>
    /// Reads the data file of an item tracker.
    /// </summary>
    /// <typeparam name="T">The type of data to be read.</typeparam>
    /// <returns>The parsed state object of T.</returns>
    /// <exception cref="Exception">Thrown if something went wrong with reading the data file.</exception>
    public static T? ReadDataFile<T>() where T : new()
    {
        T? parsedJson = new();

        try
        {
            var contents = File.ReadAllText("./Data/data.json");
            parsedJson = JsonConvert.DeserializeObject<T>(contents);

            if (parsedJson == null)
            {
                throw new Exception("Something went wrong with reading the data file!");
            }
        }
        catch (Exception e)
        {
            Logger.LogException(e);
        }
        
        return parsedJson;
    }
}