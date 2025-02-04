using System.Linq;
using System.Windows;
using EnKdev.ItemTrackers.Core;
using EnKdev.ItemTrackers.Core.Internal.Json;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.Core.Sprites;
using EnKdev.ItemTrackers.Core.Utils;
using EnKdev.ItemTrackers.OoT.Internal;

namespace EnKdev.ItemTrackers.OoT.Commands;

public static class CommandHandler
{
    private static readonly OoTData? OoTData = Globals.InstanceData;

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

    // ====================
    // = UPGRADE COMMANDS =
    // ====================

    public static void ChangeStrength(TrackerProperties properties, bool isUpgrade)
    {
        if (isUpgrade)
        {
            Logger.LogInformation("Upgrading strength.");

            switch (properties.StrengthState)
            {
                case -1:
                    properties.StrengthImage = OoTData?.Gear![6].GearEnabled;
                    properties.StrengthState = 0;
                    break;
                case 0:
                    properties.StrengthImage = OoTData?.Gear![7].GearEnabled;
                    properties.StrengthState = 1;
                    break;
                case 1:
                    properties.StrengthImage = OoTData?.Gear![8].GearEnabled;
                    properties.StrengthState = 2;
                    break;
            }
        }
        else
        {
            Logger.LogInformation("Downgrading strength.");

            switch (properties.StrengthState)
            {
                case 2:
                    properties.StrengthImage = OoTData?.Gear![7].GearEnabled;
                    properties.StrengthState = 1;
                    break;
                case 1:
                    properties.StrengthImage = OoTData?.Gear![6].GearEnabled;
                    properties.StrengthState = 0;
                    break;
                case 0:
                    properties.StrengthImage = OoTData?.Gear![6].GearDisabled;
                    properties.StrengthState = -1;
                    break;
            }
        }
    }

    public static void ChangeScale(TrackerProperties properties, bool isUpgrade)
    {
        if (isUpgrade)
        {
            Logger.LogInformation("Upgrading scale.");

            switch (properties.ScaleState)
            {
                case -1:
                    properties.ScaleImage = OoTData?.Gear![12].GearEnabled;
                    properties.ScaleState = 0;
                    break;
                case 0:
                    properties.ScaleImage = OoTData?.Gear![13].GearEnabled;
                    properties.ScaleState = 1;
                    break;
            }
        }
        else
        {
            Logger.LogInformation("Downgrading scale.");

            switch (properties.ScaleState)
            {
                case 1:
                    properties.ScaleImage = OoTData?.Gear![12].GearEnabled;
                    properties.ScaleState = 0;
                    break;
                case 0:
                    properties.ScaleImage = OoTData?.Gear![12].GearDisabled;
                    properties.ScaleState = -1;
                    break;
            }
        }
    }
    
    // =================
    // = ITEM COMMANDS =
    // =================

    public static void ToggleItem(string itemId, TrackerProperties properties)
    {
        if (Mappings.GetItemMappings().TryGetValue(itemId, out var mapping))
        {
            ItemUtils.ToggleItem(
                itemId, properties,
                mapping.GetSprite, mapping.SetSprite,
                id => ObjectUtils.GetItemObjectById(id, OoTData),
                SpriteUtils.GetState, Logger.LogInformation);
        }
    }
    
    public static void ChangeOcarina(TrackerProperties properties, bool isUpgrade)
    {
        if (isUpgrade)
        {
            Logger.LogInformation("Upgrading ocarina.");

            switch (properties.OcarinaState)
            {
                case -1:
                    properties.OcarinaImage = OoTData?.Items![11].EnabledSprite;
                    properties.OcarinaState = 0;
                    break;
                case 0:
                    properties.OcarinaImage = OoTData?.Items![12].EnabledSprite;
                    properties.OcarinaState = 1;
                    break;
            }
        }
        else
        {
            Logger.LogInformation("Downgrading ocarina.");

            switch (properties.OcarinaState)
            {
                case 1:
                    properties.OcarinaImage = OoTData?.Items![11].EnabledSprite;
                    properties.OcarinaState = 0;
                    break;
                case 0:
                    properties.OcarinaImage = OoTData?.Items![11].DisabledSprite;
                    properties.OcarinaState = -1;
                    break;
            }
        }
    }

