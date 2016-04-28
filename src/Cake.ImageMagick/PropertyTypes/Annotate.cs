namespace Cake.ImageMagick
{
    public struct Annotate
    {
        public int? DegreesX;
        public int? DegreesY;
        public int? Tx;
        public int? Ty;
        public string Text;

        public Annotate(int degrees, string text)
        {
            DegreesX = DegreesY = degrees;
            Tx = Ty = null;
            Text = text;
        }
        public Annotate(int degreesX, int degreesY, string text)
        {
            DegreesX = degreesX;
            DegreesY = degreesY;
            Tx = Ty = null;
            Text = text;
        }
        public Annotate(int degreesX, int degreesY, int tx, int ty, string text)
        {
            DegreesX = degreesX;
            DegreesY = degreesY;
            Tx =tx;
            Ty = ty;
            Text = text;
        }
        public static Annotate FromT(int tx, int ty, string text)
        {
            return new Annotate
            {
                DegreesX = null,
                DegreesY = null,
                Tx = tx,
                Ty = ty,
                Text = text
            };
        }

        public override string ToString()
        {
            string result = "";
            if (DegreesX.HasValue && DegreesY.HasValue)
            {
                if (DegreesX == DegreesY)
                {
                    result = DegreesX.ToString();
                }
                else
                {
                    result = $"X{DegreesX}Y{DegreesY}";
                }
            }
            if (Tx.HasValue && Ty.HasValue)
            {
                result += $"{Tx:+0;-0}{Ty:+0;-0}";
            }
            result += Text;
            return result;
        }
    }
}
