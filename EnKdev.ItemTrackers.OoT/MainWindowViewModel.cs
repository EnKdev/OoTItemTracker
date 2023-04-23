﻿using System.IO;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnKdev.ItemTrackers.OoT.Data;
using EnKdev.ItemTrackers.OoT.Models;

namespace EnKdev.ItemTrackers.OoT;

public partial class MainWindowViewModel : ObservableRecipient
{
    [ObservableProperty]
    private string _title;

    // Reward Locations
    [ObservableProperty]
    private string _location1;

    [ObservableProperty]
    private string _location2;

    [ObservableProperty]
    private string _location3;

    [ObservableProperty]
    private string _location4;

    [ObservableProperty]
    private string _location5;

    [ObservableProperty]
    private string _location6;

    [ObservableProperty]
    private string _location7;

    [ObservableProperty]
    private string _location8;

    [ObservableProperty]
    private string _location9;

    // Quest Items (Dungeon Rewards)
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

    // Equips (Boots, Shields, Swords, Tunics)
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

    // Upgrades
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
    
    // Other
    [ObservableProperty]
    private string _gsImage;

    [ObservableProperty] 
    private int _gsTokens;

    [ObservableProperty] 
    private string _gerudoTokenImage;

    [ObservableProperty] 
    private string _shardImage;

    // Songs
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

    // General items
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
    private string _bottle1Image;

    [ObservableProperty]
    private string _bottle2Image;

    [ObservableProperty]
    private string _bottle3Image;

    [ObservableProperty]
    private string _bottle4Image;

    [ObservableProperty]
    private string _fireArrowImage;

    [ObservableProperty]
    private string _iceArrowImage;

    [ObservableProperty]
    private string _lightArrowImage;
    
    // Backgrounds
    [ObservableProperty]
    private string _itemSongBackground;

    [ObservableProperty] 
    private string _gearBackground;

    // Data
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

    private int _childTradeStage;
    private int _adultTradeStage;

    private int _hookState;

    private TrackerData _trackerData;

    public MainWindowViewModel()
    {
        Title = Constants.AppTitle;

        Location1 = Constants.DungeonLocations[0];
        Location2 = Constants.DungeonLocations[0];
        Location3 = Constants.DungeonLocations[0];
        Location4 = Constants.DungeonLocations[0];
        Location5 = Constants.DungeonLocations[0];
        Location6 = Constants.DungeonLocations[0];
        Location7 = Constants.DungeonLocations[0];
        Location8 = Constants.DungeonLocations[0];
        Location9 = Constants.DungeonLocations[0];

        ItemSongBackground = Constants.ItemSongBg;
        GearBackground = Constants.GearBg;

        KokiriEmeraldImage = Constants.DisabledStones[0];
        GoronRubyImage = Constants.DisabledStones[1];
        ZoraSapphireImage = Constants.DisabledStones[2];

        LightMedallionImage = Constants.DisabledMeds[0];
        ForestMedallionImage = Constants.DisabledMeds[1];
        FireMedallionImage = Constants.DisabledMeds[2];
        WaterMedallionImage = Constants.DisabledMeds[3];
        ShadowMedallionImage = Constants.DisabledMeds[4];
        SpiritMedallionImage = Constants.DisabledMeds[5];

        KokiriSwordImage = Constants.DisabledEquip[0];
        MasterSwordImage = Constants.DisabledEquip[1];
        BiggoronSwordImage = Constants.DisabledEquip[2];
        DekuShieldImage = Constants.DisabledEquip[3];
        HylianShieldImage = Constants.DisabledEquip[4];
        MirrorShieldImage = Constants.DisabledEquip[5];
        KokiriTunicImage = Constants.KokiriTunicSprite;
        GoronTunicImage = Constants.DisabledEquip[6];
        ZoraTunicImage = Constants.DisabledEquip[7];
        KokiriBootsImage = Constants.KokiriBootsSprite;
        IronBootsImage = Constants.DisabledEquip[8];
        HoverBootsImage = Constants.DisabledEquip[9];

        OcarinaImage = Constants.DisabledUpgrade[3];
        ScaleImage = Constants.DisabledUpgrade[6];
        StrengthImage = Constants.DisabledUpgrade[4];
        QuiverImage = Constants.DisabledUpgrade[5];
        BombImage = Constants.DisabledUpgrade[1];
        BulletImage = Constants.DisabledUpgrade[2];

        GsImage = Constants.GsIcon;

        GerudoTokenImage = Constants.DisabledOther[0];
        ShardImage = Constants.DisabledOther[1];

        LullabyImage = Constants.DisabledSongs[0];
        EponaImage = Constants.DisabledSongs[1];
        SariaImage = Constants.DisabledSongs[2];
        SosImage = Constants.DisabledSongs[3];
        SunsImage = Constants.DisabledSongs[4];
        SotImage = Constants.DisabledSongs[5];
        MinuetImage = Constants.DisabledSongs[6];
        BoleroImage = Constants.DisabledSongs[7];
        SerenadeImage = Constants.DisabledSongs[8];
        RequiemImage = Constants.DisabledSongs[9];
        NocturneImage = Constants.DisabledSongs[10];
        PreludeImage = Constants.DisabledSongs[11];

        BombItemImage = Constants.DisabledItems[0];
        BombchuImage = Constants.DisabledItems[1];
        BoomerangImage = Constants.DisabledItems[2];
        Bottle1Image = Constants.DisabledItems[3];
        Bottle2Image = Constants.DisabledItems[3];
        Bottle3Image = Constants.DisabledItems[3];
        Bottle4Image = Constants.DisabledItems[3];
        NutImage = Constants.DisabledItems[4];
        StickImage = Constants.DisabledItems[5];
        DinsFireImage = Constants.DisabledItems[6];
        BowImage = Constants.DisabledItems[7];
        SlingshotImage = Constants.DisabledItems[8];
        FaroresWindImage = Constants.DisabledItems[9];
        FireArrowImage = Constants.DisabledItems[10];
        HookshotImage = Constants.DisabledItems[11];
        IceArrowImage = Constants.DisabledItems[12];
        LensImage = Constants.DisabledItems[13];
        LightArrowImage = Constants.DisabledItems[14];
        MegatonHammerImage = Constants.DisabledItems[15];
        NayrusLoveImage = Constants.DisabledItems[16];
        MagicBeansImage = Constants.DisabledItems[17];

        ChildTradeItemImage = Constants.ChildTradingSequence[0];
        AdultTradeItemImage = Constants.AdultTradingSequence[0];
    }

