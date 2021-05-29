using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class FireworkEvent : PlayerEvent
    {
        public override string Name => "Wonderful!";
        public override string Message => "Shoots a firework.";
        public override float Impact => 1f;

        public override void PlayerEffect(Player player)
        {
            int[] fireworks = new int[] { ProjectileID.RocketFireworkBlue, ProjectileID.RocketFireworkGreen, ProjectileID.RocketFireworkRed, ProjectileID.RocketFireworkYellow };
                Projectile.NewProjectile(player.Center, new Vector2(0, -9 - Main.rand.NextFloat(0, 5.5f)).RotatedByRandom(0.16f), Main.rand.Next(fireworks), 4, 1f);
        }
    }
}
