using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckyRunes.Items.Accessories
{
    public class LuckyStar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lucky Star");
            Tooltip.SetDefault("Get an extra item from Lucky Bags");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.buyPrice(gold: 15);
            item.rare = ItemRarityID.LightPurple;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<RunePlayer>().BagRolls++;
        }
    }
}
