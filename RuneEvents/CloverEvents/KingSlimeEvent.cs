using LuckyRunes.Items.Bags;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents.CloverEvents
{
    public class KingSlimeEvent : PlayerEvent
    {
        public override string Name => "King Slime?";
        public override string Message => "Or is it?";
        public override float Impact => 3.9f;
        public override float Alignment => -.25f;

        public override void PlayerEffect(Player player)
        {
            int npc = NPC.NewNPC((int)player.Center.X + 400 * (Main.rand.NextBool()?-1:1), (int)player.Center.Y - 100, NPCID.BlueSlime);
            Main.npc[npc].life = Main.npc[npc].lifeMax *= 40;
            Main.npc[npc].damage *= 4;
            Main.npc[npc].scale *= 10;
            Main.npc[npc].width *= 10;
            Main.npc[npc].height *= 10;
        }
    }
}
