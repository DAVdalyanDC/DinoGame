using System;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;


namespace Lesson9
{
    public class Expressions
    {


        public void Exp1()
        {
            for (float x = -7.3f; x <= 8.5f; x += 0.3f)
            {
                float result = Mathf.Log(Mathf.Pow(x, 2) + 4);
                Console.WriteLine($"x={x},Y={result}");
            }
        }

        public void Exp2()
        {
            for (float x = -2.7f; x <= 3.3f; x += 0.5f)
            {
                float result = Mathf.Pow(x + (Mathf.Pow(x, 2)),7);
                Console.WriteLine($"x={x},Y={result}");
            }
        }

        public void Exp3()
        {
            for (float x = -4.8f; x <= 5.2f; x += 0.2f)
            {
                float result = Mathf.Pow(Mathf.Atan(x + 1f), 2);
                Console.WriteLine($"x={x},Y={result}");
            }
        }

        public void Exp4()
        {
            for (float x = -6.4f; x <= 2.4f; x += 0.2f)
            {
                float result = Mathf.Exp(1 / Mathf.Tan(x));
                Console.WriteLine($"x={x},Y={result}");
            }
        }

        public void Exp5()
        {
            for (float x = -3.3f; x <= 2.7f; x += 0.3f)
            {
                float result = Mathf.Abs(2 * x + Mathf.Pow(x, 3));
                Console.WriteLine($"x={x},Y={result}");
            } 
        }

        public void Exp6(int n)
        {
            float current = 1f;
            float result = 0f;

            for (int i = 1; i <= n; ++i)
            {
                result += current * current;
                current = 0.5f * Mathf.Abs(current - 4);
            }

            Console.WriteLine($"result={result}");
        }

        public void Exp7(int n)
        {
            float current = 0.5f;
            float result = 1f;

            for (int i = 1; i <= n; ++i)
            {
                result *= current;
                current = Mathf.Tan(current+2);
            }

            Console.WriteLine($"result={result}");
        }

        public void Exp8(int n)
        {
            float current = 0.5f;
            float result = 1f;

            for (int i = 5; i <= n; ++i)
            {
                result *= Mathf.Pow(current,2) + current;
                current = Mathf.Tan(current+2);
            }

            Console.WriteLine($"result={result}");
        }

        public void Exp9(int n)
        {
            float current = -4.2f;
            float result = 0f;
            for (int i = 0; i <= n; ++i)
            {
                result += Mathf.Pow(current, 2) - 2 * current;
                current = 1 / Mathf.Tan(current);
            }
            Console.WriteLine($"result={result}");
        }
    }
}

