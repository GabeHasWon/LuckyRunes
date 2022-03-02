using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class StonedEvent : PlayerEvent
    {
        public override string Name => "Stoned";
        public override string Message => "So stoned right now";
        public override float Impact => 5.01f;
        public override float Alignment => -0.4f;

        public override void PlayerEffect(Player player) => player.AddBuff(BuffID.Stoned, 5 * 60);
    }
}
