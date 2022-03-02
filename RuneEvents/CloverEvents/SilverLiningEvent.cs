using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class SilverLiningEvent : PlayerEvent
    {
        public override string Name => "Silver Lining";
        public override string Message => "Silver rain";
        public override float Impact => 2.1f;
        public override float Alignment => .25f;

        public override void PlayerEffect(Player player)
        {
            player.GetModPlayer<RunePlayer>().SilverRain = 20 * 60;
        }
    }
}
