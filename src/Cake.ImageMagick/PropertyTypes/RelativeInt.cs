namespace Cake.ImageMagick
{
    public abstract class RelativeValue<T>
    {
        public bool IsPercentage;
        public T Value;

        public override string ToString()
        {
            string result = Value.ToString();
            if (IsPercentage)
            {
                result += "%";
            }
            return result;
        }
    }

    public class RelativeInt : RelativeValue<int>
    {
        public static RelativeInt FromAbsolute(int value)
        {
            return new RelativeInt { Value = value, IsPercentage = false };
        }

        public static RelativeInt FromRelative(int value)
        {
            return new RelativeInt { Value = value, IsPercentage = true };
        }
    }

    public class RelativeDecimal : RelativeValue<decimal>
    {
        public static RelativeDecimal FromAbsolute(decimal value)
        {
            return new RelativeDecimal { Value = value, IsPercentage = false };
        }

        public static RelativeDecimal FromRelative(decimal value)
        {
            return new RelativeDecimal { Value = value, IsPercentage = true };
        }
    }
}
