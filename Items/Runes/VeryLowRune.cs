using Terraria;
using Terraria.ID;

namespace LuckyRunes.Items.Runes
{
    public class VeryLowRune : RuneItem
    {
        public override float Impact { get => 1f; }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lucky Rune");
            Tooltip.SetDefault("Rolls an event with very low impact");
        }

        public override void SetRarityValue()
        {
            item.value = Item.sellPrice(silver:10);
            item.rare = ItemRarityID.Blue;
        }
    }
}
