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

        public static IEnumerable<RuneEvent> GetMessageEvents(Viewer viewer, string message, int bits) => events.Where(x => x.CanHandleMessage(viewer, message, bits));
        /// <summary>Gets a random event given </summary>
        /// <param name="viewer"></param>
        /// <param name="message"></param>
        /// <param name="bits"></param>
        /// <returns></returns>
        public static RuneEvent GetRandomMessageEvent(Viewer viewer, string message, int bits)
        {
            var list = GetMessageEvents(viewer, message, bits);
            float variance = Config.Variance;

            //events.Where(x => x.Impact - Config.Variance );

            return list.ElementAt(Main.rand.Next(list.Count()));
        }
    }
}
