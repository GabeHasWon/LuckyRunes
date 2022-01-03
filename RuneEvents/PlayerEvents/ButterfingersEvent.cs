using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class ButterfingersEvent : PlayerEvent
    {
        public override string Name => "Butterfingers";
        public override string Message => "Whoops, you dropped something";
        public override float Impact => 1.5f;
        public override float Alignment => -0.1f;

        public override void PlayerEffect(Player player)
        {
            if (player.HeldItem == null)
                return;
            double theta = 2 * Math.PI * Main.rand.NextDouble();
            float mag = 300;
            Item.NewItem(new Vector2(player.Center.X + (float)Math.Cos(theta) * mag, player.Center.Y + (float)Math.Sin(theta) * mag), Vector2.Zero, player.HeldItem.type, player.HeldItem.stack);
            player.HeldItem.stack = 0;
        }
    }
}
