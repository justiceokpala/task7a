using System;

namespace taskk
{
    class Program
    {
        static void Main(string[] args)

        {


 

            int[] a = new int[6] { 10, 20, 30, 40, 50, 20 };

            int[] b = new int[6] { 5, 4, 3, 2, 1, 5 };

            int[] arr = new int[6];

            for (int i = 0, j = 0; i < a.Length; i++, j++)

            {

                arr[i] = a[i] + b[j];                             

            }

            for (int i = 0; i < arr.Length; i++)

            {

                Console.Write(arr[i] + " ");

            }

            Console.Read();

        }
        }
    }