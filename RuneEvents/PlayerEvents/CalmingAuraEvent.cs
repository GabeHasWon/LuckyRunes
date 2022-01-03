using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class CalmingAuraEvent : PlayerEvent
    {
        public override string Name => "A Calming Aura";
        public override string Message => "You feel blessed!";
        public override float Impact => 3.01f;
        public override float Alignment => 0.4f;

        public override void PlayerEffect(Player player) => player.AddBuff(BuffID.DryadsWard, 2 * 60 * 60);
    }
}
