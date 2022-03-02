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

        public static RunePlayer Get() => Get(Main.LocalPlayer);
        public static RunePlayer Get(Player player) => player.GetModPlayer<RunePlayer>();

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
            if(RainbowFart > 0)
            {
                RainbowFart--;
                if (RainbowFart % 6 == 0)
                    Dust.NewDust(player.Center, 0, 22, 267, 0, 0, 0, new Color(250, 100, 100), 2); //RainbowRod
                if (RainbowFart % 6 == 1)
                    Dust.NewDust(player.Center, 0, 22, 267, 0, 0, 0, new Color(100, 250, 100), 2); //RainbowRod
                if (RainbowFart % 6 == 2)
                    Dust.NewDust(player.Center, 0, 22, 267, 0, 0, 0, new Color(100, 100, 250), 2); //RainbowRod
                if (RainbowFart % 6 == 3)
                    Dust.NewDust(player.Center, 0, 22, 267, 0, 0, 0, new Color(250, 250, 100), 2); //RainbowRod
                if (RainbowFart % 6 == 4)
                    Dust.NewDust(player.Center, 0, 22, 267, 0, 0, 0, new Color(100, 250, 250), 2); //RainbowRod
                if (RainbowFart % 6 == 5)
                    Dust.NewDust(player.Center, 0, 22, 267, 0, 0, 0, new Color(250, 100, 250), 2); //RainbowRod
                /*{
                    Vector2 midPoint = new Vector2((float)player.width, (float)player.height) / 2f;
                    if (player.oldPosition != Vector2.Zero)
                    {
                        int num319 = Dust.NewDust(player.oldPosition + midPoint, 0, 0, 66, 0f, 0f, 150, Color.Transparent, 0.7f);
                        Main.dust[num319].color = Main.hslToRgb(Main.rand.NextFloat(), 1f, 0.5f);
                        Main.dust[num319].noGravity = true;
                    }
                }*/
                player.velocity.Y -= .5f;
            }
            #endregion
            base.PreUpdate();
        }
        public override void UpdateBiomes()
        {
            ArcaneMeteor = (RuneWorld.ArcaneTiles > 30);
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
        public int RainbowFart { get; set; }
        public bool ArcaneMeteor { get; set; }
    }
}
