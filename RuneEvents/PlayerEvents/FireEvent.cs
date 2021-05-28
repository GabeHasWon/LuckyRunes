using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class FireEvent : PlayerEvent
    {
        public override string Name => "On Fire!";
        public override string Message => "You're on fire!";
        public override float Impact => 1f;

        public override void Effects()
        {
            Player p = GetPlayer();
            if (p != null)
            {
                base.Effects();
                p.AddBuff(BuffID.OnFire, 200);
            }
        }
    }
}
