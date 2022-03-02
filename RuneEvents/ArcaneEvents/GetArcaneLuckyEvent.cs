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
        public override string Name => "Wish";
        public override string Message => "Get 3 Arcane Bags!";
        public override float Impact => 7.9f;
        public override float Alignment => .75f;

        public override void PlayerEffect(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<ArcaneBag>());
            player.QuickSpawnItem(ModContent.ItemType<ArcaneBag>());
            player.QuickSpawnItem(ModContent.ItemType<ArcaneBag>());
        }
    }
}