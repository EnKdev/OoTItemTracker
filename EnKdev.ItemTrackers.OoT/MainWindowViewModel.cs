using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnKdev.ItemTrackers.Core;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.OoT.Commands;
using EnKdev.ItemTrackers.OoT.Internal;
using EnKdev.ItemTrackers.OoT.Models;

namespace EnKdev.ItemTrackers.OoT;

public partial class MainWindowViewModel : ObservableRecipient
{
    [ObservableProperty]
    private TrackerProperties _trackerProperties = new();

    private const int MaxHeartContainers = 8;
    private const int MaxHeartPieces = 36;
    private const int MaxGsTokens = 100;

    private TrackerData? _trackerData;
    
    // Observable properties
    [ObservableProperty]
    private string _title;

    public MainWindowViewModel()
    {
        _title = AppConstants.AppTitle;

        Resolver.ResolveDefaultLocations(TrackerProperties);
        Resolver.ResolveDefaultDungeonTypes(TrackerProperties);
        Resolver.ResolveDefaultKeyColors(TrackerProperties);
        Resolver.ResolveBackgrounds(TrackerProperties);
        Resolver.ResolveDefaultIcons(TrackerProperties);
        Resolver.ResolveKeyIcons(TrackerProperties);
        Resolver.ResolveDungeonIcons(TrackerProperties);
        Resolver.ResolveSongIcons(TrackerProperties);
        Resolver.ResolveEquipIcons(TrackerProperties);
        Resolver.ResolveGearIcons(TrackerProperties);
        Resolver.ResolveItemIcons(TrackerProperties);

        InitVariables();
    }

    private void InitVariables()
    {
        TrackerProperties.OcarinaState = -1;
        TrackerProperties.ScaleState = -1;
        TrackerProperties.StrengthState = -1;
        TrackerProperties.QuiverState = -1;
        TrackerProperties.BulletState = -1;
        TrackerProperties.BombState = -1;
        TrackerProperties.HookState = -1;

        TrackerProperties.ChildTradeState = -1;
        TrackerProperties.AdultTradeState = -1;

        TrackerProperties.Location1Idx = 0;
        TrackerProperties.Location2Idx = 0;
        TrackerProperties.Location3Idx = 0;
        TrackerProperties.Location4Idx = 0;
        TrackerProperties.Location5Idx = 0;
        TrackerProperties.Location6Idx = 0;
        TrackerProperties.Location7Idx = 0;
        TrackerProperties.Location8Idx = 0;
        TrackerProperties.Location9Idx = 0;
        
        TrackerProperties.Dungeon1Idx = 0;
        TrackerProperties.Dungeon2Idx = 0;
        TrackerProperties.Dungeon3Idx = 0;
        TrackerProperties.Dungeon4Idx = 0;
        TrackerProperties.Dungeon5Idx = 0;
        TrackerProperties.Dungeon6Idx = 0;
        TrackerProperties.Dungeon7Idx = 0;
        TrackerProperties.Dungeon8Idx = 0;
        TrackerProperties.Dungeon9Idx = 0;
        TrackerProperties.Dungeon10Idx = 0;
        TrackerProperties.Dungeon11Idx = 0;
        TrackerProperties.Dungeon12Idx = 0;

        TrackerProperties.HpProg = 0;
        
        TrackerProperties.IsDekuMq = false;
        TrackerProperties.IsDcMq = false;
        TrackerProperties.IsJabuMq = false;
        TrackerProperties.IsForestMq = false;
        TrackerProperties.IsFireMq = false;
        TrackerProperties.IsWaterMq = false;
        TrackerProperties.IsShadowMq = false;
        TrackerProperties.IsSpiritMq = false;
        TrackerProperties.IsBottomMq = false;
        TrackerProperties.IsCavernMq = false;
    }
    
    // ==================
    // = OTHER COMMANDS =
    // ==================
    
