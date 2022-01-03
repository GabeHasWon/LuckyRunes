using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class GetProbedEvent : PlayerEvent
    {
        public override string Name => "Get Probed";
        public override string Message => "By a spaceship of course";
        public override float Impact => 7.5f;
        public override float Alignment => -0.4f;
        public override bool Condition => NPC.downedPlantBoss;

        public override void PlayerEffect(Player player)
        {
            double theta =  Math.PI * Main.rand.NextDouble();
            float mag = 300;
            NPC.NewNPC((int)(player.Center.X + (mag * Math.Cos(theta))), (int)(player.Center.Y - (mag * Math.Sin(theta))), NPCID.MartianProbe);
        }
    }
}
