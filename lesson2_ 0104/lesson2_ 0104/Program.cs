using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2__0104
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1 - print numbers between 1 - 2000
            for (int i = 1; i <= 2000; i++)
            {
                Console.WriteLine(i);
            }
            // a. even numbers between 1 - 100
            for (int i = 2; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }
            // b. divided by 10 between 10 -100
            for (int i = 10; i <= 100; i+=10)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**************************************");

            //question 2 - countdown from 100 till 1
            for (int i = 100; i <= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**************************************");

            // question 3
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int first, second;
            // a. two digits
            if (num > 9 && num <100)
            {
                first = num % 10;
                second = num / 10;
                //b. first digit
                Console.WriteLine(first);
                // c. second digit
                Console.WriteLine(second);

                //d. check large digit
                if (first > second)
                {
                    Console.WriteLine("AHADOT");
                }
                else
                {
                    Console.WriteLine("ASAROT");
                }
            }

            //question 4 - prime numbers from 1 - 100

            for (int i = 1; i <= 100/2; i++)
            {
                int m = 2;
                while (i % m != 0 && m < i)
                {
                        m++;
                    
                    if (i == m || i == 1)
                    {
                        Console.WriteLine($"{i} Prime");
                    }
                    else
                    {
                        Console.WriteLine($"{i} not Prime");
                    }
                }
            }

            //question 6 - tringle stars
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j > i)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
