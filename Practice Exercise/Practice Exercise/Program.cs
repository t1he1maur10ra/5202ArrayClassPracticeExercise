/* Name: Jacob Van Silfhout
      Id: JV1
          This is a potential answer to the practice question*/
using System;

namespace Practice_Exercise
{
    class Program
    {
        /* Variables that can be used throughout the whole class */
        static int randMin = 1;//Min random number
        static int randMax = 100;//Max random number
        static int arraySize = 20;//size of the array

        static void Main(string[] args)
        {
            /* Create the array and populate it with the FillArray method */
            int[] randArray = FillArray(new int[arraySize]);
            /* Display the unsorted array */
            Console.WriteLine("******* Unsorted Array *******");
            Display(randArray);
            /* Display the sorted array */
            Console.WriteLine("******* Sorted Array *******");
            Array.Sort(randArray);
            Display(randArray);
            /* Exit message */
            Console.WriteLine("Press ENTER exit the application.");
            Console.ReadLine();
        }

        /* Method to populate an array with random numbers */
        static int[] FillArray(int[] arr)
        {
            Random rand = new Random();//Create a random to use
            /* Using the Length property in the loop */
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(randMin, randMax);
            }
            return arr;//Retrun the array
        }

        /* Method to display the contents of the array */
        static void Display(int[] arr)
        {
            /* Using the Length property in the loop */
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
