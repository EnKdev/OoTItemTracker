using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;

namespace EnKdev.ItemTrackers.OoT.Internal;

public partial class TrackerProperties : ObservableRecipient
{
    [ObservableProperty]
    private string? _location1;

    [ObservableProperty]
    private string? _location2;

    [ObservableProperty]
    private string? _location3;

    [ObservableProperty]
    private string? _location4;

    [ObservableProperty]
    private string? _location5;

    [ObservableProperty]
    private string? _location6;

    [ObservableProperty]
    private string? _location7;

    [ObservableProperty]
    private string? _location8;
    
    [ObservableProperty]
    private string? _location9;

    [ObservableProperty]
    private int _location1Idx;

    [ObservableProperty]
    private int _location2Idx;
    
    [ObservableProperty]
    private int _location3Idx;

    [ObservableProperty]
    private int _location4Idx;
    
    [ObservableProperty]
    private int _location5Idx;

    [ObservableProperty]
    private int _location6Idx;
    
    [ObservableProperty]
    private int _location7Idx;

    [ObservableProperty]
    private int _location8Idx;
    
    [ObservableProperty]
    private int _location9Idx;
    
    [ObservableProperty]
    private string? _dungeonType1;

    [ObservableProperty]
    private string? _dungeonType2;

    [ObservableProperty]
    private string? _dungeonType3;

    [ObservableProperty]
    private string? _dungeonType4;

    [ObservableProperty]
    private string? _dungeonType5;

    [ObservableProperty]
    private string? _dungeonType6;

    [ObservableProperty]
    private string? _dungeonType7;

    [ObservableProperty]
    private string? _dungeonType8;

    [ObservableProperty]
    private string? _dungeonType9;

    [ObservableProperty]
    private string? _dungeonType10;

    [ObservableProperty]
    private string? _dungeonType11;

    [ObservableProperty]
    private string? _dungeonType12;
    
    [ObservableProperty]
    private int _dungeon1Idx;
    
    [ObservableProperty]
    private int _dungeon2Idx;
    
    [ObservableProperty]
    private int _dungeon3Idx;
    
    [ObservableProperty]
    private int _dungeon4Idx;
    
    [ObservableProperty]
    private int _dungeon5Idx;
    
    [ObservableProperty]
    private int _dungeon6Idx;
    
    [ObservableProperty]
    private int _dungeon7Idx;
    
    [ObservableProperty]
    private int _dungeon8Idx;
    
    [ObservableProperty]
    private int _dungeon9Idx;
    
    [ObservableProperty]
    private int _dungeon10Idx;
    
    [ObservableProperty]
    private int _dungeon11Idx;
    
    [ObservableProperty]
    private int _dungeon12Idx;
    
    [ObservableProperty]
    private int _gsTokens;

    [ObservableProperty]
    private int _forestKeyCount;

    [ObservableProperty]
    private int _fireKeyCount;

    [ObservableProperty]
    private int _waterKeyCount;

    [ObservableProperty]
    private int _shadowKeyCount;

    [ObservableProperty]
    private int _spiritKeyCount;

    [ObservableProperty]
    private int _bottomKeyCount;

    [ObservableProperty]
    private int _ganonKeyCount;

    [ObservableProperty]
    private int _gtgKeyCount;

    [ObservableProperty]
    private int _heartContainerCount;

    [ObservableProperty]
    private int _heartPieceCount;
    
    [ObservableProperty]
    private int _ocarinaState;
    
    [ObservableProperty]
    private int _scaleState;
    
    [ObservableProperty]
    private int _strengthState;

    [ObservableProperty]
    private int _quiverState;

    [ObservableProperty]
    private int _bombState;

    [ObservableProperty]
    private int _bulletState;

    [ObservableProperty]
    private int _hookState;

    [ObservableProperty]
    private int _hpProg;

    [ObservableProperty]
    private bool _isDekuMq;
    
    [ObservableProperty]
    private bool _isDcMq;
    
    [ObservableProperty]
    private bool _isJabuMq;
    
    [ObservableProperty]
    private bool _isForestMq;
    
    [ObservableProperty]
    private bool _isFireMq;
    
    [ObservableProperty]
    private bool _isWaterMq;
    
    [ObservableProperty]
    private bool _isShadowMq;
    
