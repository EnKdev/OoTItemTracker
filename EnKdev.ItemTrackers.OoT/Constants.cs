using System.Collections.Generic;
using System.Windows.Media;
using EnKdev.ItemTrackers.Core.Version;

namespace EnKdev.ItemTrackers.OoT;

public static class Constants
{
    public static readonly string AppTitle = Versioner.VersionString("EnKdevs Ocarina of Time Item Tracker", 3, 0, 0, "build.2", "e5fb18");

    public const string ItemBg = "pack://application:,,,/Images/OoTTrackerItems.png";
    public const string GearBg = "pack://application:,,,/Images/OoTTrackerGear.png";
    public const string DungeonBg = "pack://application:,,,/Images/OoTTrackerDungeons.png";
    public const string QuestBg = "pack://application:,,,/Images/OoTTrackerQuest.png";

    public static readonly List<string> DungeonLocations =
    [
        "???",
        "FREE",
        "DEKU",
        "DC",
        "JABU",
        "FRST",
        "FIRE",
        "WTR",
        "SHDW",
        "SPRT"
    ];

    public static readonly SolidColorBrush NoKeyColor = new(Color.FromRgb(0, 0, 0));
    public static readonly SolidColorBrush HasKeyColor = new(Color.FromRgb(255, 255, 255));
    public static readonly SolidColorBrush AllKeyColor = new(Color.FromRgb(0, 255, 0));

    public const string DungeonMapDisabled = "pack://application:,,,/Icons/Item/OoT3D_Dungeon_Map_Icon_Disabled.png";
    public const string DungeonMapEnabled = "pack://application:,,,/Icons/Item/OoT3D_Dungeon_Map_Icon.png";
    public const string CompassDisabled = "pack://application:,,,/Icons/Item/OoT3D_Compass_Icon_Disabled.png";
    public const string CompassEnabled = "pack://application:,,,/Icons/Item/OoT3D_Compass_Icon.png";
    public const string SmallKeyDisabled = "pack://application:,,,/Icons/Item/OoT3D_Small_Key_Icon_Disabled.png";
    public const string SmallKeyEnabled = "pack://application:,,,/Icons/Item/OoT3D_Small_Key_Icon.png";
    public const string BossKeyDisabled = "pack://application:,,,/Icons/Item/OoT3D_Boss_Key_Icon_Disabled.png";
    public const string BossKeyEnabled = "pack://application:,,,/Icons/Item/OoT3D_Boss_Key_Icon.png";

    public static readonly List<string> DungeonTypes =
    [
        "???",
        "VANILLA",
        "MQ"
    ];

    public static readonly List<string> HeartPieceProgression =
    [
	    "pack://application:,,,/Icons/Other/NoHeartPiece.png",
	    "pack://application:,,,/Icons/Other/HeartPiece1Quarter.png",
	    "pack://application:,,,/Icons/Other/HeartPiece1Half.png",
	    "pack://application:,,,/Icons/Other/HeartPiece3Thirds.png"
    ];

    public const string HeartContainer = "pack://application:,,,/Icons/Other/OoT3D_Heart_Container_Icon.png";
    public const string HeartPiece = "pack://application:,,,/Icons/Other/OoT3D_Piece_of_Heart_Icon.png";

    public static readonly List<string> DisabledStones =
    [
        "pack://application:,,,/Icons/Quest/OoT3D_Kokiri's_Emerald_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Goron's_Ruby_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Zora's_Sapphire_Icon_Disabled.png"
    ];

    public static readonly List<string> EnabledStones =
    [
        "pack://application:,,,/Icons/Quest/OoT3D_Kokiri's_Emerald_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Goron's_Ruby_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Zora's_Sapphire_Icon.png"
    ];

    public static readonly List<string> DisabledMeds =
    [
        "pack://application:,,,/Icons/Quest/OoT3D_Light_Medallion_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Forest_Medallion_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Fire_Medallion_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Water_Medallion_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Shadow_Medallion_Icon_Disabled.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Spirit_Medallion_Icon_Disabled.png"
    ];

