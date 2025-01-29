using System.Linq;
using EnKdev.ItemTrackers.Core.Internal.Json;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.Core.Services;
using EnKdev.ItemTrackers.OoT.Internal;

namespace EnKdev.ItemTrackers.OoT.Commands;

public static class CommandHandler
{
    private static readonly OoTData? OoTData = Globals.InstanceData;
    
    private static readonly OtherService OtherService = new();
    private static readonly ArrowService ArrowService = new();
    private static readonly BottleService BottleService = new();
    private static readonly DungeonService DungeonService = new();
    private static readonly ItemService ItemService = new();
    private static readonly SongService SongService = new();
    private static readonly QuestService QuestService = new();
    
    public static void ToggleShard(TrackerProperties properties)
    {
        Logger.LogInformation("Toggling Shard/Stone of Agony.");

        var shardObj = OoTData?.Other?.FirstOrDefault(x => x.Id == "Othr_Shard");

        if (shardObj is null)
        {
            Logger.LogInformation("Shard/Stone of Agony not found. Returning.");
            return;
        }
        
        properties.ShardImage = OtherService.ToggleOtherItem(shardObj, properties.ShardImage);
        Logger.LogInteraction(nameof(properties.ShardImage));
    }

    public static void ToggleGerudoToken(TrackerProperties properties)
    {
        Logger.LogInformation("Toggling Gerudo Token.");
        
        var tokenObj = OoTData?.Other?.FirstOrDefault(x => x.Id == "Othr_Token");

        if (tokenObj is null)
        {
            Logger.LogInformation("Gerudo Token not found. Returning.");
            return;
        }
        
        properties.GerudoTokenImage = OtherService.ToggleOtherItem(tokenObj, properties.GerudoTokenImage);
        Logger.LogInteraction(nameof(properties.GerudoTokenImage));
    }

    public static void IncreaseGoldSkulltulaCount(TrackerProperties properties, int maxCount)
    {
        Logger.LogInformation("Increasing Gold Skulltula count.");
        
        // Cap at the max token count. (100)
        if (properties.GsTokens == maxCount)
        {
            properties.GsTokens = maxCount;
        }
        else
        { 
            properties.GsTokens++;   
        }
        
        Logger.LogInteraction(nameof(properties.GsTokens));
    }

    public static void DecreaseGoldSkulltulaCount(TrackerProperties properties)
    {
        Logger.LogInformation("Decreasing Gold Skulltula count.");
        
        // Cap at the min token count. (0)
        if (properties.GsTokens == 0)
        {
            properties.GsTokens = 0;
        }
        else
        {
            properties.GsTokens--;   
        }
        
        Logger.LogInteraction(nameof(properties.GsTokens));
    }

    public static void IncreaseHeartContainerCount(TrackerProperties properties, int maxCount)
    {
        Logger.LogInformation("Increasing Heart Container count.");
        
        // Cap at the max container count. (8)
        if (properties.HeartContainerCount == maxCount)
        {
            properties.HeartContainerCount = maxCount;
        }
        else
        {
            properties.HeartContainerCount++;   
        }
        
        Logger.LogInteraction(nameof(properties.HeartContainerCount));
    }

    public static void ProgressHeartPiece(TrackerProperties properties, int maxHeartPieceCount)
    {
        Logger.LogInformation("Progressing Heart Piece.");
        
        // Cap at the max heart piece count. (36)
        if (properties.HeartPieceCount == maxHeartPieceCount)
        {
            properties.HeartPieceCount = maxHeartPieceCount;
        }
        else
        {
            properties.HeartPieceCount++;
        }
        
        Logger.LogInteraction(nameof(properties.HeartPieceCount));
    }
}