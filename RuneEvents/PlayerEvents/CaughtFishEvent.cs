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
        public override float Impact => 2f;

        public override void PlayerEffect(Player player)
        {
            Main.PlaySound(SoundID.Splash, player.Center, 1);
            player.QuickSpawnItem(GetCatch());
        }
        private int GetCatch()
        {
            WeightedRandom<int> wRand = new WeightedRandom<int>();
                wRand.Add(ItemID.ArmoredCavefish, 1);
                wRand.Add(ItemID.AtlanticCod, 2);
                wRand.Add(ItemID.Bass, 2);
                wRand.Add(ItemID.ChaosFish, 1);
                wRand.Add(ItemID.CrimsonTigerfish, 1);
                wRand.Add(ItemID.Damselfish, 1);
                wRand.Add(ItemID.DoubleCod, 1);
                wRand.Add(ItemID.Ebonkoi, 1);
                wRand.Add(ItemID.FlarefinKoi, 1);
                wRand.Add(ItemID.FrostMinnow, 1);
                wRand.Add(ItemID.GoldenCarp, 1);
                wRand.Add(ItemID.Hemopiranha, 1);
                wRand.Add(ItemID.NeonTetra, 2);
                wRand.Add(ItemID.Obsidifish, 1);
                if(Main.hardMode)
                {
                    wRand.Add(ItemID.PrincessFish, 1);
                    wRand.Add(ItemID.Prismite, 1);
                }
                wRand.Add(ItemID.RedSnapper, 2);
                wRand.Add(ItemID.Salmon, 2);
                wRand.Add(ItemID.Shrimp, 2);
                wRand.Add(ItemID.SpecularFish, 1);
                wRand.Add(ItemID.Stinkfish, 1);
                wRand.Add(ItemID.Trout, 2);
                wRand.Add(ItemID.Tuna, 2);
                wRand.Add(ItemID.VariegatedLardfish, 1);
            return wRand.Get();
        }
    }
}