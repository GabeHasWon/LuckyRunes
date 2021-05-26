using Terraria.ModLoader.Config;

namespace LuckyRunes
{
    public class RuneConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Chaos Shift")]
        [Tooltip("Randomizes the selection of events during play.")]
        [Range(0.2f, 10f)]
        public float Variance { get; set; }
    }
}
