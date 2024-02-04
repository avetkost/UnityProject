using System;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

namespace Lesson7
{
    public class Expression
    {
            //Y = log3(x^2 + 4)
        public void Ex1Exp1 ()
        {
            for (float x = -7.5f; x <= 8.3f; x += 0.3f)
            {
                float result = MathF.Log(x * x + 4, 3);
                Console.WriteLine($"x = {x}, y = {result}");
            }
            
        }
        //Y = (x + x2)7
        public void Ex1Exp2 ()
        {
            for (float x = -4.8f; x <= 5.2f; x += 0.2f)
            {
                float result = Mathf.Pow(Mathf.Atan(x + 1f), 2);
                Console.WriteLine($"x={x},Y={result}");
            }
        }
        //Y = arctan(x + 1)
        public void Ex1Exp3 ()
        {
            for (float x = -4.8f; x <= 5.2f; x += 0.2f)
            {
                float result = Mathf.Pow(Mathf.Atan(x + 1f), 2);
                Console.WriteLine($"x={x},Y={result}");
            }
        }
        //Y = e^cot(x)
        public void Ex1Exp4()
        {
            for (float x = -6.4f; x <= 2.4f; x += 0.2f)
            {
                float result = Mathf.Exp(1 / Mathf.Tan(x));
                Console.WriteLine($"x={x},Y={result}");
            }
        }

        //Y = |2x + x^3|
        public void Ex1Exp5 ()
        {
            for (float x = -3.3f; x <= 2.7f; x += 0.3f)
            {
                float result = Mathf.Abs(2 * x + Mathf.Pow(x, 3));
                Console.WriteLine($"x={x},Y={result}");
            }
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