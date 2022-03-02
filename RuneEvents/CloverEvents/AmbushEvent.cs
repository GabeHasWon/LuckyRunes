using LuckyRunes.Items.Bags;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class AmbushEvent : PlayerEvent
    {
        public override string Name => "Ambush!";
        public override string Message => "You're surrounded!";
        public override float Impact => 3.9f;
        public override float Alignment => -.5f;
        public override void PlayerEffect(Player player)
        {
            for (int i = 0; i < 8; i++)
                NPC.SpawnOnPlayer(player.whoAmI, RuneControl.GetRandomEnemyFromProgression(RuneControl.GetProgression()));
        }
    }
}
