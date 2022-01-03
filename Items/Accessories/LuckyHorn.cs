using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckyRunes.Items.Accessories
{
    public class LuckyHorn : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lucky Horn");
            Tooltip.SetDefault("Get an extra item from Lucky Bags");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.buyPrice(gold: 20);
            item.rare = ItemRarityID.Yellow;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<RunePlayer>().BagRolls++;
        }
    }
}
