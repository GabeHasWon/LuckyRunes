using Microsoft.Xna.Framework;
using ProjectT;
using Terraria;

namespace LuckyRunes.RuneEvents
{
    public abstract class RuneEvent
    {
        /// <summary>The name of the event. Defaults to "Default".</summary>
        public virtual string Name => "Default";

        /// <summary>Message that is shown along with the event. Defaults to "Does nothing."</summary>
        public virtual string Message => "Does nothing.";

        /// <summary>Impact range of the event. Should be between 0 and 10. Defaults to 5f.</summary>
        public virtual float Impact => 5f;

        /// <summary>Signifies that the event is destructive is some way. If true, this event will not run if config has destructive events set to false. Defaults to false.</summary>
        public virtual bool Destructive => false;

        /// <summary>Check conditions. Defaults to true.</summary>
        public virtual bool Condition => true;

        /// <summary>The actual effects of this event. Prints a message to chat by default.</summary>
        public virtual void Effects()
        {
            Main.NewText(Name, Color.Pink);
            Main.NewText(Message, Color.Pink);
        }
    }
}
