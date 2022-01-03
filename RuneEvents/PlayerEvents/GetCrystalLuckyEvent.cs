using LuckyRunes.Items.Bags;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class GetCrystalLuckyEvent : PlayerEvent
    {
        public override string Name => "Get Crystal Lucky";
        public override string Message => "With a Crystal Bag!";
        public override float Impact => 5.9f;
        public override float Alignment => .65f;

        public override void PlayerEffect(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<CrystalBag>());
        }
    }
}