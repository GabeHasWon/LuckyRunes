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

namespace LuckyRunes.Items.Bags
{
    public class CrystalBag : BagItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Bag");
            Tooltip.SetDefault("Get some lucky loot!");
        }

        public override void SetRarityValue()
        {
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.LightRed;
        }

        public override void RightClick(Player player)
        {
            for (int i = 0; i < player.GetModPlayer<RunePlayer>().BagRolls; i++)
            {
                RuneControl.CrystalBagInit();
                Point point = RuneControl.CrystalBagPool.Get();
                player.QuickSpawnItem(point.X, point.Y);
            }
        }
    }
}
