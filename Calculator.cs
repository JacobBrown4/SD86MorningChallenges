using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenges
{
    public class Calculator
    {

        public double Add(double a, double b)
        {
            return a + b;
        }
        // Overloaded for ints
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            double diff = a - b;
            return diff;
        }

        public double Div(double a, double b)
        {
            return a * b;
        }

        public double Mul(double a, double b)
        {
            return a / b;
        }

        public double Add(double[] numbers)
        {
            double total = 0;
            foreach (double number in numbers)
            {
                total += number;
            }
            return total;
        }
        public double Sub(double[] numbers)
        {
            // Work around for first out issue.
            double total = 0;
            for (int i = 0; i < numbers.Length; ++i)
            {
                if (i == 0)
                {
                    total = numbers[i];
                }
                else
                {
                    total -= numbers[i];
                }
            }
            return total;
        }
        public double Div(double[] numbers)
        {
            double total = 0;
            for (int i = 0; i < numbers.Length; ++i)
            {
                if (i == 0)
                {
                    total = numbers[i];
                }
                else
                {
                    total /= numbers[i];
                }
            }
            return total;
        }
        public double Mul(double[] numbers)
        {
            double total = 1;
            foreach (double number in numbers)
            {
                total *= number;
            }
            return total;
        }

        public string Percent(double a, double b)
        {
            double c = a / b;
            c *= 100;
            return $"{c}%";
        }
    }
}
