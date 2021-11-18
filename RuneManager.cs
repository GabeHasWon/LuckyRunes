﻿using LuckyRunes.RuneEvents;
using ProjectT;
using System;
using System.Collections;
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

        public static bool NoDestructive { get; set; }

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

        /// <summary>Gets a random event given the conditions + an event's impact. Returns null if there's no valid event.</summary>
        /// <param name="viewer">The person who sent the message.</param>
        /// <param name="message">The message itself.</param>
        /// <param name="bits">The bits in the message, if any.</param>
        public static RuneEvent GetEvent(float impact, List<RuneEvent> restrictedEvents = null)
        {
            Random rand = new Random();
            var list = RestrictToImpact(restrictedEvents ?? events, impact); //Update list to include events with valid impact
            list = ReturnValidEvents(list);
            var newList = list.ToList();
            return newList[rand.Next(newList.Count())]; //Update list to remove events that don't meet the conditions, then pick a random one
        }

        private static IEnumerable<RuneEvent> ReturnValidEvents(IEnumerable<RuneEvent> list)
        {
            var newList = new List<RuneEvent>();
            foreach (RuneEvent ev in list)
            {
                if (ev.Condition && !(ev.Destructive && NoDestructive))
                    newList.Add(ev);
            }
            return newList;
        }

        private static RuneEvent GetValidEvent(IEnumerable<RuneEvent> list)
        {
            if (list.Count() > 0)
            {
                int loops = -1;
                while (true) //guarantee a valid event is returned
                {
                    loops++;
                    if (loops > 300) return null; //We could not find a valid event somehow - failsafe that only matters for edge cases

                    var ev = list.ElementAt(Main.rand.Next(list.Count())); //Grab a random event
                    if (ev is PlayerEvent) //If player event
                    {
                        var pEvent = ev as PlayerEvent;
                        if (!pEvent.ChooseAllPlayers && pEvent.GetPlayer() != null) //If the player-specific event has a valid player
                            return ev;
                        return ev;
                    }
                    else if (ev is WorldEvent) //If world event
                    {
                        var wEvent = ev as WorldEvent;
                        if (wEvent.RequiredWorldConditions)
                            return ev;
                    }
                }
            }
            return null;
        }

        /// <summary>Translates bit count into impact.</summary>
        /// <param name="bits">Bit count to check against.</param>
        public static float GetBitImpact(int bits)
        {
            if (bits >= Config.VeryHighBit) return 9f;
            else if (bits >= Config.HighBit) return 7f;
            else if (bits >= Config.MediumBit) return 5f;
            else if (bits >= Config.LowBit) return 3f;
            return 1f;
        }

        /// <summary>Returns the list given the impact and variance restrictions.</summary>
        /// <param name="list">List to restrict.</param>
        /// <param name="impact">Base impact to restrict from.</param>
        private static IEnumerable<RuneEvent> RestrictToImpact(IEnumerable<RuneEvent> list, float impact) => list.Where(x => x.Impact - Config.Variance <= impact && x.Impact + Config.Variance >= impact);
    }
}
