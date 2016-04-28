namespace Cake.ImageMagick
{
    public struct Delay
    {
        public int Ticks;
        public int? TicksPerSecond;
        public bool ChangeDelayIfExceeds;
        public bool ChangeDelayIfIsLess;

        public Delay(int ticks)
        {
            Ticks = ticks;
            TicksPerSecond = null;
            ChangeDelayIfExceeds = ChangeDelayIfIsLess = false;
        }
        public Delay(int ticks, int ticksPerSecond, bool changeDelayIfExceeds = false, bool changeDelayIfIsLess = false)
        {
            Ticks = ticks;
            TicksPerSecond = null;
            ChangeDelayIfExceeds = changeDelayIfExceeds;
            ChangeDelayIfIsLess = changeDelayIfIsLess;
        }

        public override string ToString()
        {
            string result = Ticks.ToString();
            if (TicksPerSecond.HasValue)
            {
                result += $"x{TicksPerSecond.Value}";
            }
            if (ChangeDelayIfExceeds)
            {
                result += ">";
            }
            if (ChangeDelayIfIsLess)
            {
                result += "<";
            }
            return result;
        }
    }
}
