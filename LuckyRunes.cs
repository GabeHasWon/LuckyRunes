using Terraria.ModLoader;
using ProjectT;

namespace LuckyRunes
{
    public class LuckyRunes : Mod
    {
        TwitchInput input = null;
        public static Mod ProjectTMod;

        public LuckyRunes()
        {
            ;
        }

        public override void Load()
        {
            ProjectTMod = ModLoader.GetMod("ProjectT");
            if (ProjectTMod != null)
                input = new TwitchInput();

            RuneControl.InitializeVars();
            RuneManager.Load();
        }

        public override void Unload()
        {
            ProjectTMod = null;
            RuneManager.Unload();
        }
    }
}