    [ObservableProperty]
    private bool _isSpiritMq;
    
    [ObservableProperty]
    private bool _isBottomMq;
    
    [ObservableProperty]
    private bool _isCavernMq;
    
    [ObservableProperty]
    private bool _isGanonMq;

    [ObservableProperty]
    private bool _isGtgMq;

    [ObservableProperty]
    private string _heartPieceProgression;
    
    [ObservableProperty] 
    private SolidColorBrush _forestKeyColor;

    [ObservableProperty] 
    private SolidColorBrush _fireKeyColor;

    [ObservableProperty] 
    private SolidColorBrush _waterKeyColor;

    [ObservableProperty] 
    private SolidColorBrush _shadowKeyColor;

    [ObservableProperty]
    private SolidColorBrush _spiritKeyColor;

    [ObservableProperty]
    private SolidColorBrush _bottomKeyColor;

    [ObservableProperty]
    private SolidColorBrush _ganonKeyColor;

    [ObservableProperty]
    private SolidColorBrush _gtgKeyColor;
    
    [ObservableProperty]
    private string _kokiriEmeraldImage;

    [ObservableProperty]
    private string _goronRubyImage;

    [ObservableProperty]
    private string _zoraSapphireImage;

    [ObservableProperty] 
    private string _lightMedallionImage;

    [ObservableProperty]
    private string _forestMedallionImage;

    [ObservableProperty]
    private string _fireMedallionImage;

    [ObservableProperty]
    private string _waterMedallionImage;

    [ObservableProperty]
    private string _shadowMedallionImage;

    [ObservableProperty]
    private string _spiritMedallionImage;
    
    [ObservableProperty]
    private string _kokiriSwordImage;

    [ObservableProperty]
    private string _masterSwordImage;

    [ObservableProperty]
    private string _biggoronSwordImage;

    [ObservableProperty]
    private string _dekuShieldImage;

    [ObservableProperty]
    private string _hylianShieldImage;

    [ObservableProperty]
    private string _mirrorShieldImage;

    [ObservableProperty]
    private string _kokiriTunicImage;

    [ObservableProperty]
    private string _goronTunicImage;

    [ObservableProperty]
    private string _zoraTunicImage;

    [ObservableProperty]
    private string _kokiriBootsImage;

    [ObservableProperty]
    private string _ironBootsImage;

    [ObservableProperty]
    private string _hoverBootsImage;
    
    [ObservableProperty]
    private string _ocarinaImage;

    [ObservableProperty]
    private string _scaleImage;

    [ObservableProperty]
    private string _strengthImage;

    [ObservableProperty]
    private string _bombImage;

    [ObservableProperty]
    private string _quiverImage;

    [ObservableProperty]
    private string _bulletImage;
    
    [ObservableProperty]
    private string _gsImage;

    [ObservableProperty] 
    private string _gerudoTokenImage;

    [ObservableProperty] 
    private string _shardImage;

    [ObservableProperty]
    private string _heartPiece;

    [ObservableProperty]
    private string _heartContainer;

    [ObservableProperty]
    private string _hpIcon;
    
    [ObservableProperty]
    private string _lullabyImage;

    [ObservableProperty]
    private string _eponaImage;

    [ObservableProperty]
    private string _sariaImage;

    [ObservableProperty]
    private string _sosImage;

    [ObservableProperty]
    private string _sunsImage;

    [ObservableProperty]
    private string _sotImage;

    [ObservableProperty]
    private string _minuetImage;

    [ObservableProperty]
    private string _boleroImage;

    [ObservableProperty]
    private string _serenadeImage;

    [ObservableProperty]
    private string _requiemImage;

    [ObservableProperty]
    private string _nocturneImage;

    [ObservableProperty]
    private string _preludeImage;
    
    [ObservableProperty]
    private string _bottle1Image;

    [ObservableProperty]
    private string _bottle2Image;

    [ObservableProperty]
    private string _bottle3Image;

    [ObservableProperty]
    private string _bottle4Image;

    [ObservableProperty]
    private string _weirdEggIcon;

    [ObservableProperty]
    private string _cuccoIcon;

    [ObservableProperty]
    private string _letterIcon;

    [ObservableProperty]
    private string _skullMaskIcon;

    [ObservableProperty]
    private string _maskOfTruthIcon;
    
