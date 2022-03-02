using LuckyRunes.Items.Bags;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class GetCloverLuckyEvent : PlayerEvent
    {
        public override string Name => "4 Leaves";
        public override string Message => "Get 4 Clover loot bags!";
        public override float Impact => 3.9f;
        public override float Alignment => .8f;
        public override float Weight => 1.5f;
        public override void PlayerEffect(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<CloverBag>());
            player.QuickSpawnItem(ModContent.ItemType<CloverBag>());
            player.QuickSpawnItem(ModContent.ItemType<CloverBag>());
            player.QuickSpawnItem(ModContent.ItemType<CloverBag>());
        }
    }
}