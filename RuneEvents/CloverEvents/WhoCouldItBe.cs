using Terraria;
using Terraria.ModLoader;

namespace LuckyRunes.RuneEvents.CloverEvents
{
    public class WhoCouldItBe : PlayerEvent
    {
        public override string Name => "Who Could It Be?";
        public override string Message => "Spawns a group of entirely random NPCs";
        public override float Impact => 3;

        public override void PlayerEffect(Player player)
        {
            var count = Main.rand.Next(8, 12 + 1);
            var types = BuildNPCList(count);

            for (int i = 0; i < count; i++)
            {
                NPC.SpawnOnPlayer(player.whoAmI, types[i]);
            }
        }

        public static int[] BuildNPCList(int count)
        {
            var types = new int[count];

            for (int i = 0; i < count; i++)
            {
                types[i] = Main.rand.Next(0, NPCLoader.NPCCount);
            }

            return types;
        }
    }
}
