using LuckyRunes.RuneEvents.PlayerEvents;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckyRunes
{
    public class RunePlayer : ModPlayer
    {
        public override void ResetEffects()
        {
            BagRolls = 1;
            base.ResetEffects();
        }

        public override void PreUpdate()
        {
            #region Rains
            if(RainingFish > 0)
            {
                RainingFish--;
                if (RainingFish % 8 == 0)
                    Rain(RuneControl.FishPool.Get());
            }
            if(CopperRain > 0)
            {
                CopperRain--;
                if (CopperRain % 4 == 0)
                    Rain(ItemID.CopperCoin);
            }
            if(SilverRain > 0)
            {
                SilverRain--;
                if (SilverRain % 8 == 0)
                    Rain(ItemID.SilverCoin);
            }
            if(GoldRain > 0)
            {
                GoldRain--;
                if (GoldRain % 16 == 0)
                    Rain(ItemID.GoldCoin);
            }
            #endregion
            base.PreUpdate();
        }

        private void Rain(int item)
        {
            Item.NewItem(new Vector2(player.Center.X - 800 + Main.rand.Next(1600), player.Center.Y - 800), item);
        }

        public int BagRolls { get; set; }
        public int RainingFish { get; set; }
        public int CopperRain { get; set; }
        public int SilverRain { get; set; }
        public int GoldRain { get; set; }
    }
}
