using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(10);
            PrintNumbers(numbers);
            numbers = Reverse(numbers);
            PrintNumbers(numbers);
            Console.ReadLine();
        }

        static int[] GenerateNumbers(int manyNumbers)
        {
            int[] numbers = new int[manyNumbers];
            Random rnd = new Random();
            for (int i = 0; i < manyNumbers; i++)
                numbers[i] = rnd.Next(11);
            return numbers;
        }

        static int[] Reverse(int[] numbers)
        {
            int right;
            int left;
            int temp;
            for (int i = 0; i < numbers.Length/2 + 1; i++)
            {
                left = numbers[i];
                right = numbers[numbers.Length - 1 - i];
                temp = left;
                numbers[i] = right;
                numbers[numbers.Length - 1 - i] = temp;
            }
            return numbers;
        }

        static void PrintNumbers(int[] numbers)
        {
            foreach (int number in numbers)
                Console.WriteLine(number);
            Console.WriteLine();
        }
    }
}
