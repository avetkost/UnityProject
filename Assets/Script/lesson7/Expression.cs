using System;

namespace Lesson7
{
    public class Expression
    {
        //Y = log3(x^2 + 4)
        public float Ex1Exp1 (float x)
        {
            return MathF.Log(x * x + 4, 3);
        }
        //Y = (x + x2)7
        public float Ex1Exp2 (float x)
        {
            return MathF.Pow((x + x * x) , 7);
        }
        //Y = arctan(x + 1)
        public float Ex1Exp3 (float x)
        {
            return MathF.Pow(MathF.Atan(x + 1f) ,2);
        }
        //Y = e^cot(x)
        public float Ex1Exp4 (float x)
        {
            return MathF.Exp(1/MathF.Tan(x));
        }
        //Y = |2x + x^3|
        public float Ex1Exp5 (float x)
        {
            return MathF.Abs(2 * x + MathF.Pow(x, 3));
        }
        //∑ 𝑥𝑖² ,  x₁=1; x₀=0,5| x₁ - 4|
        public float Ex2Exp1(int n)
        {
            float first = 1f;
            float result = 0f;
            for(int i = 1; i <= n; ++i)
            {
                result += first * first;
                first = 0.5f * MathF.Abs(first - 4);
            }
            return result;
        }
        //Π 𝑥𝑖 ,  x₁=0,5; xᵢ=tg(xᵢ+1 +2):
        public float Ex2Exp2 (int n)
        {
            float first = 0.5f;
            float result = 1f;

            for (int i = 1; i <= n; ++i)
            {
                result *= first;
                first = MathF.Tan(first + 2);
            }
            return result;
        }
        //Π (x₅² + 𝑥𝑖 ) ,  x₅=0,5; xi=tg(xᵢ+1 +2):
        public float Ex2Exp3 (int n)
        {
            float first = 0.5f;
            float result = 1f;
            for (int i = 5; i <= n; ++i)
            {
                result *= (first * first + first);
                first = MathF.Log10(first + 2);
            }
            return result;
        }
        //∑ (x₀² – 2xᵢ ) ,  x₀=-4.2; xi=ctg xi-1:
        public float Ex2Exp4 (int n)
        {
            float first = -4.2f;
            float result = 0f;

            for (int i = 0; i <= n; ++i)
            {
                result += (first * first - 2 * first);
                first = 1 / MathF.Tan(first);
            }
            return result;
        }
    }
}