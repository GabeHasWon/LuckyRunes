using Terraria.ModLoader;

namespace LuckyRunes
{
    public class RunRuneCommand : ModCommand
    {
        public override void Action(CommandCaller caller, string input, string[] args)
        {
            var ev = RuneManager.GetDirectEvent(string.Join(" ", args));
            ev?.Effects();
        }

        public override bool Autoload(ref string name)
        {
            return true; // TODO Turn this off before release.
        }

        public override string Command => "runrune";
        public override CommandType Type => CommandType.Chat;
    }
}
