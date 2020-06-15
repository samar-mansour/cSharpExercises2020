using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1 - prime number with while loop
            int num, i = 2, flag = 0;
            Console.WriteLine("Enter number: ");
            num = int.Parse(Console.ReadLine());

            while (i <= num/2)
            {
                if (num% i == 0)
                {
                    flag = 1;
                    break;
                }
                i++;
            }
            if (flag == 0)
            {
                Console.WriteLine($"{num} is prime");
            }
            else
            {
                Console.WriteLine($"{num} not a prime");
            }

            //question 2 - students and classes
            int largeClass, mediumClass, smallClass;

            Console.WriteLine("Students number: ");
            int studentNumber = int.Parse(Console.ReadLine());

            largeClass = studentNumber / 100;
            studentNumber = studentNumber - (largeClass * 100);

            mediumClass = studentNumber / 30;
            studentNumber = studentNumber - (mediumClass * 30);

            smallClass = studentNumber / 10;
            studentNumber = studentNumber - (smallClass * 10);

            Console.WriteLine($"Class 100 {largeClass}");
            Console.WriteLine($"Class 30 {mediumClass}");
            Console.WriteLine($"Class 10 {smallClass}");


            //question 3 - Triangle
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            for (int k = 1; k <= n; k++)
            {
                for (int j = 1; j < k; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            for (int k = n - 1; k >=1 ; k--)
            {
                for (int j = 1; j < k; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            //question 4 - Star Triangle
            Console.WriteLine("Enter number: ");
            int n2 = int.Parse(Console.ReadLine());
            for ( i = 1; i <= n2; i++)
            {
                for (int k = n2-1; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2*i-1 ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            
        }
    }
}
