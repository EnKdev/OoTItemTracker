using System.Collections.Generic;
using System.Linq;
using EnKdev.ItemTrackers.Core;
using EnKdev.ItemTrackers.OoT.Internal;

namespace EnKdev.ItemTrackers.OoT;

public static class Resolver
{
    public static void ResolveDefaultLocations(TrackerProperties properties)
    {
        var ootData = Globals.InstanceData;

        properties.Location1 = ootData?.Locations![0]!;
        properties.Location2 = ootData?.Locations![0]!;
        properties.Location3 = ootData?.Locations![0]!;
        properties.Location4 = ootData?.Locations![0]!;
        properties.Location5 = ootData?.Locations![0]!;
        properties.Location6 = ootData?.Locations![0]!;
        properties.Location7 = ootData?.Locations![0]!;
        properties.Location8 = ootData?.Locations![0]!;
        properties.Location9 = ootData?.Locations![0]!;
    }

    public static void ResolveDefaultDungeonTypes(TrackerProperties properties)
    {
        var ootData = Globals.InstanceData;

        properties.DungeonType1 = ootData?.Types![0]!;
        properties.DungeonType2 = ootData?.Types![0]!;
        properties.DungeonType3 = ootData?.Types![0]!;
        properties.DungeonType4 = ootData?.Types![0]!;
        properties.DungeonType5 = ootData?.Types![0]!;
        properties.DungeonType6 = ootData?.Types![0]!;
        properties.DungeonType7 = ootData?.Types![0]!;
        properties.DungeonType8 = ootData?.Types![0]!;
        properties.DungeonType9 = ootData?.Types![0]!;
        properties.DungeonType10 = ootData?.Types![0]!;
        properties.DungeonType11 = ootData?.Types![0]!;
        properties.DungeonType12 = ootData?.Types![0]!;
    }

    public static void ResolveDefaultKeyColors(TrackerProperties properties)
    {
        properties.ForestKeyColor = Constants.NoKeyColor;
        properties.FireKeyColor = Constants.NoKeyColor;
        properties.WaterKeyColor = Constants.NoKeyColor;
        properties.ShadowKeyColor = Constants.NoKeyColor;
        properties.SpiritKeyColor = Constants.NoKeyColor;
        properties.BottomKeyColor = Constants.NoKeyColor;
        properties.GanonKeyColor = Constants.NoKeyColor;
        properties.GtgKeyColor = Constants.NoKeyColor;
    }

    public static void ResolveBackgrounds(TrackerProperties properties)
    {
        properties.ItemBackground = OoTConstants.ItemBg;
        properties.GearBackground = OoTConstants.GearBg;
        properties.DungeonBackground = OoTConstants.DungeonBg;
        properties.QuestBackground = OoTConstants.QuestBg;
    }

    public static void ResolveDefaultIcons(TrackerProperties properties)
    {
        var ootData = Globals.InstanceData;

        properties.KokiriEmeraldImage = ootData?.Progression![0].DisabledSprite!;
        properties.GoronRubyImage = ootData?.Progression![1].DisabledSprite!;
        properties.ZoraSapphireImage = ootData?.Progression![2].DisabledSprite!;
        properties.LightMedallionImage = ootData?.Progression![3].DisabledSprite!;
        properties.ForestMedallionImage = ootData?.Progression![4].DisabledSprite!;
        properties.FireMedallionImage = ootData?.Progression![5].DisabledSprite!;
        properties.WaterMedallionImage = ootData?.Progression![6].DisabledSprite!;
        properties.ShadowMedallionImage = ootData?.Progression![7].DisabledSprite!;
        properties.SpiritMedallionImage = ootData?.Progression![8].DisabledSprite!;

        properties.GerudoTokenImage = ootData?.Other![0].ItemDisabled!;
        properties.ShardImage = ootData?.Other![1].ItemDisabled!;

        properties.GsImage = OoTConstants.GsIcon;
        
        properties.HeartContainer = OoTConstants.HeartContainer;
        properties.HeartPiece = OoTConstants.HeartPiece;
    }

    public static void ResolveKeyIcons(TrackerProperties properties)
    {
        properties.BottomKeyImage = OoTConstants.SmallKeyDisabled;
        properties.ForestKeyImage = OoTConstants.SmallKeyDisabled;
        properties.FireKeyImage = OoTConstants.SmallKeyDisabled;
        properties.WaterKeyImage = OoTConstants.SmallKeyDisabled;
        properties.ShadowKeyImage = OoTConstants.SmallKeyDisabled;
        properties.SpiritKeyImage = OoTConstants.SmallKeyDisabled;
        properties.GanonKeyImage = OoTConstants.SmallKeyDisabled;
        properties.GtgKeyImage = OoTConstants.SmallKeyDisabled;

        properties.ForestBkImage = OoTConstants.BossKeyDisabled!;
        properties.FireBkImage = OoTConstants.BossKeyDisabled!;
        properties.WaterBkImage = OoTConstants.BossKeyDisabled!;
        properties.ShadowBkImage = OoTConstants.BossKeyDisabled!;
        properties.SpiritBkImage = OoTConstants.BossKeyDisabled!;
        properties.GanonBkImage = OoTConstants.BossKeyDisabled!;
    }

