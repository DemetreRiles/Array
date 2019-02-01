/*
Author: Demetre Riles
Date: 1/31/2019
Comments: This is a C# Application that prints out the values in an array to a console
*/
using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try and catch block to handle any exepctions 
            try 
            {
                // Starting line which asks a user to press a key to start program
                Console.WriteLine("Press any key to start the Array program...");
                Console.ReadKey(true);

                // Manually coded array of values
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
                 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 }; 
                
                 // Loop that uses array to print out element value line
                 foreach (int i in numbers) 
                 {
                    Console.WriteLine("Element Vaule = " + i);
                 }

                 // Diolog to exit program
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true); 
            }
            catch 
            {
                // handles any exeption given while running program
                Console.WriteLine("Error, please press any key to exit program...");
                Console.ReadKey(true); 

            }

        }
    }
}
