using Terraria;
using Terraria.ID;

namespace LuckyRunes.Items.Runes
{
    public class VeryHighRune : RuneItem
    {
        public override float Impact { get => 9f; }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gilded Lucky Rune");
            Tooltip.SetDefault("Rolls an event with very high impact");
        }

        public override void SetRarityValue()
        {
            item.value = Item.sellPrice(gold: 5);
            item.rare = ItemRarityID.Yellow;
        }
    }
}
