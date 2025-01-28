using CommunityToolkit.Mvvm.ComponentModel;
using EnKdev.ItemTrackers.Core.Services;
using EnKdev.ItemTrackers.OoT.Internal;
using EnKdev.ItemTrackers.OoT.Models;

namespace EnKdev.ItemTrackers.OoT;

public partial class MainWindowViewModel : ObservableRecipient
{
    // Variables
    private readonly ArrowService _arrowService = new();
    private readonly BottleService _bottleService = new();
    private readonly DungeonService _dungeonService = new();
    private readonly ItemService _itemService = new();

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

    private int _maxHeartContainers = 8;
    private int _maxHeartPieces = 36;
    
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
    }
}