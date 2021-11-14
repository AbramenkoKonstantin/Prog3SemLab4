using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3SemLab4
{
    static public class ShakerSort
    {

        public static void Sort(int[] a)
        {
            bool swapped = true;
            int start = 0;
            int end = a.Length;

            while (swapped == true)
            {
                swapped = false;

                for (int i = start; i < end - 1; ++i)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                {
                    break;
                }

                swapped = false;
                end = end - 1;

                for (int i = end - 1; i >= start; i--)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        swapped = true;
                    }
                }

                start = start + 1;
            }
        }

        static double Print()
        {
            return 1;
        }
    }
}
