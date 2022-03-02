using LuckyRunes.Items.Bags;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents.CloverEvents
{
    public class BehindYouEvent : PlayerEvent
    {
        public override string Name => "Behind You!";
        public override string Message => "Some tough enemies appear!";
        public override float Impact => 3.9f;
        public override float Alignment => -.5f;

        public override void PlayerEffect(Player player)
        {
            for (int i = 0; i < 4; i++)
                NPC.SpawnOnPlayer(player.whoAmI, RuneControl.GetRandomEnemyFromProgression(RuneControl.GetNextProgression(RuneControl.GetProgression())));
        }
    }
}