    [RelayCommand]
    private void ToggleOther(string otherId)
    {
        Logger.LogCommand(nameof(ToggleOtherCommand));
        CommandHandler.ToggleOther(otherId, TrackerProperties);
    }

    [RelayCommand]
    private void HandleGsCount(string action)
    {
        Logger.LogCommand(nameof(HandleGsCountCommand));

        switch (action)
        {
            case "inc":
                CommandHandler.IncreaseGoldSkulltulaCount(TrackerProperties, MaxGsTokens);
                break;
            case "dec":
                CommandHandler.DecreaseGoldSkulltulaCount(TrackerProperties);
                break;
        }
    }

    [RelayCommand]
    private void HandleHearts(string action)
    {
        Logger.LogCommand(nameof(HandleHeartsCommand));

        switch (action)
        {
            case "hc":
                CommandHandler.IncreaseHeartContainerCount(TrackerProperties, MaxHeartContainers);
                break;
            case "hp":
                CommandHandler.ProgressHeartPiece(TrackerProperties, MaxHeartPieces);
                ProcessHeartPieceProgression(TrackerProperties);
                break;
        }
    }
    
    // ==============================
    // = QUEST PROGRESSION COMMANDS =
    // ==============================
    
    [RelayCommand]
    private void ToggleQuest(string progressionId)
    {
        Logger.LogCommand(nameof(ToggleQuestCommand));
        CommandHandler.ToggleQuest(progressionId, TrackerProperties);
    }

    [RelayCommand]
    private void SetLocation(string progressionId)
    {
        Logger.LogCommand(nameof(SetLocationCommand));
        CommandHandler.UpdateLocation(progressionId, TrackerProperties);
    }
    
    // =================
    // = SONG COMMANDS =
    // =================

    [RelayCommand]
    private void ToggleSong(string songId)
    {
        Logger.LogCommand(nameof(ToggleSongCommand));
        CommandHandler.ToggleSong(songId, TrackerProperties);
    }
    
    // ==================
    // = EQUIP COMMANDS =
    // ==================

    [RelayCommand]
    private void ToggleEquip(string equipId)
    {
        Logger.LogCommand(nameof(ToggleEquipCommand));
        CommandHandler.ToggleEquip(equipId, TrackerProperties);
    }
    
    // ====================
    // = UPGRADE COMMANDS =
    // ====================
    
    [RelayCommand]
    private void ChangeStrength(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);
        
