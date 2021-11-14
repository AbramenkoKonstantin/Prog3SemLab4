using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3SemLab4
{
    static class BogoSort
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public static bool IsSorted(int[] a, int n)
        {
            int i = 0;

            while (i < n - 1)
            {
                if (a[i] > a[i + 1])
                {
                    return false;
                }

                i++;
            }
            return true;
        }

        public static void Shuffle(int[] a, int n)
        {
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                Swap(ref a[i], ref a[rnd.Next(0, n)]);
            }
        }

        public static void Sort(int[] a, int n = 10)
        {
            while (!IsSorted(a, n))
            {
                Shuffle(a, n);
            }
        }

        public static void Print(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.Write("\n");
        }

    }
}
