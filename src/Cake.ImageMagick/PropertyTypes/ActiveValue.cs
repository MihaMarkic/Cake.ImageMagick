namespace Cake.ImageMagick
{
    public abstract class ActiveValue<T>
    {
        public bool IsEnabled = true;
        public T Value;

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class ActiveString: ActiveValue<string>
    {
        public ActiveString(string value, bool isEnabled  = true)
        {
            Value = value;
            IsEnabled = isEnabled;
        }
    }

    public class ActiveInts: ActiveValue<int[]>
    {
        public ActiveInts(int[] value, bool isEnabled = true)
        {
            Value = value;
            IsEnabled = isEnabled;
        }

        public override string ToString()
        {
            return string.Join(",", Value);
        }
    }
}