    public static void ChangeHookshot(TrackerProperties properties, bool isUpgrade)
    {
        if (isUpgrade)
        {
            Logger.LogInformation("Upgrading hookshot.");

            switch (properties.HookState)
            {
                case -1:
                    properties.HookshotImage = OoTData?.Items![13].EnabledSprite;
                    properties.HookState = 0;
                    break;
                case 0:
                    properties.HookshotImage = OoTData?.Items![14].EnabledSprite;
                    properties.HookState = 1;
                    break;
            }
        }
        else
        {
            Logger.LogInformation("Downgrading hookshot.");

            switch (properties.HookState)
            {
                case 1:
                    properties.HookshotImage = OoTData?.Items![13].EnabledSprite;
                    properties.HookState = 0;
                    break;
                case 0:
                    properties.HookshotImage = OoTData?.Items![13].EnabledSprite;
                    properties.HookState = -1;
                    break;
            }
        }
    }
    
    // ==================
    // = ARROW COMMANDS =
    // ==================

    public static void ToggleArrow(string arrowId, TrackerProperties properties)
    {
        if (Mappings.GetArrowMappings().TryGetValue(arrowId, out var mapping))
        {
            ArrowUtils.ToggleArrow(
                arrowId, properties,
                mapping.Get, mapping.Set,
                id => ObjectUtils.GetArrowObjectById(id, OoTData),
                SpriteUtils.GetState, Logger.LogInformation);
        }
    }
    
    // ===================
    // = BOTTLE COMMANDS =
    // ===================

    public static void ToggleBottle(string bottleId, TrackerProperties properties)
    {
        if (Mappings.GetBottleMappings().TryGetValue(bottleId, out var mapping))
        {
            BottleUtils.ToggleBottle(
                bottleId, properties,
                mapping.Get, mapping.Set,
                id => ObjectUtils.GetBottleObjectById(id, OoTData),
                SpriteUtils.GetState, Logger.LogInformation);
        }
    }
    
    // =================
    // = GEAR COMMANDS =
    // =================
    public static void ChangeQuiver(TrackerProperties properties, bool isUpgrade)
    {
        if (isUpgrade)
        {
            Logger.LogInformation("Upgrading quiver.");
            
            switch (properties.QuiverState)
            {
                case -1: 
                    properties.QuiverImage = OoTData?.Gear![9].GearEnabled;
                    properties.QuiverState = 0;
                    break;
                case 0: 
                    properties.QuiverImage = OoTData?.Gear![10].GearEnabled;
                    properties.QuiverState = 1;
                    break;
                case 1: 
                    properties.QuiverImage = OoTData?.Gear![11].GearEnabled;
                    properties.QuiverState = 2;
                    break;
            }
        }
        else
        {
            Logger.LogInformation("Downgrading quiver.");

            switch (properties.QuiverState)
            {
                case 2:
                    properties.QuiverImage = OoTData?.Gear![10].GearEnabled;
                    properties.QuiverState = 1;
                    break;
                case 1:
                    properties.QuiverImage = OoTData?.Gear![9].GearEnabled;
                    properties.QuiverState = 0;
                    break;
                case 0:
                    properties.QuiverImage = OoTData?.Gear![9].GearDisabled;
                    properties.QuiverState = -1;
                    break;
            }
        }
    }

    public static void ChangeBombBag(TrackerProperties properties, bool isUpgrade)
    {
        if (isUpgrade)
        {
            Logger.LogInformation("Upgrading bomb bag.");

            switch (properties.BombState)
            {
                case -1:
                    properties.BombImage = OoTData?.Gear![0].GearEnabled;
                    properties.BombState = 0;
                    break;
                case 0:
                    properties.BombImage = OoTData?.Gear![1].GearEnabled;
                    properties.BombState = 1;
                    break;
                case 1:
                    properties.BombImage = OoTData?.Gear![2].GearEnabled;
                    properties.BombState = 2;
                    break;
            }
        }
        else
        {
            Logger.LogInformation("Downgrading bomb bag.");

            switch (properties.BombState)
            {
                case 2:
                    properties.BombImage = OoTData?.Gear![1].GearEnabled;
                    properties.BombState = 1;
                    break;
                case 1:
                    properties.BombImage = OoTData?.Gear![0].GearEnabled;
                    properties.BombState = 0;
                    break;
                case 0:
                    properties.BombImage = OoTData?.Gear![0].GearDisabled;
                    properties.BombState = -1;
                    break;
            }
        }
    }
    
