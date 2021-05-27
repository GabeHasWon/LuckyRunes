using LuckyRunes.RuneEvents;
using System;
using System.Reflection;
using Terraria.ModLoader;

namespace LuckyRunes
{
	public class LuckyRunes : Mod
	{
		TwitchInput input = new TwitchInput();
		public static Mod ProjectT;

		public override void Load()
		{
			ProjectT = ModLoader.GetMod("ProjectT");
			input = new TwitchInput();

            RuneManager.Load();
		}

        public override void Unload()
		{
			ProjectT = null;
			input = null;

            RuneManager.Unload();
		}
	}
}