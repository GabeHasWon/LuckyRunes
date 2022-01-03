using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class PocketChangeEvent : PlayerEvent
    {
        public override string Name => "Pocket Change";
        public override string Message => "Copper rain";
        public override float Impact => 0.1f;

        public override void PlayerEffect(Player player)
        {
            player.GetModPlayer<RunePlayer>().CopperRain = 20 * 60;
        }
    }
}
