using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace LuckyRunes
{
    public class RuneWorld : ModWorld
    {

        public override void Initialize()
        {
            ArcaneTiles = 0;
        }

        public override void TileCountsAvailable(int[] tileCounts)
        {
            ArcaneTiles = tileCounts[ModContent.TileType<Tiles.ArcaneOreTile>()];
        }

        public static int ArcaneTiles { get; set; }
    }
}
