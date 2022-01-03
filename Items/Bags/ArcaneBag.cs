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
    public class ArcaneBag : BagItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Bag");
            Tooltip.SetDefault("Get some lucky loot!");
        }

        public override void SetRarityValue()
        {
            item.value = Item.sellPrice(gold: 5);
            item.rare = ItemRarityID.LightPurple;
        }

        public override void RightClick(Player player)
        {
            for (int i = 0; i < player.GetModPlayer<RunePlayer>().BagRolls; i++)
            {
                RuneControl.ArcaneBagInit();
                Point point = RuneControl.ArcaneBagPool.Get();
                player.QuickSpawnItem(point.X, point.Y);
            }
        }
    }
}
