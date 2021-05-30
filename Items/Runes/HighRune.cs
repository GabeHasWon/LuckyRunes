using Terraria;
using Terraria.ID;

namespace LuckyRunes.Items.Runes
{
    public class HighRune : RuneItem
    {
        public override float Impact { get => 7f; }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Lucky Rune");
            Tooltip.SetDefault("Rolls an event with high impact");
        }

        public override void SetRarityValue()
        {
            item.value = Item.sellPrice(gold: 2);
            item.rare = ItemRarityID.LightPurple;
        }
    }
}
