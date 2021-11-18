using ProjectT;
using System.Collections.Generic;
using System.Linq;
using Terraria;

namespace LuckyRunes.RuneEvents
{
    public abstract class PlayerEvent : RuneEvent
    {
        /// <summary>If true, effects every player in the world. Defaults to false.</summary>
        public virtual bool EffectAllPlayers => false;

        /// <summary>Allows you to choose which player is selected for this event. Defaults to Main.LocalPlayer in singleplayer, and any random player in multiplayer. Return null if there is no valid player active.</summary>
        public virtual Player GetPlayer()
        {
            if (Main.ActivePlayersCount > 1)
                return Main.rand.Next(Main.player.Where(x => x.active && !x.dead) as IList<Player>); //Grab a random player
            return Main.LocalPlayer; //Grab the local player
        }

        public sealed override void Effects()
        {
            base.Effects();

            if (!EffectAllPlayers)
            {
                Player p = GetPlayer();
                if (p != null)
                {
                    PlayerEffect(p);
                }
            }
            else
            {
                for (int i = 0; i < Main.maxPlayers; ++i)
                {
                    Player p = Main.player[i];

                    if (p.active && !p.dead)
                        PlayerEffect(p);
                }
            }
        }

        public abstract void PlayerEffect(Player player);
    }
}