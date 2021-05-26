using LuckyRunes.RuneEvents;
using ProjectT;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace LuckyRunes
{
    public static class RuneManager
    {
        private readonly static List<RuneEvent> events = new List<RuneEvent>();

        private static RuneConfig Config => ModContent.GetInstance<RuneConfig>();

        public static void AddEvent(RuneEvent ev) => events.Add(ev);
        public static void RemoveEvent(RuneEvent ev) => events.Remove(ev);
        public static void Clear() => events.Clear();

        public static void Load()
        {
            //Load all RuneEvents
            var types = typeof(RuneEvent).Assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.IsSubclassOf(typeof(RuneEvent)) && !type.IsAbstract)
                {
                    events.Add(Activator.CreateInstance(type) as RuneEvent);
                }
            }
        }

        public static void Unload()
        {
            events.Clear();
        }

        /// <summary>
        /// Gets all events given conditions.
        /// </summary>
        /// <param name="viewer">The person who sent the message.</param>
        /// <param name="message">The message itself.</param>
        /// <param name="bits">The bits in the message, if any.</param>
        /// <returns></returns>
        public static IEnumerable<RuneEvent> GetMessageEvents(Viewer viewer, string message, int bits) => events.Where(x => x.CanHandleMessage(viewer, message, bits));

        /// <summary>Gets a random event given the conditions + an event's impact.</summary>
        /// <param name="viewer">The person who sent the message.</param>
        /// <param name="message">The message itself.</param>
        /// <param name="bits">The bits in the message, if any.</param>
        /// <returns></returns>
        public static RuneEvent GetRandomMessageEvent(Viewer viewer, string message, int bits)
        {
            var list = GetMessageEvents(viewer, message, bits); //Grab events that can handle the current message
            float bitImpact = 5f; //replace with actual impact later
            float variance = Config.Variance; //Variance local

            list = list.Where(x => x.Impact - Config.Variance < bitImpact && x.Impact + Config.Variance > bitImpact); //Update list to include events with valid impact

            return list.ElementAt(Main.rand.Next(list.Count())); //Return a random event
        }
    }
}
