using LuckyRunes.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckyRunes.RuneEvents.WorldEvents
{
    public class CelestialDisturbanceEvent : WorldEvent
    {
        public override string Name => "Celestial Disturbance";
        public override string Message => "A strange meteor has landed";
        public override float Impact => 7.99f;
        public override float Alignment => .8f;

        public override void WorldEffect()
        {
            WorldGen.spawnMeteor = false;
            WorldGen.dropMeteor();
            for (int i = 0; i < Main.tile.GetLength(0) && i < Main.maxTilesX; i++)
            {
                for (int j = 0; j < Main.tile.GetLength(1) && j < Main.maxTilesY; j++)
                {
                    if (Main.tile[i, j].type == TileID.Meteorite)
                        Main.tile[i, j].type = (ushort)ModContent.TileType<ArcaneOreTile>();
                }
            }
        }
    }
}
