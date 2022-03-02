using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class FishRainEvent : PlayerEvent
    {
        public override string Name => "Fish Rain";
        public override string Message => "It's raining fish, hallelujah";
        public override float Impact => 2.5f;
        public override float Alignment => 0f;

        public override void PlayerEffect(Player player)
        {
            player.GetModPlayer<RunePlayer>().RainingFish = 20 * 60;
        }
    }
}