    public static readonly List<string> EnabledMeds =
    [
        "pack://application:,,,/Icons/Quest/OoT3D_Light_Medallion_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Forest_Medallion_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Fire_Medallion_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Water_Medallion_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Shadow_Medallion_Icon.png",
        "pack://application:,,,/Icons/Quest/OoT3D_Spirit_Medallion_Icon.png"
    ];

    public const string KokiriTunicSprite = "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Tunic_Icon.png";
    public const string KokiriBootsSprite = "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Boots_Icon.png";

    public static readonly List<string> DisabledEquip =
    [
        "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Sword_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Master_Sword_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Biggoron's_Sword_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Deku_Shield_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Hylian_Shield_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Mirror_Shield_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Goron_Tunic_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Zora_Tunic_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Iron_Boots_Icon_Disabled.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Hover_Boots_Icon_Disabled.png"
    ];

    public static readonly List<string> EnabledEquip =
    [
        "pack://application:,,,/Icons/Equip/OoT3D_Kokiri_Sword_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Master_Sword_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Biggoron's_Sword_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Deku_Shield_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Hylian_Shield_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Mirror_Shield_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Goron_Tunic_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Zora_Tunic_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Iron_Boots_Icon.png",
        "pack://application:,,,/Icons/Equip/OoT3D_Hover_Boots_Icon.png"
    ];

    public static readonly List<string> DisabledUpgrade =
    [
        "pack://application:,,,/Icons/Upgrade/OoT3D_Adult's_Wallet_Icon_Disabled.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Bomb_Bag_Icon_Disabled.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Bullet_Bag_30_Icon_Disabled.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Fairy_Ocarina_Icon_Disabled.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Goron_Bracelet_Icon_Disabled.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Quiver_Icon_Disabled.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Silver_Scale_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Hookshot_Icon_Disabled.png"
    ];

    public static readonly List<string> EnabledUpgrade =
    [
        "pack://application:,,,/Icons/Upgrade/OoT3D_Adult's_Wallet_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Giant's_Wallet_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Bomb_Bag_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Big_Bomb_Bag_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Biggest_Bomb_Bag_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Bullet_Bag_30_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Bullet_Bag_40_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Bullet_Bag_50_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Fairy_Ocarina_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Ocarina_of_Time_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Goron_Bracelet_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Silver_Gauntlets_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Golden_Gauntlets_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Quiver_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Big_Quiver_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Biggest_Quiver_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Silver_Scale_Icon.png",
        "pack://application:,,,/Icons/Upgrade/OoT3D_Golden_Scale_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Hookshot_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Longshot_Icon.png"
    ];

    public static readonly string GsIcon = "pack://application:,,,/Icons/Other/OoT3D_Token_Icon.png";

    public static readonly List<string> DisabledOther =
    [
        "pack://application:,,,/Icons/Other/OoT3D_Gerudo_Token_Icon_Disabled.png",
        "pack://application:,,,/Icons/Other/OoT3D_Shard_of_Agony_Icon_Disabled.png"
    ];

    public static readonly List<string> EnabledOther =
    [
        "pack://application:,,,/Icons/Other/OoT3D_Gerudo_Token_Icon.png",
        "pack://application:,,,/Icons/Other/OoT3D_Shard_of_Agony_Icon.png"
    ];

    public static readonly List<string> DisabledSongs =
    [
        "pack://application:,,,/Icons/Songs/OoT3D_Zelda's_Lullaby_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Epona's_Song_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Saria's_Song_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Song_of_Storms_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Sun's_Song_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Song_of_Time_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Minuet_of_Forest_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Bolero_of_Fire_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Serenade_of_Water_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Requiem_of_Spirit_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Nocturne_of_Shadow_Icon_Disabled.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Prelude_of_Light_Icon_Disabled.png"
    ];

    public static readonly List<string> EnabledSongs =
    [
        "pack://application:,,,/Icons/Songs/OoT3D_Zelda's_Lullaby_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Epona's_Song_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Saria's_Song_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Song_of_Storms_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Sun's_Song_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Song_of_Time_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Minuet_of_Forest_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Bolero_of_Fire_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Serenade_of_Water_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Requiem_of_Spirit_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Nocturne_of_Shadow_Icon.png",
        "pack://application:,,,/Icons/Songs/OoT3D_Prelude_of_Light_Icon.png"
    ];

