using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnKdev.ItemTrackers.Core;
using EnKdev.ItemTrackers.Core.Logging;
using EnKdev.ItemTrackers.Core.Services;
using EnKdev.ItemTrackers.OoT.Commands;
using EnKdev.ItemTrackers.OoT.Internal;
using EnKdev.ItemTrackers.OoT.Models;

namespace EnKdev.ItemTrackers.OoT;

public partial class MainWindowViewModel : ObservableRecipient
{
    [ObservableProperty]
    private TrackerProperties _trackerProperties = new();
    
    private int _ocarinaState;
    private int _scaleState;
    private int _strengthState;
    private int _bombState;
    private int _quiverState;
    private int _bulletState;

    private int _location1Idx;
    private int _location2Idx;
    private int _location3Idx;
    private int _location4Idx;
    private int _location5Idx;
    private int _location6Idx;
    private int _location7Idx;
    private int _location8Idx;
    private int _location9Idx;

    private int _dungeon1Idx;
    private int _dungeon2Idx;
    private int _dungeon3Idx;
    private int _dungeon4Idx;
    private int _dungeon5Idx;
    private int _dungeon6Idx;
    private int _dungeon7Idx;
    private int _dungeon8Idx;
    private int _dungeon9Idx;
    private int _dungeon10Idx;
    private int _dungeon11Idx;
    private int _dungeon12Idx;

    private int _hookState;

    private int _hpProg;

    private int _gsTokens;

    private int _maxHeartContainers = 8;
    private int _maxHeartPieces = 36;
    private int _maxGsTokens = 100;
    
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

    private bool _isDekuMq;
    private bool _isDcMq;
    private bool _isJabuMq;
    private bool _isForestMq;
    private bool _isFireMq;
    private bool _isWaterMq;
    private bool _isShadowMq;
    private bool _isSpiritMq;
    private bool _isBottomMq;
    private bool _isCavernMq;
    private bool _isGanonMq;
    private bool _isGtgMq;
    
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
        _ocarinaState = 0;
        _bulletState = 0;
        _bombState = 0;
        _quiverState = 0;
        _scaleState = 0;
        _strengthState = 0;
        
        _location1Idx = 0;
        _location2Idx = 0;
        _location3Idx = 0;
        _location4Idx = 0;
        _location5Idx = 0;
        _location6Idx = 0;
        _location7Idx = 0;
        _location8Idx = 0;
        _location9Idx = 0;
        
        _dungeon1Idx = 0;
        _dungeon2Idx = 0;
        _dungeon3Idx = 0;
        _dungeon4Idx = 0;
        _dungeon5Idx = 0;
        _dungeon6Idx = 0;
        _dungeon7Idx = 0;
        _dungeon8Idx = 0;
        _dungeon9Idx = 0;
        _dungeon10Idx = 0;
        _dungeon11Idx = 0;
        _dungeon12Idx = 0;
        
        _hookState = 0;
        _hpProg = 0;
        
        _isDekuMq = false;
        _isDcMq = false;
        _isJabuMq = false;
        _isForestMq = false;
        _isFireMq = false;
        _isWaterMq = false;
        _isShadowMq = false;
        _isSpiritMq = false;
        _isBottomMq = false;
        _isCavernMq = false;
    }
    
    // Commands
    [RelayCommand]
    private void ToggleShard()
    {
        Logger.LogCommand(nameof(ToggleShardCommand));
        CommandHandler.ToggleShard(TrackerProperties);
    }

    [RelayCommand]
    private void ToggleGerudoToken()
    {
        Logger.LogCommand(nameof(ToggleGerudoTokenCommand));
        CommandHandler.ToggleGerudoToken(TrackerProperties);
    }

    [RelayCommand]
    private void IncreaseGsCount()
    {
        Logger.LogCommand(nameof(IncreaseGsCountCommand));
        CommandHandler.IncreaseGoldSkulltulaCount(TrackerProperties, _maxGsTokens);
    }

    [RelayCommand]
    private void DecreaseGsCount()
    {
        Logger.LogCommand(nameof(DecreaseGsCountCommand));
        CommandHandler.DecreaseGoldSkulltulaCount(TrackerProperties);
    }

    [RelayCommand]
    private void IncreaseHeartContainerCount()
    {
        Logger.LogCommand(nameof(IncreaseHeartContainerCountCommand));
        CommandHandler.IncreaseHeartContainerCount(TrackerProperties, _maxHeartContainers);
    }

    [RelayCommand]
    private void ProgressHeartPiece()
    {
        Logger.LogCommand(nameof(ProgressHeartPieceCommand));
        CommandHandler.ProgressHeartPiece(TrackerProperties, _maxHeartPieces);
        ProcessHeartPieceProgression(TrackerProperties);
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