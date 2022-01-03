using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckyRunes.Items.Bags
{
    public abstract class BagItem : ModItem
    {
        public sealed override void SetDefaults()
        {
            item.width = 26;
            item.height = 30;
            item.maxStack = 99;
            item.consumable = true;
            SetRarityValue();
        }

        public override bool CanUseItem(Player player)
        {
            return false;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public abstract void SetRarityValue();
    }
}
