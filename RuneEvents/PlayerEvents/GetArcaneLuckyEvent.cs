using LuckyRunes.Items.Bags;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class GetArcaneLuckyEvent : PlayerEvent
    {
        public override string Name => "Get Arcane Lucky";
        public override string Message => "With an Arcane Bag!";
        public override float Impact => 7.9f;
        public override float Alignment => .75f;

        public override void PlayerEffect(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<ArcaneBag>());
        }
    }
}