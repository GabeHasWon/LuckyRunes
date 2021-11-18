using Terraria;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    class LaunchEvent : PlayerEvent
    {
        public override string Name => "yeet";
        public override string Message => "weeeee";
        public override float Impact => 1f;
        public override float Chaos => 0.1f;

        public override void PlayerEffect(Player player) => player.velocity.Y = -50;
    }
}