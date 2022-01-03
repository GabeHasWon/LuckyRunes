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
        public override string Name => "Get Clover Lucky";
        public override string Message => "With a Clover Bag!";
        public override float Impact => 3.9f;
        public override float Alignment => .5f;

        public override void PlayerEffect(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<CloverBag>());
        }
    }
}