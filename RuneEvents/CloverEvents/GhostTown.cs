using LuckyRunes.Items.Bags;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class GhostTown : PlayerEvent
    {
        public override string Name => "Ghost Town";
        public override string Message => "Goodbye Town NPCs";
        public override float Impact => 3.9f;
        public override float Alignment => -.5f;
        public override void PlayerEffect(Player player)
        {
            foreach (NPC npc in Main.npc)
            {
                if(npc.townNPC)
                {
                    npc.life = 0;
                    npc.active = false;
                }
            }
        }
    }
}
