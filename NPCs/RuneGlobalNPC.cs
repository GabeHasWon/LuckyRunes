using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace LuckyRunes.NPCs
{
    public class RuneGlobalNPC : GlobalNPC
    {
        /*
        public override void EditSpawnPool(IDictionary<int, float> pool, NPCSpawnInfo spawnInfo)
        {
            if (RunePlayer.Get(spawnInfo.player).ArcaneMeteor)
            {
                pool.Clear();
                pool.Add(ModContent.NPCType<ArcaneHead>(), 20);
            }
            return;
        }*/
    }
}