    public static void ChangeBulletBag(TrackerProperties properties, bool isUpgrade)
    {
        if (isUpgrade)
        {
            Logger.LogInformation("Upgrading bullet bag.");

            switch (properties.BulletState)
            {
                case -1:
                    properties.BulletImage = OoTData?.Gear![3].GearEnabled;
                    properties.BulletState = 0;
                    break;
                case 0:
                    properties.BulletImage = OoTData?.Gear![4].GearEnabled;
                    properties.BulletState = 1;
                    break;
                case 1:
                    properties.BulletImage = OoTData?.Gear![5].GearEnabled;
                    properties.BulletState = 2;
                    break;
            }
        }
        else
        {
            Logger.LogInformation("Downgrading bullet bag.");

            switch (properties.BulletState)
            {
                case 2:
                    properties.BulletImage = OoTData?.Gear![4].GearEnabled;
                    properties.BulletState = 1;
                    break;
                case 1:
                    properties.BulletImage = OoTData?.Gear![3].GearEnabled;
                    properties.BulletState = 0;
                    break;
                case 0:
                    properties.BulletImage = OoTData?.Gear![3].GearDisabled;
                    properties.BulletState = -1;
                    break;
            }
        }
    }
    
    // ==================
    // = TRADE COMMANDS =
    // ==================

    public static void ChangeChildTrade(TrackerProperties properties, bool isAdvancing)
    {
        if (isAdvancing)
        {
            Logger.LogInformation("Advancing child trade item.");

            switch (properties.ChildTradeState)
            {
                case -1:
                    properties.ChildTradeItemImage = OoTData?.Trades?.Child![0].ItemEnabled; // Weird Egg
                    properties.ChildTradeState = 0;
                    break;
                case 0:
                    properties.ChildTradeItemImage = OoTData?.Trades?.Child![1].ItemEnabled; // Cucco
                    properties.ChildTradeState = 1;
                    break;
                case 1:
                    properties.ChildTradeItemImage = OoTData?.Trades?.Child![2].ItemEnabled; // Zelda's Letter
                    properties.ChildTradeState = 2;
                    break;
                case 2:
                    properties.ChildTradeItemImage = OoTData?.Trades?.Child![3].ItemEnabled; // Skull Mask
                    properties.ChildTradeState = 3;
                    break;
                case 3:
                    properties.ChildTradeItemImage = OoTData?.Trades?.Child![4].ItemEnabled; // Mask of Truth
                    properties.ChildTradeState = 4;
                    break;
            }
        }
        else
        {
            Logger.LogInformation("Reverting child trade item.");

            switch (properties.ChildTradeState)
            {
                case 4:
                    properties.ChildTradeItemImage = OoTData?.Trades?.Child![3].ItemEnabled; // Skull Mask
                    properties.ChildTradeState = 3;
                    break;
                case 3:
                    properties.ChildTradeItemImage = OoTData?.Trades?.Child![2].ItemEnabled; // Zelda's Letter
                    properties.ChildTradeState = 2;
                    break;
                case 2:
                    properties.ChildTradeItemImage = OoTData?.Trades?.Child![1].ItemEnabled; // Cucco
                    properties.ChildTradeState = 1;
                    break;
                case 1:
                    properties.ChildTradeItemImage = OoTData?.Trades?.Child![0].ItemEnabled; // Weird Egg
                    properties.ChildTradeState = 0;
                    break;
                case 0:
                    properties.ChildTradeItemImage = OoTData?.Trades?.Child![0].ItemDisabled; // Weird Egg (Disabled)
                    properties.ChildTradeState = -1;
                    break;
            }
        }
    }