    [ObservableProperty]
    private string _pocketEggImage;

    [ObservableProperty]
    private string _pocketCuccoImage;

    [ObservableProperty]
    private string _cojiroImage;

    [ObservableProperty]
    private string _oddMushroomImage;

    [ObservableProperty]
    private string _oddPoulticeImage;

    [ObservableProperty]
    private string _poachersSawImage;

    [ObservableProperty]
    private string _giantsKnifeImage;

    [ObservableProperty]
    private string _brokenGoronsSwordImage;

    [ObservableProperty]
    private string _prescriptionImage;

    [ObservableProperty]
    private string _eyeballFrogImage;

    [ObservableProperty]
    private string _eyeDropsImage;

    [ObservableProperty]
    private string _claimCheckImage;
    
    [ObservableProperty] 
    private string _stickImage;

    [ObservableProperty] 
    private string _nutImage;

    [ObservableProperty]
    private string _slingshotImage;

    [ObservableProperty]
    private string _dinsFireImage;

    [ObservableProperty]
    private string _bombItemImage;

    [ObservableProperty]
    private string _bombchuImage;

    [ObservableProperty]
    private string _childTradeItemImage;

    [ObservableProperty]
    private string _faroresWindImage;

    [ObservableProperty]
    private string _boomerangImage;

    [ObservableProperty]
    private string _hookshotImage;

    [ObservableProperty]
    private string _adultTradeItemImage;

    [ObservableProperty]
    private string _nayrusLoveImage;

    [ObservableProperty]
    private string _lensImage;

    [ObservableProperty]
    private string _megatonHammerImage;

    [ObservableProperty]
    private string _bowImage;

    [ObservableProperty]
    private string _magicBeansImage;

    [ObservableProperty]
    private string _fireArrowImage;

    [ObservableProperty]
    private string _iceArrowImage;

    [ObservableProperty]
    private string _lightArrowImage;
    
    [ObservableProperty]
    private string _dekuMapImage;

    [ObservableProperty]
    private string _dekuCompassImage;

    [ObservableProperty]
    private string _dcMapImage;

    [ObservableProperty]
    private string _dcCompassImage;

    [ObservableProperty]
    private string _jabuMapImage;

    [ObservableProperty]
    private string _jabuCompassImage;

    [ObservableProperty]
    private string _forestMapImage;

    [ObservableProperty]
    private string _forestCompassImage;

    [ObservableProperty]
    private string _forestKeyImage;

    [ObservableProperty]
    private string _forestBkImage;

    [ObservableProperty]
    private string _fireMapImage;

    [ObservableProperty]
    private string _fireCompassImage;

    [ObservableProperty]
    private string _fireKeyImage;

    [ObservableProperty]
    private string _fireBkImage;

    [ObservableProperty]
    private string _waterMapImage;

    [ObservableProperty]
    private string _waterCompassImage;

    [ObservableProperty]
    private string _waterKeyImage;

    [ObservableProperty]
    private string _waterBkImage;

    [ObservableProperty]
    private string _shadowMapImage;

    [ObservableProperty]
    private string _shadowCompassImage;

    [ObservableProperty]
    private string _shadowKeyImage;

    [ObservableProperty]
    private string _shadowBkImage;

    [ObservableProperty]
    private string _spiritMapImage;

    [ObservableProperty]
    private string _spiritCompassImage;

    [ObservableProperty]
    private string _spiritKeyImage;

    [ObservableProperty]
    private string _spiritBkImage;

    [ObservableProperty]
    private string _cavernMapImage;

    [ObservableProperty]
    private string _cavernCompassImage;

    [ObservableProperty]
    private string _bottomMapImage;

    [ObservableProperty]
    private string _bottomCompassImage;

    [ObservableProperty]
    private string _bottomKeyImage;

    [ObservableProperty] 
    private string _ganonCompassImage;

    [ObservableProperty]
    private string _ganonKeyImage;

    [ObservableProperty]
    private string _ganonBkImage;
    
    [ObservableProperty]
    private string _gtgKeyImage;
    
    [ObservableProperty]
    private string _itemBackground;

    [ObservableProperty] 
    private string _gearBackground;

    [ObservableProperty]
    private string _dungeonBackground;

    [ObservableProperty]
    private string _questBackground;
}