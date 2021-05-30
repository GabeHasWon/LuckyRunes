using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckyRunes
{
    internal class CategoryLists
    {
        public static readonly HashSet<int> NaturalBlocks =
        new HashSet<int>
        {
            TileID.Dirt, TileID.Mud, TileID.Stone, TileID.ClayBlock, TileID.Grass, TileID.JungleGrass, TileID.MushroomGrass, TileID.Sand,
            TileID.Granite, TileID.Marble, TileID.Ebonstone, TileID.Crimstone, TileID.Silt, TileID.Ash, TileID.Sandstone, TileID.IceBlock, TileID.SnowBlock,
            TileID.HardenedSand, TileID.Pearlsand, TileID.Pearlstone, TileID.Crimsand, TileID.Ebonsand, TileID.CorruptHardenedSand, TileID.CrimsonHardenedSand,
            TileID.HallowHardenedSand, TileID.CorruptSandstone, TileID.CrimsonSandstone, TileID.HallowSandstone, TileID.BreakableIce, TileID.CorruptIce,
            TileID.FleshGrass, TileID.CorruptGrass, TileID.HallowedGrass, TileID.FleshIce, TileID.HallowedIce, TileID.Cloud, TileID.RainCloud, TileID.SnowCloud,
            TileID.Hellstone
        };

        public static readonly HashSet<int> OreBlocks =
        new HashSet<int>
        {
            TileID.Copper, TileID.Tin, TileID.Iron, TileID.Lead, TileID.Silver, TileID.Tungsten, TileID.Gold, TileID.Platinum
        };
    }
}
