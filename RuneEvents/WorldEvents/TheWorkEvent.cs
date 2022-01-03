using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.WorldEvents
{
    public class TheWorkEvent : WorldEvent
    {
        public override string Name => "The Work";
        public override string Message => "Complete the Work";
        public override float Impact => 9.99f;
        public override bool Destructive => true;
        public override float Chaos => 0.9f;
        public override float Alignment => -0.5f;

        public override void WorldEffect()
        {
            for (int i = 0; i < Main.tile.GetLength(0) && i < Main.maxTilesX; i++)
            {
                for (int j = 0; j < Main.tile.GetLength(1) && j < Main.maxTilesY; j++)
                {
                    if ((CategoryLists.NaturalBlocks.Contains(Main.tile[i, j].type) || CategoryLists.OreBlocks.Contains(Main.tile[i, j].type)) && Vector2.Distance(new Vector2(i, j), new Vector2(Main.spawnTileX, Main.spawnTileY)) < Main.maxTilesX / 4)
                        Main.tile[i, j].type = TileID.Gold;
                }
            }
        }
    }
}
