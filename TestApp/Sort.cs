using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    public class Sort
    {
        #region Bubble Sort
        public int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        #endregion

        #region QuickSort
        public int Partition(int[] a, int start, int end)
        {
            int pivot = end;
            int i = start - 1;
            //int j = end;
            for (int j = start; j < end - 1; j++)
            {
                if (a[j] <= a[pivot])
                {
                    i++;
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
            int t = a[i + 1];
            a[i + 1] = a[end];
            a[end] = t;
            return i + 1;
        }

        public void QuickSort(int[] a, int p, int r)
        {
            if (p < r)
            {
                int q;
                q = Partition(a, p, r);
                QuickSort(a, p, q - 1);
                QuickSort(a, q + 1, r);
            }
        }
        #endregion


    }
}
