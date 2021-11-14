using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3SemLab4
{
    static public class QuickSort
    {
        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int lowIndex = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    lowIndex++;
                    int temp = array[lowIndex];
                    array[lowIndex] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = temp1;

            return lowIndex + 1;
        }

        public static void Sort(int[] array, int low = 0, int high = 10)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);
                Sort(array, low, partitionIndex - 1);
                Sort(array, partitionIndex + 1, high);
            }
        }
    }
}
