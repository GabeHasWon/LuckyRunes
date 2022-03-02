using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class RainbowFartEvent : PlayerEvent
    {
        public override string Name => "Essence of Unicorn";
        public override string Message => "Rainbow Fart :D";
        public override float Impact => 1f;

        public override void PlayerEffect(Player player)
        {
            RunePlayer runePlayer = player.GetModPlayer<RunePlayer>();
            runePlayer.RainbowFart = 60;
            for (int i = 0; i < 8; i++)
                Dust.NewDust(player.Center, 0, 22, 188, 0, 0, 0, default, 2); //Fart clouds

            Main.PlaySound(SoundID.Item, player.Center, 16); //Fart
            Main.PlaySound(SoundID.Item, player.Center, 67); //Rainbow
        }
    }
}