    public static void ChangeAdultTrade(TrackerProperties properties, bool isAdvancing)
    {
        if (isAdvancing)
        {
            Logger.LogInteraction("Advancing adult trade item.");

            switch (properties.AdultTradeState)
            {
                case -1:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![0].ItemEnabled; // Pocket Egg
                    properties.AdultTradeState = 0;
                    break;
                case 0:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![1].ItemEnabled; // Pocket Cucco
                    properties.AdultTradeState = 1;
                    break;
                case 1:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![2].ItemEnabled; // Cojiro
                    properties.AdultTradeState = 2;
                    break;
                case 2:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![3].ItemEnabled; // Odd Mushroom
                    properties.AdultTradeState = 3;
                    break;
                case 3:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![4].ItemEnabled; // Odd Poultice
                    properties.AdultTradeState = 4;
                    break;
                case 4:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![5].ItemEnabled; // Poachers Saw
                    properties.AdultTradeState = 5;
                    break;
                case 5:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![6].ItemEnabled; // Giant's Knife
                    properties.AdultTradeState = 6;
                    break;
                case 6:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![7].ItemEnabled; // Broken Goron's Sword
                    properties.AdultTradeState = 7;
                    break;
                case 7:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![8].ItemEnabled; // Prescription
                    properties.AdultTradeState = 8;
                    break;
                case 8:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![9].ItemEnabled; // Eyeball Frog
                    properties.AdultTradeState = 9;
                    break;
                case 9:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![10].ItemEnabled; // Eye Drops
                    properties.AdultTradeState = 10;
                    break;
                case 10:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![11].ItemEnabled; // Claim Check
                    properties.AdultTradeState = 11;
                    break;
            }
        }
        else
        {
            Logger.LogInformation("Reverting adult trade item.");

            switch (properties.AdultTradeState)
            {
                case 11:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![10].ItemEnabled; // Eye Drops
                    properties.AdultTradeState = 10;
                    break;
                case 10:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![9].ItemEnabled; // Eyeball Frog
                    properties.AdultTradeState = 9;
                    break;
                case 9:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![8].ItemEnabled; // Prescription
                    properties.AdultTradeState = 8;
                    break;
                case 8:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![7].ItemEnabled; // Broken Goron's Sword
                    properties.AdultTradeState = 7;
                    break;
                case 7:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![6].ItemEnabled; // Giant's Knife
                    properties.AdultTradeState = 6;
                    break;
                case 6:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![5].ItemEnabled; // Poachers Saw
                    properties.AdultTradeState = 5;
                    break;
                case 5:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![4].ItemEnabled; // Odd Poultice
                    properties.AdultTradeState = 4;
                    break;
                case 4:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![3].ItemEnabled; // Odd Mushroom
                    properties.AdultTradeState = 3;
                    break;
                case 3:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![2].ItemEnabled; // Cojiro
                    properties.AdultTradeState = 2;
                    break;
                case 2:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![1].ItemEnabled; // Pocket Cucco
                    properties.AdultTradeState = 1;
                    break;
                case 1:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![0].ItemEnabled; // Pocket Egg
                    properties.AdultTradeState = 0;
                    break;
                case 0:
                    properties.AdultTradeItemImage = OoTData?.Trades?.Adult![0].ItemDisabled; // Pocket Egg (Disabled)
                    properties.AdultTradeState = -1;
                    break;
            }
        }
    }
    
    // ====================
    // = DUNGEON COMMANDS =
    // ====================

    // I know this looks freaking ugly but Dungeons are their special thing alongside
    // the Trade Sequences.
    
    // This could probably be cleaned up and simplified later, but for now, this will have to do.
    public static void ToggleMap(TrackerProperties properties, string dungeonId)
    {
        if (Mappings.GetDungeonMapMappings().TryGetValue(dungeonId, out var mapping))
        {
            DungeonUtils.ToggleDungeonMap(dungeonId, properties,
                mapping.Get, mapping.Set,
                SpriteUtils.GetState, Logger.LogInformation);
        }
    }

    public static void ToggleCompass(TrackerProperties properties, string dungeonId)
    {
        if (Mappings.GetDungeonCompassMappings().TryGetValue(dungeonId, out var mapping))
        {
            DungeonUtils.ToggleDungeonCompass(dungeonId, properties,
                mapping.Get, mapping.Set,
                SpriteUtils.GetState, Logger.LogInformation);
        }
    }

    public static void UpdateDungeonState(TrackerProperties properties, string dungeonId)
    {
        if (Mappings.GetDungeonStateMappings().TryGetValue(dungeonId, out var mapping))
        {
            DungeonUtils.UpdateDungeonState(
                properties,
                mapping.Item1, mapping.Item2,
                mapping.Item3, mapping.Item4,
                mapping.Item5, mapping.Item6,
                mapping.Item7, mapping.Item8,
                Logger.LogInformation,
                action => Application.Current.Dispatcher.Invoke(action));
        }
    }

