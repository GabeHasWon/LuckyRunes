using System;
using Terraria;
using Terraria.ID;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class CatchGarbageEvent : PlayerEvent
    {
        public override string Name => "I Caught a- oh...";
        public override string Message => "Catch some garbage";
        public override float Impact => .5f;

        public override void PlayerEffect(Player player)
        {
            Main.PlaySound(SoundID.Splash, player.Center, 1);
            player.QuickSpawnItem(GetRandomTrash());
        }
        public static int GetRandomTrash()
        {
            WeightedRandom<int> wRand = new WeightedRandom<int>();
                wRand.Add(ItemID.OldShoe, 10);
                wRand.Add(ItemID.Seaweed, 1);
                wRand.Add(ItemID.TinCan, 10);
                wRand.Add(ItemID.FishingSeaweed, 10);
            return wRand.Get();
        }
    }
}