    #region Quest Items (Dungeon Rewards)

    [RelayCommand]
    public void ToggleEmerald()
    {
        KokiriEmeraldImage = GetState(KokiriEmeraldImage) ? 
            Constants.DisabledStones[0] : 
            Constants.EnabledStones[0];
    }

    [RelayCommand]
    public void SetEmeraldLocation()
    {
        if (_location1Idx >= 9)
        {
            // Reset back to 0
            _location1Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location1Idx++;
            
            Location1 = _location1Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location1
            };
        });
    }

    [RelayCommand]
    public void ToggleGoronRuby()
    {
        GoronRubyImage = GetState(GoronRubyImage)
            ? Constants.DisabledStones[1]
            : Constants.EnabledStones[1];
    }

    [RelayCommand]
    public void SetRubyLocation()
    {
        if (_location2Idx >= 9)
        {
            // Reset back to 0
            _location2Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location2Idx++;
            
            Location2 = _location2Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location2
            };
        });
    }

    [RelayCommand]
    public void ToggleZorasSapphire()
    {
        ZoraSapphireImage = GetState(ZoraSapphireImage)
            ? Constants.DisabledStones[2]
            : Constants.EnabledStones[2];
    }

    [RelayCommand]
    public void SetSapphireLocation()
    {
        if (_location3Idx >= 9)
        {
            // Reset back to 0
            _location3Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location3Idx++;
            
            Location3 = _location3Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location3
            };
        });
    }

    [RelayCommand]
    public void ToggleLightMedallion()
    {
        LightMedallionImage = GetState(LightMedallionImage)
            ? Constants.DisabledMeds[0]
            : Constants.EnabledMeds[0];
    }

    [RelayCommand]
    public void SetLightLocation()
    {
        if (_location4Idx >= 9)
        {
            // Reset back to 0
            _location4Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location4Idx++;
            
            Location4 = _location4Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location4
            };
        });
    }

    [RelayCommand]
    public void ToggleForestMedallion()
    {
        ForestMedallionImage = GetState(ForestMedallionImage)
            ? Constants.DisabledMeds[1]
            : Constants.EnabledMeds[1];
    }

    [RelayCommand]
    public void SetForestLocation()
    {
        if (_location5Idx >= 9)
        {
            // Reset back to 0
            _location5Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location5Idx++;
            
            Location5 = _location5Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location5
            };
        });
    }

    [RelayCommand]
    public void ToggleFireMedallion()
    {
        FireMedallionImage = GetState(FireMedallionImage)
            ? Constants.DisabledMeds[2]
            : Constants.EnabledMeds[2];
    }

    [RelayCommand]
    public void SetFireLocation()
    {
        if (_location6Idx >= 9)
        {
            // Reset back to 0
            _location6Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location6Idx++;
            
            Location6 = _location6Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location6
            };
        });
    }

    [RelayCommand]
    public void ToggleWaterMedallion()
    {
        WaterMedallionImage = GetState(WaterMedallionImage)
            ? Constants.DisabledMeds[3]
            : Constants.EnabledMeds[3];
    }

    [RelayCommand]
    public void SetWaterLocation()
    {
        if (_location7Idx >= 9)
        {
            // Reset back to 0
            _location7Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location7Idx++;
            
            Location7 = _location7Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location7
            };
        });
    }

    [RelayCommand]
    public void ToggleShadowMedallion()
    {
        ShadowMedallionImage = GetState(ShadowMedallionImage)
            ? Constants.DisabledMeds[4]
            : Constants.EnabledMeds[4];
    }

    [RelayCommand]
    public void SetShadowLocation()
    {
        if (_location8Idx >= 9)
        {
            // Reset back to 0
            _location8Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location8Idx++;
            
            Location8 = _location8Idx switch
            {
                0 => Constants.DungeonLocations[0], // "???"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location8
            };
        });
    }

    [RelayCommand]
    public void ToggleSpiritMedallion()
    {
        SpiritMedallionImage = GetState(SpiritMedallionImage)
            ? Constants.DisabledMeds[5]
            : Constants.EnabledMeds[5];
    }

    [RelayCommand]
    public void SetSpiritLocation()
    {
        if (_location9Idx >= 9)
        {
            // Reset back to 0
            _location9Idx = 0;
        }

        Application.Current.Dispatcher.BeginInvoke(() =>
        {
            _location9Idx++;
        
            Location9 = _location9Idx switch
            {
                0 => Constants.DungeonLocations[0], // "??"
                1 => Constants.DungeonLocations[1], // "FREE"
                2 => Constants.DungeonLocations[2], // "DEKU"
                3 => Constants.DungeonLocations[3], // "DC"
                4 => Constants.DungeonLocations[4], // "JABU"
                5 => Constants.DungeonLocations[5], // "FRST"
                6 => Constants.DungeonLocations[6], // "FIRE"
                7 => Constants.DungeonLocations[7], // "WTR"
                8 => Constants.DungeonLocations[8], // "SHDW"
                9 => Constants.DungeonLocations[9], // "SPRT"
                _ => Location9
            };
        });
    }

    #endregion
    #region Equip Items (Tunics, Swords, Shields, Boots)
    #region Swords
    [RelayCommand]
    public void ToggleKokiriSword()
    {
        KokiriSwordImage = GetState(KokiriSwordImage)
            ? Constants.DisabledEquip[0]
            : Constants.EnabledEquip[0];
    }

    [RelayCommand]
    public void ToggleMasterSword()
    {
        MasterSwordImage = GetState(MasterSwordImage)
            ? Constants.DisabledEquip[1]
            : Constants.EnabledEquip[1];
    }

    [RelayCommand]
    public void ToggleBiggoronSword()
    {
        BiggoronSwordImage = GetState(BiggoronSwordImage)
            ? Constants.DisabledEquip[2]
            : Constants.EnabledEquip[2];
    }
    #endregion
    #region Shields
    [RelayCommand]
    public void ToggleDekuShield()
    {
        DekuShieldImage = GetState(DekuShieldImage)
            ? Constants.DisabledEquip[3]
            : Constants.EnabledEquip[3];
    }

    [RelayCommand]
    public void ToggleHylianShield()
    {
        HylianShieldImage = GetState(HylianShieldImage)
            ? Constants.DisabledEquip[4]
            : Constants.EnabledEquip[4];
    }

    [RelayCommand]
    public void ToggleMirrorShield()
    {
        MirrorShieldImage = GetState(MirrorShieldImage)
            ? Constants.DisabledEquip[5]
            : Constants.EnabledEquip[5];
    }
    #endregion
    #region Tunics
    [RelayCommand]
    public void ToggleGoronTunic()
    {
        GoronTunicImage = GetState(GoronTunicImage)
            ? Constants.DisabledEquip[6]
            : Constants.EnabledEquip[6];
    }

    [RelayCommand]
    public void ToggleZoraTunic()
    {
        ZoraTunicImage = GetState(ZoraTunicImage)
            ? Constants.DisabledEquip[7]
            : Constants.EnabledEquip[7];
    }
    #endregion
    #region Boots
    [RelayCommand]
    public void ToggleIronBoots()
    {
        IronBootsImage = GetState(IronBootsImage)
            ? Constants.DisabledEquip[8]
            : Constants.EnabledEquip[8];
    }

    [RelayCommand]
    public void ToggleHoverBoots()
    {
        HoverBootsImage = GetState(HoverBootsImage)
            ? Constants.DisabledEquip[9]
            : Constants.EnabledEquip[9];
    }
    #endregion
    #endregion
    #region Upgrades
    [RelayCommand]
    public void UpgradeOcarina()
    {
        switch (_ocarinaState)
        {
            case 0:
                OcarinaImage = Constants.EnabledUpgrade[8];
                _ocarinaState = 1;
                break;
            case 1:
                OcarinaImage = Constants.EnabledUpgrade[9];
                _ocarinaState = 2;
                break;
            default:
                break;
        }
    }

    [RelayCommand]
    public void DowngradeOcarina()
    {
        switch (_ocarinaState)
        {
            case 2:
                OcarinaImage = Constants.EnabledUpgrade[8];
                _ocarinaState = 1;
                break;
            case 1:
                OcarinaImage = Constants.DisabledUpgrade[3];
                _ocarinaState = 0;
                break;
        }
    }

    [RelayCommand]
    public void UpgradeScale()
    {
        switch (_scaleState)
        {
            case 0:
                ScaleImage = Constants.EnabledUpgrade[16];
                _scaleState = 1;
                break;
            case 1:
                ScaleImage = Constants.EnabledUpgrade[17];
                _scaleState = 2;
                break;
        }
    }

    [RelayCommand]
    public void DowngradeScale()
    {
        switch (_scaleState)
        {
            case 2:
                ScaleImage = Constants.EnabledUpgrade[16];
                _scaleState = 1;
                break;
            case 1:
                ScaleImage = Constants.DisabledUpgrade[6];
                _scaleState = 0;
                break;
        }
    }

    [RelayCommand]
    public void UpgradeStrength()
    {
        switch (_strengthState)
        {
            case 0:
                StrengthImage = Constants.EnabledUpgrade[10];
                _strengthState = 1;
                break;
            case 1:
                StrengthImage = Constants.EnabledUpgrade[11];
                _strengthState = 2;
                break;
            case 2:
                StrengthImage = Constants.EnabledUpgrade[12];
                _strengthState = 3;
                break;
        }
    }

    [RelayCommand]
    public void DowngradeStrength()
    {
        switch (_strengthState)
        {
            case 3:
                StrengthImage = Constants.EnabledUpgrade[11];
                _strengthState = 2;
                break;
            case 2:
                StrengthImage = Constants.EnabledUpgrade[10];
                _strengthState = 1;
                break;
            case 1:
                StrengthImage = Constants.DisabledUpgrade[4];
                _strengthState = 0;
                break;
        }
    }

    [RelayCommand]
    public void UpgradeBomb()
    {
        switch (_bombState)
        {
            case 0:
                BombImage = Constants.EnabledUpgrade[2];
                _bombState = 1;
                break;
            case 1:
                BombImage = Constants.EnabledUpgrade[3];
                _bombState = 2;
                break;
            case 2:
                BombImage = Constants.EnabledUpgrade[4];
                _bombState = 3;
                break;
        }
    }

    [RelayCommand]
    public void DowngradeBomb()
    {
        switch (_bombState)
        {
            case 3:
                BombImage = Constants.EnabledUpgrade[3];
                _bombState = 2;
                break;
            case 2:
                BombImage = Constants.EnabledUpgrade[2];
                _bombState = 1;
                break;
            case 1:
                BombImage = Constants.DisabledUpgrade[1];
                _bombState = 0;
                break;
        }
    }

    [RelayCommand]
    public void UpgradeQuiver()
    {
        switch (_quiverState)
        {
            case 0:
                QuiverImage = Constants.EnabledUpgrade[13];
                _quiverState = 1;
                break;
            case 1:
                QuiverImage = Constants.EnabledUpgrade[14];
                _quiverState = 2;
                break;
            case 2:
                QuiverImage = Constants.EnabledUpgrade[15];
                _quiverState = 3;
                break;
        }
    }

    [RelayCommand]
    public void DowngradeQuiver()
    {
        switch (_quiverState)
        {
            case 3:
                QuiverImage = Constants.EnabledUpgrade[14];
                _quiverState = 2;
                break;
            case 2:
                QuiverImage = Constants.EnabledUpgrade[13];
                _quiverState = 1;
                break;
            case 1:
                QuiverImage = Constants.DisabledUpgrade[5];
                _quiverState = 0;
                break;
        }
    }

    [RelayCommand]
    public void UpgradeBullet()
    {
        switch (_bulletState)
        {
            case 0:
                BulletImage = Constants.EnabledUpgrade[5];
                _bulletState = 1;
                break;
            case 1:
                BulletImage = Constants.EnabledUpgrade[6];
                _bulletState = 2;
                break;
            case 2:
                BulletImage = Constants.EnabledUpgrade[7];
                _bulletState = 3;
                break;
        }
    }

    [RelayCommand]
    public void DowngradeBullet()
    {
        switch (_bulletState)
        {
            case 3:
                BulletImage = Constants.EnabledUpgrade[6];
                _bulletState = 2;
                break;
            case 2:
                BulletImage = Constants.EnabledUpgrade[5];
                _bulletState = 1;
                break;
            case 1:
                BulletImage = Constants.DisabledUpgrade[2];
                _bulletState = 0;
                break;
        }
    }
    #endregion
    #region Other
    [RelayCommand]
    public void IncreaseGsCount()
    {
        // Cap at 100
        if (GsTokens == 100)
        {
            GsTokens = 100;
        }
        else
        {
            GsTokens++;
        }
    }

    [RelayCommand]
    public void DecreaseGsCount()
    {
        // Cap at 0
        if (GsTokens == 0)
        {
            GsTokens = 0;
        }
        else
        {
            GsTokens--;
        }
    }

    [RelayCommand]
    public void ToggleGerudoToken()
    {
        GerudoTokenImage = GetState(GerudoTokenImage)
            ? Constants.DisabledOther[0]
            : Constants.EnabledOther[0];
    }

    [RelayCommand]
    public void ToggleShard()
    {
        ShardImage = GetState(ShardImage)
            ? Constants.DisabledOther[1]
            : Constants.EnabledOther[1];
    }
    #endregion
    #region Songs
    [RelayCommand]
    public void ToggleZeldasLullaby()
    {
        LullabyImage = GetState(LullabyImage)
            ? Constants.DisabledSongs[0]
            : Constants.EnabledSongs[0];
    }

    [RelayCommand]
    public void ToggleEponasSong()
    {
        EponaImage = GetState(EponaImage)
            ? Constants.DisabledSongs[1]
            : Constants.EnabledSongs[1];
    }

    [RelayCommand]
    public void ToggleSariasSong()
    {
        SariaImage = GetState(SariaImage)
            ? Constants.DisabledSongs[2]
            : Constants.EnabledSongs[2];
    }

    [RelayCommand]
    public void ToggleSongOfStorms()
    {
        SosImage = GetState(SosImage)
            ? Constants.DisabledSongs[3]
            : Constants.EnabledSongs[3];
    }

    [RelayCommand]
    public void ToggleSunsSong()
    {
        SunsImage = GetState(SunsImage)
            ? Constants.DisabledSongs[4]
            : Constants.EnabledSongs[4];
    }

    [RelayCommand]
    public void ToggleSongOfTime()
    {
        SotImage = GetState(SotImage)
            ? Constants.DisabledSongs[5]
            : Constants.EnabledSongs[5];
    }

    [RelayCommand]
    public void ToggleMinuet()
    {
        MinuetImage = GetState(MinuetImage)
            ? Constants.DisabledSongs[6]
            : Constants.EnabledSongs[6];
    }

    [RelayCommand]
    public void ToggleBolero()
    {
        BoleroImage = GetState(BoleroImage)
            ? Constants.DisabledSongs[7]
            : Constants.EnabledSongs[7];
    }

    [RelayCommand]
    public void ToggleSerenade()
    {
        SerenadeImage = GetState(SerenadeImage)
            ? Constants.DisabledSongs[8]
            : Constants.EnabledSongs[8];
    }

    [RelayCommand]
    public void ToggleRequiem()
    {
        RequiemImage = GetState(RequiemImage)
            ? Constants.DisabledSongs[9]
            : Constants.EnabledSongs[9];
    }

    [RelayCommand]
    public void ToggleNocturne()
    {
        NocturneImage = GetState(NocturneImage)
            ? Constants.DisabledSongs[10]
            : Constants.EnabledSongs[10];
    }

    [RelayCommand]
    public void TogglePrelude()
    {
        PreludeImage = GetState(PreludeImage)
            ? Constants.DisabledSongs[11]
            : Constants.EnabledSongs[11];
    }
    #endregion
    #region General Items
    [RelayCommand]
    public void ToggleStick()
    {
        StickImage = GetState(StickImage)
            ? Constants.DisabledItems[5]
            : Constants.EnabledItems[5];
    }

    [RelayCommand]
    public void ToggleNut()
    {
        NutImage = GetState(NutImage)
            ? Constants.DisabledItems[4]
            : Constants.EnabledItems[4];
    }

    [RelayCommand]
    public void ToggleSlingshot()
    {
        SlingshotImage = GetState(SlingshotImage)
            ? Constants.DisabledItems[8]
            : Constants.EnabledItems[8];
    }

    [RelayCommand]
    public void ToggleDins()
    {
        DinsFireImage = GetState(DinsFireImage)
            ? Constants.DisabledItems[6]
            : Constants.EnabledItems[6];
    }

    [RelayCommand]
    public void ToggleBomb()
    {
        BombItemImage = GetState(BombItemImage)
            ? Constants.DisabledItems[0]
            : Constants.EnabledItems[0];
    }

    [RelayCommand]
    public void ToggleBombchu()
    {
        BombchuImage = GetState(BombchuImage)
            ? Constants.DisabledItems[1]
            : Constants.EnabledItems[1];
    }

    [RelayCommand]
    public void IncreaseChildTrade()
    {
        if (_childTradeStage > 5)
        {
            _childTradeStage = 5;
        }

        ChildTradeItemImage = _childTradeStage switch
        {
            0 => Constants.ChildTradingSequence[1],
            1 => Constants.ChildTradingSequence[2],
            2 => Constants.ChildTradingSequence[3],
            3 => Constants.ChildTradingSequence[4],
            4 => Constants.ChildTradingSequence[5],
            _ => ChildTradeItemImage
        };

        if (_childTradeStage >= 5)
        {
            _childTradeStage = 5;
        }
        else
        {
            _childTradeStage++;
        }
    }

    [RelayCommand]
    public void DecreaseChildTrade()
    {
        if (_childTradeStage < 0)
        {
            _childTradeStage = 0;
        }

        ChildTradeItemImage = _childTradeStage switch
        {
            5 => Constants.ChildTradingSequence[4],
            4 => Constants.ChildTradingSequence[3],
            3 => Constants.ChildTradingSequence[2],
            2 => Constants.ChildTradingSequence[1],
            1 => Constants.ChildTradingSequence[0],
            _ => ChildTradeItemImage
        };

        if (_childTradeStage <= 0)
        {
            _childTradeStage = 0;
        }
        else
        {
            _childTradeStage--;
        }
    }

    [RelayCommand]
    public void ToggleFarore()
    {
        FaroresWindImage = GetState(FaroresWindImage)
            ? Constants.DisabledItems[9]
            : Constants.EnabledItems[9];
    }

    [RelayCommand]
    public void ToggleBoomerang()
    {
        BoomerangImage = GetState(BoomerangImage)
            ? Constants.DisabledItems[2]
            : Constants.EnabledItems[2];
    }

    [RelayCommand]
    public void IncreaseHookshot()
    {
        if (_hookState > 2)
        {
            _hookState = 2;
        }

        HookshotImage = _hookState switch
        {
            0 => Constants.EnabledItems[11],
            1 => Constants.EnabledItems[14],
            _ => HookshotImage
        };

        if (_hookState >= 2)
        {
            _hookState = 2;
        }
        else
        {
            _hookState++;   
        }
    }

    [RelayCommand]
    public void DecreaseHookshot()
    {
        if (_hookState < 0)
        {
            _hookState = 0;
        }

        HookshotImage = _hookState switch
        {
            2 => Constants.EnabledItems[11],
            1 => Constants.DisabledItems[11],
            _ => HookshotImage
        };

        if (_hookState <= 0)
        {
            _hookState = 0;
        }
        else
        {
            _hookState--;
        }
    }

    [RelayCommand]
    public void IncreaseAdultTrade()
    {
        if (_adultTradeStage > 12)
        {
            _adultTradeStage = 12;
        }

        AdultTradeItemImage = _adultTradeStage switch
        {
            0 => Constants.AdultTradingSequence[1],
            1 => Constants.AdultTradingSequence[2],
            2 => Constants.AdultTradingSequence[3],
            3 => Constants.AdultTradingSequence[4],
            4 => Constants.AdultTradingSequence[5],
            5 => Constants.AdultTradingSequence[6],
            6 => Constants.AdultTradingSequence[7],
            7 => Constants.AdultTradingSequence[8],
            8 => Constants.AdultTradingSequence[9],
            9 => Constants.AdultTradingSequence[10],
            10 => Constants.AdultTradingSequence[11],
            11 => Constants.AdultTradingSequence[12],
            _ => AdultTradeItemImage
        };

        if (_adultTradeStage >= 12)
        {
            _adultTradeStage = 12;
        }
        else
        {
            _adultTradeStage++;   
        }
    }

    [RelayCommand]
    public void DecreaseAdultTrade()
    {
        if (_adultTradeStage < 0)
        {
            _adultTradeStage = 0;
        }

        AdultTradeItemImage = _adultTradeStage switch
        {
            12 => Constants.AdultTradingSequence[11],
            11 => Constants.AdultTradingSequence[10],
            10 => Constants.AdultTradingSequence[9],
            9 => Constants.AdultTradingSequence[8],
            8 => Constants.AdultTradingSequence[7],
            7 => Constants.AdultTradingSequence[6],
            6 => Constants.AdultTradingSequence[5],
            5 => Constants.AdultTradingSequence[4],
            4 => Constants.AdultTradingSequence[3],
            3 => Constants.AdultTradingSequence[2],
            2 => Constants.AdultTradingSequence[1],
            1 => Constants.AdultTradingSequence[0],
            _ => AdultTradeItemImage
        };

        if (_adultTradeStage <= 0)
        {
            _adultTradeStage = 0;
        }
        else
        {
            _adultTradeStage--;   
        }
    }

    [RelayCommand]
    public void ToggleNayru()
    {
        NayrusLoveImage = GetState(NayrusLoveImage)
            ? Constants.DisabledItems[16]
            : Constants.EnabledItems[17];
    }

    [RelayCommand]
    public void ToggleLens()
    {
        LensImage = GetState(LensImage)
            ? Constants.DisabledItems[13]
            : Constants.EnabledItems[13];
    }

    [RelayCommand]
    public void ToggleHammer()
    {
        MegatonHammerImage = GetState(MegatonHammerImage)
            ? Constants.DisabledItems[15]
            : Constants.EnabledItems[16];
    }

    [RelayCommand]
    public void ToggleBow()
    {
        BowImage = GetState(BowImage)
            ? Constants.DisabledItems[7]
            : Constants.EnabledItems[7];
    }

    [RelayCommand]
    public void ToggleBeans()
    {
        MagicBeansImage = GetState(MagicBeansImage)
            ? Constants.DisabledItems[17]
            : Constants.EnabledItems[18];
    }

    [RelayCommand]
    public void ToggleFireArrow()
    {
        FireArrowImage = GetState(FireArrowImage)
            ? Constants.DisabledItems[10]
            : Constants.EnabledItems[10];
    }

    [RelayCommand]
    public void ToggleIceArrow()
    {
        IceArrowImage = GetState(IceArrowImage)
            ? Constants.DisabledItems[12]
            : Constants.EnabledItems[12];
    }

    [RelayCommand]
    public void ToggleLightArrow()
    {
        LightArrowImage = GetState(LightArrowImage)
            ? Constants.DisabledItems[14]
            : Constants.EnabledItems[15];
    }

    [RelayCommand]
    public void ToggleBottle(string bottleNumber)
    {
        var bottleNum = int.Parse(bottleNumber);
        
        switch (bottleNum)
        {
            case 1:
                Bottle1Image = GetState(Bottle1Image)
                    ? Constants.DisabledItems[3]
                    : Constants.EnabledItems[3];
                break;
            case 2:
                Bottle2Image = GetState(Bottle2Image)
                    ? Constants.DisabledItems[3]
                    : Constants.EnabledItems[3];
                break;
            case 3:
                Bottle3Image = GetState(Bottle3Image)
                    ? Constants.DisabledItems[3]
                    : Constants.EnabledItems[3];
                break;
            case 4:
                Bottle4Image = GetState(Bottle4Image)
                    ? Constants.DisabledItems[3]
                    : Constants.EnabledItems[3];
                break;
        }
    }
    #endregion
    #region Utils
    private void PrepareData()
    {
        _trackerData = new TrackerData
        {
            TradeData = new TradeData
            {
                TradeStageChild = _childTradeStage,
                TradeStageAdult = _adultTradeStage
            },
            UpgradeData = new UpgradeData
            {
                BombState = _bombState,
                BulletState = _bulletState,
                HookState = _hookState,
                OcarinaState = _ocarinaState,
                QuiverState = _quiverState,
                ScaleState = _scaleState,
                StrengthState = _strengthState
            },
            LocationData = new LocationData
            {
                Location1 = _location1Idx,
                Location2 = _location2Idx,
                Location3 = _location3Idx,
                Location4 = _location4Idx,
                Location5 = _location5Idx,
                Location6 = _location6Idx,
                Location7 = _location7Idx,
                Location8 = _location8Idx,
                Location9 = _location9Idx
            },
            UiData = new UiRelevantData
            {
                Location1String = Location1,
                Location2String = Location2,
                Location3String = Location3,
                Location4String = Location4,
                Location5String = Location5,
                Location6String = Location6,
                Location7String = Location7,
                Location8String = Location8,
                Location9String = Location9,
                
                EmeraldString = KokiriEmeraldImage,
                RubyString = GoronRubyImage,
                SapphireString = ZoraSapphireImage,
                LightMedallionString = LightMedallionImage,
                ForestMedallionString = ForestMedallionImage,
                FireMedallionString = FireMedallionImage,
                WaterMedallionString = WaterMedallionImage,
                SpiritMedallionString = SpiritMedallionImage,
                ShadowMedallionString = ShadowMedallionImage,
                
                KokiriSwordString = KokiriSwordImage,
                MasterSwordString = MasterSwordImage,
                BiggoronSwordString = BiggoronSwordImage,
                DekuShieldString = DekuShieldImage,
                HylianShieldString = HylianShieldImage,
                MirrorShieldString = MirrorShieldImage,
                GoronTunicString = GoronTunicImage,
                ZoraTunicString = ZoraTunicImage,
                IronBootsString = IronBootsImage,
                HoverBootsString = HoverBootsImage,
                
                OcarinaString = OcarinaImage,
                ScaleString = ScaleImage,
                StrengthString = StrengthImage,
                BombString = BombImage,
                QuiverString = QuiverImage,
                BulletString = BulletImage,
                
                GsTokenCount = GsTokens,
                GerudoTokenString = GerudoTokenImage,
                ShardString = ShardImage,
                
                LullabyString = LullabyImage,
                EponaString = EponaImage,
                SariaString = SariaImage,
                StormsString = SosImage,
                SunsString = SunsImage,
                TimeString = SotImage,
                MinuetString = MinuetImage,
                BoleroString = BoleroImage,
                SerenadeString = SerenadeImage,
                RequiemString = RequiemImage,
                NocturneString = NocturneImage,
                PreludeString = PreludeImage,
                
                StickString = StickImage,
                NutString = NutImage,
                SlingshotString = SlingshotImage,
                DinsString = DinsFireImage,
                BombItemString = BombItemImage,
                BombchuString = BombchuImage,
                ChildTradeString = ChildTradeItemImage,
                AdultTradeString = AdultTradeItemImage,
                FaroresString = FaroresWindImage,
                BoomerangString = BoomerangImage,
                HookshotString = HookshotImage,
                NayrusString = NayrusLoveImage,
                LensString = LensImage,
                HammerString = MegatonHammerImage,
                BowString = BowImage,
                BeanString = MagicBeansImage,
                FireArrowString = FireArrowImage,
                IceArrowString = IceArrowImage,
                LightArrowString = LightArrowImage,
                Bottle1String = Bottle1Image,
                Bottle2String = Bottle2Image,
                Bottle3String = Bottle3Image,
                Bottle4String = Bottle4Image
            }
        };
    }

    [RelayCommand]
    public void WriteData()
    {
        PrepareData();
        DataWriter.WriteData(_trackerData);
    }

    [RelayCommand]
    public void ReadData()
    {
        _trackerData = DataReader.ReadData();
        SetTrackerUi();
        SetTrackerCtrl();
    }

    private void SetTrackerUi()
    {
        Location1 = _trackerData.UiData.Location1String;
        Location2 = _trackerData.UiData.Location2String;
        Location3 = _trackerData.UiData.Location3String;
        Location4 = _trackerData.UiData.Location4String;
        Location5 = _trackerData.UiData.Location5String;
        Location6 = _trackerData.UiData.Location6String;
        Location7 = _trackerData.UiData.Location7String;
        Location8 = _trackerData.UiData.Location8String;
        Location9 = _trackerData.UiData.Location9String;

        KokiriEmeraldImage = _trackerData.UiData.EmeraldString;
        GoronRubyImage = _trackerData.UiData.RubyString;
        ZoraSapphireImage = _trackerData.UiData.SapphireString;
        LightMedallionImage = _trackerData.UiData.LightMedallionString;
        ForestMedallionImage = _trackerData.UiData.ForestMedallionString;
        FireMedallionImage = _trackerData.UiData.FireMedallionString;
        WaterMedallionImage = _trackerData.UiData.WaterMedallionString;
        SpiritMedallionImage = _trackerData.UiData.SpiritMedallionString;
        ShadowMedallionImage = _trackerData.UiData.ShadowMedallionString;

        KokiriSwordImage = _trackerData.UiData.KokiriSwordString;
        MasterSwordImage = _trackerData.UiData.MasterSwordString;
        BiggoronSwordImage = _trackerData.UiData.BiggoronSwordString;
        DekuShieldImage = _trackerData.UiData.DekuShieldString;
        HylianShieldImage = _trackerData.UiData.HylianShieldString;
        MirrorShieldImage = _trackerData.UiData.MirrorShieldString;
        IronBootsImage = _trackerData.UiData.IronBootsString;
        HoverBootsImage = _trackerData.UiData.HoverBootsString;
        GoronTunicImage = _trackerData.UiData.GoronTunicString;
        ZoraTunicImage = _trackerData.UiData.ZoraTunicString;

        OcarinaImage = _trackerData.UiData.OcarinaString;
        ScaleImage = _trackerData.UiData.ScaleString;
        StrengthImage = _trackerData.UiData.StrengthString;
        BombImage = _trackerData.UiData.BombString;
        QuiverImage = _trackerData.UiData.QuiverString;
        BulletImage = _trackerData.UiData.BulletString;

        GsTokens = _trackerData.UiData.GsTokenCount;
        GerudoTokenImage = _trackerData.UiData.GerudoTokenString;
        ShardImage = _trackerData.UiData.ShardString;
        
        LullabyImage = _trackerData.UiData.LullabyString;
        EponaImage = _trackerData.UiData.EponaString;
        SariaImage = _trackerData.UiData.SariaString;
        SosImage = _trackerData.UiData.StormsString;
        SunsImage = _trackerData.UiData.SunsString;
        SotImage = _trackerData.UiData.TimeString;
        MinuetImage = _trackerData.UiData.MinuetString;
        BoleroImage = _trackerData.UiData.BoleroString;
        SerenadeImage = _trackerData.UiData.SerenadeString;
        RequiemImage = _trackerData.UiData.RequiemString;
        NocturneImage = _trackerData.UiData.NocturneString;
        PreludeImage = _trackerData.UiData.PreludeString;
        
        StickImage = _trackerData.UiData.StickString;
        NutImage = _trackerData.UiData.NutString;
        SlingshotImage = _trackerData.UiData.SlingshotString;
        DinsFireImage = _trackerData.UiData.DinsString;
        BombItemImage = _trackerData.UiData.BombItemString;
        BombchuImage = _trackerData.UiData.BombchuString;
        ChildTradeItemImage = _trackerData.UiData.ChildTradeString;
        AdultTradeItemImage = _trackerData.UiData.AdultTradeString;
        FaroresWindImage = _trackerData.UiData.FaroresString;
        BoomerangImage = _trackerData.UiData.BoomerangString;
        HookshotImage = _trackerData.UiData.HookshotString;
        NayrusLoveImage = _trackerData.UiData.NayrusString;
        LensImage = _trackerData.UiData.LensString;
        MegatonHammerImage = _trackerData.UiData.HammerString;
        BowImage = _trackerData.UiData.BowString;
        MagicBeansImage = _trackerData.UiData.BeanString;
        FireArrowImage = _trackerData.UiData.FireArrowString;
        IceArrowImage = _trackerData.UiData.IceArrowString;
        LightArrowImage = _trackerData.UiData.LightArrowString;
        Bottle1Image = _trackerData.UiData.Bottle1String;
        Bottle2Image = _trackerData.UiData.Bottle2String;
        Bottle3Image = _trackerData.UiData.Bottle3String;
        Bottle4Image = _trackerData.UiData.Bottle4String;
    }

    private void SetTrackerCtrl()
    {
        _ocarinaState = _trackerData.UpgradeData.OcarinaState;
        _scaleState = _trackerData.UpgradeData.ScaleState;
        _strengthState = _trackerData.UpgradeData.StrengthState;
        _bombState = _trackerData.UpgradeData.BombState;
        _quiverState = _trackerData.UpgradeData.QuiverState;
        _bulletState = _trackerData.UpgradeData.BulletState;
        _hookState = _trackerData.UpgradeData.HookState;

        _location1Idx = _trackerData.LocationData.Location1;
        _location2Idx = _trackerData.LocationData.Location2;
        _location3Idx = _trackerData.LocationData.Location3;
        _location4Idx = _trackerData.LocationData.Location4;
        _location5Idx = _trackerData.LocationData.Location5;
        _location6Idx = _trackerData.LocationData.Location6;
        _location7Idx = _trackerData.LocationData.Location7;
        _location8Idx = _trackerData.LocationData.Location8;
        _location9Idx = _trackerData.LocationData.Location9;

        _childTradeStage = _trackerData.TradeData.TradeStageChild;
        _adultTradeStage = _trackerData.TradeData.TradeStageAdult;
    }

    [RelayCommand]
    public void DeleteData()
    {
        if (File.Exists($"./trackerState"))
        {
            File.Delete($"./trackerState");
        }
    }

    private static bool GetState(string spriteName)
    {
        // Returns true if the sprite is active
        // Or false is inactive
        return !spriteName.Contains("_Disabled");
    }
    #endregion
}