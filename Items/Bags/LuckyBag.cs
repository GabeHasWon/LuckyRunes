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
    public class LuckyBag : BagItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lucky Bag");
            Tooltip.SetDefault("Get some lucky loot!");
        }

        public override void SetRarityValue()
        {
            item.value = Item.sellPrice(silver: 10);
            item.rare = ItemRarityID.White;
        }

        public override void RightClick(Player player)
        {
            for (int i = 0; i < player.GetModPlayer<RunePlayer>().BagRolls; i++)
            {
                RuneControl.LuckyBagInit();
                Point point = RuneControl.LuckyBagPool.Get();
                player.QuickSpawnItem(point.X, point.Y);
            }
        }
    }
}
