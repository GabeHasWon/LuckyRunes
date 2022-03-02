using LuckyRunes.Items.Bags;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents.CloverEvents
{
    public class WhatsInsideEvent : PlayerEvent
    {
        public override string Name => "What's Inside?";
        public override string Message => "A suspicious egg!";
        public override float Impact => 3.9f;
        public override float Alignment => -.5f;

        public override void PlayerEffect(Player player)
        {
            NPC.NewNPC((int)player.Center.X - 80 + Main.rand.Next(160), (int)player.Center.Y - 200, NPCID.MothronEgg);
        }
    }
}
