using System;
using Terraria;
using Terraria.ID;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class CaughtFishEvent : PlayerEvent
    {
        public override string Name => "I Caught a Fish!";
        public override string Message => "Catch a random fish";
        public override float Impact => 1.1f;

        public override void PlayerEffect(Player player)
        {
            Main.PlaySound(SoundID.Splash, player.Center, 1);
            player.QuickSpawnItem(RuneControl.FishPool.Get());
        }
    }
}