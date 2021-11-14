using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3SemLab4
{
    static class InsertionSort
    {

        static public void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }

        static void Print(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("\n");
        }
    }
}
