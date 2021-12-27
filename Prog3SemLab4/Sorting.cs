using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3SemLab4
{
    static class Sortings
    {
        private static bool IsSorted(double[] array, bool isSortIncreasing)
        {
            for (int index = 0; index < array.Length - 1; ++index)
            {
                if (isSortIncreasing && array[index] > array[index + 1])
                {
                    return false;
                }
                else if (!isSortIncreasing && array[index] < array[index + 1])
                {
                    return false;
                }
            }
            return true;
        }

        private static void Swap<T>(ref T firstValue, ref T secondValue)
        {
            T temp = firstValue;
            firstValue = secondValue;
            secondValue = temp;
        }

        public static long BOGOSort(ref double[] array, bool isSortIncreasing)
        {
            var watch = Stopwatch.StartNew();
            Random randomize = new Random();
            while (!IsSorted(array, isSortIncreasing))
            {
                for (int index = 0; index < array.Length; index++)
                {
                    int secIndex = randomize.Next() % array.Length;
                    while (secIndex == index)
                    {
                        secIndex = randomize.Next() % array.Length;
                    }
                    Swap(ref array[index], ref array[secIndex]);
                }
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public static long BubbleSort(ref double[] array, bool isSortIncreasing)
        {
            var watch = Stopwatch.StartNew();
            for (int index = 0; index < array.Length - 1; ++index)
            {
                bool swapped = false;
                for (int sortIndex = 0; sortIndex < array.Length - index - 1; sortIndex++)
                {
                    if (array[sortIndex] > array[sortIndex + 1] && isSortIncreasing)
                    {
                        Swap(ref array[sortIndex], ref array[sortIndex + 1]);
                        swapped = true;
                    }
                    else if (array[sortIndex] < array[sortIndex + 1] && !isSortIncreasing)
                    {
                        Swap(ref array[sortIndex], ref array[sortIndex + 1]);
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break;
                }
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public static long InsertionSort(ref double[] array, bool isSortIncreasing)
        {
            var watch = Stopwatch.StartNew();
            for (int index = 1; index < array.Length; ++index)
            {
                double key = array[index];
                int prevIndex = index - 1;

                if (isSortIncreasing)
                {
                    while (prevIndex >= 0 && array[prevIndex] > key)
                    {
                        array[prevIndex + 1] = array[prevIndex];
                        --prevIndex;
                    }
                }
                else
                {
                    while (prevIndex >= 0 && array[prevIndex] < key)
                    {
                        array[prevIndex + 1] = array[prevIndex];
                        --prevIndex;
                    }
                }
                array[prevIndex + 1] = key;
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public static long ShakerSort(ref double[] array, bool isSortIncreasing)
        {
            var watch = Stopwatch.StartNew();
            int lowerBorder = 0;
            int upperBorder = array.Length - 1;

            while (lowerBorder < upperBorder)
            {
                for (int index = lowerBorder; index < upperBorder; ++index)
                {
                    if (isSortIncreasing && array[index] > array[index + 1])
                    {
                        Swap(ref array[index], ref array[index + 1]);
                    }
                    else if (!isSortIncreasing && array[index] < array[index + 1])
                    {
                        Swap(ref array[index], ref array[index + 1]);
                    }
                }
                --upperBorder;

                for (int index = upperBorder; index > lowerBorder; --index)
                {
                    if (isSortIncreasing && array[index - 1] > array[index])
                    {
                        Swap(ref array[index - 1], ref array[index]);
                    }
                    else if (!isSortIncreasing && array[index - 1] < array[index])
                    {
                        Swap(ref array[index - 1], ref array[index]);
                    }
                }
                ++lowerBorder;
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public static long QuickSort(ref double[] array, bool isSortIncreasing, int start = -1, int end = -1)
        {
            if (start == -1 && end == -1)
            {
                start = 0;
                end = array.Length - 1;
            }
            var watch = Stopwatch.StartNew();
            if (start >= end)
            {
                return watch.ElapsedMilliseconds;
            }
            int pivot = Partition(array, start, end, isSortIncreasing, ref watch);
            watch.Stop();
            long time = watch.ElapsedMilliseconds;
            time += QuickSort(ref array, isSortIncreasing, start, pivot - 1);
            time += QuickSort(ref array, isSortIncreasing, pivot + 1, end);
            return time;
        }

        private static int Partition(double[] array, int lowerBorder, int upperBorder, bool isSortIncreasing, ref Stopwatch watch)
        {
            int pivot = lowerBorder;
            for (int index = lowerBorder; index < upperBorder; ++index)
            {
                if (isSortIncreasing && array[index] < array[upperBorder])
                {
                    Swap(ref array[pivot], ref array[index]);
                    ++pivot;
                }
                else if (!isSortIncreasing && array[index] > array[upperBorder])
                {
                    Swap(ref array[pivot], ref array[index]);
                    ++pivot;
                }
            }
            Swap(ref array[pivot], ref array[upperBorder]);
            return pivot;
        }
    }
}
