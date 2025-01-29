using System;
using System.Collections.Generic;
using EnKdev.ItemTrackers.Core.Internal.Json;

namespace EnKdev.ItemTrackers.OoT.Internal;

public static class Mappings
{
    private static readonly OoTData? OoTData = Globals.InstanceData; 
    
    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        QuestMappings = new()
        {
            { "Adult_LghtMd", (p => p.LightMedallionImage, (p, val) => p.LightMedallionImage = val!) },
            { "Adult_FrstMd", (p => p.ForestMedallionImage, (p, val) => p.ForestMedallionImage = val!) },
            { "Adult_FrMd", (p => p.FireMedallionImage, (p, val) => p.FireMedallionImage = val!) },
            { "Adult_WtrMd", (p => p.WaterMedallionImage, (p, val) => p.WaterMedallionImage = val!) },
            { "Adult_ShdwMd", (p => p.ShadowMedallionImage, (p, val) => p.ShadowMedallionImage = val!) },
            { "Adult_SprtMd", (p => p.SpiritMedallionImage, (p, val) => p.SpiritMedallionImage = val!) },
            { "Child_Emerald", (p => p.KokiriEmeraldImage, (p, val) => p.KokiriEmeraldImage = val!) },
            { "Child_Ruby", (p => p.GoronRubyImage, (p, val) => p.GoronRubyImage = val!) },
            { "Child_Sapphire", (p => p.ZoraSapphireImage, (p, val) => p.ZoraSapphireImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        OtherMappings = new()
        {
            { "Othr_Shard", (p => p.ShardImage, (p, val) => p.ShardImage = val!) },
            { "Othr_Token", (p => p.GerudoTokenImage, (p, val) => p.GerudoTokenImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        SongMappings = new()
        {
            { "Sng_Lul", (p => p.LullabyImage, (p, val) => p.LullabyImage = val!) },
            { "Sng_Epo", (p => p.EponaImage, (p, val) => p.EponaImage = val!) },
            { "Sng_Sar", (p => p.SariaImage, (p, val) => p.SariaImage = val!) },
            { "Sng_SoS", (p => p.SosImage, (p, val) => p.SosImage = val!) },
            { "Sng_Sun", (p => p.SunsImage, (p, val) => p.SunsImage = val!) },
            { "Sng_SoT", (p => p.SotImage, (p, val) => p.SotImage = val!) },
            { "Sng_Min", (p => p.MinuetImage, (p, val) => p.MinuetImage = val!) },
            { "Sng_Bol", (p => p.BoleroImage, (p, val) => p.BoleroImage = val!) },
            { "Sng_Ser", (p => p.SerenadeImage, (p, val) => p.SerenadeImage = val!) },
            { "Sng_Req", (p => p.RequiemImage, (p, val) => p.RequiemImage = val!) },
            { "Sng_Noc", (p => p.NocturneImage, (p, val) => p.NocturneImage = val!) },
            { "Sng_Pre", (p => p.PreludeImage, (p, val) => p.PreludeImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        EquipMappings = new()
        {
            { "Eqp_Boots2", (p => p.IronBootsImage, (p, val) => p.IronBootsImage = val!) },
            { "Eqp_Boots3", (p => p.HoverBootsImage, (p, val) => p.HoverBootsImage = val!) },
            { "Eqp_Sword1", (p => p.KokiriSwordImage, (p, val) => p.KokiriSwordImage = val!) },
            { "Eqp_Sword2", (p => p.MasterSwordImage, (p, val) => p.MasterSwordImage = val!) },
            { "Eqp_Sword3", (p => p.BiggoronSwordImage, (p, val) => p.BiggoronSwordImage = val!) },
            { "Eqp_Shield1", (p => p.DekuShieldImage, (p, val) => p.DekuShieldImage = val!) },
            { "Eqp_Shield2", (p => p.HylianShieldImage, (p, val) => p.HylianShieldImage = val!) },
            { "Eqp_Shield3", (p => p.MirrorShieldImage, (p, val) => p.MirrorShieldImage = val!) },
            { "Eqp_Tunic2", (p => p.GoronTunicImage, (p, val) => p.GoronTunicImage = val!) },
            { "Eqp_Tunic3", (p => p.ZoraTunicImage, (p, val) => p.ZoraTunicImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        UpgradeGearMappings = new()
        {
            { "Upg_Bmb_Base", (p => p.BombImage, (p, val) => p.BombImage = val!) },
            { "Upg_Bmb_1", (p => p.BombImage, (p, val) => p.BombImage = val!) },
            { "Upg_Bmb_2", (p => p.BombImage, (p, val) => p.BombImage = val!) },

            { "Upg_Slngsht_Base", (p => p.BulletImage, (p, val) => p.BulletImage = val!) },
            { "Upg_Slngsht_1", (p => p.BulletImage, (p, val) => p.BulletImage = val!) },
            { "Upg_Slngsht_2", (p => p.BulletImage, (p, val) => p.BulletImage = val!) },

            { "Upg_Strngth_Base", (p => p.StrengthImage, (p, val) => p.StrengthImage = val!) },
            { "Upg_Strngth_1", (p => p.StrengthImage, (p, val) => p.StrengthImage = val!) },
            { "Upg_Strngth_2", (p => p.StrengthImage, (p, val) => p.StrengthImage = val!) },

            { "Upg_Bw_Base", (p => p.QuiverImage, (p, val) => p.QuiverImage = val!) },
            { "Upg_Bw_1", (p => p.QuiverImage, (p, val) => p.QuiverImage = val!) },
            { "Upg_Bw_2", (p => p.QuiverImage, (p, val) => p.QuiverImage = val!) },

            { "Upg_Scl_Base", (p => p.ScaleImage, (p, val) => p.ScaleImage = val!) },
            { "Upg_Scl_1", (p => p.ScaleImage, (p, val) => p.ScaleImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        UpgradeItemMappings = new()
        {
            { "Upg_Bmb_Base", (p => p.BombItemImage, (p, val) => p.BombItemImage = val!) },
            { "Upg_Bmb_1", (p => p.BombItemImage, (p, val) => p.BombItemImage = val!) },
            { "Upg_Bmb_2", (p => p.BombItemImage, (p, val) => p.BombItemImage = val!) },

            { "Upg_Slngsht_Base", (p => p.SlingshotImage, (p, val) => p.SlingshotImage = val!) },
            { "Upg_Slngsht_1", (p => p.SlingshotImage, (p, val) => p.SlingshotImage = val!) },
            { "Upg_Slngsht_2", (p => p.SlingshotImage, (p, val) => p.SlingshotImage = val!) },

            { "Upg_Ocrn_Base", (p => p.OcarinaImage, (p, val) => p.OcarinaImage = val!) },
            { "Upg_Ocrn_1", (p => p.OcarinaImage, (p, val) => p.OcarinaImage = val!) },

            { "Upg_Bw_Base", (p => p.BowImage, (p, val) => p.BowImage = val!) },
            { "Upg_Bw_1", (p => p.BowImage, (p, val) => p.BowImage = val!) },
            { "Upg_Bw_2", (p => p.BowImage, (p, val) => p.BowImage = val!) },

            { "Upg_Hksht_Base", (p => p.HookshotImage, (p, val) => p.HookshotImage = val!) },
            { "Upg_Hksht_1", (p => p.HookshotImage, (p, val) => p.HookshotImage = val!) },

            { "Upg_DkNt_Base", (p => p.NutImage, (p, val) => p.NutImage = val!) },
            { "Upg_DkNt_1", (p => p.NutImage, (p, val) => p.NutImage = val!) },
            { "Upg_DkNt_2", (p => p.NutImage, (p, val) => p.NutImage = val!) },

            { "Upg_DkStck_Base", (p => p.StickImage, (p, val) => p.StickImage = val!) },
            { "Upg_DkStck_1", (p => p.StickImage, (p, val) => p.StickImage = val!) },
            { "Upg_DkStck_2", (p => p.StickImage, (p, val) => p.StickImage = val!) }
        };

    private static readonly
        Dictionary<string, (Func<TrackerProperties, int>, Action<TrackerProperties, int>,
            Func<TrackerProperties, string?>, Action<TrackerProperties, string?>,
            Func<int, string?>, int)> LocationMappings = new()
        {
            {
                "Adult_LghtMd",
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
                "Adult_FrstMd",
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
                "Adult_FrMd",
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
                "Adult_WtrMd",
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
                "Adult_ShdwMd",
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
                "Adult_SprtMd",
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
                "Child_Emerald",
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
                "Child_Ruby",
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
                "Child_Sapphire",
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

    /// <summary>
    /// Retrieves the dictionary containing quest mappings, where each mapping consists
    /// of a key-value pair. The key is a string identifier for a progression, and the
    /// value is a tuple containing a getter and setter for the respective tracker property.
    /// </summary>
    /// <returns>
    /// A dictionary of quest mappings with string keys and value tuples, where each tuple
    /// includes a function to get a property value and an action to set a property value.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetQuestMappings() => QuestMappings;

    /// <summary>
    /// Retrieves the dictionary containing other mappings, where each mapping consists
    /// of a key-value pair. The key is a string identifier for an item, and the value is
    /// a tuple containing a getter and setter for the respective tracker property.
    /// </summary>
    /// <returns>
    /// A dictionary of other mappings with string keys and value tuples, where each tuple
    /// includes a function to get a property value and an action to set a property value.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetOtherMappings() => OtherMappings;

    /// <summary>
    /// Retrieves the dictionary containing song mappings, where each mapping consists
    /// of a key-value pair. The key is a string identifier for a specific song, and the
    /// value is a tuple containing a getter and setter for the respective tracker property.
    /// </summary>
    /// <returns>
    /// A dictionary of song mappings with string keys and value tuples, where each tuple
    /// includes a function to get a property value and an action to set a property value.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetSongMappings() => SongMappings;

    /// <summary>
    /// Retrieves the dictionary containing location mappings, where each mapping consists
    /// of a key-value pair. The key is a string identifier for a location, and the value is
    /// a tuple containing functions and actions for getting and setting integer and string
    /// properties, as well as additional metadata.
    /// </summary>
    /// <returns>
    /// A dictionary of location mappings with string keys and value tuples, where each tuple
    /// includes functions to get and set integer and string properties, a function to convert
    /// an integer to a string representation, and an integer denoting metadata.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, int>, Action<TrackerProperties, int>,
        Func<TrackerProperties, string?>, Action<TrackerProperties, string?>,
        Func<int, string?>, int)> GetLocationMappings() => LocationMappings;

    /// <summary>
    /// Retrieves the dictionary containing equip mappings, where each mapping consists
    /// of a key-value pair. The key represents an equip item identifier, and the value
    /// is a tuple containing a function to get the corresponding property value and
    /// an action to set the property value.
    /// </summary>
    /// <returns>
    /// A dictionary of equip mappings with string keys and value tuples, where each tuple
    /// includes a getter function and a setter action for equip-related tracker properties.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetEquipMappings() => EquipMappings;

    /// <summary>
    /// Retrieves the dictionary containing upgrade item mappings, where each mapping consists
    /// of a key-value pair. The key is a string identifier for a specific upgrade item, and the
    /// value is a tuple containing a function to get the corresponding tracker property value
    /// and an action to set the tracker property value.
    /// </summary>
    /// <returns>
    /// A dictionary of upgrade item mappings with string keys and value tuples, where each tuple
    /// includes a function to retrieve a property value and an action to update the property value.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetUpgradeItemMappings() => UpgradeItemMappings;

    /// <summary>
    /// Retrieves the dictionary containing upgrade gear mappings, where each mapping consists
    /// of a key-value pair. The key is a string identifier for an upgrade gear type, and the
    /// value is a tuple containing a function to get a property value and an action to set a property value.
    /// </summary>
    /// <returns>
    /// A dictionary of upgrade gear mappings with string keys and tuple values, where each tuple
    /// includes a getter function and a setter action for managing upgrade gear properties in the tracker.
    /// </returns>
    public static Dictionary<string, (Func<TrackerProperties, string?> Get, Action<TrackerProperties, string?> Set)>
        GetUpgradeGearMappings() => UpgradeGearMappings;
}