using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;


namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class LavaPit : PlayerEvent
    {
        public override string Name => "Lava Pit";
        public override string Message => "A nice warm bath";
        public override float Impact => 4.95f;
        public override bool Destructive => true;
        public override float Chaos => 0.3f;
        public override float Alignment => -0.5f;

        public override void PlayerEffect(Player player)
        {
            int x = (int)Math.Round(player.Center.X / 16);
            int y = (int)Math.Round(player.Center.Y / 16);

            for (int i = Math.Max(0, x - 5); i < Main.tile.GetLength(0) - 1 && i <= x + 5 && i < Main.maxTilesX; i++)
            {
                for (int j = Math.Max(0, y); j < Main.tile.GetLength(1) - 1 && j <= y + 40 && j < Main.maxTilesY; j++)
                {
                    if(i == Math.Max(0, x - 5) || i == x + 5 || j == y + 40)
                    {
                        WorldGen.KillTile(i, j);
                        WorldGen.PlaceTile(i, j, TileID.ObsidianBrick, true, true);
                    }
                    else
                    {
                        WorldGen.KillTile(i, j);
                        if(j > y + 30)
                        {
                            Main.tile[i, j].lava(true);
                            Main.tile[i, j].liquid = 255;
                        }
                    }
                }
            }
        }
    }
}
