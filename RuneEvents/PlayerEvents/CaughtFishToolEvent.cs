using System;
using Terraria;
using Terraria.ID;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class CaughtFishToolEvent : PlayerEvent
    {
        public override string Name => "I Caught a Fish?";
        public override string Message => "Catch a fish tool or wooden/iron crate";
        public override float Impact => 2.5f;
        public override float Alignment => 0.1f;

        public override void PlayerEffect(Player player)
        {
            Main.PlaySound(SoundID.Splash, player.Center, 1);
            player.QuickSpawnItem(GetCatch());
        }
        private int GetCatch()
        {
            WeightedRandom<int> wRand = new WeightedRandom<int>();
                wRand.Add(ItemID.Rockfish, 15);
                wRand.Add(ItemID.SawtoothShark, 15);
                wRand.Add(ItemID.Swordfish, 15);
                wRand.Add(ItemID.ReaverShark, 15);
                wRand.Add(ItemID.WoodenCrate, 20);
                wRand.Add(ItemID.IronCrate, 5);
            return wRand.Get();
        }
    }
}