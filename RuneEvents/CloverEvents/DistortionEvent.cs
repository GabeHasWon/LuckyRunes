using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class DistortionEvent : PlayerEvent
    {
        public override string Name => "Wocky Slush";
        public override string Message => "You're Distorted!";
        public override float Impact => 3f;
        public override float Alignment => -0.1f;

        public override void PlayerEffect(Player player) => player.AddBuff(BuffID.VortexDebuff, 30 * 60);
    }
}
