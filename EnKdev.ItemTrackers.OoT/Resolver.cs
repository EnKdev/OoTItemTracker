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
}