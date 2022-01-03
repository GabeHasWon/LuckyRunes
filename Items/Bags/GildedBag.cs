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
    public class GildedBag : BagItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gilded Bag");
            Tooltip.SetDefault("Get some lucky loot!");
        }

        public override void SetRarityValue()
        {
            item.value = Item.sellPrice(gold: 10);
            item.rare = ItemRarityID.Yellow;
        }

        public override void RightClick(Player player)
        {
            for (int i = 0; i < player.GetModPlayer<RunePlayer>().BagRolls; i++)
            {
                RuneControl.GildedBagInit();
                Point point = RuneControl.GildedBagPool.Get();
                player.QuickSpawnItem(point.X, point.Y);
            }
        }
    }
}
