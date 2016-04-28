namespace Cake.ImageMagick
{
    public struct Function
    {
        public string TargetFunction;
        public string Parameters;
        public Function(string function, string parameters)
        {
            TargetFunction = function;
            Parameters = parameters;
        }

        public override string ToString()
        {
            return $"{TargetFunction} {Parameters}";
        }
    }
}
