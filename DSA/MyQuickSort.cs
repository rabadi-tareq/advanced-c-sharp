// Copyright 2025 JamilWare Technologies LLC
// SPDX-License-Identifier: gpl-3.0

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    using System;
    using Utilities;

    public static class MyQuickSort
    {
        public static void Run(int[] arr, int low, int high, int range)
        {
            Console.WriteLine();
            //Console.WriteLine($"{string.Join(' ', Enumerable.Range(0, range).Select(i => " "))} Running [{low}] => {arr[low]} to [{high}] => {arr[high]}");

            if (low < high)
            {
                Console.WriteLine($"Before partitioning {arr.ToMyString()}");
                // pi is the partition return index of pivot
                int partitionIndex = partition(arr, low, high);

                if (partitionIndex == -1)
                    return;

                Console.WriteLine($"After partitioning {arr.ToMyString()}");


                // recursion calls for smaller elements
                // and greater or equals elements
                var newRange = range + 5;

                Run(arr, low, partitionIndex - 1, newRange);
                Run(arr, partitionIndex + 1, high, newRange);
            }
        }

        // partition function
        static int partition(int[] arr, int low, int currentPivotPosition)
        {

            // choose the pivot
            int pivot = arr[currentPivotPosition];

            // index of smaller element and indicates 
            // the right position of pivot found so far
            int i = low - 1;

            // traverse arr[low..currentPivotPosition] and move all smaller
            // elements to the left side. Elements from low to 
            // i are smaller after every iteration
            bool hasSwapHappened = false;
            for (int j = low; j <= currentPivotPosition - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    ++i;
                    if(i == j)
                        continue;

                    hasSwapHappened = swap(arr, i, j);
                    
                }
            }

            if (hasSwapHappened == false)
                return -1;

            // move pivot after smaller elements and
            // return its position
            var newPivotPosition = i + 1;
            
            if(newPivotPosition != currentPivotPosition)
                swap(arr, newPivotPosition, currentPivotPosition);

            Console.WriteLine($"new pivot index is {newPivotPosition} with value {arr[newPivotPosition]}");

            return newPivotPosition;
        }

        // swap function
        static bool swap(int[] arr, int i, int j)
        {
            Console.WriteLine($"Swapping {i} with {j}");

            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

            return true;
        }
    }
}
