using EnKdev.ItemTrackers.Core;
using EnKdev.ItemTrackers.Core.Internal.Json;
using EnKdev.ItemTrackers.OoT.Internal;

namespace EnKdev.ItemTrackers.OoT;

public static class Resolver
{
    private static readonly OoTData? OoTData = Globals.InstanceData;
    
    public static void ResolveDefaultLocations(TrackerProperties properties)
    {
        properties.Location1 = OoTData?.Locations![0]!;
        properties.Location2 = OoTData?.Locations![0]!;
        properties.Location3 = OoTData?.Locations![0]!;
        properties.Location4 = OoTData?.Locations![0]!;
        properties.Location5 = OoTData?.Locations![0]!;
        properties.Location6 = OoTData?.Locations![0]!;
        properties.Location7 = OoTData?.Locations![0]!;
        properties.Location8 = OoTData?.Locations![0]!;
        properties.Location9 = OoTData?.Locations![0]!;
    }

    public static void ResolveDefaultDungeonTypes(TrackerProperties properties)
    {
        properties.DungeonType1 = OoTData?.Types![0]!;
        properties.DungeonType2 = OoTData?.Types![0]!;
        properties.DungeonType3 = OoTData?.Types![0]!;
        properties.DungeonType4 = OoTData?.Types![0]!;
        properties.DungeonType5 = OoTData?.Types![0]!;
        properties.DungeonType6 = OoTData?.Types![0]!;
        properties.DungeonType7 = OoTData?.Types![0]!;
        properties.DungeonType8 = OoTData?.Types![0]!;
        properties.DungeonType9 = OoTData?.Types![0]!;
        properties.DungeonType10 = OoTData?.Types![0]!;
        properties.DungeonType11 = OoTData?.Types![0]!;
        properties.DungeonType12 = OoTData?.Types![0]!;
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
        properties.KokiriEmeraldImage = OoTData?.Progression![0].DisabledSprite!;
        properties.GoronRubyImage = OoTData?.Progression![1].DisabledSprite!;
        properties.ZoraSapphireImage = OoTData?.Progression![2].DisabledSprite!;
        properties.LightMedallionImage = OoTData?.Progression![3].DisabledSprite!;
        properties.ForestMedallionImage = OoTData?.Progression![4].DisabledSprite!;
        properties.FireMedallionImage = OoTData?.Progression![5].DisabledSprite!;
        properties.WaterMedallionImage = OoTData?.Progression![6].DisabledSprite!;
        properties.ShadowMedallionImage = OoTData?.Progression![7].DisabledSprite!;
        properties.SpiritMedallionImage = OoTData?.Progression![8].DisabledSprite!;

        properties.GerudoTokenImage = OoTData?.Other![0].ItemDisabled!;
        properties.ShardImage = OoTData?.Other![1].ItemDisabled!;

        properties.GsImage = OoTConstants.GsIcon;
        
        properties.HeartContainer = OoTConstants.HeartContainer;
        properties.HeartPiece = OoTConstants.HeartPiece;
        properties.HeartPieceProgression = OoTConstants.HeartPieceProgression[0];
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
        properties.LullabyImage = OoTData?.Songs![0].SongDisabled!;
        properties.EponaImage = OoTData?.Songs![1].SongDisabled!;
        properties.SariaImage = OoTData?.Songs![2].SongDisabled!;
        properties.SosImage = OoTData?.Songs![3].SongDisabled!;
        properties.SunsImage = OoTData?.Songs![4].SongDisabled!;
        properties.SotImage = OoTData?.Songs![5].SongDisabled!;
        
        properties.MinuetImage = OoTData?.Songs![6].SongDisabled!;
        properties.BoleroImage = OoTData?.Songs![7].SongDisabled!;
        properties.SerenadeImage = OoTData?.Songs![8].SongDisabled!;
        properties.RequiemImage = OoTData?.Songs![9].SongDisabled!;
        properties.NocturneImage = OoTData?.Songs![10].SongDisabled!;
        properties.PreludeImage = OoTData?.Songs![11].SongDisabled!;
    }

