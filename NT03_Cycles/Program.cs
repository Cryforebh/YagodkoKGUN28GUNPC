using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT03_Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1

            Console.WriteLine("Exercise 1: ");

            int[] myArray01 = new int[10];

            myArray01[0] = 0;
            myArray01[1] = 1;

            for (int i = 2; i < myArray01.Length; i++)
            {
                myArray01[i] = myArray01[i - 1] + myArray01[i - 2];
            }

            foreach (var item in myArray01)
            {
                Console.Write(item + " ");
            }



            // Exercise 2

            Console.WriteLine("\n\nExercise 2: ");

            int[] myArray02 = new int [20];

            for (int i = 0; i < myArray02.Length; i++)
            {
                myArray02[i] = i + 1;

                if (myArray02[i] % 2 == 0 && myArray02[i] >= 2 && myArray02[i] <= 20)
                {
                    Console.Write(myArray02[i] + "\t");
                }
                    
            }



            // Exercise 3

            Console.WriteLine("\n\nExercise 3: ");

            int[] myArray03 = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < myArray03.Length; i++)
            {
                for (int j = 0; j < myArray03.Length; j++)
                {
                    Console.Write(myArray03[i] * myArray03[j] + "\t");
                }
                Console.WriteLine("\n");
            }



            // Exercise 4

            Console.WriteLine("\nExercise 4: ");

            string password = "qwerty";
            string enter;

            Console.WriteLine("Enter password.\n");

            do
            {
                enter = Console.ReadLine();

                if (enter != password)
                {
                    Console.WriteLine("The password entered is incorrect.\n");
                }

            } while (password != enter);

            Console.WriteLine("Password entered correctly!");
            Console.ReadLine();
        }
    }
}
