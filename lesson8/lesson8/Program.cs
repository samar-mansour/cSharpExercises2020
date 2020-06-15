using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    class Program
    {
        //question1 - dividable
        private static bool Isdivided(int a, int b)
        {
            //if (a % b == 0)
            //{
            //    return true;
            //}
            //return false;
            return a % b == 0;
        }

        //question2 - change values
        private static void ChancgeNumber(ref int a, ref int b)
        {
            a++;
            b *= 2;
        }

        //question 3 - input from user
        private static void UserInput(out int a, out int b)
        {
            Console.Write("Enter first number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = int.Parse(Console.ReadLine());
        }

        //question 4 - none known number of parameters
        private static double SumNumber(params int [] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                double power = Math.Pow(a[i], i+1);
                sum += power;
            }
            return sum;
        }

        //question 5 - Mult
        private static int MultNumber(int a, int b = 1, int c = -1)
        {
            return a * b * c;
        }

        //question 7 - sorting postive, negative array
        private static void AssortingArray(int[]a, out int[]b, out int[]c)
        {
            int countPositive = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    countPositive++;
                }
            }
            int countNegative = a.Length - countPositive;

            b = new int[countPositive];
            c = new int[countNegative];
            int indexB = 0, indexC = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    b[indexB] = a[i];
                    indexB++;
                }
                else
                {
                    c[indexC] = a[i];
                    indexC++;
                }
            }
        }
        static void Main(string[] args)
        {
            int num1 = 12, num2 = 5;
            if (Isdivided(num1, num2))
            {
                Console.WriteLine("no module");
            }
            else
            {
                Console.WriteLine("some module");
            }
            //============================================================
            
            Console.WriteLine($"before change {num1},{num2}");
            ChancgeNumber(ref num1, ref num2);
            Console.WriteLine($"After change {num1},{num2}");
            //============================================================

            Console.WriteLine($"Before change:\na = {num1}, b = {num2}");
            UserInput(out num1, out num2);
            Console.WriteLine($"After Change:\na = {num1}, b = {num2}");
            //============================================================

            double sum = SumNumber(3, 11, 6, 1, 40);
            Console.WriteLine(sum);
            Console.WriteLine(SumNumber(4,6,2));
            //============================================================

            Console.WriteLine(MultNumber(1,2,3));
            Console.WriteLine(MultNumber(5,3));
            Console.WriteLine(MultNumber(1));
            //============================================================

            Console.WriteLine(MultNumber(a:1, c:10));

            int[] a = { 77, -41, 5, 9, -11, 30, -21 };
            int[] b;
            int[] c;
            AssortingArray(a, out b, out c);

            Console.Write("Positive array: ");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write($"{b[i]} ");
            }
            Console.WriteLine();
            Console.Write("Negative array: ");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write($"{c[i]} ");
            }
            Console.WriteLine();

        }
    }
}
