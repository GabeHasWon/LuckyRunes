using Terraria;
using Terraria.ID;

namespace LuckyRunes.Items.Runes
{
    public class MediumRune : RuneItem
    {
        public override float Impact { get => 5f; }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Rune");
            Tooltip.SetDefault("Rolls an event with medium impact");
        }

        public override void SetRarityValue()
        {
            item.value = Item.sellPrice(gold:1);
            item.rare = ItemRarityID.LightRed;
        }
    }
}
