using System;
using Terraria;
using Terraria.ID;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class HaveASeatEvent : PlayerEvent
    {
        public override string Name => "Have a Seat";
        public override string Message => ":)";
        public override float Impact => 0.3f;

        public override void PlayerEffect(Player player)
        {
            player.QuickSpawnItem(ItemID.CactusChair);
        }
    }
}