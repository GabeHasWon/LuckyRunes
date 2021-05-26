using ProjectT;
using Terraria;

namespace LuckyRunes.RuneEvents
{
    public abstract class PlayerEvent : RuneEvent
    {
        /// <summary>Allows you to choose which player is selected for this event. Defaults to Main.LocalPlayer in singleplayer, and any random player in multiplayer.</summary>
        public virtual Player ChoosePlayer()
        {
            if (Main.ActivePlayersCount > 1)
                return Main.rand.Next(Main.player);
            return Main.LocalPlayer;
        }
    }
}
