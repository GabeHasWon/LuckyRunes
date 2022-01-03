using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class OhShinyEvent : PlayerEvent
    {
        public override string Name => "Ooh Shiny";
        public override string Message => "A gold portal!";
        public override float Impact => 2.8f;
        public override float Alignment => 0.5f;

        public override void PlayerEffect(Player player)
        {
            Projectile.NewProjectile(new Vector2(player.Center.X, player.Center.Y - 40), new Vector2(0, -8), ProjectileID.CoinPortal, 0, 0);
        }
    }
}