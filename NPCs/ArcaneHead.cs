using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckyRunes.NPCs
{
    public class ArcaneHead : ModNPC
    {
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 32;
            npc.damage = 80;
            npc.defense = 20;
            npc.lifeMax = 1000;
            npc.HitSound = SoundID.NPCHit3;
            npc.DeathSound = SoundID.NPCDeath3;
            npc.value = 60f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 10;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Main.NewText(RunePlayer.Get(spawnInfo.player).ArcaneMeteor);
            if (RunePlayer.Get(spawnInfo.player).ArcaneMeteor)
                return 10;
            return 0;
        }

        public override void OnHitPlayer(Player target, int dmgDealt, bool crit)
        {
            target.AddBuff(BuffID.ShadowFlame, 4 * 60, true);
        }
    }
}
