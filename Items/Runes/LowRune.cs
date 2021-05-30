using Terraria;
using Terraria.ID;

namespace LuckyRunes.Items.Runes
{
    public class LowRune : RuneItem
    {
        public override float Impact { get => 3f; }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Clover Rune");
            Tooltip.SetDefault("Rolls an event with low impact");
        }

        public override void SetRarityValue()
        {
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Green;
        }
    }
}