    public static void HandleKeys(TrackerProperties properties, string dungeonId)
    {
        Logger.LogInformation($"Handling keys for dungeon {dungeonId}");

        switch (dungeonId)
        {
            case "Dungeon_Forest":
                DungeonUtils.HandleKeys(
                    properties.IsForestMq,
                    () => properties.ForestKeyCount,
                    count => properties.ForestKeyCount = count,
                    color => properties.ForestKeyColor = color,
                    image => properties.ForestKeyImage = image,
                    AppConstants.MaxForestKeysVanilla,
                    AppConstants.MaxForestKeysMq,
                    OoTConstants.SmallKeyEnabled,
                    AppConstants.HasKeyColor,
                    AppConstants.AllKeyColor);
                break;
            case "Dungeon_Fire":
                DungeonUtils.HandleKeys(
                    properties.IsFireMq,
                    () => properties.FireKeyCount,
                    count => properties.FireKeyCount = count,
                    color => properties.FireKeyColor = color,
                    image => properties.FireKeyImage = image,
                    AppConstants.MaxFireKeysVanilla,
                    AppConstants.MaxFireKeysMq,
                    OoTConstants.SmallKeyEnabled,
                    AppConstants.HasKeyColor,
                    AppConstants.AllKeyColor);
                break;
            case "Dungeon_Water":
                DungeonUtils.HandleKeys(
                    properties.IsWaterMq,
                    () => properties.WaterKeyCount,
                    count => properties.WaterKeyCount = count,
                    color => properties.WaterKeyColor = color,
                    image => properties.WaterKeyImage = image,
                    AppConstants.MaxWaterKeysVanilla,
                    AppConstants.MaxWaterKeysMq,
                    OoTConstants.SmallKeyEnabled,
                    AppConstants.HasKeyColor,
                    AppConstants.AllKeyColor);
                break;
            case "Dungeon_Shadow":
                DungeonUtils.HandleKeys(
                    properties.IsShadowMq,
                    () => properties.ShadowKeyCount,
                    count => properties.ShadowKeyCount = count,
                    color => properties.ShadowKeyColor = color,
                    image => properties.ShadowKeyImage = image,
                    AppConstants.MaxShadowKeysVanilla,
                    AppConstants.MaxShadowKeysMq,
                    OoTConstants.SmallKeyEnabled,
                    AppConstants.HasKeyColor,
                    AppConstants.AllKeyColor);
                break;
            case "Dungeon_Spirit":
                DungeonUtils.HandleKeys(
                    properties.IsSpiritMq,
                    () => properties.SpiritKeyCount,
                    count => properties.SpiritKeyCount = count,
                    color => properties.SpiritKeyColor = color,
                    image => properties.SpiritKeyImage = image,
                    AppConstants.MaxSpiritKeysVanilla,
                    AppConstants.MaxSpiritKeysMq,
                    OoTConstants.SmallKeyEnabled,
                    AppConstants.HasKeyColor,
                    AppConstants.AllKeyColor);
                break;
            case "Dungeon_Bottom":
                DungeonUtils.HandleKeys(
                    properties.IsBottomMq,
                    () => properties.BottomKeyCount,
                    count => properties.BottomKeyCount = count,
                    color => properties.BottomKeyColor = color,
                    image => properties.BottomKeyImage = image,
                    AppConstants.MaxBottomKeysVanilla,
                    AppConstants.MaxBottomKeysMq,
                    OoTConstants.SmallKeyEnabled,
                    AppConstants.HasKeyColor,
                    AppConstants.AllKeyColor);
                break;
            case "Dungeon_Training":
                DungeonUtils.HandleKeys(
                    properties.IsGtgMq,
                    () => properties.GtgKeyCount,
                    count => properties.GtgKeyCount = count,
                    color => properties.GtgKeyColor = color,
                    image => properties.GtgKeyImage = image,
                    AppConstants.MaxGtgKeysVanilla,
                    AppConstants.MaxGtgKeysMq,
                    OoTConstants.SmallKeyEnabled,
                    AppConstants.HasKeyColor,
                    AppConstants.AllKeyColor);
                break;
            case "Dungeon_Ganon":
                DungeonUtils.HandleKeys(
                    properties.IsGanonMq,
                    () => properties.GanonKeyCount,
                    count => properties.GanonKeyCount = count,
                    color => properties.GanonKeyColor = color,
                    image => properties.GanonKeyImage = image,
                    AppConstants.MaxGanonKeysVanilla,
                    AppConstants.MaxGanonKeysMq,
                    OoTConstants.SmallKeyEnabled,
                    AppConstants.HasKeyColor,
                    AppConstants.AllKeyColor);
                break;
        }
    }

    public static void ToggleBossKey(TrackerProperties properties, string dungeonId)
    {
        if (Mappings.GetDungeonBossKeyMappings().TryGetValue(dungeonId, out var mapping))
        {
            DungeonUtils.ToggleBossKey(
                dungeonId, properties,
                mapping.Get, mapping.Set,
                SpriteUtils.GetState, Logger.LogInformation);
        }
    }
}