namespace Cake.ImageMagick
{
    public struct Evaluate
    {
        public EvaluateOperator Operator;
        public string Value;

        public Evaluate(EvaluateOperator @operator, string value)
        {
            Operator = @operator;
            Value = value;
        }

        public override string ToString()
        {
            return $"{ArgumentsBuilderExtension.GetEnumValue(Operator)} {Value}";
        }
    }
}
