using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace LuckyRunes
{
    public class RuneConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Chaos Shift")]
        [Tooltip("Randomizes the selection of events during play.")]
        [Range(0.2f, 10f)]
        [DefaultValue(1)]
        public float Variance { get; set; }

        [Label("Very Low Impact Bit Threshold")]
        [Tooltip("Bit donations equal to or higher than this number will roll an event with an impact of 1.")]
        [DefaultValue(10)]
        public int VeryLowBit { get; set; }

        [Label("Low Impact Bit Threshold")]
        [Tooltip("Bit donations equal to or higher than this number will roll an event with an impact of 3.")]
        [DefaultValue(100)]
        public int LowBit { get; set; }

        [Label("Medium Impact Bit Threshold")]
        [Tooltip("Bit donations equal to or higher than this number will roll an event with an impact of 5.")]
        [DefaultValue(500)]
        public int MediumBit { get; set; }

        [Label("High Impact Bit Threshold")]
        [Tooltip("Bit donations equal to or higher than this number will roll an event with an impact of 7.")]
        [DefaultValue(2000)]
        public int HighBit { get; set; }

        [Label("Very High Impact Bit Threshold")]
        [Tooltip("Bit donations equal to or higher than this number will roll an event with an impact of 9.")]
        [DefaultValue(2000)]
        public int VeryHighBit { get; set; }
    }
}
