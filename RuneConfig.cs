using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace LuckyRunes
{
    [Label("Client Config")]
    public class RuneConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;


        [Label("Event Prefix")]
        [Tooltip("The prefix for viewers to type before rolling a rune. The amount of coins spent should be typed after it with a space.")]
        [DefaultValue("!runeroll")]
        public string RuneCommandPrefix { get; set; }

        [Label("Coin to Bit Ratio")]
        [Tooltip("The amount of Coins equal to a bit. The thresholds used will be the same as the bit settings.")]
        [Range(0.01f, 10)]
        [DefaultValue(1)]
        public float CoinRatio { get; set; }

        [Label("Chaos Shift")]
        [Tooltip("Randomizes the selection of events during play.")]
        [Range(0.2f, 10f)]
        [DefaultValue(1)]
        public float Variance { get; set; }

        [Label("Very Low Impact Bit Threshold")]
        [Tooltip("Bit donations equal to or higher than this number will roll an event with an impact of 1.")]
        [Range(1, int.MaxValue - 20)]
        [DefaultValue(10)]
        public int VeryLowBit { get; set; }

        [Label("Low Impact Bit Threshold")]
        [Tooltip("Bit donations equal to or higher than this number will roll an event with an impact of 3.")]
        [Range(1, int.MaxValue - 20)]
        [DefaultValue(100)]
        public int LowBit { get; set; }

        [Label("Medium Impact Bit Threshold")]
        [Tooltip("Bit donations equal to or higher than this number will roll an event with an impact of 5.")]
        [Range(1, int.MaxValue - 20)]
        [DefaultValue(500)]
        public int MediumBit { get; set; }

        [Label("High Impact Bit Threshold")]
        [Tooltip("Bit donations equal to or higher than this number will roll an event with an impact of 7.")]
        [Range(1, int.MaxValue - 20)]
        [DefaultValue(2000)]
        public int HighBit { get; set; }

        [Label("Very High Impact Bit Threshold")]
        [Tooltip("Bit donations equal to or higher than this number will roll an event with an impact of 9.")]
        [Range(1, int.MaxValue - 20)]
        [DefaultValue(4000)]
        public int VeryHighBit { get; set; }

        [Label("Very Low Impact Host Threshold")]
        [Tooltip("Hosts that bring in an audience equal to or higher than this value will roll an event with an impact of 1.")]
        [Range(1, int.MaxValue - 20)]
        [DefaultValue(1)]
        public int VeryLowHost { get; set; }

        [Label("Low Impact Host Threshold")]
        [Tooltip("Hosts that bring in an audience equal to or higher than this value will roll an event with an impact of 3.")]
        [Range(1, int.MaxValue - 20)]
        [DefaultValue(20)]
        public int LowHost { get; set; }

        [Label("Medium Impact Host Threshold")]
        [Tooltip("Hosts that bring in an audience equal to or higher than this value will roll an event with an impact of 5.")]
        [Range(1, int.MaxValue - 20)]
        [DefaultValue(250)]
        public int MediumHost { get; set; }

        [Label("High Impact Host Threshold")]
        [Tooltip("Hosts that bring in an audience equal to or higher than this value will roll an event with an impact of 7.")]
        [Range(1, int.MaxValue - 20)]
        [DefaultValue(800)]
        public int HighHost { get; set; }

        [Label("Very High Impact Host Threshold")]
        [Tooltip("Hosts that bring in an audience equal to or higher than this value will roll an event with an impact of 9.")]
        [Range(1, int.MaxValue - 20)]
        [DefaultValue(2000)]
        public int VeryHighHost { get; set; }

        [Label("No Destructive Events")]
        [Tooltip("If true, disables all events that destroy, replace or add tiles to the world.")]
        [DefaultValue(false)]
        public bool NoDestructive { get; set; }

        [Label("Sub Impact Level")]
        [Tooltip("Controls the impact that a sub of any kind has. Defaults to 5.")]
        [Range(0.2f, 10f)]
        [DefaultValue(5f)]
        public float SubImpact { get; set; }

        [Label("Sub Specific Event")]
        [Tooltip("Runs a specific event every time someone subs to the channel. If None, will not run a specific event on sub. Defaults to None.")]
        [DefaultValue("None")]
        public string SubSpecificName { get; set; }

        public override void OnChanged()
        {
            RuneManager.NoDestructive = NoDestructive;
        }
    }
}
