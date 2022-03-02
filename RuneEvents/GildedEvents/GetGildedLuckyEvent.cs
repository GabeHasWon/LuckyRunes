using LuckyRunes.Items.Bags;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class GetGildedLuckyEvent : PlayerEvent
    {
        public override string Name => "Golden Opportunity";
        public override string Message => "Get 3 Gilded Bags!";
        public override float Impact => 9.9f;
        public override float Alignment => .95f;

        public override void PlayerEffect(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<GildedBag>());
            player.QuickSpawnItem(ModContent.ItemType<GildedBag>());
            player.QuickSpawnItem(ModContent.ItemType<GildedBag>());
        }
    }
}