﻿using CommunityToolkit.Mvvm.ComponentModel;
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

    private const int MaxForestKeysVanilla = 5;
    private const int MaxForestKeysMq = 6;

    private const int MaxFireKeysVanilla = 8;
    private const int MaxFireKeysMq = 5;

    private const int MaxWaterKeysVanilla = 6;
    private const int MaxWaterKeysMq = 2;

    private const int MaxShadowKeysVanilla = 5;
    private const int MaxShadowKeysMq = 6;

    private const int MaxSpiritKeysVanilla = 5;
    private const int MaxSpiritKeysMq = 7;

    private const int MaxBottomKeysVanilla = 3;
    private const int MaxBottomKeysMq = 2;

    private const int MaxGanonKeysVanilla = 2;
    private const int MaxGanonKeysMq = 3;

    private const int MaxGtgKeysVanilla = 9;
    private const int MaxGtgKeysMq = 3;
    
    // Observable properties
    [ObservableProperty]
    private string _title;

    public MainWindowViewModel()
    {
        _title = Constants.AppTitle;

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
        TrackerProperties.OcarinaState = 0;
        TrackerProperties.ScaleState = 0;
        TrackerProperties.StrengthState = 0;
        TrackerProperties.QuiverState = 0;
        TrackerProperties.BulletState = 0;
        TrackerProperties.BombState = 0;
        TrackerProperties.HookState = 0;

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
    private void UpgradeGear(string upgradeId)
    {
        Logger.LogInformation("Not implemented yet.");
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