    public static readonly List<string> DisabledItems =
    [
        "pack://application:,,,/Icons/Item/OoT3D_Bomb_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Bombchu_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Boomerang_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Bottle_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Deku_Nut_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Deku_Stick_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Din's_Fire_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Fairy_Bow_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Fairy_Slingshot_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Farore's_Wind_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Fire_Arrow_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Hookshot_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Ice_Arrow_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Lens_of_Truth_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Light_Arrow_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Megaton_Hammer_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Nayru's_Love_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Magic_Bean_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Boss_Key_Icon_Disabled.png",
        "pack://application:,,,/Icons/Item/OoT3D_Small_Key_Icon_Disabled.png"
    ];

    public static readonly List<string> EnabledItems =
    [
        "pack://application:,,,/Icons/Item/OoT3D_Bomb_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Bombchu_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Boomerang_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Bottle_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Deku_Nut_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Deku_Stick_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Din's_Fire_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Fairy_Bow_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Fairy_Slingshot_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Farore's_Wind_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Fire_Arrow_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Hookshot_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Ice_Arrow_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Lens_of_Truth_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Longshot_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Light_Arrow_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Megaton_Hammer_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Nayru's_Love_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Magic_Bean_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Boss_Key_Icon.png",
        "pack://application:,,,/Icons/Item/OoT3D_Small_Key_Icon.png"
    ];

    public static readonly List<string> ChildTradingItemsEnabled =
    [
        "pack://application:,,,/Icons/ChildTrade/OoT3D_Weird_Egg_Icon.png",
        "pack://application:,,,/Icons/ChildTrade/OoT3D_Cucco_Icon.png",
        "pack://application:,,,/Icons/ChildTrade/OoT3D_Zeldas_Letter_Icon.png",
        "pack://application:,,,/Icons/ChildTrade/OoT3D_Skull_Mask_Icon.png",
        "pack://application:,,,/Icons/ChildTrade/OoT3D_Mask_of_Truth_Icon.png"
    ];

    public static readonly List<string> ChildTradingItemsDisabled =
    [
        "pack://application:,,,/Icons/ChildTrade/OoT3D_Weird_Egg_Icon_Disabled.png",
        "pack://application:,,,/Icons/ChildTrade/OoT3D_Cucco_Icon_Disabled.png",
        "pack://application:,,,/Icons/ChildTrade/OoT3D_Zeldas_Letter_Icon_Disabled.png",
        "pack://application:,,,/Icons/ChildTrade/OoT3D_Skull_Mask_Icon_Disabled.png",
        "pack://application:,,,/Icons/ChildTrade/OoT3D_Mask_of_Truth_Icon_Disabled.png"
    ];

    public static readonly List<string> AdultTradingItemsEnabled =
    [
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Pocket_Egg_Icon.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Pocket_Cucco_Icon.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Cojiro_Icon.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Odd_Mushroom_Icon.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Odd_Poultice_Icon.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Poachers_Saw_Icon.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Giants_Knife_Icon.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Broken_Gorons_Sword_Icon.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Prescription_Icon.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Eyeball_Frog_Icon.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Eye_Drops_Icon.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Claim_Check_Icon.png"
    ];

    public static readonly List<string> AdultTradingItemsDisabled =
    [
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Pocket_Egg_Icon_Disabled.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Pocket_Cucco_Icon_Disabled.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Cojiro_Icon_Disabled.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Odd_Mushroom_Icon_Disabled.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Odd_Poultice_Icon_Disabled.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Poachers_Saw_Icon_Disabled.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Giants_Knife_Icon_Disabled.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Broken_Gorons_Sword_Icon_Disabled.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Prescription_Icon_Disabled.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Eyeball_Frog_Icon_Disabled.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Eye_Drops_Icon_Disabled.png",
        "pack://application:,,,/Icons/AdultTrade/OoT3D_Claim_Check_Icon_Disabled.png"
    ];
}