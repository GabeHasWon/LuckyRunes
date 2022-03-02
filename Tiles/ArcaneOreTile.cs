using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes.Tiles
{
    public class ArcaneOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMerge[TileID.Dirt][ModContent.TileType<ArcaneOreTile>()] = true;
            Main.tileMerge[ModContent.TileType<ArcaneOreTile>()][TileID.Dirt] = true;
            AddMapEntry(new Color(225, 50, 225));
            Main.tileSpelunker[Type] = true;
            Main.tileLighted[Type] = true;
            mineResist = .5f;
            minPick = 120;
            dustType = 229;
            drop = ModContent.ItemType<Items.ArcaneOre>();
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}
