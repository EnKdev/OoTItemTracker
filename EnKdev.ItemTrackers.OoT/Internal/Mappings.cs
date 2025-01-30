using System;
using System.Collections.Generic;
using EnKdev.ItemTrackers.Core.Internal.Json;

namespace EnKdev.ItemTrackers.OoT.Internal;

public static class Mappings
{
    private static readonly OoTData? OoTData = Globals.InstanceData;

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
        Dictionary<string, (Func<TrackerProperties, int>? GetState, Action<TrackerProperties, int>? SetState,
            Func<TrackerProperties, string?> GetSprite, Action<TrackerProperties, string?> SetSprite)>
        ItemMappings = new()
        {
            { "Item_Bombchu", (null, null, p => p.BombchuImage, (p, val) => p.BombchuImage = val!) },
            { "Item_Boomerang", (null, null, p => p.BoomerangImage, (p, val) => p.BoomerangImage = val!) },
            { "Item_DinsFire", (null, null, p => p.DinsFireImage, (p, val) => p.DinsFireImage = val!) },
            { "Item_FaroresWind", (null, null, p => p.FaroresWindImage, (p, val) => p.FaroresWindImage = val!) },
            { "Item_Lens", (null, null, p => p.LensImage, (p, val) => p.LensImage = val!) },
            { "Item_Hammer", (null, null, p => p.MegatonHammerImage, (p, val) => p.MegatonHammerImage = val!) },
            { "Item_NayrusLove", (null, null, p => p.NayrusLoveImage, (p, val) => p.NayrusLoveImage = val!) },
            { "Item_MagicBeans", (null, null, p => p.MagicBeansImage, (p, val) => p.MagicBeansImage = val!) },
            {
                "Item_FairyOcarina",
                (p => p.OcarinaState, (p, state) => p.OcarinaState = state, p => p.OcarinaImage,
                    (p, val) => p.OcarinaImage = val!)
            },
            {
                "Item_OcarinaOfTime",
                (p => p.OcarinaState, (p, state) => p.OcarinaState = state, p => p.OcarinaImage,
                    (p, val) => p.OcarinaImage = val!)
            },
            {
                "Item_Hookshot",
                (p => p.HookState, (p, state) => p.HookState = state, p => p.HookshotImage,
                    (p, val) => p.HookshotImage = val!)
            },
            {
                "Item_Longshot",
                (p => p.HookState, (p, state) => p.HookState = state, p => p.HookshotImage,
                    (p, val) => p.HookshotImage = val!)
            },
            { "Item_DekuNuts", (null, null, p => p.NutImage, (p, val) => p.NutImage = val!) },
            { "Item_DekuStick", (null, null, p => p.StickImage, (p, val) => p.StickImage = val!) },
            { "Item_Bomb", (null, null, p => p.BombItemImage, (p, val) => p.BombItemImage = val!) },
            { "Item_Slingshot", (null, null, p => p.SlingshotImage, (p, val) => p.SlingshotImage = val!) },
            { "Item_Bow", (null, null, p => p.BowImage, (p, val) => p.BowImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, int> GetState, Action<TrackerProperties, int> SetState,
            Func<TrackerProperties, string?> GetGearSprite, Action<TrackerProperties, string?> SetGearSprite,
            string? AssociatedItem)>
        GearMappings = new()
        {
            {
                "Gear_BombBag", (p => p.BombState, (p, state) => p.BombState = state,
                    p => p.BombImage, (p, val) => p.BombImage = val!,
                    "Item_Bomb")
            },
            {
                "Gear_BigBombBag", (p => p.BombState, (p, state) => p.BombState = state,
                    p => p.BombImage, (p, val) => p.BombImage = val!,
                    null)
            },
            {
                "Gear_BiggestBombBag", (p => p.BombState, (p, state) => p.BombState = state,
                    p => p.BombImage, (p, val) => p.BombImage = val!,
                    null)
            },
            {
                "Gear_BulletBag30", (p => p.BulletState, (p, state) => p.BulletState = state,
                    p => p.BulletImage, (p, val) => p.BulletImage = val!,
                    "Item_Slingshot")
            },
            {
                "Gear_BulletBag40", (p => p.BulletState, (p, state) => p.BulletState = state,
                    p => p.BulletImage, (p, val) => p.BulletImage = val!,
                    null)
            },
            {
                "Gear_BulletBag50", (p => p.BulletState, (p, state) => p.BulletState = state,
                    p => p.BulletImage, (p, val) => p.BulletImage = val!,
                    null)
            },
            {
                "Gear_Bracelet", (p => p.StrengthState, (p, state) => p.StrengthState = state,
                    p => p.StrengthImage, (p, val) => p.StrengthImage = val!,
                    null)
            },
            {
                "Gear_SilverGauntlets", (p => p.StrengthState, (p, state) => p.StrengthState = state,
                    p => p.StrengthImage, (p, val) => p.StrengthImage = val!,
                    null)
            },
            {
                "Gear_GoldenGauntlets", (p => p.StrengthState, (p, state) => p.StrengthState = state,
                    p => p.StrengthImage, (p, val) => p.StrengthImage = val!,
                    null)
            },
            {
                "Gear_Quiver", (p => p.QuiverState, (p, state) => p.QuiverState = state,
                    p => p.QuiverImage, (p, val) => p.QuiverImage = val!,
                    "Item_Bow")
            },
            {
                "Gear_BigQuiver", (p => p.QuiverState, (p, state) => p.QuiverState = state,
                    p => p.QuiverImage, (p, val) => p.QuiverImage = val!,
                    null)
            },
            {
                "Gear_BiggestQuiver", (p => p.QuiverState, (p, state) => p.QuiverState = state,
                    p => p.QuiverImage, (p, val) => p.QuiverImage = val!,
                    null)
            },
            {
                "Gear_SilverScale", (p => p.ScaleState, (p, state) => p.ScaleState = state,
                    p => p.ScaleImage, (p, val) => p.ScaleImage = val!,
                    null)
            },
            {
                "Gear_GoldenScale", (p => p.ScaleState, (p, state) => p.ScaleState = state,
                    p => p.ScaleImage, (p, val) => p.ScaleImage = val!,
                    null)
            }
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
    
    // TODO: Figure Vanilla/MQ Dungeon Mappings out
    
    // ----
    
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetArrowMappings() => ArrowMappings;

    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetBottleMappings() => BottleMappings;
    
    public static
        Dictionary<string, (Func<TrackerProperties, int>? GetState, Action<TrackerProperties, int>? SetState,
            Func<TrackerProperties, string?> GetSprite, Action<TrackerProperties, string?> SetSprite)>
        GetItemMappings() => ItemMappings;
    
    public static 
        Dictionary<string, (Func<TrackerProperties, int> GetState, Action<TrackerProperties, int> SetState,
            Func<TrackerProperties, string?> GetGearSprite, Action<TrackerProperties, string?> SetGearSprite,
            string? AssociatedItem)>
        GetGearMappings() => GearMappings;
    
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetQuestMappings() => QuestMappings;
    
    public static Dictionary<string,
        (Func<TrackerProperties, int>, Action<TrackerProperties, int>,
        Func<TrackerProperties, string?>, Action<TrackerProperties, string?>,
        Func<int, string?>, int)>
        GetLocationMappings() => LocationMappings;
        
    
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetEquipMappings() => EquipMappings;
    
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetSongMappings() => SongMappings;
    
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetChildTradeMappings() => ChildTradeMappings;

    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetAdultTradeMappings() => AdultTradeMappings;
    
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetOtherMappings() => OtherMappings;
}