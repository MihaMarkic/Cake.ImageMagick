﻿namespace Cake.ImageMagick
{
    public enum EvaluateOperator
    {
        Abs,
        Add,
        [ArgValue("AddModulus")]
        AddModulus,
        And,
        Cos,
        Divide,
        Exp,
        Exponential,
        [ArgValue("LeftShift")]
        LeftShift,
        Log,
        Max,
        Mean,
        Median,
        Min,
        Multiply,
        Or,
        Pow,
        [ArgValue("RightShift")]
        RightShift,
        [ArgValue("RootMeanSquare")]
        RootMeanSquare,
        Set,
        Sin,
        Sine,
        Subtract,
        Xor,
        GaussianNoise,
        ImpulseNoise,
        LeplacianNoise,
        MultiplicativeNoise,
        [ArgValue("PoissionNoise")]
        PoissionNoise,
        UniformNoise,
        Threshold,
        [ArgValue("ThresholdBlack")]
        ThresholdBlack,
        [ArgValue("ThresholdWhite")]
        ThresholdWhite
    }
}