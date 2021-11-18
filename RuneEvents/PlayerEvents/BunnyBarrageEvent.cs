using System;
using Terraria;
using Terraria.ID;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class BunnyBarrageEvent : PlayerEvent
    {
        public override string Name => "Bunny Barrage";
        public override string Message => "A burst of bunnies!";
        public override float Impact => .5f;

        public override void PlayerEffect(Player player)
        {
            for (int i = 0; i < 20; i++)
            {
                int bunny = GetBunny();
                if (Main.netMode != NetmodeID.MultiplayerClient)
                {
                    int npc = NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, bunny);
                    double theta = (1 + Main.rand.NextDouble()) * Math.PI;
                    float mag = 8 + (float)Main.rand.NextDouble() * 8;
                    Main.npc[npc].velocity.X = (float)Math.Cos(theta) * mag;
                    Main.npc[npc].velocity.Y = (float)Math.Sin(theta) * mag;
                }
            }
        }

        private int GetBunny()
        {
            WeightedRandom<int> wRand = new WeightedRandom<int>(Main.rand);
            wRand.Add(NPCID.Bunny, 99);
            wRand.Add(NPCID.GoldBunny, 1);
            return wRand;
        }
    }
}