        Logger.LogCommand(nameof(ChangeStrengthCommand));
        CommandHandler.ChangeStrength(TrackerProperties, isUpgradeBool);
    }

    [RelayCommand]
    private void ChangeScale(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);

        Logger.LogCommand(nameof(ChangeScaleCommand));
        CommandHandler.ChangeScale(TrackerProperties, isUpgradeBool);
    }
    
    // =================
    // = ITEM COMMANDS =
    // =================
    
    [RelayCommand]
    private void ToggleItem(string itemId)
    {
        Logger.LogCommand(nameof(ToggleItemCommand));
        CommandHandler.ToggleItem(itemId, TrackerProperties);
    }

    [RelayCommand]
    private void ChangeOcarina(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);

        Logger.LogCommand(nameof(ChangeOcarinaCommand));
        CommandHandler.ChangeOcarina(TrackerProperties, isUpgradeBool);
    }

    [RelayCommand]
    private void ChangeHookshot(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);
        
        Logger.LogCommand(nameof(ChangeHookshotCommand));
        CommandHandler.ChangeHookshot(TrackerProperties, isUpgradeBool);
    }
    
    // ==================
    // = ARROW COMMANDS =
    // ==================
    
    [RelayCommand]
    private void ToggleArrow(string arrowId)
    {
        Logger.LogCommand(nameof(ToggleArrowCommand));
        CommandHandler.ToggleArrow(arrowId, TrackerProperties);
    }
    
    // ===================
    // = BOTTLE COMMANDS =
    // ===================
    
    [RelayCommand]
    private void ToggleBottle(string bottleId)
    {
        Logger.LogCommand(nameof(ToggleBottleCommand));
        CommandHandler.ToggleBottle(bottleId, TrackerProperties);
    }
    
    // =================
    // = GEAR COMMANDS =
    // =================

    [RelayCommand]
    private void ChangeQuiver(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);
        
        Logger.LogCommand(nameof(ChangeQuiverCommand));
        CommandHandler.ChangeQuiver(TrackerProperties, isUpgradeBool);
    }

    [RelayCommand]
    private void ChangeBombBag(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);
        
        Logger.LogCommand(nameof(ChangeBombBagCommand));
        CommandHandler.ChangeBombBag(TrackerProperties, isUpgradeBool);
    }

    [RelayCommand]
    private void ChangeBulletBag(string isUpgrade)
    {
        var isUpgradeBool = bool.Parse(isUpgrade);
        
        Logger.LogCommand(nameof(ChangeBulletBagCommand));
        CommandHandler.ChangeBulletBag(TrackerProperties, isUpgradeBool);
    }
    
    // ==================
    // = TRADE COMMANDS =
    // ==================

    [RelayCommand]
    private void ChangeChildTrade(string isAdvancing)
    {
        var isAdvancingBool = bool.Parse(isAdvancing);
        
        Logger.LogCommand(nameof(ChangeChildTradeCommand));
        CommandHandler.ChangeChildTrade(TrackerProperties, isAdvancingBool);
    }
    
    [RelayCommand]
    private void ChangeAdultTrade(string isAdvancing)
    {
        var isAdvancingBool = bool.Parse(isAdvancing);
        
        Logger.LogCommand(nameof(ChangeChildTradeCommand));
        CommandHandler.ChangeAdultTrade(TrackerProperties, isAdvancingBool);
    }
    
    // ====================
    // = DUNGEON COMMANDS =
    // ====================

    [RelayCommand]
    private void ToggleMap(string dungeonId)
    {
        Logger.LogCommand(nameof(ToggleMapCommand));
        CommandHandler.ToggleMap(TrackerProperties, dungeonId);
    }

    [RelayCommand]
    private void ToggleCompass(string dungeonId)
    {
        Logger.LogCommand(nameof(ToggleCompassCommand));
        CommandHandler.ToggleCompass(TrackerProperties, dungeonId);
    }

    [RelayCommand]
    private void ToggleDungeonState(string dungeonId)
    {
        Logger.LogCommand(nameof(ToggleDungeonStateCommand));
        CommandHandler.UpdateDungeonState(TrackerProperties, dungeonId);
    }

    [RelayCommand]
    private void HandleKeys(string dungeonId)
    {
        Logger.LogCommand(nameof(HandleKeysCommand));
        CommandHandler.HandleKeys(TrackerProperties, dungeonId);
    }

    [RelayCommand]
    private void ToggleBossKey(string dungeonId)
    {
        Logger.LogCommand(nameof(ToggleBossKeyCommand));
        CommandHandler.ToggleBossKey(TrackerProperties, dungeonId);
    }
    
    // Util methods
    private static void ProcessHeartPieceProgression(TrackerProperties properties)
    {
        if (properties.HeartPieceCount == 0)
        {
            properties.HeartPieceProgression = OoTConstants.HeartPieceProgression[0];
        }
        else
            properties.HeartPieceProgression = (properties.HeartPieceCount % 4) switch
            {
                1 => OoTConstants.HeartPieceProgression[1],
                2 => OoTConstants.HeartPieceProgression[2],
                3 => OoTConstants.HeartPieceProgression[3],
                0 => OoTConstants.HeartPieceProgression[4],
                _ => properties.HeartPieceProgression
            };
        
        Logger.LogInteraction(nameof(properties.HeartPieceProgression));
    }
}