using System;
using Terraria;
using Terraria.ID;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class GetALifeEvent : PlayerEvent
    {
        public override string Name => "Get a Life";
        public override string Message => "In a good way";
        public override float Impact => 5.3f;
        public override float Alignment => 0.8f;

        public override void PlayerEffect(Player player)
        {
            player.QuickSpawnItem(ItemID.LifeCrystal);
        }
    }
}