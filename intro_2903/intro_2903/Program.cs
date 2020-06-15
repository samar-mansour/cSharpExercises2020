using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_2903
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1 - divided by other number
            Console.WriteLine("Enter two numbers: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber % secondNumber == 0)
            {
                Console.WriteLine("Dividable");
            }
            else
            {
                Console.WriteLine("Indivisible");
            }
            Console.WriteLine("***************************************************");
            
            //question 2 - factorial
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 1; i <= num; i++)
            {
                count *= i;
            }
            Console.WriteLine($"Factorial of {num} is {count}");

            /* fuctorial with while loop
             * while (num != 1)
             * {
             *      count *= num;
             *      num--;
             * }
             * Console.WriteLine($"Factorial of {num} is {count}");
             */
            Console.WriteLine("***************************************************");
            
            //question 3 - multiple two numbers using substraction and addition
            Console.WriteLine("Enter two numbers: ");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < firstNum; i++)
            {
                result += secondNum;
            }
            Console.WriteLine($"Result of {firstNum} * {secondNum} = {result}");

            Console.WriteLine("***************************************************");
            
            //question 4 - prime number
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            bool IsPrime = true;
           
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    IsPrime = false;
                }
            }
            if (IsPrime)
            {
                Console.WriteLine($"{n} is Prime");
            }
            else
            {
                Console.WriteLine($"{n} Not Prime");
            }

            Console.WriteLine("***************************************************");
            //question 5 - print countdown one digit number
            Console.WriteLine("Enter number: ");
            int digit = int.Parse(Console.ReadLine());
            int c = 0;
            Console.WriteLine(digit);
            while (digit > 0)
            {
                digit--;
                Console.WriteLine(digit);
                c++;
            }
            Console.WriteLine(c);

        }
    }
}
