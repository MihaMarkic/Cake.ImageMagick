namespace Cake.ImageMagick
{
    public struct Duplicate
    {
        public int Count;
        public string Indexes;

        public Duplicate(int count, string indexes)
        {
            Count = count;
            Indexes = indexes;
        }

        public override string ToString()
        {
            return $"{Count},{Indexes}";
        }

    }
}