    public static void ResolveDungeonIcons(TrackerProperties properties)
    {
        properties.DekuCompassImage = OoTConstants.CompassDisabled;
        properties.DcCompassImage = OoTConstants.CompassDisabled;
        properties.JabuCompassImage = OoTConstants.CompassDisabled;
        properties.ForestCompassImage = OoTConstants.CompassDisabled;
        properties.FireCompassImage = OoTConstants.CompassDisabled;
        properties.WaterCompassImage = OoTConstants.CompassDisabled;
        properties.ShadowCompassImage = OoTConstants.CompassDisabled;
        properties.SpiritCompassImage = OoTConstants.CompassDisabled;
        properties.GanonCompassImage = OoTConstants.CompassDisabled;
        properties.BottomCompassImage = OoTConstants.CompassDisabled;
        properties.CavernCompassImage = OoTConstants.CompassDisabled;

        properties.DekuMapImage = OoTConstants.DungeonMapDisabled;
        properties.DcMapImage = OoTConstants.DungeonMapDisabled;
        properties.JabuMapImage = OoTConstants.DungeonMapDisabled;
        properties.ForestMapImage = OoTConstants.DungeonMapDisabled;
        properties.FireMapImage = OoTConstants.DungeonMapDisabled;
        properties.WaterMapImage = OoTConstants.DungeonMapDisabled;
        properties.ShadowMapImage = OoTConstants.DungeonMapDisabled;
        properties.SpiritMapImage = OoTConstants.DungeonMapDisabled;
        properties.BottomMapImage = OoTConstants.DungeonMapDisabled;
        properties.CavernMapImage = OoTConstants.DungeonMapDisabled;
    }

    public static void ResolveSongIcons(TrackerProperties properties)
    {
        var ootData = Globals.InstanceData;

        properties.LullabyImage = ootData?.Songs![0].SongDisabled!;
        properties.EponaImage = ootData?.Songs![1].SongDisabled!;
        properties.SariaImage = ootData?.Songs![2].SongDisabled!;
        properties.SosImage = ootData?.Songs![3].SongDisabled!;
        properties.SunsImage = ootData?.Songs![4].SongDisabled!;
        properties.SotImage = ootData?.Songs![5].SongDisabled!;
        
        properties.MinuetImage = ootData?.Songs![6].SongDisabled!;
        properties.BoleroImage = ootData?.Songs![7].SongDisabled!;
        properties.SerenadeImage = ootData?.Songs![8].SongDisabled!;
        properties.RequiemImage = ootData?.Songs![9].SongDisabled!;
        properties.NocturneImage = ootData?.Songs![10].SongDisabled!;
        properties.PreludeImage = ootData?.Songs![11].SongDisabled!;
    }

    public static void ResolveEquipIcons(TrackerProperties properties)
    {
        var ootData = Globals.InstanceData;

        properties.KokiriTunicImage = ootData?.Equips?.Tunics![0].EnabledSprite!;
        properties.GoronTunicImage = ootData?.Equips?.Tunics![1].DisabledSprite!;
        properties.ZoraTunicImage = ootData?.Equips?.Tunics![2].DisabledSprite!;

        properties.KokiriBootsImage = ootData?.Equips?.Boots![0].EnabledSprite!;
        properties.IronBootsImage = ootData?.Equips?.Boots![1].DisabledSprite!;
        properties.HoverBootsImage = ootData?.Equips?.Boots![2].DisabledSprite!;

        properties.KokiriSwordImage = ootData?.Equips?.Swords![0].EnabledSprite!;
        properties.MasterSwordImage = ootData?.Equips?.Swords![1].DisabledSprite!;
        properties.BiggoronSwordImage = ootData?.Equips?.Swords![2].DisabledSprite!;
        
        properties.DekuShieldImage = ootData?.Equips?.Shields![0].DisabledSprite!;
        properties.HylianShieldImage = ootData?.Equips?.Shields![1].DisabledSprite!;
        properties.MirrorShieldImage = ootData?.Equips?.Shields![2].DisabledSprite!;
    }

    public static void ResolveGearIcons(TrackerProperties properties)
    {
        var ootData = Globals.InstanceData;

        properties.StrengthImage = ootData?.Upgrades![8].Icons?.GearDisabled!;
        properties.QuiverImage = ootData?.Upgrades![13].Icons?.GearDisabled!;
        properties.BombImage = ootData?.Upgrades![0].Icons?.GearDisabled!;
        properties.BulletImage = ootData?.Upgrades![3].Icons?.GearDisabled!;
        properties.ScaleImage = ootData?.Upgrades![17].Icons?.GearDisabled!;
    }

    public static void ResolveItemIcons(TrackerProperties properties)
    {
        var ootData = Globals.InstanceData;
        
        properties.SlingshotImage = ootData?.Upgrades![3].Icons?.ItemDisabled!;
        properties.StickImage = ootData?.Upgrades![24].Icons?.ItemDisabled!;
        properties.NutImage = ootData?.Upgrades![21].Icons?.ItemDisabled!;
        properties.BowImage = ootData?.Upgrades![13].Icons?.ItemDisabled!;
        properties.FireArrowImage = ootData?.Arrows![0].DisabledSprite!;
        properties.BombItemImage = ootData?.Upgrades![0].Icons?.ItemDisabled!;
        properties.DinsFireImage = ootData?.Items![2].DisabledSprite!;
        properties.HookshotImage = ootData?.Upgrades![19].Icons?.ItemDisabled!;
        properties.IceArrowImage = ootData?.Arrows![1].DisabledSprite!;
        properties.FaroresWindImage = ootData?.Items![3].DisabledSprite!;
    }
}