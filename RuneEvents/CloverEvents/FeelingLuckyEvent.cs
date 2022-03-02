using LuckyRunes.Items.Accessories;
using LuckyRunes.Items.Bags;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class FeelingLuckyEvent : PlayerEvent
    {
        public override string Name => "Feeling Lucky";
        public override string Message => "A clover!";
        public override float Impact => 3.9f;
        public override float Alignment => .5f;

        public override void PlayerEffect(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<LuckyClover>());
        }
    }
}