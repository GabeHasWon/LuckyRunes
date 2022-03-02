using LuckyRunes.Items.Bags;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes.RuneEvents.PlayerEvents.CloverEvents
{
    public class WhatHappenedEvent : PlayerEvent
    {
        public override string Name => "What Happened?";
        public override string Message => "Hmmm";
        public override float Impact => 2.2f;
        public override float Alignment => -.1f;

        public override void PlayerEffect(Player player)
        {
            Item helm = player.armor[0];
            Item vHelm = player.armor[10];
            player.armor[0] = vHelm;
            player.armor[10] = helm;

            Item chest = player.armor[1];
            Item vChest = player.armor[11];
            player.armor[1] = vChest;
            player.armor[11] = chest;

            Item pants = player.armor[2];
            Item vPants = player.armor[12];
            player.armor[2] = vPants;
            player.armor[12] = pants;

            Item acc1 = player.armor[3];
            Item vacc1 = player.armor[13];
            player.armor[3] = vacc1;
            player.armor[13] = acc1;

            Item acc2 = player.armor[4];
            Item vacc2 = player.armor[14];
            player.armor[4] = vacc2;
            player.armor[14] = acc2;

            Item acc3 = player.armor[5];
            Item vacc3 = player.armor[15];
            player.armor[5] = vacc3;
            player.armor[15] = acc3;

            Item acc4 = player.armor[6];
            Item vacc4 = player.armor[16];
            player.armor[6] = vacc4;
            player.armor[16] = acc4;

            Item acc5 = player.armor[7];
            Item vacc5 = player.armor[17];
            player.armor[7] = vacc5;
            player.armor[17] = acc5;

            Item acc6 = player.armor[8];
            Item vacc6 = player.armor[18];
            player.armor[8] = vacc6;
            player.armor[18] = acc6;

            Item acc7 = player.armor[9];
            Item vacc7 = player.armor[19];
            player.armor[9] = vacc7;
            player.armor[19] = acc7;
        }
    }
}
