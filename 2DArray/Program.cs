using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[4, 3]
            {
                { 10, 20, 30 },
                { 40, 50, 60 },
                { 70, 80, 90 },
                { 100, 110, 120 }
            };

            //Print perticular element from 2D array
            Console.WriteLine(arr1[2,1]);

            //Print all element from 2D array
            //using for loop
            for (int row = 0; row <arr1.GetLength(0); row++)
            {
                for (int col = 0; col < arr1.GetLength(1); col++) 
                {
                    Console.Write($"arr1[{row},{col}] = {arr1[row,col]}   ");
                }
                Console.WriteLine();
            }

           



            //To accept the input from user for 2D array

            int[,] arr2 = new int[4, 3];

            Console.WriteLine("Enter 2D Array element");
            for (int row = 0; row < arr1.GetLength(0); row++)
            {
                for (int col = 0; col < arr1.GetLength(1); col++)
                {
                    arr2[row,col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int row = 0; row < arr2.GetLength(0); row++)
            {
                for (int col = 0; col < arr2.GetLength(1); col++)
                {
                    Console.Write($"arr2[{row},{col}] = {arr2[row, col]}   ");
                }
                Console.WriteLine();
            }
        }
    }
}
