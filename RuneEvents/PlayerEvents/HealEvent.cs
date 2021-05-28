using Microsoft.Xna.Framework;
using ProjectT;
using Terraria;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    /// <summary>A simple event which simply heals a player if bits > 50 are donated.</summary>
    class HealEvent : PlayerEvent
    {
        public override string Name => "Heal";
        public override string Message => "You get healed!";
        public override float Impact => 1f;

        public override void Effects()
        {
            Player player = GetPlayer();
            if (player != null)
            {
                base.Effects();
                player.HealEffect(20);
                player.statLife += 20;
                if (player.statLife > player.statLifeMax2)
                    player.statLife = player.statLifeMax2;
            }
        }
    }
}
