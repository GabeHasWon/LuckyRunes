using LuckyRunes.RuneEvents;
using System;
using System.Reflection;
using Terraria.ModLoader;

namespace LuckyRunes
{
    public class LuckyRunes : Mod
    {
        TwitchInput input = null;
        public static Mod ProjectT;

        public override void Load()
        {
            ProjectT = ModLoader.GetMod("ProjectT");
            if(ProjectT != null)
            {
                input = new TwitchInput();
            }
            RuneManager.Load();
        }

        public override void Unload()
        {
            ProjectT = null;
            RuneManager.Unload();
        }
    }
}