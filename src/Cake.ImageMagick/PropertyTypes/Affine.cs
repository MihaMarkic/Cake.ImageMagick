namespace Cake.ImageMagick
{
    public struct Affine
    {
        public int Sx;
        public int Sy;
        public int Rx;
        public int Ry;
        public int? Tx;
        public int? Ty;

        public Affine(int sx, int rx, int ry, int sy)
            : this(sx, rx, ry, sy, null, null)
        {}
        public Affine(int sx, int rx, int ry, int sy, int tx, int ty)
            : this(sx, rx, ry, sy, (int?)tx, (int?)ty)
        { }
        private Affine(int sx, int rx, int ry, int sy, int? tx, int? ty)
        {
            Sx = sx;
            Sy = sy;
            Rx = rx;
            Ry = ry;
            Tx = tx;
            Ty = ty;
        }

        public override string ToString()
        {
            string result = $"{Sx},{Rx},{Ry},{Sy}";
            if (Tx.HasValue && Ty.HasValue)
            {
                result += $",{Tx},{Ty}";
            }
            return result;
        }
    }
}
