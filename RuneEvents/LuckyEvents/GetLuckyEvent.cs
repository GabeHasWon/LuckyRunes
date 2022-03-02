using LuckyRunes.Items.Bags;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class GetLuckyEvent : PlayerEvent
    {
        public override string Name => "Get Lucky";
        public override string Message => "With 3 Lucky Bags!";
        public override float Impact => 1.9f;
        public override float Alignment => .25f;

        public override void PlayerEffect(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<LuckyBag>());
            player.QuickSpawnItem(ModContent.ItemType<LuckyBag>());
            player.QuickSpawnItem(ModContent.ItemType<LuckyBag>());
        }
    }
}