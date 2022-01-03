using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckyRunes.Items.Accessories
{
    public class LuckyCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lucky Crystal");
            Tooltip.SetDefault("Get an extra item from Lucky Bags");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.buyPrice(gold: 10);
            item.rare = ItemRarityID.LightRed;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<RunePlayer>().BagRolls++;
        }
    }
}