    public static void ResolveEquipIcons(TrackerProperties properties)
    {
        properties.KokiriTunicImage = Constants.KokiriTunicImage;
        properties.GoronTunicImage = OoTData?.Equips?.Tunics![0].DisabledSprite!;
        properties.ZoraTunicImage = OoTData?.Equips?.Tunics![1].DisabledSprite!;

        properties.KokiriBootsImage = Constants.KokiriBootsImage;
        properties.IronBootsImage = OoTData?.Equips?.Boots![0].DisabledSprite!;
        properties.HoverBootsImage = OoTData?.Equips?.Boots![1].DisabledSprite!;

        properties.KokiriSwordImage = OoTData?.Equips?.Swords![0].DisabledSprite!;
        properties.MasterSwordImage = OoTData?.Equips?.Swords![1].DisabledSprite!;
        properties.BiggoronSwordImage = OoTData?.Equips?.Swords![2].DisabledSprite!;
        
        properties.DekuShieldImage = OoTData?.Equips?.Shields![0].DisabledSprite!;
        properties.HylianShieldImage = OoTData?.Equips?.Shields![1].DisabledSprite!;
        properties.MirrorShieldImage = OoTData?.Equips?.Shields![2].DisabledSprite!;
    }

    public static void ResolveGearIcons(TrackerProperties properties)
    {
        properties.StrengthImage = OoTData?.Gear![6].GearDisabled!;
        properties.QuiverImage = OoTData?.Gear![9].GearDisabled!;
        properties.BombImage = OoTData?.Gear![0].GearDisabled!;
        properties.BulletImage = OoTData?.Gear![3].GearDisabled!;
        properties.ScaleImage = OoTData?.Gear![12].GearDisabled!;
    }

    public static void ResolveItemIcons(TrackerProperties properties)
    {
        properties.SlingshotImage = OoTData?.Items![5].DisabledSprite!;
        properties.StickImage = OoTData?.Items![16].DisabledSprite!;
        properties.NutImage = OoTData?.Items![15].DisabledSprite!;
        properties.BowImage = OoTData?.Items![6].DisabledSprite!;
        properties.FireArrowImage = OoTData?.Arrows![0].DisabledSprite!;
        properties.BombItemImage = OoTData?.Items![1].DisabledSprite!;
        properties.DinsFireImage = OoTData?.Items![3].DisabledSprite!;
        properties.HookshotImage = OoTData?.Items![13].DisabledSprite!;
        properties.IceArrowImage = OoTData?.Arrows![1].DisabledSprite!;
        properties.FaroresWindImage = OoTData?.Items![4].DisabledSprite!;
        properties.LensImage = OoTData?.Items![7].DisabledSprite!;
        properties.BombchuImage = OoTData?.Items![0].DisabledSprite!;
        properties.MegatonHammerImage = OoTData?.Items![8].DisabledSprite!;
        properties.NayrusLoveImage = OoTData?.Items![9].DisabledSprite!;
        properties.MagicBeansImage = OoTData?.Items![10].DisabledSprite!;
        properties.LightArrowImage = OoTData?.Arrows![2].DisabledSprite!;
        properties.AdultTradeItemImage = OoTData?.Trades?.Adult![0].ItemDisabled!;
        properties.ChildTradeItemImage = OoTData?.Trades?.Child![0].ItemDisabled!;
        properties.BoomerangImage = OoTData?.Items![2].DisabledSprite!;
        properties.OcarinaImage = OoTData?.Items![11].DisabledSprite!;
        
        properties.Bottle1Image = OoTData?.Bottles![0].DisabledSprite!;
        properties.Bottle2Image = OoTData?.Bottles![1].DisabledSprite!;
        properties.Bottle3Image = OoTData?.Bottles![2].DisabledSprite!;
        properties.Bottle4Image = OoTData?.Bottles![3].DisabledSprite!;
    }
}