using Terraria;
using Terraria.ID;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class BirdplosionEvent : PlayerEvent
    {
        public override string Name => "Birdplosion";
        public override string Message => "A burst of birds!";
        public override float Impact => .5f;

        public override void PlayerEffect(Player player)
        {
            for (int i = 0; i < 20; i++)
            {
                int bird = GetBird();
                if (Main.netMode != NetmodeID.MultiplayerClient)
                    NPC.NewNPC((int)player.Center.X - 20 + Main.rand.Next(40), (int)player.Center.Y - 30 + Main.rand.Next(60), bird);
            }
        }

        private int GetBird()
        {
            WeightedRandom<int> wRand = new WeightedRandom<int>(Main.rand);
            wRand.Add(NPCID.Bird, 33);
            wRand.Add(NPCID.BirdBlue, 33);
            wRand.Add(NPCID.BirdRed, 33);
            wRand.Add(NPCID.GoldBird, 1);
            return wRand;
        }
    }
}