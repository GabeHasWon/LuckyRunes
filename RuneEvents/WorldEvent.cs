using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyRunes.RuneEvents
{
    public abstract class WorldEvent : RuneEvent
    {
        /// <summary>Used to check conditions, such as Main.hardMode.</summary>
        public virtual bool RequiredWorldConditions => true;

        public sealed override void Effects()
        {
            base.Effects();
            WorldEffect();
        }

        public abstract void WorldEffect();
    }
}
