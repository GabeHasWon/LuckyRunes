using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class GoldenShowerEvent : PlayerEvent
    {
        public override string Name => "Golden Shower";
        public override string Message => "Gold rain";
        public override float Impact => 4.1f;
        public override float Alignment => .5f;

        public override void PlayerEffect(Player player)
        {
            player.GetModPlayer<RunePlayer>().GoldRain = 20 * 60;
        }
    }
}
