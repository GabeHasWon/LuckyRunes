using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckyRunes.Items
{
    public class EventTester : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("test evnt.");
        }

        public override void SetDefaults()
        {
            item.damage = 120;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 2;
            item.useAnimation = 2;
            item.maxStack = 50;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void OnCraft(Recipe recipe)
        {
        }

        public override bool UseItem(Player player)
        {
            var ev = RuneManager.GetEvent(1f);
            if (ev != null)
                ev.Effects();
            return true;
        }
    }
}