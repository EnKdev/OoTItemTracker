using System.Windows;
using EnKdev.ItemTrackers.Core.Internal.Json;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.Core.Services;
using EnKdev.ItemTrackers.Core.Sprites;
using EnKdev.ItemTrackers.Core.Utils;
using EnKdev.ItemTrackers.OoT.Internal;

namespace EnKdev.ItemTrackers.OoT.Commands;

public static class CommandHandler
{
    private static readonly OoTData? OoTData = Globals.InstanceData;
    
    private static readonly ArrowService ArrowService = new();
    private static readonly BottleService BottleService = new();
    private static readonly DungeonService DungeonService = new();
    private static readonly ItemService ItemService = new();
    
    
    // ==================
    // = OTHER COMMANDS =
    // ==================
    public static void ToggleOther(string otherId, TrackerProperties properties)
    {
        if (Mappings.GetOtherMappings().TryGetValue(otherId, out var mapping))
        {
            OtherUtils.ToggleOtherItem(
                otherId, properties, mapping.Get, mapping.Set,
                id => ObjectUtils.GetOtherObjectById(id, OoTData),
                SpriteUtils.GetState, Logger.LogInformation);
        }
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
    
    // =====================
    // = QUEST PROGRESSION =
    // =====================

    public static void ToggleQuest(string progressionId, TrackerProperties properties)
    {
        if (Mappings.GetQuestMappings().TryGetValue(progressionId, out var mapping))
        {
            QuestUtils.ToggleQuestProgression(
                progressionId, properties, mapping.Get, mapping.Set,
                id => ObjectUtils.GetProgressionObjectById(id, OoTData),
                SpriteUtils.GetState, Logger.LogInformation);
        }
    }

    public static void UpdateLocation(string questItem, TrackerProperties properties)
    {
        if (Mappings.GetLocationMappings().TryGetValue(questItem, out var mapping))
        {
            QuestUtils.UpdateLocationIndex(
                properties,
                mapping.Item1, // Get index
                mapping.Item2, // Set index
                mapping.Item3, // Get location
                mapping.Item4, // Set location
                mapping.Item5, // Get location by index
                mapping.Item6, // Max index
                Logger.LogInformation,
                action => Application.Current.Dispatcher.Invoke(action)
            );
        }
        else
        {
            Logger.LogInformation($"Invalid quest item: {questItem}.");
        }
    }
    
    // =================
    // = SONG COMMANDS =
    // =================

    public static void ToggleSong(string songId, TrackerProperties properties)
    {
        if (Mappings.GetSongMappings().TryGetValue(songId, out var mapping))
        {
            SongUtils.ToggleSong(
                songId, properties, mapping.Get, mapping.Set,
                id => ObjectUtils.GetSongObjectById(id, OoTData),
                SpriteUtils.GetState, Logger.LogInformation);
        }
    }
    
    // ==================
    // = EQUIP COMMANDS =
    // ==================

    public static void ToggleEquip(string equipId, TrackerProperties properties)
    {
        // ReSharper disable once InvertIf
        if (Mappings.GetEquipMappings().TryGetValue(equipId, out var mapping))
        {
            if (equipId.Contains("Sword"))
            {
                EquipUtils.ToggleSword(
                    equipId, properties, mapping.Get, mapping.Set,
                    id => ObjectUtils.GetSwordObjectById(id, OoTData)!,
                    SpriteUtils.GetState, Logger.LogInformation);
            }
            else if (equipId.Contains("Shield"))
            {
                EquipUtils.ToggleShield(
                    equipId, properties, mapping.Get, mapping.Set,
                    id => ObjectUtils.GetShieldObjectById(id, OoTData)!,
                    SpriteUtils.GetState, Logger.LogInformation);
            }
            else if (equipId.Contains("Tunic"))
            {
                EquipUtils.ToggleTunic(
                    equipId, properties, mapping.Get, mapping.Set,
                    id => ObjectUtils.GetTunicObjectById(id, OoTData)!,
                    SpriteUtils.GetState, Logger.LogInformation);
            }
            else if (equipId.Contains("Boots"))
            {
                EquipUtils.ToggleBoots(
                    equipId, properties, mapping.Get, mapping.Set,
                    id => ObjectUtils.GetBootObjectById(id, OoTData)!,
                    SpriteUtils.GetState, Logger.LogInformation);
            }
        }
    }
}