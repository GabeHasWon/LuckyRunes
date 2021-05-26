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

        public override bool CanHandleMessage(Viewer viewer, string message, int bits) => bits >= 50;

        public override void HandleMessage(Viewer viewer, string message, int bits)
        {
            int heal = bits / 5;
            Player player = ChoosePlayer();
            if (player != null)
            {
                player.HealEffect(heal);
                player.statLife += heal;
                if (player.statLife > player.statLifeMax2)
                    player.statLife = player.statLifeMax2;
            }
        }
    }
}
