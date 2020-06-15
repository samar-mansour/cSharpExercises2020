using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_functions
{
    class Program
    {
        //question 1 
        private static int IsPrime(int number)
        {
            if (number == 1) return 0;
            if (number == 2) return 1;

            for (int i = 2; i < number/2; i++)
            {
                if (number % i == 0) return 0;
                
            }
            return 1;
        }

        //question 2 
        private static void CheckArrayForPrimeNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(IsPrime(arr[i]) == 0)
                {
                    Console.WriteLine($"{arr[i]} Not Prime");
                }
                else
                {
                    Console.WriteLine($"{arr[i]} It's a Prime");

                }
            }
        }

        //question 3 
        private static int whichArrayIsBigger(int[] arr1, int[] arr2)
        {
            int sumArr1 = 0, sumArr2 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sumArr1 += arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                sumArr2 += arr2[i];
            }
            if (sumArr1 > sumArr2)
            {
                return 1;
            }
            else if (sumArr1 == sumArr2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        //question 4
        private static int[,] FillRandom()
        {
            int[,] matrix = new int [10,10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = rnd.Next(1, 101);
                }
            }
            return matrix;
        }

        private static void CheckExist(int[,] theMatrix)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < theMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < theMatrix.GetLength(1); j++)
                {
                    if (theMatrix[i,j] == num)
                    {
                        Console.WriteLine("Exist");
                    }
                    else
                    {
                        Console.WriteLine("Missing");
                    }
                }
            }
        }

        //question 5
        private static void SortArry(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;

                    }
                }
            }
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
           //============================================
            
            int[] prime = { 2, 4, 9, 13, 17 };
            CheckArrayForPrimeNumbers(prime);
            //============================================

            int[] a = { -55, 4, 89, 130, 17 };
            int[] b = { 15, 30, -9, 75, 27 };
            Console.WriteLine(whichArrayIsBigger(a,b));
            //============================================

            int[,] matrix = FillRandom();
            for (int i = 1; i < 10; i++)
            {
                CheckExist(matrix);
            }
            //============================================

            int[] arr = {-5, -10, 15, 2, 5, 100 };
            SortArry(arr);
            PrintArray(arr);
        }
    }
}
