namespace Cake.ImageMagick
{
    public struct Dissolve
    {
        public int SrcPercent;
        public int? DstPercent;

        public Dissolve(int srcPercent, int? dstPercent = null)
        {
            SrcPercent = srcPercent;
            DstPercent = dstPercent;
        }

        public override string ToString()
        {
            string result = SrcPercent.ToString();
            if (DstPercent.HasValue)
            {
                result += $"x{DstPercent}";
            }
            return result;
        }
    }
}
