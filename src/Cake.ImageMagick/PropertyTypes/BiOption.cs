namespace Cake.ImageMagick
{
    public abstract class Noise
    {
    }

    public class ReduceNoise: Noise
    {
        public Geometry Geometry;

        public ReduceNoise(Geometry geometry)
        {
            Geometry = geometry;
        }

        public override string ToString()
        {
            return Geometry.ToString();
        }
    }

    public class AddNoise: Noise
    {
        public NoiseType Type;

        public AddNoise(NoiseType type)
        {
            Type = type;
        }

        public override string ToString()
        {
            return Type.ToString();
        }

    }
}
