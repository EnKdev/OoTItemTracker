using System;
using System.Collections.Generic;
using EnKdev.ItemTrackers.Core.Internal.Json;

namespace EnKdev.ItemTrackers.OoT.Internal;

public static class Mappings
{
    private static readonly OoTData? OoTData = Globals.InstanceData;

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        DungeonMapMappings = new()
        {
            { "Dungeon_Deku", (p => p.DekuMapImage, (p, val) => p.DekuMapImage = val!) },
            { "Dungeon_DC", (p => p.DcMapImage, (p, val) => p.DcMapImage = val!) },
            { "Dungeon_Jabu", (p => p.JabuMapImage, (p, val) => p.JabuMapImage = val!) },
            { "Dungeon_Forest", (p => p.ForestMapImage, (p, val) => p.ForestMapImage = val!) },
            { "Dungeon_Fire", (p => p.FireMapImage, (p, val) => p.FireMapImage = val!) },
            { "Dungeon_Water", (p => p.WaterMapImage, (p, val) => p.WaterMapImage = val!) },
            { "Dungeon_Shadow", (p => p.ShadowMapImage, (p, val) => p.ShadowMapImage = val!) },
            { "Dungeon_Spirit", (p => p.SpiritMapImage, (p, val) => p.SpiritMapImage = val!) },
            { "Dungeon_Bottom", (p => p.BottomMapImage, (p, val) => p.BottomMapImage = val!) },
            { "Dungeon_Cavern", (p => p.CavernMapImage, (p, val) => p.CavernMapImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        DungeonCompassMappings = new()
        {
            { "Dungeon_Deku", (p => p.DekuCompassImage, (p, val) => p.DekuCompassImage = val!) },
            { "Dungeon_DC", (p => p.DcCompassImage, (p, val) => p.DcCompassImage = val!) },
            { "Dungeon_Jabu", (p => p.JabuCompassImage, (p, val) => p.JabuCompassImage = val!) },
            { "Dungeon_Forest", (p => p.ForestCompassImage, (p, val) => p.ForestCompassImage = val!) },
            { "Dungeon_Fire", (p => p.FireCompassImage, (p, val) => p.FireCompassImage = val!) },
            { "Dungeon_Water", (p => p.WaterCompassImage, (p, val) => p.WaterCompassImage = val!) },
            { "Dungeon_Shadow", (p => p.ShadowCompassImage, (p, val) => p.ShadowCompassImage = val!) },
            { "Dungeon_Spirit", (p => p.SpiritCompassImage, (p, val) => p.SpiritCompassImage = val!) },
            { "Dungeon_Bottom", (p => p.BottomCompassImage, (p, val) => p.BottomCompassImage = val!) },
            { "Dungeon_Cavern", (p => p.CavernCompassImage, (p, val) => p.CavernCompassImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        DungeonBossKeyMappings = new()
        {
            { "Dungeon_Forest", (p => p.ForestBkImage, (p, val) => p.ForestBkImage = val!) },
            { "Dungeon_Fire", (p => p.FireBkImage, (p, val) => p.FireBkImage = val!) },
            { "Dungeon_Water", (p => p.WaterBkImage, (p, val) => p.WaterBkImage = val!) },
            { "Dungeon_Shadow", (p => p.ShadowBkImage, (p, val) => p.ShadowBkImage = val!) },
            { "Dungeon_Spirit", (p => p.SpiritBkImage, (p, val) => p.SpiritBkImage = val!) },
            { "Dungeon_Ganon", (p => p.GanonBkImage, (p, val) => p.GanonBkImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        ArrowMappings = new()
        {
            { "Arrow_Fire", (p => p.FireArrowImage, (p, val) => p.FireArrowImage = val!) },
            { "Arrow_Ice", (p => p.IceArrowImage, (p, val) => p.IceArrowImage = val!) },
            { "Arrow_Light", (p => p.LightArrowImage, (p, val) => p.LightArrowImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        BottleMappings = new()
        {
            { "Bottle1", (p => p.Bottle1Image, (p, val) => p.Bottle1Image = val!) },
            { "Bottle2", (p => p.Bottle2Image, (p, val) => p.Bottle2Image = val!) },
            { "Bottle3", (p => p.Bottle3Image, (p, val) => p.Bottle3Image = val!) },
            { "Bottle4", (p => p.Bottle4Image, (p, val) => p.Bottle4Image = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> GetSprite, Action<TrackerProperties, string?> SetSprite)>
        ItemMappings = new()
        {
            { "Item_Bombchu", (p => p.BombchuImage, (p, val) => p.BombchuImage = val!) },
            { "Item_Boomerang", (p => p.BoomerangImage, (p, val) => p.BoomerangImage = val!) },
            { "Item_DinsFire", (p => p.DinsFireImage, (p, val) => p.DinsFireImage = val!) },
            { "Item_FaroresWind", (p => p.FaroresWindImage, (p, val) => p.FaroresWindImage = val!) },
            { "Item_Lens", (p => p.LensImage, (p, val) => p.LensImage = val!) },
            { "Item_Hammer", (p => p.MegatonHammerImage, (p, val) => p.MegatonHammerImage = val!) },
            { "Item_NayrusLove", (p => p.NayrusLoveImage, (p, val) => p.NayrusLoveImage = val!) },
            { "Item_MagicBeans", (p => p.MagicBeansImage, (p, val) => p.MagicBeansImage = val!) },
            { "Item_FairyOcarina", (p => p.OcarinaImage, (p, val) => p.OcarinaImage = val!) },
            { "Item_OcarinaOfTime", (p => p.OcarinaImage, (p, val) => p.OcarinaImage = val!) },
            { "Item_Hookshot", (p => p.HookshotImage, (p, val) => p.HookshotImage = val!) },
            { "Item_Longshot", (p => p.HookshotImage, (p, val) => p.HookshotImage = val!) },
            { "Item_DekuNuts", (p => p.NutImage, (p, val) => p.NutImage = val!) },
            { "Item_DekuStick", (p => p.StickImage, (p, val) => p.StickImage = val!) },
            { "Item_Bomb", (p => p.BombItemImage, (p, val) => p.BombItemImage = val!) },
            { "Item_Slingshot", (p => p.SlingshotImage, (p, val) => p.SlingshotImage = val!) },
            { "Item_Bow", (p => p.BowImage, (p, val) => p.BowImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        QuestMappings = new()
        {
            { "Progression_LightMedallion", (p => p.LightMedallionImage, (p, val) => p.LightMedallionImage = val!) },
            { "Progression_ForestMedallion", (p => p.ForestMedallionImage, (p, val) => p.ForestMedallionImage = val!) },
            { "Progression_FireMedallion", (p => p.FireMedallionImage, (p, val) => p.FireMedallionImage = val!) },
            { "Progression_WaterMedallion", (p => p.WaterMedallionImage, (p, val) => p.WaterMedallionImage = val!) },
            { "Progression_ShadowMedallion", (p => p.ShadowMedallionImage, (p, val) => p.ShadowMedallionImage = val!) },
            { "Progression_SpiritMedallion", (p => p.SpiritMedallionImage, (p, val) => p.SpiritMedallionImage = val!) },
            { "Progression_KokiriEmerald", (p => p.KokiriEmeraldImage, (p, val) => p.KokiriEmeraldImage = val!) },
            { "Progression_GoronRuby", (p => p.GoronRubyImage, (p, val) => p.GoronRubyImage = val!) },
            { "Progression_ZorasSapphire", (p => p.ZoraSapphireImage, (p, val) => p.ZoraSapphireImage = val!) }
        };

    private static readonly Dictionary<string,
            (Func<TrackerProperties, int>, Action<TrackerProperties, int>,
            Func<TrackerProperties, string?>, Action<TrackerProperties, string?>,
            Func<int, string?>, int)>
        LocationMappings = new()
        {
            {
                "Progression_LightMedallion",
                (p => p.Location4Idx, (p, idx) => p.Location4Idx = idx,
                    p => p.Location4, (p, loc) => p.Location4 = loc,
                    idx => idx switch
                    {
                        0 => OoTData?.Locations![0],
                        1 => OoTData?.Locations![1],
                        2 => OoTData?.Locations![2],
                        3 => OoTData?.Locations![3],
                        4 => OoTData?.Locations![4],
                        5 => OoTData?.Locations![5],
                        6 => OoTData?.Locations![6],
                        7 => OoTData?.Locations![7],
                        8 => OoTData?.Locations![8],
                        9 => OoTData?.Locations![9],
                        _ => null
                    }, 9)
            },
            {
                "Progression_ForestMedallion",
                (p => p.Location5Idx, (p, idx) => p.Location5Idx = idx,
                    p => p.Location5, (p, loc) => p.Location5 = loc,
                    idx => idx switch
                    {
                        0 => OoTData?.Locations![0],
                        1 => OoTData?.Locations![1],
                        2 => OoTData?.Locations![2],
                        3 => OoTData?.Locations![3],
                        4 => OoTData?.Locations![4],
                        5 => OoTData?.Locations![5],
                        6 => OoTData?.Locations![6],
                        7 => OoTData?.Locations![7],
                        8 => OoTData?.Locations![8],
                        9 => OoTData?.Locations![9],
                        _ => null
                    }, 9)
            },
            {
                "Progression_FireMedallion",
                (p => p.Location6Idx, (p, idx) => p.Location6Idx = idx,
                    p => p.Location6, (p, loc) => p.Location6 = loc,
                    idx => idx switch
                    {
                        0 => OoTData?.Locations![0],
                        1 => OoTData?.Locations![1],
                        2 => OoTData?.Locations![2],
                        3 => OoTData?.Locations![3],
                        4 => OoTData?.Locations![4],
                        5 => OoTData?.Locations![5],
                        6 => OoTData?.Locations![6],
                        7 => OoTData?.Locations![7],
                        8 => OoTData?.Locations![8],
                        9 => OoTData?.Locations![9],
                        _ => null
                    }, 9)
            },
            {
                "Progression_WaterMedallion",
                (p => p.Location7Idx, (p, idx) => p.Location7Idx = idx,
                    p => p.Location7, (p, loc) => p.Location7 = loc,
                    idx => idx switch
                    {
                        0 => OoTData?.Locations![0],
                        1 => OoTData?.Locations![1],
                        2 => OoTData?.Locations![2],
                        3 => OoTData?.Locations![3],
                        4 => OoTData?.Locations![4],
                        5 => OoTData?.Locations![5],
                        6 => OoTData?.Locations![6],
                        7 => OoTData?.Locations![7],
                        8 => OoTData?.Locations![8],
                        9 => OoTData?.Locations![9],
                        _ => null
                    }, 9)
            },
            {
                "Progression_ShadowMedallion",
                (p => p.Location9Idx, (p, idx) => p.Location9Idx = idx,
                    p => p.Location9, (p, loc) => p.Location9 = loc,
                    idx => idx switch
                    {
                        0 => OoTData?.Locations![0],
                        1 => OoTData?.Locations![1],
                        2 => OoTData?.Locations![2],
                        3 => OoTData?.Locations![3],
                        4 => OoTData?.Locations![4],
                        5 => OoTData?.Locations![5],
                        6 => OoTData?.Locations![6],
                        7 => OoTData?.Locations![7],
                        8 => OoTData?.Locations![8],
                        9 => OoTData?.Locations![9],
                        _ => null
                    }, 9)
            },
            {
                "Progression_SpiritMedallion",
                (p => p.Location8Idx, (p, idx) => p.Location8Idx = idx,
                    p => p.Location8, (p, loc) => p.Location8 = loc,
                    idx => idx switch
                    {
                        0 => OoTData?.Locations![0],
                        1 => OoTData?.Locations![1],
                        2 => OoTData?.Locations![2],
                        3 => OoTData?.Locations![3],
                        4 => OoTData?.Locations![4],
                        5 => OoTData?.Locations![5],
                        6 => OoTData?.Locations![6],
                        7 => OoTData?.Locations![7],
                        8 => OoTData?.Locations![8],
                        9 => OoTData?.Locations![9],
                        _ => null
                    }, 9)
            },
            {
                "Progression_KokiriEmerald",
                (p => p.Location1Idx, (p, idx) => p.Location1Idx = idx,
                    p => p.Location1, (p, loc) => p.Location1 = loc,
                    idx => idx switch
                    {
                        0 => OoTData?.Locations![0],
                        1 => OoTData?.Locations![1],
                        2 => OoTData?.Locations![2],
                        3 => OoTData?.Locations![3],
                        4 => OoTData?.Locations![4],
                        5 => OoTData?.Locations![5],
                        6 => OoTData?.Locations![6],
                        7 => OoTData?.Locations![7],
                        8 => OoTData?.Locations![8],
                        9 => OoTData?.Locations![9],
                        _ => null
                    }, 9)
            },
            {
                "Progression_GoronRuby",
                (p => p.Location2Idx, (p, idx) => p.Location2Idx = idx,
                    p => p.Location2, (p, loc) => p.Location2 = loc,
                    idx => idx switch
                    {
                        0 => OoTData?.Locations![0],
                        1 => OoTData?.Locations![1],
                        2 => OoTData?.Locations![2],
                        3 => OoTData?.Locations![3],
                        4 => OoTData?.Locations![4],
                        5 => OoTData?.Locations![5],
                        6 => OoTData?.Locations![6],
                        7 => OoTData?.Locations![7],
                        8 => OoTData?.Locations![8],
                        9 => OoTData?.Locations![9],
                        _ => null
                    }, 9)
            },
            {
                "Progression_ZorasSapphire",
                (p => p.Location3Idx, (p, idx) => p.Location3Idx = idx,
                    p => p.Location3, (p, loc) => p.Location3 = loc,
                    idx => idx switch
                    {
                        0 => OoTData?.Locations![0],
                        1 => OoTData?.Locations![1],
                        2 => OoTData?.Locations![2],
                        3 => OoTData?.Locations![3],
                        4 => OoTData?.Locations![4],
                        5 => OoTData?.Locations![5],
                        6 => OoTData?.Locations![6],
                        7 => OoTData?.Locations![7],
                        8 => OoTData?.Locations![8],
                        9 => OoTData?.Locations![9],
                        _ => null
                    }, 9)
            }
        };

    private static readonly Dictionary<string,
            (Func<TrackerProperties, int>, Action<TrackerProperties, int>,
            Func<TrackerProperties, string?>, Action<TrackerProperties, string?>,
            Func<TrackerProperties, bool>, Action<TrackerProperties, bool>,
            Func<int, string?>, int)>
        DungeonStateMappings = new()
        {
            {
                "Dungeon_Deku", (p => p.Dungeon1Idx, (p, idx) => p.Dungeon1Idx = idx,
                    p => p.DungeonType1, (p, val) => p.DungeonType1 = val!,
                    p => p.IsDekuMq, (p, val) => p.IsDekuMq = val,
                    idx => idx switch
                    {
                        0 => OoTData?.Types![0],
                        1 => OoTData?.Types![1],
                        2 => OoTData?.Types![2],
                        _ => null
                    }, 2)
            },
            {
                "Dungeon_DC", (p => p.Dungeon2Idx, (p, idx) => p.Dungeon2Idx = idx,
                    p => p.DungeonType2, (p, val) => p.DungeonType2 = val!,
                    p => p.IsDcMq, (p, val) => p.IsDcMq = val,
                    idx => idx switch
                    {
                        0 => OoTData?.Types![0],
                        1 => OoTData?.Types![1],
                        2 => OoTData?.Types![2],
                        _ => null
                    }, 2)
            },
            {
                "Dungeon_Jabu", (p => p.Dungeon3Idx, (p, idx) => p.Dungeon3Idx = idx,
                    p => p.DungeonType3, (p, val) => p.DungeonType3 = val!,
                    p => p.IsJabuMq, (p, val) => p.IsJabuMq = val,
                    idx => idx switch
                    {
                        0 => OoTData?.Types![0],
                        1 => OoTData?.Types![1],
                        2 => OoTData?.Types![2],
                        _ => null
                    }, 2)
            },
            {
                "Dungeon_Forest", (p => p.Dungeon4Idx, (p, idx) => p.Dungeon4Idx = idx,
                    p => p.DungeonType4, (p, val) => p.DungeonType4 = val!,
                    p => p.IsForestMq, (p, val) => p.IsForestMq = val,
                    idx => idx switch
                    {
                        0 => OoTData?.Types![0],
                        1 => OoTData?.Types![1],
                        2 => OoTData?.Types![2],
                        _ => null
                    }, 2)
            },
            {
                "Dungeon_Fire", (p => p.Dungeon5Idx, (p, idx) => p.Dungeon5Idx = idx,
                    p => p.DungeonType5, (p, val) => p.DungeonType5 = val!,
                    p => p.IsFireMq, (p, val) => p.IsFireMq = val,
                    idx => idx switch
                    {
                        0 => OoTData?.Types![0],
                        1 => OoTData?.Types![1],
                        2 => OoTData?.Types![2],
                        _ => null
                    }, 2)
            },
            {
                "Dungeon_Water", (p => p.Dungeon6Idx, (p, idx) => p.Dungeon6Idx = idx,
                    p => p.DungeonType6, (p, val) => p.DungeonType6 = val!,
                    p => p.IsWaterMq, (p, val) => p.IsWaterMq = val,
                    idx => idx switch
                    {
                        0 => OoTData?.Types![0],
                        1 => OoTData?.Types![1],
                        2 => OoTData?.Types![2],
                        _ => null
                    }, 2)
            },
            {
                "Dungeon_Shadow", (p => p.Dungeon7Idx, (p, idx) => p.Dungeon7Idx = idx,
                    p => p.DungeonType7, (p, val) => p.DungeonType7 = val!,
                    p => p.IsShadowMq, (p, val) => p.IsShadowMq = val,
                    idx => idx switch
                    {
                        0 => OoTData?.Types![0],
                        1 => OoTData?.Types![1],
                        2 => OoTData?.Types![2],
                        _ => null
                    }, 2)
            },
            {
                "Dungeon_Spirit", (p => p.Dungeon8Idx, (p, idx) => p.Dungeon8Idx = idx,
                    p => p.DungeonType8, (p, val) => p.DungeonType8 = val!,
                    p => p.IsSpiritMq, (p, val) => p.IsSpiritMq = val,
                    idx => idx switch
                    {
                        0 => OoTData?.Types![0],
                        1 => OoTData?.Types![1],
                        2 => OoTData?.Types![2],
                        _ => null
                    }, 2)
            },
            {
                "Dungeon_Bottom", (p => p.Dungeon9Idx, (p, idx) => p.Dungeon9Idx = idx,
                    p => p.DungeonType9, (p, val) => p.DungeonType9 = val!,
                    p => p.IsBottomMq, (p, val) => p.IsBottomMq = val,
                    idx => idx switch
                    {
                        0 => OoTData?.Types![0],
                        1 => OoTData?.Types![1],
                        2 => OoTData?.Types![2],
                        _ => null
                    }, 2)
            },
            {
                "Dungeon_Cavern", (p => p.Dungeon10Idx, (p, idx) => p.Dungeon10Idx = idx,
                    p => p.DungeonType10, (p, val) => p.DungeonType10 = val!,
                    p => p.IsCavernMq, (p, val) => p.IsCavernMq = val,
                    idx => idx switch
                    {
                        0 => OoTData?.Types![0],
                        1 => OoTData?.Types![1],
                        2 => OoTData?.Types![2],
                        _ => null
                    }, 2)
            },
            {
                "Dungeon_Training", (p => p.Dungeon11Idx, (p, idx) => p.Dungeon11Idx = idx,
                    p => p.DungeonType11, (p, val) => p.DungeonType11 = val!,
                    p => p.IsGtgMq, (p, val) => p.IsGtgMq = val,
                    idx => idx switch
                    {
                        0 => OoTData?.Types![0],
                        1 => OoTData?.Types![1],
                        2 => OoTData?.Types![2],
                        _ => null
                    }, 2)
            },
            {
                "Dungeon_Ganon", (p => p.Dungeon12Idx, (p, idx) => p.Dungeon12Idx = idx,
                    p => p.DungeonType12, (p, val) => p.DungeonType12 = val!,
                    p => p.IsGanonMq, (p, val) => p.IsGanonMq = val,
                    idx => idx switch
                    {
                        0 => OoTData?.Types![0],
                        1 => OoTData?.Types![1],
                        2 => OoTData?.Types![2],
                        _ => null
                    }, 2)
            }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        EquipMappings = new()
        {
            { "Equip_Boots_Iron", (p => p.IronBootsImage, (p, val) => p.IronBootsImage = val!) },
            { "Equip_Boots_Hover", (p => p.HoverBootsImage, (p, val) => p.HoverBootsImage = val!) },
            { "Equip_Sword_Kokiri", (p => p.KokiriSwordImage, (p, val) => p.KokiriSwordImage = val!) },
            { "Equip_Sword_Master", (p => p.MasterSwordImage, (p, val) => p.MasterSwordImage = val!) },
            { "Equip_Sword_Biggoron", (p => p.BiggoronSwordImage, (p, val) => p.BiggoronSwordImage = val!) },
            { "Equip_Shield_Deku", (p => p.DekuShieldImage, (p, val) => p.DekuShieldImage = val!) },
            { "Equip_Shield_Hylian", (p => p.HylianShieldImage, (p, val) => p.HylianShieldImage = val!) },
            { "Equip_Shield_Mirror", (p => p.MirrorShieldImage, (p, val) => p.MirrorShieldImage = val!) },
            { "Equip_Tunic_Goron", (p => p.GoronTunicImage, (p, val) => p.GoronTunicImage = val!) },
            { "Equip_Tunic_Zora", (p => p.ZoraTunicImage, (p, val) => p.ZoraTunicImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        SongMappings = new()
        {
            { "Song_Lullaby", (p => p.LullabyImage, (p, val) => p.LullabyImage = val!) },
            { "Song_Epona", (p => p.EponaImage, (p, val) => p.EponaImage = val!) },
            { "Song_Saria", (p => p.SariaImage, (p, val) => p.SariaImage = val!) },
            { "Song_Storms", (p => p.SosImage, (p, val) => p.SosImage = val!) },
            { "Song_Suns", (p => p.SunsImage, (p, val) => p.SunsImage = val!) },
            { "Song_Time", (p => p.SotImage, (p, val) => p.SotImage = val!) },
            { "Song_Minuet", (p => p.MinuetImage, (p, val) => p.MinuetImage = val!) },
            { "Song_Bolero", (p => p.BoleroImage, (p, val) => p.BoleroImage = val!) },
            { "Song_Serenade", (p => p.SerenadeImage, (p, val) => p.SerenadeImage = val!) },
            { "Song_Nocturne", (p => p.NocturneImage, (p, val) => p.NocturneImage = val!) },
            { "Song_Requiem", (p => p.RequiemImage, (p, val) => p.RequiemImage = val!) },
            { "Song_Prelude", (p => p.PreludeImage, (p, val) => p.PreludeImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        ChildTradeMappings = new()
        {
            { "Trade_Child_WeirdEgg", (p => p.ChildTradeItemImage, (p, val) => p.ChildTradeItemImage = val!) },
            { "Trade_Child_Cucco", (p => p.ChildTradeItemImage, (p, val) => p.ChildTradeItemImage = val!) },
            { "Trade_Child_ZeldasLetter", (p => p.ChildTradeItemImage, (p, val) => p.ChildTradeItemImage = val!) },
            { "Trade_Child_SkullMask", (p => p.ChildTradeItemImage, (p, val) => p.ChildTradeItemImage = val!) },
            { "Trade_Child_MaskOfTruth", (p => p.ChildTradeItemImage, (p, val) => p.ChildTradeItemImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        AdultTradeMappings = new()
        {
            { "Trade_Adult_PocketEgg", (p => p.AdultTradeItemImage, (p, val) => p.AdultTradeItemImage = val!) },
            { "Trade_Adult_PocketCucco", (p => p.AdultTradeItemImage, (p, val) => p.AdultTradeItemImage = val!) },
            { "Trade_Adult_Cojiro", (p => p.AdultTradeItemImage, (p, val) => p.AdultTradeItemImage = val!) },
            { "Trade_Adult_Mushroom", (p => p.AdultTradeItemImage, (p, val) => p.AdultTradeItemImage = val!) },
            { "Trade_Adult_Poultice", (p => p.AdultTradeItemImage, (p, val) => p.AdultTradeItemImage = val!) },
            { "Trade_Adult_Saw", (p => p.AdultTradeItemImage, (p, val) => p.AdultTradeItemImage = val!) },
            { "Trade_Adult_Knife", (p => p.AdultTradeItemImage, (p, val) => p.AdultTradeItemImage = val!) },
            { "Trade_Adult_BGS", (p => p.AdultTradeItemImage, (p, val) => p.AdultTradeItemImage = val!) },
            { "Trade_Adult_Prescription", (p => p.AdultTradeItemImage, (p, val) => p.AdultTradeItemImage = val!) },
            { "Trade_Adult_Frog", (p => p.AdultTradeItemImage, (p, val) => p.AdultTradeItemImage = val!) },
            { "Trade_Adult_Drops", (p => p.AdultTradeItemImage, (p, val) => p.AdultTradeItemImage = val!) },
            { "Trade_Adult_Check", (p => p.AdultTradeItemImage, (p, val) => p.AdultTradeItemImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        OtherMappings = new()
        {
            { "Other_Token", (p => p.GerudoTokenImage, (p, val) => p.GerudoTokenImage = val!) },
            { "Other_Shard", (p => p.ShardImage, (p, val) => p.ShardImage = val!) }
        };
    
    // ----

    /// <summary>
    /// Retrieves a dictionary of mappings related to dungeon map images. Each key represents
    /// a dungeon identifier, and the value is a tuple containing a getter and setter.
    /// The getter retrieves the current map image for the specified dungeon from a TrackerProperties object,
    /// and the setter updates the map image for the same dungeon within the object.
    /// </summary>
    /// <returns>
    /// A dictionary where the keys are string identifiers corresponding to specific dungeons,
    /// and the values are tuples. Each tuple consists of a function to get the string value
    /// of the dungeon map image and a function to set the string value in a TrackerProperties object.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetDungeonMapMappings() => DungeonMapMappings;

    /// <summary>
    /// Retrieves a dictionary of mappings related to dungeon compass images. Each key represents
    /// a dungeon identifier, and the value is a tuple containing a getter and setter.
    /// The getter retrieves the current compass image for the specified dungeon from a TrackerProperties object,
    /// and the setter updates the compass image for the same dungeon within the object.
    /// </summary>
    /// <returns>
    /// A dictionary where the keys are string identifiers corresponding to specific dungeons,
    /// and the values are tuples. Each tuple consists of a function to get the string value
    /// of the dungeon compass image and a function to set the string value in a TrackerProperties object.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetDungeonCompassMappings() => DungeonCompassMappings;

    /// <summary>
    /// Retrieves a dictionary of mappings related to dungeon boss key images. Each key represents
    /// a specific dungeon identifier, and the value is a tuple containing a getter and setter.
    /// The getter retrieves the current boss key image for the specified dungeon from a TrackerProperties object,
    /// and the setter updates the boss key image for the same dungeon within the object.
    /// </summary>
    /// <returns>
    /// A dictionary where the keys are string identifiers corresponding to specific dungeons,
    /// and the values are tuples. Each tuple consists of a function to get the string value
    /// of the dungeon boss key image and a function to set the string value in a TrackerProperties object.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetDungeonBossKeyMappings() => DungeonBossKeyMappings;

    /// <summary>
    /// Retrieves a dictionary of mappings for arrow-related items, where each key corresponds
    /// to an identifier, and the value represents a tuple containing a getter and setter.
    /// The getter retrieves the value associated with a specific arrow item image from a TrackerProperties object,
    /// and the setter updates the value for the same property within the object.
    /// </summary>
    /// <returns>
    /// A dictionary where the keys are string identifiers representing specific arrow items,
    /// and the values are tuples. Each tuple consists of a function to get the string value of
    /// the arrow item image and a function to set the string value in a TrackerProperties object.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetArrowMappings() => ArrowMappings;

    /// <summary>
    /// Retrieves a dictionary of mappings for bottle-related items, where each key corresponds
    /// to an identifier, and the value represents a tuple containing a getter and setter.
    /// The getter retrieves the value associated with a specific bottle item image from a TrackerProperties object,
    /// and the setter updates the value for the same property within the object.
    /// </summary>
    /// <returns>
    /// A dictionary where the keys are string identifiers representing specific bottle items,
    /// and the values are tuples. Each tuple consists of a function to get the string value of
    /// the bottle item image and a function to set the string value in a TrackerProperties object.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetBottleMappings() => BottleMappings;

    /// <summary>
    /// Retrieves a dictionary of mappings for item-related properties. Each entry in the dictionary
    /// corresponds to an item identifier, providing its associated state and sprite manipulation functions.
    /// </summary>
    /// <returns>
    /// A dictionary where the keys are strings representing item identifiers, and the values are
    /// tuples containing functions to get or set the item's state and sprite within a TrackerProperties object.
    /// </returns>
    public static
        Dictionary<string, (Func<TrackerProperties, string?> GetSprite, Action<TrackerProperties, string?> SetSprite)>
        GetItemMappings() => ItemMappings;

    /// <summary>
    /// Retrieves a dictionary of mappings for quest-related items, where each key corresponds
    /// to a progression identifier (e.g., medallions or spiritual stones), and the value is
    /// a tuple containing a getter and a setter.
    /// The getter retrieves the string representation of the item's image from a TrackerProperties object,
    /// and the setter updates the string value for that property within the object.
    /// </summary>
    /// <returns>
    /// A dictionary where the keys are string identifiers representing specific quest items,
    /// and the values are tuples. Each tuple consists of a function to get the string value of
    /// the quest item image and a function to set the string value in a TrackerProperties object.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetQuestMappings() => QuestMappings;

    /// <summary>
    /// Retrieves a dictionary of mappings for location-related items, where each key corresponds
    /// to an identifier, and the value represents a tuple containing multiple functions and a default threshold value.
    /// The functions include getters and setters for integer and string representations of the location's properties,
    /// as well as a conversion function to transform an integer value into its string representation.
    /// </summary>
    /// <returns>
    /// A dictionary where the keys are string identifiers representing specific locations,
    /// and the values are tuples consisting of:
    /// 1. A function to get an integer value associated with the location's property.
    /// 2. A function to set an integer value for the location's property.
    /// 3. A function to get a string value representing the location's property.
    /// 4. A function to set a string value for the location's property.
    /// 5. A function to convert an integer into a string representation.
    /// 6. An integer representing the default threshold value for the property.
    /// </returns>
    public static Dictionary<string,
            (Func<TrackerProperties, int>, Action<TrackerProperties, int>,
        Func<TrackerProperties, string?>, Action<TrackerProperties, string?>,
        Func<int, string?>, int)>
        GetLocationMappings() => LocationMappings;

    /// <summary>
    /// Retrieves a dictionary of mappings related to dungeon states. Each key represents
    /// a dungeon identifier, and the values are a set of functions and integers that interact
    /// with dungeon state data within a TrackerProperties object. These include functions
    /// to get and set integer and string state values, as well as a function to map integer
    /// states to corresponding string representations, and a default integer state value.
    /// </summary>
    /// <returns>
    /// A dictionary where the keys are string identifiers corresponding to specific dungeons.
    /// Each value is a tuple consisting of functions to get and set both integer and string
    /// state values in a TrackerProperties object, a function to convert integer states to
    /// string representations, and a default integer state value.
    /// </returns>
    public static Dictionary<string,
            (Func<TrackerProperties, int>, Action<TrackerProperties, int>,
            Func<TrackerProperties, string?>, Action<TrackerProperties, string?>,
            Func<TrackerProperties, bool>, Action<TrackerProperties, bool>,
            Func<int, string?>, int)>
        GetDungeonStateMappings() => DungeonStateMappings;

    /// <summary>
    /// Retrieves a dictionary of mappings for equipment-related items, where each key corresponds
    /// to an identifier, and the value represents a tuple containing a getter and setter.
    /// The getter retrieves the image value associated with a specific equipment item from a TrackerProperties object,
    /// and the setter updates the image value for the same property within the object.
    /// </summary>
    /// <returns>
    /// A dictionary where the keys are string identifiers representing specific equipment items,
    /// and the values are tuples. Each tuple consists of a function to get the string value of
    /// the equipment item image and a function to set the string value in a TrackerProperties object.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetEquipMappings() => EquipMappings;

    /// <summary>
    /// Retrieves a dictionary of mappings for song-related items, where each key represents
    /// a song identifier, and the value is a tuple containing a getter and setter function.
    /// The getter retrieves the value associated with the specific song item image from a TrackerProperties object,
    /// and the setter updates the value for the same property within the object.
    /// </summary>
    /// <returns>
    /// A dictionary where the keys are string identifiers corresponding to specific song items,
    /// and the values are tuples. Each tuple consists of a function to get the string value
    /// of the song item image and a function to set the string value in a TrackerProperties object.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetSongMappings() => SongMappings;

    /// <summary>
    /// Retrieves a dictionary of mappings used for "Other" trackers, where each key corresponds
    /// to an identifier and the value represents a tuple containing a getter and setter.
    /// The getter retrieves the value from the specified TrackerProperties object, while
    /// the setter updates the value within the same object.
    /// </summary>
    /// <returns>
    /// A dictionary where keys are string identifiers and values are tuples. Each tuple
    /// consists of a function to get a string value and a function to set a string value
    /// in a TrackerProperties object.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetOtherMappings() => OtherMappings;
}