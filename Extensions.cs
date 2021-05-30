using LuckyRunes.RuneEvents;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace LuckyRunes
{
    public static class Extensions
    {
        public static T GetRandom<T>(this IEnumerable<T> list) => list.Count() > 0 ? list.ElementAt(Main.rand.Next(list.Count())) : default(T);
    }
}
