using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3SemLab4
{
    static class BubbleSort
    {

        public static void Sort(int[] arr, int n = 10)
        {
            int i, j, temp;
            bool swapped;

            for (i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                {
                    break;
                }
            }
        }

        static void Print(int[] arr, int size)
        {
            int i;

            for (i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

    }
}
