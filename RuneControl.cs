using LuckyRunes.Items.Accessories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes
{
    public static class RuneControl
    {
        public static void InitializeVars()
        {
            FishPoolInit();
            LuckyBagInit();
            CloverBagInit();
        }

        #region LootTables
        private static void FishPoolInit()
        {
            FishPool.Clear();
            FishPool.Add(ItemID.ArmoredCavefish, 4);
            FishPool.Add(ItemID.AtlanticCod, 12);
            FishPool.Add(ItemID.Bass, 32);
            FishPool.Add(ItemID.ChaosFish, 1);
            FishPool.Add(ItemID.CrimsonTigerfish, 4);
            FishPool.Add(ItemID.Damselfish, 1);
            FishPool.Add(ItemID.DoubleCod, 12);
            FishPool.Add(ItemID.Ebonkoi, 4);
            FishPool.Add(ItemID.FlarefinKoi, 1);
            FishPool.Add(ItemID.FrostMinnow, 12);
            FishPool.Add(ItemID.GoldenCarp, 1);
            FishPool.Add(ItemID.Hemopiranha, 1);
            FishPool.Add(ItemID.NeonTetra, 4);
            FishPool.Add(ItemID.Obsidifish, 4);
            FishPool.Add(ItemID.PrincessFish, 1);
            FishPool.Add(ItemID.Prismite, 1);
            FishPool.Add(ItemID.RedSnapper, 12);
            FishPool.Add(ItemID.Salmon, 12);
            FishPool.Add(ItemID.Shrimp, 12);
            FishPool.Add(ItemID.SpecularFish, 4);
            FishPool.Add(ItemID.Stinkfish, 1);
            FishPool.Add(ItemID.Trout, 22);
            FishPool.Add(ItemID.Tuna, 22);
            FishPool.Add(ItemID.VariegatedLardfish, 1);
        }

        public static void LuckyBagInit()
        {
            LuckyBagPool.Clear();
            //Misc Items
            LuckyBagPool.Add(new Point(ItemID.GoldCoin, Main.rand.Next(1, 4)), 5);
            LuckyBagPool.Add(new Point(ItemID.WoodenCrate, Main.rand.Next(1, 3)), 5);
            LuckyBagPool.Add(new Point(ItemID.LesserHealingPotion, Main.rand.Next(5, 11)), 10);
            LuckyBagPool.Add(new Point(ItemID.LesserManaPotion, Main.rand.Next(5, 11)), 10);

            //Wooden Chest Loot
            LuckyBagPool.Add(new Point(ItemID.Spear, 1), 10);
            LuckyBagPool.Add(new Point(ItemID.Blowpipe, 1), 10);
            LuckyBagPool.Add(new Point(ItemID.WoodenBoomerang, 1), 10);
            LuckyBagPool.Add(new Point(ItemID.Glowstick, Main.rand.Next(40, 50)), 10);
            LuckyBagPool.Add(new Point(ItemID.ThrowingKnife, Main.rand.Next(150, 299)), 10);
            LuckyBagPool.Add(new Point(ItemID.Shuriken, Main.rand.Next(150, 299)), 10);
            LuckyBagPool.Add(new Point(ItemID.Snowball, Main.rand.Next(150, 299)), 10);
            LuckyBagPool.Add(new Point(ItemID.Torch, Main.rand.Next(40, 99)), 10);
            LuckyBagPool.Add(new Point(ItemID.Aglet, 1), 10);
            LuckyBagPool.Add(new Point(ItemID.ClimbingClaws, 1), 10);
            LuckyBagPool.Add(new Point(ItemID.ShoeSpikes, 1), 10);
            LuckyBagPool.Add(new Point(ItemID.Umbrella, 1), 10);
            LuckyBagPool.Add(new Point(ItemID.CordageGuide, 1), 10);
            LuckyBagPool.Add(new Point(ItemID.WandofSparking, 1), 10);
            LuckyBagPool.Add(new Point(ItemID.Radar, 1), 10);

            //Water Chest Loot
            LuckyBagPool.Add(new Point(ItemID.BreathingReed, 1), 10);
            LuckyBagPool.Add(new Point(ItemID.Flipper, 1), 10);
            LuckyBagPool.Add(new Point(ItemID.Trident, 1), 10);
            LuckyBagPool.Add(new Point(ItemID.WaterWalkingBoots, 1), 10);

            //Blocks
            LuckyBagPool.Add(new Point(ItemID.Wood, Main.rand.Next(99, 499)), 10);
            LuckyBagPool.Add(new Point(ItemID.BorealWood, Main.rand.Next(99, 499)), 10);
            LuckyBagPool.Add(new Point(ItemID.PalmWood, Main.rand.Next(99, 499)), 10);
            LuckyBagPool.Add(new Point(ItemID.StoneBlock, Main.rand.Next(99, 499)), 10);
            LuckyBagPool.Add(new Point(ItemID.DirtBlock, Main.rand.Next(99, 499)), 10);
            LuckyBagPool.Add(new Point(ItemID.SandBlock, Main.rand.Next(99, 499)), 10);
            LuckyBagPool.Add(new Point(ItemID.SnowBlock, Main.rand.Next(99, 499)), 10);
            LuckyBagPool.Add(new Point(ItemID.MudBlock, Main.rand.Next(99, 499)), 10);
            LuckyBagPool.Add(new Point(ItemID.MarbleBlock, Main.rand.Next(99, 499)), 10);
            LuckyBagPool.Add(new Point(ItemID.GraniteBlock, Main.rand.Next(99, 499)), 10);
            LuckyBagPool.Add(new Point(ItemID.GrayBrick, Main.rand.Next(99, 499)), 10);
            LuckyBagPool.Add(new Point(ItemID.ClayBlock, Main.rand.Next(99, 499)), 10);
            LuckyBagPool.Add(new Point(ItemID.RedBrick, Main.rand.Next(99, 499)), 10);
            LuckyBagPool.Add(new Point(ItemID.AshBlock, Main.rand.Next(99, 499)), 10);

            //Materials
            LuckyBagPool.Add(new Point(ItemID.Cobweb, Main.rand.Next(50, 200)), 10);
            LuckyBagPool.Add(new Point(ItemID.Silk, Main.rand.Next(20, 60)), 10);
            LuckyBagPool.Add(new Point(ItemID.Coral, Main.rand.Next(10, 20)), 10);
            LuckyBagPool.Add(new Point(ItemID.Chain, Main.rand.Next(20, 60)), 10);
        }

        public static void CloverBagInit()
        {
            CloverBagPool.Clear();
            //Misc Items
            CloverBagPool.Add(new Point(ItemID.GoldCoin, Main.rand.Next(5, 16)), 5);
            CloverBagPool.Add(new Point(ItemID.IronCrate, Main.rand.Next(1, 3)), 5);
            CloverBagPool.Add(new Point(ItemID.HealingPotion, Main.rand.Next(5, 11)), 10);
            CloverBagPool.Add(new Point(ItemID.ManaPotion, Main.rand.Next(5, 11)), 10);
            CloverBagPool.Add(new Point(ModContent.ItemType<LuckyClover>(), 1), 20);

            //Gold Chest Loot
            CloverBagPool.Add(new Point(ItemID.BandofRegeneration, 1), 10);
            CloverBagPool.Add(new Point(ItemID.MagicMirror, 1), 10);
            CloverBagPool.Add(new Point(ItemID.CloudinaBottle, 1), 10);
            CloverBagPool.Add(new Point(ItemID.HermesBoots, 1), 10);
            CloverBagPool.Add(new Point(ItemID.EnchantedBoomerang, 1), 10);
            CloverBagPool.Add(new Point(ItemID.FlareGun, 1), 10);
            CloverBagPool.Add(new Point(ItemID.Extractinator, 1), 10);
            CloverBagPool.Add(new Point(ItemID.LavaCharm, 1), 10);

            //Ice Chest Loot
            CloverBagPool.Add(new Point(ItemID.IceBoomerang, 1), 10);
            CloverBagPool.Add(new Point(ItemID.IceBlade, 1), 10);
            CloverBagPool.Add(new Point(ItemID.IceSkates, 1), 10);
            CloverBagPool.Add(new Point(ItemID.SnowballCannon, 1), 10);
            CloverBagPool.Add(new Point(ItemID.BlizzardinaBottle, 1), 10);
            CloverBagPool.Add(new Point(ItemID.FlurryBoots, 1), 10);
            CloverBagPool.Add(new Point(ItemID.IceMirror, 1), 10);
            CloverBagPool.Add(new Point(ItemID.IceMachine, 1), 10);

            //Floating Island Loot
            CloverBagPool.Add(new Point(ItemID.Starfury, 1), 10);
            CloverBagPool.Add(new Point(ItemID.LuckyHorseshoe, 1), 10);
            CloverBagPool.Add(new Point(ItemID.ShinyRedBalloon, 1), 10);

            //Pyramid Loot
            CloverBagPool.Add(new Point(ItemID.SandstorminaBottle, 1), 10);
            CloverBagPool.Add(new Point(ItemID.FlyingCarpet, 1), 10);
            CloverBagPool.Add(new Point(ItemID.PharaohsMask, 1), 10);
            CloverBagPool.Add(new Point(ItemID.PharaohsRobe, 1), 10);

            //Jungle Loot
            CloverBagPool.Add(new Point(ItemID.AnkletoftheWind, 1), 10);
            CloverBagPool.Add(new Point(ItemID.FeralClaws, 1), 10);
            CloverBagPool.Add(new Point(ItemID.StaffofRegrowth, 1), 10);
            CloverBagPool.Add(new Point(ItemID.FiberglassFishingPole, 1), 10);
            CloverBagPool.Add(new Point(ItemID.Boomstick, 1), 10);
            CloverBagPool.Add(new Point(ItemID.FlowerBoots, 1), 10);

            //Metals
            CloverBagPool.Add(new Point(ItemID.IronBar, Main.rand.Next(25, 51)), 10);
            CloverBagPool.Add(new Point(ItemID.LeadBar, Main.rand.Next(25, 51)), 10);
            CloverBagPool.Add(new Point(ItemID.SilverBar, Main.rand.Next(25, 51)), 10);
            CloverBagPool.Add(new Point(ItemID.TungstenBar, Main.rand.Next(25, 51)), 10);
            CloverBagPool.Add(new Point(ItemID.GoldBar, Main.rand.Next(25, 51)), 10);
            CloverBagPool.Add(new Point(ItemID.PlatinumBar, Main.rand.Next(25, 51)), 10);
            CloverBagPool.Add(new Point(ItemID.DemoniteBar, Main.rand.Next(25, 51)), 10);
            CloverBagPool.Add(new Point(ItemID.CrimtaneBar, Main.rand.Next(25, 51)), 10);
        }

        public static void CrystalBagInit()
        {
            CrystalBagPool.Clear();

            CrystalBagPool.Add(new Point(ModContent.ItemType<LuckyCrystal>(), 1), 20);
            switch (GetProgression())
            {
                case Progression.PostML:
                    //ML
                    CrystalBagPool.Add(new Point(ItemID.Meowmere, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Terrarian, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.StarWrath, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SDMG, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.LastPrism, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.LunarFlareBook, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.RainbowCrystalStaff, 1), 10);
                    CrystalBagPool.Add(new Point(3569, 1), 10); //LunarPortalStaff
                    CrystalBagPool.Add(new Point(ItemID.FireworksLauncher, 1), 10); //Celebration
                    CrystalBagPool.Add(new Point(ItemID.LunarBar, Main.rand.Next(50,101)), 10);
                    //Fragments
                    CrystalBagPool.Add(new Point(ItemID.FragmentSolar, Main.rand.Next(50, 101)), 10);
                    CrystalBagPool.Add(new Point(ItemID.FragmentNebula, Main.rand.Next(50, 101)), 10);
                    CrystalBagPool.Add(new Point(ItemID.FragmentStardust, Main.rand.Next(50, 101)), 10);
                    CrystalBagPool.Add(new Point(ItemID.FragmentVortex, Main.rand.Next(50, 101)), 10);
                    break;
                case Progression.LateHM:
                    //Pumpkin Moon
                    CrystalBagPool.Add(new Point(ItemID.StakeLauncher, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.NecromanticScroll, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SpookyHook, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SpookyTwig, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.CursedSapling, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.TheHorsemansBlade, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.RavenStaff, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.BatScepter, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.CandyCornRifle, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.JackOLanternLauncher, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.BlackFairyDust, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SpiderEgg, 1), 10);
                    //Frost Moon
                    CrystalBagPool.Add(new Point(ItemID.ChristmasTreeSword, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Razorpine, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.FestiveWings, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.ChristmasHook, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.EldMelter, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.ChainGun, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.BlizzardStaff, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.NorthPole, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SnowmanCannon, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.BabyGrinchMischiefWhistle, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.ReindeerBells, 1), 10);
                    //DF
                    CrystalBagPool.Add(new Point(ItemID.BubbleGun, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Flairon, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.RazorbladeTyphoon, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.TempestStaff, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Tsunami, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.FishronWings, 1), 10);
                    //Betsy
                    CrystalBagPool.Add(new Point(3859, 1), 10);//Aerial Bane
                    CrystalBagPool.Add(new Point(3858, 1), 10);//Sky Dragon's Fury
                    CrystalBagPool.Add(new Point(3870, 1), 10);//Betsy's Wrath
                    CrystalBagPool.Add(new Point(3827, 1), 10);//Flying Dragon
                    CrystalBagPool.Add(new Point(ItemID.BetsyWings, 1), 10);
                    break;
                case Progression.MidHM:
                    //HM Dungeon
                    CrystalBagPool.Add(new Point(ItemID.BoneFeather, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Keybrand, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.WispinaBottle, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.MagnetSphere, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.ShadowbeamStaff, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.RocketLauncher, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.PaladinsHammer, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.PaladinsShield, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SpectreStaff, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.RifleScope, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SniperRifle, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.InfernoFork, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.TacticalShotgun, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Tabi, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.BlackBelt, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Ectoplasm, Main.rand.Next(30, 61)), 10);

                    //Plantera
                    CrystalBagPool.Add(new Point(ItemID.GrenadeLauncher, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.VenusMagnum, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.NettleBurst, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.LeafBlower, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.FlowerPow, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.WaspGun, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Seedler, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.PygmyStaff, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.ThornHook, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.TheAxe, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Seedling, 1), 10);

                    //Golem
                    CrystalBagPool.Add(new Point(ItemID.Picksaw, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.PossessedHatchet, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SunStone, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.EyeoftheGolem, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.HeatRay, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.StaffofEarth, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.GolemFist, 1), 10);

                    break;
                case Progression.PostMech:
                    //Mech Bosses
                    CrystalBagPool.Add(new Point(ItemID.LightDisc, 5), 10);
                    CrystalBagPool.Add(new Point(ItemID.Megashark, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.PickaxeAxe, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.MagicalHarp, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.FairyBell, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.OpticStaff, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.RainbowRod, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Flamethrower, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.AvengerEmblem, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.HallowedBar, Main.rand.Next(30, 61)), 10);

                    //Chloro
                    CrystalBagPool.Add(new Point(ItemID.LifeFruit, Main.rand.Next(2, 5)), 20);
                    CrystalBagPool.Add(new Point(ItemID.ChlorophyteBar, Main.rand.Next(30, 61)), 20);

                    //Mimics
                    CrystalBagPool.Add(new Point(ItemID.DualHook, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.MagicDagger, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.TitanGlove, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.PhilosophersStone, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.CrossNecklace, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.StarCloak, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Frostbrand, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.IceBow, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.FlowerofFrost, 1), 10);

                    CrystalBagPool.Add(new Point(ItemID.DartRifle, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.DartPistol, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.WormHook, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.TendonHook, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.ChainGuillotines, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.FetidBaghnakhs, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.ClingerStaff, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SoulDrain, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.PutridScent, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.FleshKnuckles, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.DaedalusStormbow, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.IlluminantHook, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.FlyingKnife, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.CrystalVileShard, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.BlessedApple, 1), 10);
                    break;

                case Progression.EarlyHM:
                    //WoF
                    CrystalBagPool.Add(new Point(ItemID.Pwnhammer, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.BreakerBlade, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.ClockworkAssaultRifle, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.LaserRifle, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.WarriorEmblem, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SorcererEmblem, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.RangerEmblem, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SummonerEmblem, 1), 10);

                    //Mimics
                    CrystalBagPool.Add(new Point(ItemID.DualHook, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.MagicDagger, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.TitanGlove, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.PhilosophersStone, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.CrossNecklace, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.StarCloak, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Frostbrand, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.IceBow, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.FlowerofFrost, 1), 10);

                    CrystalBagPool.Add(new Point(ItemID.DartRifle, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.DartPistol, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.WormHook, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.TendonHook, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.ChainGuillotines, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.FetidBaghnakhs, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.ClingerStaff, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SoulDrain, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.PutridScent, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.FleshKnuckles, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.DaedalusStormbow, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.IlluminantHook, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.FlyingKnife, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.CrystalVileShard, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.BlessedApple, 1), 10);

                    //Bars
                    CrystalBagPool.Add(new Point(ItemID.CobaltBar, Main.rand.Next(30, 61)), 20);
                    CrystalBagPool.Add(new Point(ItemID.MythrilBar, Main.rand.Next(30, 61)), 20);
                    CrystalBagPool.Add(new Point(ItemID.AdamantiteBar, Main.rand.Next(30, 61)), 20);
                    CrystalBagPool.Add(new Point(ItemID.PalladiumBar, Main.rand.Next(30, 61)), 20);
                    CrystalBagPool.Add(new Point(ItemID.OrichalcumBar, Main.rand.Next(30, 61)), 20);
                    CrystalBagPool.Add(new Point(ItemID.TitaniumBar, Main.rand.Next(30, 61)), 20);

                    break;
                case Progression.LatePreHM:
                    //Dungeon Loot
                    CrystalBagPool.Add(new Point(ItemID.BookofSkulls, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SkeletronHand, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Handgun, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.AquaScepter, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.MagicMissile, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.BlueMoon, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.CobaltShield, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Muramasa, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.ShadowKey, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Valor, 1), 10);

                    //Underworld Loot
                    CrystalBagPool.Add(new Point(ItemID.Sunfury, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.FlowerofFire, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Flamelash, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.DarkLance, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.HellwingBow, 1), 10);

                    break;
                case Progression.MidPreHM:
                    //Queen Bee
                    CrystalBagPool.Add(new Point(ItemID.BeeGun, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.BeeKeeper, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.BeesKnees, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.HoneyComb, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Nectar, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.HoneyedGoggles, 1), 5);
                    CrystalBagPool.Add(new Point(ItemID.BeeWax, Main.rand.Next(25, 51)), 10);
                    CrystalBagPool.Add(new Point(ItemID.Beenade, Main.rand.Next(200, 401)), 10);

                    //World Evil Boss
                    CrystalBagPool.Add(new Point(ItemID.ShadowScale, Main.rand.Next(25, 51)), 10);
                    CrystalBagPool.Add(new Point(ItemID.TissueSample, Main.rand.Next(25, 51)), 10);
                    break;
                case Progression.EarlyPreHM:
                    //King Slime
                    CrystalBagPool.Add(new Point(ItemID.SlimySaddle, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SlimeHook, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.KingSlimeMask, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.SlimeGun, 1), 10);

                    //EoC
                    CrystalBagPool.Add(new Point(ItemID.EoCShield, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.DemoniteBar, Main.rand.Next(35, 60)), 10);
                    CrystalBagPool.Add(new Point(ItemID.CrimtaneBar, Main.rand.Next(35, 60)), 10);
                    break;
                case Progression.PreBoss:
                    //Shadow Orb
                    CrystalBagPool.Add(new Point(ItemID.ShadowOrb, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Musket, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.Vilethorn, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.BallOHurt, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.BandofStarpower, 1), 10);

                    //Crimson Heart
                    CrystalBagPool.Add(new Point(ItemID.TheUndertaker, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.CrimsonHeart, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.PanicNecklace, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.CrimsonRod, 1), 10);
                    CrystalBagPool.Add(new Point(ItemID.TheRottedFork, 1), 10);

                    break;
                default:
                    break;
            }
        }

        public static void GildedBagInit()
        {
            GildedBagPool.Clear();

            GildedBagPool.Add(new Point(ModContent.ItemType<LuckyHorn>(), 1), 20);
            switch (GetProgression())
            {
                case Progression.PostML:
                    //ML
                    GildedBagPool.Add(new Point(ItemID.Meowmere, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.Terrarian, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.StarWrath, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.SDMG, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.LastPrism, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.LunarFlareBook, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.RainbowCrystalStaff, 1), 10);
                    GildedBagPool.Add(new Point(3569, 1), 10); //LunarPortalStaff
                    GildedBagPool.Add(new Point(ItemID.FireworksLauncher, 1), 10); //Celebration
                    GildedBagPool.Add(new Point(ItemID.LunarBar, Main.rand.Next(50, 101)), 10);
                    //Fragments
                    GildedBagPool.Add(new Point(ItemID.FragmentSolar, Main.rand.Next(50, 101)), 10);
                    GildedBagPool.Add(new Point(ItemID.FragmentNebula, Main.rand.Next(50, 101)), 10);
                    GildedBagPool.Add(new Point(ItemID.FragmentStardust, Main.rand.Next(50, 101)), 10);
                    GildedBagPool.Add(new Point(ItemID.FragmentVortex, Main.rand.Next(50, 101)), 10);
                    break;
                case Progression.LateHM:
                    //ML
                    GildedBagPool.Add(new Point(ItemID.Meowmere, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.Terrarian, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.StarWrath, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.SDMG, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.LastPrism, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.LunarFlareBook, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.RainbowCrystalStaff, 1), 10);
                    GildedBagPool.Add(new Point(3569, 1), 10); //LunarPortalStaff
                    GildedBagPool.Add(new Point(ItemID.FireworksLauncher, 1), 10); //Celebration
                    GildedBagPool.Add(new Point(ItemID.LunarBar, Main.rand.Next(50, 101)), 10);
                    //Fragments
                    GildedBagPool.Add(new Point(ItemID.FragmentSolar, Main.rand.Next(50, 101)), 10);
                    GildedBagPool.Add(new Point(ItemID.FragmentNebula, Main.rand.Next(50, 101)), 10);
                    GildedBagPool.Add(new Point(ItemID.FragmentStardust, Main.rand.Next(50, 101)), 10);
                    GildedBagPool.Add(new Point(ItemID.FragmentVortex, Main.rand.Next(50, 101)), 10);
                    break;
                case Progression.MidHM:
                    //Pumpkin Moon
                    GildedBagPool.Add(new Point(ItemID.StakeLauncher, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.NecromanticScroll, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.SpookyHook, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.TheHorsemansBlade, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.RavenStaff, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.BatScepter, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.CandyCornRifle, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.JackOLanternLauncher, 1), 10);
                    //Frost Moon
                    GildedBagPool.Add(new Point(ItemID.ChristmasTreeSword, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.Razorpine, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.EldMelter, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.ChainGun, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.BlizzardStaff, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.NorthPole, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.SnowmanCannon, 1), 10);
                    //DF
                    GildedBagPool.Add(new Point(ItemID.BubbleGun, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.Flairon, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.RazorbladeTyphoon, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.TempestStaff, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.Tsunami, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.FishronWings, 1), 10);
                    //Betsy
                    GildedBagPool.Add(new Point(3859, 1), 10);//Aerial Bane
                    GildedBagPool.Add(new Point(3858, 1), 10);//Sky Dragon's Fury
                    GildedBagPool.Add(new Point(3870, 1), 10);//Betsy's Wrath
                    GildedBagPool.Add(new Point(3827, 1), 10);//Flying Dragon
                    break;
                case Progression.PostMech:
                    //HM Dungeon
                    GildedBagPool.Add(new Point(ItemID.Keybrand, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.MagnetSphere, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.ShadowbeamStaff, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.RocketLauncher, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.PaladinsHammer, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.PaladinsShield, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.SpectreStaff, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.RifleScope, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.SniperRifle, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.InfernoFork, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.TacticalShotgun, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.Tabi, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.BlackBelt, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.Ectoplasm, Main.rand.Next(30, 61)), 10);

                    //Plantera
                    GildedBagPool.Add(new Point(ItemID.GrenadeLauncher, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.VenusMagnum, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.NettleBurst, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.LeafBlower, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.FlowerPow, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.WaspGun, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.Seedler, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.PygmyStaff, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.TheAxe, 1), 10);

                    //Golem
                    GildedBagPool.Add(new Point(ItemID.PossessedHatchet, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.SunStone, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.EyeoftheGolem, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.HeatRay, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.GolemFist, 1), 10);
                    break;

                case Progression.EarlyHM:
                    //Mech Bosses
                    GildedBagPool.Add(new Point(ItemID.LightDisc, 5), 10);
                    GildedBagPool.Add(new Point(ItemID.Megashark, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.MagicalHarp, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.OpticStaff, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.RainbowRod, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.Flamethrower, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.AvengerEmblem, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.HallowedBar, Main.rand.Next(30, 61)), 10);

                    //Chloro
                    GildedBagPool.Add(new Point(ItemID.LifeFruit, Main.rand.Next(2, 5)), 20);
                    GildedBagPool.Add(new Point(ItemID.ChlorophyteBar, Main.rand.Next(30, 61)), 20);

                    break;
                case Progression.LatePreHM:
                    //WoF
                    GildedBagPool.Add(new Point(ItemID.ClockworkAssaultRifle, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.LaserRifle, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.WarriorEmblem, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.SorcererEmblem, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.RangerEmblem, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.SummonerEmblem, 1), 10);

                    //Mimics
                    GildedBagPool.Add(new Point(ItemID.DualHook, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.MagicDagger, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.TitanGlove, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.PhilosophersStone, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.CrossNecklace, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.Frostbrand, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.IceBow, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.FlowerofFrost, 1), 10);

                    GildedBagPool.Add(new Point(ItemID.DartRifle, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.DartPistol, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.ChainGuillotines, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.FetidBaghnakhs, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.ClingerStaff, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.SoulDrain, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.PutridScent, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.FleshKnuckles, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.DaedalusStormbow, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.FlyingKnife, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.CrystalVileShard, 1), 10);

                    break;
                case Progression.MidPreHM:
                    //Dungeon Loot
                    GildedBagPool.Add(new Point(ItemID.BookofSkulls, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.Handgun, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.AquaScepter, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.MagicMissile, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.BlueMoon, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.CobaltShield, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.Muramasa, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.ShadowKey, 1), 10);

                    //Underworld Loot
                    GildedBagPool.Add(new Point(ItemID.Sunfury, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.FlowerofFire, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.Flamelash, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.DarkLance, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.HellwingBow, 1), 10);
                    break;
                case Progression.EarlyPreHM:
                    //Queen Bee
                    GildedBagPool.Add(new Point(ItemID.BeeGun, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.BeeKeeper, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.BeesKnees, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.HoneyComb, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.HoneyedGoggles, 1), 5);
                    GildedBagPool.Add(new Point(ItemID.BeeWax, Main.rand.Next(25, 51)), 10);
                    GildedBagPool.Add(new Point(ItemID.Beenade, Main.rand.Next(200, 401)), 10);

                    //World Evil Boss
                    GildedBagPool.Add(new Point(ItemID.ShadowScale, Main.rand.Next(25, 51)), 10);
                    GildedBagPool.Add(new Point(ItemID.TissueSample, Main.rand.Next(25, 51)), 10);
                    break;
                case Progression.PreBoss:
                    //King Slime
                    GildedBagPool.Add(new Point(ItemID.SlimySaddle, 1), 10);

                    //EoC
                    GildedBagPool.Add(new Point(ItemID.EoCShield, 1), 10);
                    GildedBagPool.Add(new Point(ItemID.DemoniteBar, Main.rand.Next(35, 60)), 10);
                    GildedBagPool.Add(new Point(ItemID.CrimtaneBar, Main.rand.Next(35, 60)), 10);
                    break;
                default:
                    break;
            }
        }

        public static void ArcaneBagInit()
        {
            ArcaneBagPool.Clear();

            ArcaneBagPool.Add(new Point(ModContent.ItemType<LuckyStar>(), 1), 20);
            ArcaneBagPool.Add(new Point(ItemID.RodofDiscord, 1), 10);
            ArcaneBagPool.Add(new Point(ItemID.SlimeStaff, 1), 10);
            ArcaneBagPool.Add(new Point(ItemID.RainbowBrick, 999), 10);
            ArcaneBagPool.Add(new Point(ItemID.FrozenTurtleShell, 1), 10);
            ArcaneBagPool.Add(new Point(ItemID.CelestialMagnet, 1), 10);
            ArcaneBagPool.Add(new Point(ItemID.AnkhCharm, 1), 10);
            ArcaneBagPool.Add(new Point(ItemID.CelestialStone, 1), 10);
            ArcaneBagPool.Add(new Point(ItemID.ArchitectGizmoPack, 1), 10);
            ArcaneBagPool.Add(new Point(ItemID.AnglerTackleBag, 1), 10);
            ArcaneBagPool.Add(new Point(ItemID.CoinRing, 1), 10);
            ArcaneBagPool.Add(new Point(ItemID.LuckyCoin, 1), 10);
            ArcaneBagPool.Add(new Point(ItemID.DiscountCard, 1), 10);
            ArcaneBagPool.Add(new Point(ItemID.WormScarf, 1), 10);
            ArcaneBagPool.Add(new Point(ItemID.ShinyStone, 1), 10);
            ArcaneBagPool.Add(new Point(ItemID.ShrimpyTruffle, 1), 10);
        }
        #endregion

        #region Progression
        public static Progression GetProgression()
        {
            if (NPC.downedMoonlord)
                return Progression.PostML;
            if (NPC.downedChristmasIceQueen || NPC.downedHalloweenKing || NPC.downedFishron || NPC.downedAncientCultist)
                return Progression.LateHM;
            if (NPC.downedPlantBoss)
                return Progression.MidHM;
            if (NPC.downedMechBoss1 || NPC.downedMechBoss2 || NPC.downedMechBoss3)
                return Progression.PostMech;
            if (Main.hardMode)
                return Progression.EarlyHM;
            if (Main.LocalPlayer.statLifeMax == 400 || NPC.downedBoss3)
                return Progression.LatePreHM;
            if (Main.LocalPlayer.statLifeMax >= 300 || NPC.downedQueenBee || NPC.downedBoss2)
                return Progression.MidPreHM;
            if (Main.LocalPlayer.statLifeMax >= 200 || NPC.downedBoss1 || NPC.downedSlimeKing)
                return Progression.EarlyPreHM;
            return Progression.PreBoss;
        }

        public static Progression GetNextProgression(Progression progression)
        {
            switch(progression)
            {
                case Progression.PreBoss:
                    return Progression.EarlyPreHM;
                case Progression.EarlyPreHM:
                    return Progression.MidPreHM;
                case Progression.MidPreHM:
                    return Progression.LatePreHM;
                case Progression.LatePreHM:
                    return Progression.EarlyHM;
                case Progression.EarlyHM:
                    return Progression.PostMech;
                case Progression.PostMech:
                    return Progression.MidHM;
                case Progression.MidHM:
                    return Progression.LateHM;
                case Progression.LateHM:
                    return Progression.PostML;
                case Progression.PostML:
                    return Progression.PostML;
                default:
                    return Progression.PreBoss;
            }
        }
        #endregion

        public static bool TileCheckSafe(int x, int y)
        {
            return x >= 0 && x < Main.maxTilesX && y >= 0 && y < Main.maxTilesY;
        }

        public static WeightedRandom<int> FishPool { get; set; } = new WeightedRandom<int>();
        public static WeightedRandom<Point> LuckyBagPool { get; set; } = new WeightedRandom<Point>();
        public static WeightedRandom<Point> CloverBagPool { get; set; } = new WeightedRandom<Point>();
        public static WeightedRandom<Point> CrystalBagPool { get; set; } = new WeightedRandom<Point>();
        public static WeightedRandom<Point> ArcaneBagPool { get; set; } = new WeightedRandom<Point>();
        public static WeightedRandom<Point> GildedBagPool { get; set; } = new WeightedRandom<Point>();
    }

    public enum Progression
    {
        PreBoss,
        EarlyPreHM,
        MidPreHM,
        LatePreHM,
        EarlyHM,
        PostMech,
        MidHM,
        LateHM,
        PostML
    }
}
