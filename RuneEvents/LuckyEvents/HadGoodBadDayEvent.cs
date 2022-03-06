using Terraria;

namespace LuckyRunes.RuneEvents.LuckyEvents
{
    public class HadGoodDayEvent : DayLuckEvent
    {
        public override string Name => "Had a Good Day";

        public override bool Debuff => false;
        public override int Duration => 60 * 15;
    }
    
    public class HadBadDayEvent : DayLuckEvent
    {
        public override string Name => "Had a Bad Day";

        public override bool Debuff => true;
        public override int Duration => 60 * 5;
    }
}
