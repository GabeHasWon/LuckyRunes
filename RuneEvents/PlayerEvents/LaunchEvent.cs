using Terraria;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    class LaunchEvent : PlayerEvent
    {
        public override string Name => "yeet";
        public override string Message => "weeeee";
        public override float Impact => 1f;

        public override void Effects()
        {
            base.Effects();
            Player p = GetPlayer();
            if (p != null)
                p.velocity.Y = -50;
        }
    }
}