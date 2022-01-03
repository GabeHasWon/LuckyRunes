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
    public class CloverBag : BagItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Clover Bag");
            Tooltip.SetDefault("Get some lucky loot!");
        }

        public override void SetRarityValue()
        {
            item.value = Item.sellPrice(gold: 1);
            item.rare = ItemRarityID.Green;
        }

        public override void RightClick(Player player)
        {
            for (int i = 0; i < player.GetModPlayer<RunePlayer>().BagRolls; i++)
            {
                RuneControl.CloverBagInit();
                Point point = RuneControl.CloverBagPool.Get();
                player.QuickSpawnItem(point.X, point.Y);
            }
        }
    }
}
