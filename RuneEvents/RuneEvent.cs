using Microsoft.Xna.Framework;
using ProjectT;
using Terraria;

namespace LuckyRunes.RuneEvents
{
    public abstract class RuneEvent
    {
        /// <summary>The name of the event.</summary>
        public virtual string Name => "Default";

        /// <summary>Message that is shown along with the event.</summary>
        public virtual string Message => "Does nothing.";

        /// <summary>Impact range of the event. Should be between 0 and 10.</summary>
        public virtual float Impact => 5f;

        /// <summary>Checks if this event should handle a message. Use to check for mod status, bit amounts, etc. Defaults to false.</summary>
        /// <param name="viewer"></param>
        /// <param name="message"></param>
        /// <param name="bits"></param>
        public virtual bool CanHandleMessage(Viewer viewer, string message, int bits) => false;

        /// <summary>Called when any message that satisfies CanHAndleMessage is posted. Use for registering commands and responding to chat.</summary>
        /// <param name="viewer">Information on the person who sent the message.</param>
        /// <param name="message">The message.</param>
        /// <param name="bits">Bits if the message has any.</param>
        public virtual void HandleMessage(Viewer viewer, string message, int bits)
        {
        }

        /// <summary>Checks if this event should handle a host. Use to check for host name or raid size. Defaults to false.</summary>
        public virtual bool CanHandleHost(string hoster, int viewers) => false;

        /// <summary>Called when anyone hosts the stream. Use to cause stuff to happen on host. Defaults to a simple thank-you message in game.</summary>
        /// <param name="hoster">Name of the hoster.</param>
        /// <param name="viewers">Number of viewers who came from the hoster.</param>
        public virtual void HandleHost(string hoster, int viewers)
        {
            Main.NewText($"Thank you {hoster} for hosting with {viewers}!");
        }

        /// <summary>Called when a gift sub is rewarded to someone. Use to cause stuff on gift sub. Defaults to a simple congrats message in game.</summary>
        /// <param name="viewer">The recipient of the sub.</param>
        /// <param name="tier">Tier of the sub - can be "Tier1", "Tier2", "Tier3".</param>
        public virtual void HandleGiftedSub(Viewer viewer, string tier)
        {
            Main.NewText($"Congrats to ${viewer.Name} on the gifted {tier.Insert(3, " ")} sub!");
        }

        /// <summary>Called when a non-subscriber subscribes. Use to cause stuff specific to new subs. Defaults to a simple congrats message in game.</summary>
        /// <param name="viewer">The new subscriber.</param>
        /// <param name="tier">Tier of the sub - can be "Prime", "Tier1", "Tier2", "Tier3" or "NotSet".</param>
        public virtual void HandleNewSub(Viewer viewer, string tier)
        {
            Main.NewText($"Welcome to ${viewer.Name} with a {tier} sub!");
        }

        /// <summary>Called when a user resubscribes. Use to cause stuff specific to resubs. Defaults to a simple congrats message in game.</summary>
        /// <param name="viewer">The resubscriber.</param>
        /// <param name="tier">Tier of the sub - presumably can be "Prime", "Tier1", "Tier2", "Tier3" or "NotSet".</param>
        public virtual void HandleResub(Viewer viewer, string tier)
        {
            Main.NewText($"Welcome back to ${viewer.Name} with a {tier} sub!");
        }
    }
}
