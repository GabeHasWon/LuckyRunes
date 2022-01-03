using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckyRunes.Items.Accessories
{
    public class LuckyClover : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lucky Clover");
            Tooltip.SetDefault("Get an extra item from Lucky Bags");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.buyPrice(gold: 5);
            item.rare = ItemRarityID.Green;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<RunePlayer>().BagRolls++;
        }
    }
}
