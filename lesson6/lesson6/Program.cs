using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1 - students grades
            int sum = 0, avg = 0;
            Console.Write("Students number: ");
            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{i + 1}. student grade is: ");
                int grade = int.Parse(Console.ReadLine());
                arr[i] = grade;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                avg = sum / arr.Length;
            }
            Console.WriteLine($"Total grades is: {sum} \nAvgerage grades is: {avg}");

            // question 2 - matrix array
            int[,] matrixArr = new int[5,5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrixArr[i, j] = rnd.Next(1, 10);
                }
            }
            Console.Write("Enter number between 1-10: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 && n > 10)
            {
                Console.Write("number out of range. \nEnter number between 1-10: ");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (n == matrixArr[i,j])
                    {
                        Console.WriteLine($"{n} in place ({i},{j})");
                    }
                }
            }

            //question 3 - finding right places in matrix "Boom/Miss game"
            int[,] board = new int[3, 3];
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = rnd.Next(0, 2);
                   // Console.Write(bord[i,j]);
                }
                //Console.WriteLine();
            }
            Console.WriteLine("Enter row and colum: ");
            int row = int.Parse(Console.ReadLine());
            int colum = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[row,colum] == 1)
                    {
                        Console.WriteLine("Boom");
                        board[i, j] = 0;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Miss");
                        Console.WriteLine("Enter row and colum: ");
                        row = int.Parse(Console.ReadLine());
                        colum = int.Parse(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine("total tries: ", count);
        }

        

    }
}
